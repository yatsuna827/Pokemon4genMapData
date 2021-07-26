using System.Linq;

namespace Pokemon4genMapData
{
    class HGSSHeadbuttMapProtoType : HGSSMapProtoType<WrappedHeadbutt>
    {
        protected override DecodedHGSSMapData<WrappedHeadbutt> DecodeMap(string rawData)
            => new DecodedHGSSHeadbuttMapData(rawData);

        // スロット入替処理.
        protected override string[] ResolveAlternatingSlots(DecodedHGSSMapData<WrappedHeadbutt> mapData, HGSSQueryArgs args)
        {
            return GetBasicTable(mapData, args);
        }

        protected override Slot[] BuildTable(DecodedHGSSMapData<WrappedHeadbutt> mapData, HGSSQueryArgs args)
        {
            // basicTableとprotoTableの長さは同じになっていることが期待される.
            return ResolveAlternatingSlots(mapData, args).Zip(mapData.ProtoTable, (poke, slot) => slot.GetSlot(poke)).ToArray();
        }

        public HGSSHeadbuttMapProtoType(string mapData) : base(mapData, MapType.Headbutt) { }
    }

}
