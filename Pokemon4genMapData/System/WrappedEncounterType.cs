using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon4genMapData
{
    public interface IWrappedEncounterType<in TVersion> : IEnumWapper<EncounterType>
        where TVersion : IWrappedGameVersion
    {

    }

    public struct WrappedGrass : IWrappedEncounterType<IWrappedDPt>, IWrappedEncounterType<IWrappedHGSS>
    {
        public EncounterType Unwrap() => EncounterType.Grass;
    }
    public struct WrappedSurf : IWrappedEncounterType<IWrappedDPt>, IWrappedEncounterType<IWrappedHGSS>
    {
        public EncounterType Unwrap() => EncounterType.Surf;
    }
    public struct WrappedOldRod : IWrappedEncounterType<IWrappedDPt>, IWrappedEncounterType<IWrappedHGSS>
    {
        public EncounterType Unwrap() => EncounterType.OldRod;
    }
    public struct WrappedGoodRod : IWrappedEncounterType<IWrappedDPt>, IWrappedEncounterType<IWrappedHGSS>
    {
        public EncounterType Unwrap() => EncounterType.GoodRod;
    }
    public struct WrappedSuperRod : IWrappedEncounterType<IWrappedDPt>, IWrappedEncounterType<IWrappedHGSS>
    {
        public EncounterType Unwrap() => EncounterType.SuperRod;
    }
    public struct WrappedRockSmash : IWrappedEncounterType<IWrappedHGSS>
    {
        public EncounterType Unwrap() => EncounterType.RockSmash;
    }
    public struct WrappedHeadbutt : IWrappedEncounterType<IWrappedHGSS>
    {
        public EncounterType Unwrap() => EncounterType.Headbutt;
    }
    public struct WrappedBugCatching : IWrappedEncounterType<IWrappedHGSS>
    {
        public EncounterType Unwrap() => EncounterType.BugCatching;
    }
}
