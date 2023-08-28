﻿using BossMod;
using ImGuiNET;
using System;
using System.Collections.Generic;
using System.Linq;

namespace UIDev
{
    class ReplayTimelineWindow : UIWindow
    {
        private Replay _replay;
        private Replay.Encounter _encounter;
        private StateMachineTree _stateTree;
        private List<int> _phaseBranches;
        private Timeline _timeline = new();
        private ColumnEnemiesCastEvents _colCastEvents;
        private ColumnStateMachineBranch _colStates;
        private ColumnEnemiesDetails _colEnemies;
        private ColumnPlayersDetails _colPlayers;
        private UISimpleWindow? _config;
        private UITree _configTree = new();

        public ReplayTimelineWindow(Replay replay, Replay.Encounter enc, BitMask showPlayers) : base($"Replay timeline: {replay.Path} @ {enc.Time.Start:O}", true, new(1200, 1000))
        {
            _replay = replay;
            _encounter = enc;
            (_stateTree, _phaseBranches) = BuildStateData(enc);
            _timeline.MinTime = -30;
            _timeline.MaxTime = _stateTree.TotalMaxTime;

            _colCastEvents = _timeline.Columns.Add(new ColumnEnemiesCastEvents(_timeline, _stateTree, _phaseBranches, replay, enc));
            _colStates = _timeline.Columns.Add(new ColumnStateMachineBranch(_timeline, _stateTree, _phaseBranches));
            _timeline.Columns.Add(new ColumnSeparator(_timeline));
            _colEnemies = _timeline.Columns.Add(new ColumnEnemiesDetails(_timeline, _stateTree, _phaseBranches, replay, enc));
            _colPlayers = _timeline.Columns.Add(new ColumnPlayersDetails(_timeline, _stateTree, _phaseBranches, replay, enc, showPlayers));

            if (IsOpen)
            {
                _config = new($"Replay timeline config: {_replay.Path} @ {_encounter.Time.Start:O}", DrawConfig, false, new(600, 600));
            }
        }

        protected override void Dispose(bool disposing)
        {
            _config?.Dispose();
        }

        public override void PreOpenCheck() => RespectCloseHotkey = !_colPlayers.AnyPlanModified;

        public override void Draw()
        {
            if (_config != null && ImGui.Button(!_config.IsOpen ? "Show config" : "Hide config"))
            {
                _config.Toggle();
            }
            ImGui.SameLine();
            if (ImGui.Button($"Save {(_colPlayers.AnyPlanModified ? "all changes" : "(no changes)")}"))
            {
                _colPlayers.SaveAll();
            }

            _timeline.Draw();
        }

        private void DrawConfig()
        {
            UICombo.Enum("State text", ref _colStates.TextDisplay);
            foreach (var n in _configTree.Node("Enemy casts columns"))
                _colCastEvents.DrawConfig(_configTree);
            foreach (var n in _configTree.Node("Enemy details"))
                _colEnemies.DrawConfig(_configTree);
            foreach (var n in _configTree.Node("Player details"))
                _colPlayers.DrawConfig(_configTree);
        }

        private (StateMachineTree, List<int>) BuildStateData(Replay.Encounter enc)
        {
            // build state tree with expected timings
            var m = ModuleRegistry.CreateModuleForTimeline(enc.OID);
            if (m == null)
                throw new Exception($"Encounter module not available");

            Dictionary<uint, (StateMachine.State state, StateMachine.State? pred)> stateLookup = new();
            foreach (var p in m.StateMachine.Phases)
                GatherStates(stateLookup, p.InitialState, null);

            // update state durations to match replay data; we don't touch unvisited states, however we set 'skipped' state durations to 0
            var stateEnter = enc.Time.Start;
            StateMachine.State? pred = null;
            foreach (var s in enc.States)
            {
                var cur = stateLookup[s.ID];
                while (cur.pred != pred && cur.pred != null)
                {
                    cur.pred.Duration = 0;
                    cur.pred = stateLookup[cur.pred.ID].pred;
                }
                stateLookup[s.ID].state.Duration = (float)(s.Exit - stateEnter).TotalSeconds;
                stateEnter = s.Exit;
                pred = cur.state;
            }

            var tree = new StateMachineTree(m.StateMachine);
            var phaseBranches = Enumerable.Repeat(0, m.StateMachine.Phases.Count).ToList();
            var phaseTimings = new StateMachineTimings();
            phaseTimings.PhaseDurations.AddRange(Enumerable.Repeat(0.0f, m.StateMachine.Phases.Count));

            var phaseEnter = enc.Time.Start;
            foreach (var p in enc.Phases)
            {
                phaseBranches[p.ID] = tree.Nodes[p.LastStateID].BranchID - tree.Phases[p.ID].StartingNode.BranchID;
                phaseTimings.PhaseDurations[p.ID] = (float)(p.Exit - phaseEnter).TotalSeconds;
                phaseEnter = p.Exit;
            }

            tree.ApplyTimings(phaseTimings);
            return (tree, phaseBranches);
        }

        private void GatherStates(Dictionary<uint, (StateMachine.State state, StateMachine.State? pred)> res, StateMachine.State start, StateMachine.State? pred)
        {
            res[start.ID] = (start, pred);
            if (start.NextStates != null)
                foreach (var succ in start.NextStates)
                    GatherStates(res, succ, start);
        }
    }
}
