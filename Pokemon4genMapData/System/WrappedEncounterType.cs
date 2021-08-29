using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon4genMapData
{
    public interface IWrappedEncounterType<in TVersion> : IEnumWapper<EncounterType>
        where TVersion : IWrappedGameVersion
    { }

    public struct WrappedGrass : IWrappedEncounterType<IWrappedDPt>, IWrappedEncounterType<IWrappedHGSS>,
        IWrappedEncounterType<WrappedDiamond>, IWrappedEncounterType<WrappedPearl>, IWrappedEncounterType<WrappedPlatinum>,
        IWrappedEncounterType<WrappedHeartGold>, IWrappedEncounterType<WrappedSoulSilver>
    {
        public EncounterType Unwrap() => EncounterType.Grass;
    }
    public struct WrappedSurf : IWrappedEncounterType<IWrappedDPt>, IWrappedEncounterType<IWrappedHGSS>,
        IWrappedEncounterType<WrappedDiamond>, IWrappedEncounterType<WrappedPearl>, IWrappedEncounterType<WrappedPlatinum>,
        IWrappedEncounterType<WrappedHeartGold>, IWrappedEncounterType<WrappedSoulSilver>
    {
        public EncounterType Unwrap() => EncounterType.Surf;
    }
    public struct WrappedOldRod : IWrappedEncounterType<IWrappedDPt>, IWrappedEncounterType<IWrappedHGSS>,
        IWrappedEncounterType<WrappedDiamond>, IWrappedEncounterType<WrappedPearl>, IWrappedEncounterType<WrappedPlatinum>,
        IWrappedEncounterType<WrappedHeartGold>, IWrappedEncounterType<WrappedSoulSilver>
    {
        public EncounterType Unwrap() => EncounterType.OldRod;
    }
    public struct WrappedGoodRod : IWrappedEncounterType<IWrappedDPt>, IWrappedEncounterType<IWrappedHGSS>,
        IWrappedEncounterType<WrappedDiamond>, IWrappedEncounterType<WrappedPearl>, IWrappedEncounterType<WrappedPlatinum>,
        IWrappedEncounterType<WrappedHeartGold>, IWrappedEncounterType<WrappedSoulSilver>
    {
        public EncounterType Unwrap() => EncounterType.GoodRod;
    }
    public struct WrappedSuperRod : IWrappedEncounterType<IWrappedDPt>, IWrappedEncounterType<IWrappedHGSS>,
        IWrappedEncounterType<WrappedDiamond>, IWrappedEncounterType<WrappedPearl>, IWrappedEncounterType<WrappedPlatinum>,
        IWrappedEncounterType<WrappedHeartGold>, IWrappedEncounterType<WrappedSoulSilver>
    {
        public EncounterType Unwrap() => EncounterType.SuperRod;
    }
    public struct WrappedRockSmash : IWrappedEncounterType<IWrappedHGSS>,
        IWrappedEncounterType<WrappedHeartGold>, IWrappedEncounterType<WrappedSoulSilver>
    {
        public EncounterType Unwrap() => EncounterType.RockSmash;
    }
    public struct WrappedHeadbutt : IWrappedEncounterType<IWrappedHGSS>,
        IWrappedEncounterType<WrappedHeartGold>, IWrappedEncounterType<WrappedSoulSilver>
    {
        public EncounterType Unwrap() => EncounterType.Headbutt;
    }
    public struct WrappedBugCatching : IWrappedEncounterType<IWrappedHGSS>,
        IWrappedEncounterType<WrappedHeartGold>, IWrappedEncounterType<WrappedSoulSilver>
    {
        public EncounterType Unwrap() => EncounterType.BugCatching;
    }

    public struct WrappedRuinOfAlph : IWrappedEncounterType<IWrappedHGSS>,
        IWrappedEncounterType<WrappedHeartGold>, IWrappedEncounterType<WrappedSoulSilver>
    {
        public EncounterType Unwrap() => EncounterType.Grass;
    }
}
