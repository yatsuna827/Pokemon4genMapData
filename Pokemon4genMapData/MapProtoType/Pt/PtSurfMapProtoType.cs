using System.Linq;

namespace Pokemon4genMapData
{
    class PtSurfMapProtoType : PtMapProtoType<WrappedSurf>
    {
        protected override DecodedDPtMapData<WrappedSurf> DecodeMap(string rawData)
            => new DecodedDPtSurfMapData(rawData);

        // スロット入替処理.
        // ...は存在しないのでそのまま返す.
        protected override string[] ResolveAlternatingSlots(DecodedDPtMapData<WrappedSurf> mapData, PtQueryArgs args)
        {

            return mapData.BasicTable.ToArray();
        }

        protected override Slot[] BuildTable(DecodedDPtMapData<WrappedSurf> mapData, PtQueryArgs args)
        {
            // basicTableとprotoTableの長さは同じになっていることが期待される.
            return ResolveAlternatingSlots(mapData, args).Zip(mapData.ProtoTable, (poke, slot) => slot.GetSlot(poke)).ToArray();
        }

        public PtSurfMapProtoType(string mapData) : base(mapData, MapType.Surf) { }
    }

}
