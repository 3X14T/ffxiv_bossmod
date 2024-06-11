﻿namespace BossMod.DNC;

public enum AID : uint
{
    None = 0,
    Sprint = ClassShared.AID.Sprint,

    CrimsonLotus = 17106, // LB3, 4.5s cast, range 30, AOE 30+R width 8 rect, targets=hostile, animLock=???, castAnimLock=3.700
    Cascade = 15989, // L1, instant, GCD, range 25, single-target, targets=hostile
    Fountain = 15990, // L2, instant, GCD, range 25, single-target, targets=hostile
    SingleStandardFinish = 16191, // L15, instant, GCD, range 0, AOE 15 circle, targets=self
    DoubleStandardFinish = 16192, // L15, instant, GCD, range 0, AOE 15 circle, targets=self
    StandardFinish = 16003, // L15, instant, GCD, range 0, AOE 15 circle, targets=self
    Pirouette = 16002, // L15, instant, GCD, range 0, single-target, targets=self
    Jete = 16001, // L15, instant, GCD, range 0, single-target, targets=self
    Entrechat = 16000, // L15, instant, GCD, range 0, single-target, targets=self
    Emboite = 15999, // L15, instant, GCD, range 0, single-target, targets=self
    Windmill = 15993, // L15, instant, GCD, range 0, AOE 5 circle, targets=self
    StandardStep = 15997, // L15, instant, 30.0s CD (group 8/57), range 0, single-target, targets=self
    ReverseCascade = 15991, // L20, instant, GCD, range 25, single-target, targets=hostile
    Bladeshower = 15994, // L25, instant, GCD, range 0, AOE 5 circle, targets=self
    FanDance = 16007, // L30, instant, 1.0s CD (group 1), range 25, single-target, targets=hostile
    RisingWindmill = 15995, // L35, instant, GCD, range 0, AOE 5 circle, targets=self
    Fountainfall = 15992, // L40, instant, GCD, range 25, single-target, targets=hostile
    Bloodshower = 15996, // L45, instant, GCD, range 0, AOE 5 circle, targets=self
    EnAvant = 16010, // L50, instant, 30.0s CD (group 9/70), range 0, single-target, targets=self
    FanDanceII = 16008, // L50, instant, 1.0s CD (group 2), range 0, AOE 5 circle, targets=self
    CuringWaltz = 16015, // L52, instant, 60.0s CD (group 11), range 0, AOE 3 circle, targets=self
    ShieldSamba = 16012, // L56, instant, 120.0s CD (group 22), range 0, AOE 30 circle, targets=self
    ClosedPosition = 16006, // L60, instant, 30.0s CD (group 0), range 30, single-target, targets=party
    Ending = 18073, // L60, instant, 1.0s CD (group 0), range 0, single-target, targets=self
    Devilment = 16011, // L62, instant, 120.0s CD (group 20), range 0, single-target, targets=self
    FanDanceIII = 16009, // L66, instant, 1.0s CD (group 3), range 25, AOE 5 circle, targets=hostile
    TechnicalStep = 15998, // L70, instant, 120.0s CD (group 19/57), range 0, single-target, targets=self
    TechnicalFinish = 16004, // L70, instant, GCD, range 0, AOE 15 circle, targets=self
    SingleTechnicalFinish = 16193, // L70, instant, GCD, range 0, AOE 15 circle, targets=self
    DoubleTechnicalFinish = 16194, // L70, instant, GCD, range 0, AOE 15 circle, targets=self
    TripleTechnicalFinish = 16195, // L70, instant, GCD, range 0, AOE 15 circle, targets=self
    QuadrupleTechnicalFinish = 16196, // L70, instant, GCD, range 0, AOE 15 circle, targets=self
    SingleTechnicalFinish2 = 33215, // L70, instant, range 0, AOE 30 circle, targets=self, animLock=???
    DoubleTechnicalFinish2 = 33216, // L70, instant, range 0, AOE 30 circle, targets=self, animLock=???
    TripleTechnicalFinish2 = 33217, // L70, instant, range 0, AOE 30 circle, targets=self, animLock=???
    QuadrupleTechnicalFinish2 = 33218, // L70, instant, range 0, AOE 30 circle, targets=self, animLock=???
    Flourish = 16013, // L72, instant, 60.0s CD (group 10), range 0, single-target, targets=self
    SaberDance = 16005, // L76, instant, GCD, range 25, AOE 5 circle, targets=hostile
    Improvisation = 16014, // L80, instant, 120.0s CD (group 18), range 0, ???, targets=self
    ImprovisedFinish = 25789, // L80, instant, 1.5s CD (group 5), range 0, AOE 8 circle, targets=self
    Tillana = 25790, // L82, instant, GCD, range 0, AOE 15 circle, targets=self
    FanDanceIV = 25791, // L86, instant, 1.0s CD (group 4), range 15, AOE 15+R ?-degree cone, targets=hostile
    StarfallDance = 25792, // L90, instant, GCD, range 25, AOE 25+R width 4 rect, targets=hostile

    // Shared
    BigShot = ClassShared.AID.BigShot, // LB1, 2.0s cast, range 30, AOE 30+R width 4 rect, targets=hostile, castAnimLock=3.100
    Desperado = ClassShared.AID.Desperado, // LB2, 3.0s cast, range 30, AOE 30+R width 5 rect, targets=hostile, castAnimLock=3.100
    LegGraze = ClassShared.AID.LegGraze, // L6, instant, 30.0s CD (group 42), range 25, single-target, targets=hostile
    SecondWind = ClassShared.AID.SecondWind, // L8, instant, 120.0s CD (group 49), range 0, single-target, targets=self
    FootGraze = ClassShared.AID.FootGraze, // L10, instant, 30.0s CD (group 41), range 25, single-target, targets=hostile
    Peloton = ClassShared.AID.Peloton, // L20, instant, 5.0s CD (group 40), range 0, AOE 30 circle, targets=self
    HeadGraze = ClassShared.AID.HeadGraze, // L24, instant, 30.0s CD (group 43), range 25, single-target, targets=hostile
    ArmsLength = ClassShared.AID.ArmsLength, // L32, instant, 120.0s CD (group 48), range 0, single-target, targets=self
}

public enum TraitID : uint
{
    None = 0,
    FourfoldFantasy = 252, // L30
    IncreasedActionDamage = 251, // L50
    IncreasedActionDamageII = 253, // L60
    EnhancedEnAvant = 254, // L68
    Esprit = 255, // L76
    EnhancedEnAvantII = 256, // L78
    EnhancedTechnicalFinish = 453, // L82
    EnhancedEsprit = 454, // L84
    EnhancedFlourish = 455, // L86
    EnhancedShieldSamba = 456, // L88
    EnhancedDevilment = 457, // L90
}

public sealed class Definitions : IDisposable
{
    public static readonly uint[] UnlockQuests = [68790];

    public static bool Unlocked(AID id, int level, int questProgress) => id switch
    {
        AID.Fountain => level >= 2,
        AID.LegGraze => level >= 6,
        AID.SecondWind => level >= 8,
        AID.FootGraze => level >= 10,
        AID.SingleStandardFinish => level >= 15,
        AID.DoubleStandardFinish => level >= 15,
        AID.StandardFinish => level >= 15,
        AID.Pirouette => level >= 15,
        AID.Jete => level >= 15,
        AID.Entrechat => level >= 15,
        AID.Emboite => level >= 15,
        AID.Windmill => level >= 15,
        AID.StandardStep => level >= 15,
        AID.ReverseCascade => level >= 20,
        AID.Peloton => level >= 20,
        AID.HeadGraze => level >= 24,
        AID.Bladeshower => level >= 25,
        AID.FanDance => level >= 30,
        AID.ArmsLength => level >= 32,
        AID.RisingWindmill => level >= 35,
        AID.Fountainfall => level >= 40,
        AID.Bloodshower => level >= 45,
        AID.EnAvant => level >= 50,
        AID.FanDanceII => level >= 50,
        AID.CuringWaltz => level >= 52,
        AID.ShieldSamba => level >= 56,
        AID.ClosedPosition => level >= 60,
        AID.Ending => level >= 60,
        AID.Devilment => level >= 62,
        AID.FanDanceIII => level >= 66,
        AID.TechnicalStep => level >= 70 && questProgress > 0,
        AID.TechnicalFinish => level >= 70 && questProgress > 0,
        AID.SingleTechnicalFinish => level >= 70 && questProgress > 0,
        AID.DoubleTechnicalFinish => level >= 70 && questProgress > 0,
        AID.TripleTechnicalFinish => level >= 70 && questProgress > 0,
        AID.QuadrupleTechnicalFinish => level >= 70 && questProgress > 0,
        AID.SingleTechnicalFinish2 => level >= 70 && questProgress > 0,
        AID.DoubleTechnicalFinish2 => level >= 70 && questProgress > 0,
        AID.TripleTechnicalFinish2 => level >= 70 && questProgress > 0,
        AID.QuadrupleTechnicalFinish2 => level >= 70 && questProgress > 0,
        AID.Flourish => level >= 72,
        AID.SaberDance => level >= 76,
        AID.Improvisation => level >= 80,
        AID.ImprovisedFinish => level >= 80,
        AID.Tillana => level >= 82,
        AID.FanDanceIV => level >= 86,
        AID.StarfallDance => level >= 90,
        _ => true
    };

    public static bool Unlocked(TraitID id, int level, int questProgress) => id switch
    {
        TraitID.FourfoldFantasy => level >= 30,
        TraitID.IncreasedActionDamage => level >= 50,
        TraitID.IncreasedActionDamageII => level >= 60,
        TraitID.EnhancedEnAvant => level >= 68,
        TraitID.Esprit => level >= 76,
        TraitID.EnhancedEnAvantII => level >= 78,
        TraitID.EnhancedTechnicalFinish => level >= 82,
        TraitID.EnhancedEsprit => level >= 84,
        TraitID.EnhancedFlourish => level >= 86,
        TraitID.EnhancedShieldSamba => level >= 88,
        TraitID.EnhancedDevilment => level >= 90,
        _ => true
    };

    public Definitions(ActionDefinitions d)
    {
        d.RegisterSpell(AID.CrimsonLotus, true, castAnimLock: 3.70f); // animLock=???, castAnimLock=3.700
        d.RegisterSpell(AID.Cascade, true);
        d.RegisterSpell(AID.Fountain, true);
        d.RegisterSpell(AID.SingleStandardFinish, true);
        d.RegisterSpell(AID.DoubleStandardFinish, true);
        d.RegisterSpell(AID.StandardFinish, true);
        d.RegisterSpell(AID.Pirouette, true);
        d.RegisterSpell(AID.Jete, true);
        d.RegisterSpell(AID.Entrechat, true);
        d.RegisterSpell(AID.Emboite, true);
        d.RegisterSpell(AID.Windmill, true);
        d.RegisterSpell(AID.StandardStep, true);
        d.RegisterSpell(AID.ReverseCascade, true);
        d.RegisterSpell(AID.Bladeshower, true);
        d.RegisterSpell(AID.FanDance, true);
        d.RegisterSpell(AID.RisingWindmill, true);
        d.RegisterSpell(AID.Fountainfall, true);
        d.RegisterSpell(AID.Bloodshower, true);
        d.RegisterSpell(AID.EnAvant, true, maxCharges: 3);
        d.RegisterSpell(AID.FanDanceII, true);
        d.RegisterSpell(AID.CuringWaltz, true);
        d.RegisterSpell(AID.ShieldSamba, true);
        d.RegisterSpell(AID.ClosedPosition, true);
        d.RegisterSpell(AID.Ending, true);
        d.RegisterSpell(AID.Devilment, true);
        d.RegisterSpell(AID.FanDanceIII, true);
        d.RegisterSpell(AID.TechnicalStep, true);
        d.RegisterSpell(AID.TechnicalFinish, true);
        d.RegisterSpell(AID.SingleTechnicalFinish, true);
        d.RegisterSpell(AID.DoubleTechnicalFinish, true);
        d.RegisterSpell(AID.TripleTechnicalFinish, true);
        d.RegisterSpell(AID.QuadrupleTechnicalFinish, true);
        d.RegisterSpell(AID.SingleTechnicalFinish2, true); // animLock=???
        d.RegisterSpell(AID.DoubleTechnicalFinish2, true); // animLock=???
        d.RegisterSpell(AID.TripleTechnicalFinish2, true); // animLock=???
        d.RegisterSpell(AID.QuadrupleTechnicalFinish2, true); // animLock=???
        d.RegisterSpell(AID.Flourish, true);
        d.RegisterSpell(AID.SaberDance, true);
        d.RegisterSpell(AID.Improvisation, true);
        d.RegisterSpell(AID.ImprovisedFinish, true);
        d.RegisterSpell(AID.Tillana, true);
        d.RegisterSpell(AID.FanDanceIV, true);
        d.RegisterSpell(AID.StarfallDance, true);

        Customize(d);
    }

    public void Dispose() { }

    private void Customize(ActionDefinitions d)
    {
        d.Spell(AID.StandardStep)!.EffectDuration = 15;
        d.Spell(AID.ShieldSamba)!.EffectDuration = 15;
        d.Spell(AID.Flourish)!.EffectDuration = 30;
        d.Spell(AID.ImprovisedFinish)!.EffectDuration = 60;
    }
}