using System.Linq;

namespace Pokemon4genMapData
{
    class HGSSBugCatchingMapProtoType : HGSSMapProtoType<WrappedBugCatching>
    {
        protected override DecodedHGSSMapData<WrappedBugCatching> DecodeMap(string rawData)
            => new DecodedHGSSBugCatchingMapData(rawData);

        // スロット入替処理.
        protected override string[] ResolveAlternatingSlots(DecodedHGSSMapData<WrappedBugCatching> mapData, HGSSQueryArgs args)
        {
            return GetBasicTable(mapData, args);
        }

        protected override Slot[] BuildTable(DecodedHGSSMapData<WrappedBugCatching> mapData, HGSSQueryArgs args)
        {
            // basicTableとprotoTableの長さは同じになっていることが期待される.
            return ResolveAlternatingSlots(mapData, args).Zip(mapData.ProtoTable, (poke, slot) => slot.GetSlot(poke)).ToArray();
        }

        public HGSSBugCatchingMapProtoType(string mapData) : base(mapData, MapType.BugCatching) { }
    }

}
