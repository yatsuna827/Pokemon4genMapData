using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon4genMapData
{
    interface IWrappedEncounterType<TVersion> : IEnumWapper<EncounterType>
        where TVersion : IWrappedGameVersion
    {

    }

    struct WrappedGrass : IWrappedEncounterType<WrappedDPt>, IWrappedEncounterType<WrappedHGSS>
    {
        public EncounterType Unwrap() => EncounterType.Grass;
    }
    struct WrappedSurf : IWrappedEncounterType<WrappedDPt>, IWrappedEncounterType<WrappedHGSS>
    {
        public EncounterType Unwrap() => EncounterType.Surf;
    }
    struct WrappedOldRod : IWrappedEncounterType<WrappedDPt>, IWrappedEncounterType<WrappedHGSS>
    {
        public EncounterType Unwrap() => EncounterType.OldRod;
    }
    struct WrappedGoodRod : IWrappedEncounterType<WrappedDPt>, IWrappedEncounterType<WrappedHGSS>
    {
        public EncounterType Unwrap() => EncounterType.GoodRod;
    }
    struct WrappedSuperRod : IWrappedEncounterType<WrappedDPt>, IWrappedEncounterType<WrappedHGSS>
    {
        public EncounterType Unwrap() => EncounterType.SuperRod;
    }
    struct WrappedRockSmash : IWrappedEncounterType<WrappedHGSS>
    {
        public EncounterType Unwrap() => EncounterType.RockSmash;
    }
    struct WrappedHeadbutt : IWrappedEncounterType<WrappedHGSS>
    {
        public EncounterType Unwrap() => EncounterType.Headbutt;
    }
    struct WrappedBugCatching : IWrappedEncounterType<WrappedHGSS>
    {
        public EncounterType Unwrap() => EncounterType.BugCatching;
    }
}
