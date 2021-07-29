using System.Linq;

namespace Pokemon4genMapData
{
    class PtSuperRodMapProtoType : PtMapProtoType<WrappedSuperRod>
    {
        protected override DecodedDPtMapData<WrappedSuperRod> DecodeMap(string rawData)
            => new DecodedDPtSuperRodMapData(rawData);

        // スロット入替処理.
        // ...は存在しないのでそのまま返す.
        protected override string[] ResolveAlternatingSlots(DecodedDPtMapData<WrappedSuperRod> mapData, PtQueryArgs args)
        {

            return mapData.BasicTable.ToArray();
        }

        protected override Slot[] BuildTable(DecodedDPtMapData<WrappedSuperRod> mapData, PtQueryArgs args)
        {
            // basicTableとprotoTableの長さは同じになっていることが期待される.
            return ResolveAlternatingSlots(mapData, args).Zip(mapData.ProtoTable, (poke, slot) => slot.GetSlot(poke)).ToArray();
        }

        public PtSuperRodMapProtoType(string mapData) : base(mapData, MapType.SuperRod) { }
    }

    class PtSuperRodFeebasMapProtoType : PtSuperRodMapProtoType
    {
        private static Slot GetFeebasSlot()
            => new Slot() { Pokemon = "ヒンバス", BasicLv = 10, VariableLv = 11, MaxLv = 20 };
        protected override Slot[] ResolveOptionalSlots(DecodedDPtMapData<WrappedSuperRod> mapData, PtQueryArgs args)
            => new Slot[1] { GetFeebasSlot() };

        public PtSuperRodFeebasMapProtoType(string mapData) : base(mapData) { }
    }
}
