using System.Linq;

namespace Pokemon4genMapData
{
    class HGSSRockSmashMapProtoType : HGSSMapProtoType<WrappedRockSmash>
    {
        protected override DecodedHGSSMapData<WrappedRockSmash> DecodeMap(string rawData)
            => new DecodedHGSSRockSmashMapData(rawData);

        // スロット入替処理.
        protected override string[] ResolveAlternatingSlots(DecodedHGSSMapData<WrappedRockSmash> mapData, HGSSQueryArgs args)
        {
            return GetBasicTable(mapData, args);
        }

        protected override Slot[] BuildTable(DecodedHGSSMapData<WrappedRockSmash> mapData, HGSSQueryArgs args)
        {
            // basicTableとprotoTableの長さは同じになっていることが期待される.
            return ResolveAlternatingSlots(mapData, args).Zip(mapData.ProtoTable, (poke, slot) => slot.GetSlot(poke)).ToArray();
        }

        public HGSSRockSmashMapProtoType(string mapData) : base(mapData, MapType.RockSmash) { }
    }

}
