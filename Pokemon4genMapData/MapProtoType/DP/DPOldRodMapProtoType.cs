using System.Linq;

namespace Pokemon4genMapData
{
    class DPOldRodMapProtoType : DPMapProtoType<WrappedOldRod>
    {
        protected override DecodedDPtMapData<WrappedOldRod> DecodeMap(string rawData)
            => new DecodedDPtOldRodMapData(rawData);

        // スロット入替処理.
        // ...は存在しないのでそのまま返す.
        protected override string[] ResolveAlternatingSlots(DecodedDPtMapData<WrappedOldRod> mapData, DPQueryArgs args)
        {

            return mapData.BasicTable.ToArray();
        }

        protected override Slot[] BuildTable(DecodedDPtMapData<WrappedOldRod> mapData, DPQueryArgs args)
        {
            // basicTableとprotoTableの長さは同じになっていることが期待される.
            return ResolveAlternatingSlots(mapData, args).Zip(mapData.ProtoTable, (poke, slot) => slot.GetSlot(poke)).ToArray();
        }

        public DPOldRodMapProtoType(string mapData) : base(mapData, MapType.OldRod) { }
    }

    class DPOldRodFeebasMapProtoType : DPOldRodMapProtoType
    {
        private static Slot GetFeebasSlot()
            => new Slot() { Pokemon = "ヒンバス", BasicLv = 10, VariableLv = 11, MaxLv = 20 };
        protected override Slot[] ResolveOptionalSlots(DecodedDPtMapData<WrappedOldRod> mapData, DPQueryArgs args)
            => new Slot[1] { GetFeebasSlot() };

        public DPOldRodFeebasMapProtoType(string mapData) : base(mapData) { }
    }
}
