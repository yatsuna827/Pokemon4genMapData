using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon4genMapData
{
    interface WrappedMapType : IEnumWapper<MapType>
    {

    }

    struct WrappedGrass : WrappedMapType
    {
        public MapType Unwrap() => MapType.Grass;
    }
    struct WrappedSurf : WrappedMapType
    {
        public MapType Unwrap() => MapType.Surf;
    }
    struct WrappedOldRod : WrappedMapType
    {
        public MapType Unwrap() => MapType.OldRod;
    }
    struct WrappedGoodRod : WrappedMapType
    {
        public MapType Unwrap() => MapType.GoodRod;
    }
    struct WrappedSuperRod : WrappedMapType
    {
        public MapType Unwrap() => MapType.SuperRod;
    }
    struct WrappedRockSmash : WrappedMapType
    {
        public MapType Unwrap() => MapType.RockSmash;
    }
    struct WrappedHeadbutt : WrappedMapType
    {
        public MapType Unwrap() => MapType.Headbutt;
    }
    struct WrappedBugCatching : WrappedMapType
    {
        public MapType Unwrap() => MapType.BugCatching;
    }
}
