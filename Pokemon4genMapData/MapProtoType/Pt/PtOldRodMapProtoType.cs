using System.Linq;

namespace Pokemon4genMapData
{
    class PtOldRodMapProtoType : PtMapProtoType<WrappedOldRod>
    {
        protected override DecodedDPtMapData<WrappedOldRod> DecodeMap(string rawData)
            => new DecodedDPtOldRodMapData(rawData);

        // スロット入替処理.
        // ...は存在しないのでそのまま返す.
        protected override string[] ResolveAlternatingSlots(DecodedDPtMapData<WrappedOldRod> mapData, PtQueryArgs args)
        {

            return mapData.BasicTable.ToArray();
        }

        protected override Slot[] BuildTable(DecodedDPtMapData<WrappedOldRod> mapData, PtQueryArgs args)
        {
            // basicTableとprotoTableの長さは同じになっていることが期待される.
            return ResolveAlternatingSlots(mapData, args).Zip(mapData.ProtoTable, (poke, slot) => slot.GetSlot(poke)).ToArray();
        }

        public PtOldRodMapProtoType(string mapData) : base(mapData, MapType.OldRod) { }
    }

    class PtOldRodFeebasMapProtoType : PtOldRodMapProtoType
    {
        private static Slot GetFeebasSlot()
            => new Slot() { Pokemon = "ヒンバス", BasicLv = 10, VariableLv = 11, MaxLv = 20 };
        protected override Slot[] ResolveOptionalSlots(DecodedDPtMapData<WrappedOldRod> mapData, PtQueryArgs args)
            => new Slot[1] { GetFeebasSlot() };

        public PtOldRodFeebasMapProtoType(string mapData) : base(mapData) { }
    }
}
