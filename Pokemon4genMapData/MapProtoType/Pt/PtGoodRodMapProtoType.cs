using System.Linq;
using PokemonStandardLibrary.PokeDex.Gen4;

namespace Pokemon4genMapData
{
    class PtGoodRodMapProtoType : PtMapProtoType<WrappedGoodRod>
    {
        protected override DecodedDPtMapData<WrappedGoodRod> DecodeMap(string rawData)
            => new DecodedDPtGoodRodMapData(rawData);

        // スロット入替処理.
        // ...は存在しないのでそのまま返す.
        protected override string[] ResolveAlternatingSlots(DecodedDPtMapData<WrappedGoodRod> mapData, PtQueryArgs args)
        {
            return mapData.BasicTable.ToArray();
        }

        protected override Slot[] BuildTable(DecodedDPtMapData<WrappedGoodRod> mapData, PtQueryArgs args)
        {
            // basicTableとprotoTableの長さは同じになっていることが期待される.
            return ResolveAlternatingSlots(mapData, args).Zip(mapData.ProtoTable, (poke, slot) => slot.GetSlot(poke)).ToArray();
        }

        public PtGoodRodMapProtoType(string mapData) : base(mapData, MapType.GoodRod) { }
    }

    class PtGoodRodFeebasMapProtoType : PtGoodRodMapProtoType
    {
        private static Slot GetFeebasSlot()
            => new Slot() { Pokemon = Pokemon.GetPokemon("ヒンバス"), BasicLv = 10, VariableLv = 11, MaxLv = 20 };
        protected override Slot[] ResolveOptionalSlots(DecodedDPtMapData<WrappedGoodRod> mapData, PtQueryArgs args)
            => new Slot[1] { GetFeebasSlot() };

        public PtGoodRodFeebasMapProtoType(string mapData) : base(mapData) { }
    }
}
