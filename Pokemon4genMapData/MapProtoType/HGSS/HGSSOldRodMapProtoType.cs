using System.Linq;
using PokemonStandardLibrary.PokeDex.Gen4;

namespace Pokemon4genMapData
{
    class HGSSOldRodMapProtoType : HGSSMapProtoType<WrappedOldRod>
    {
        protected override DecodedHGSSMapData<WrappedOldRod> DecodeMap(string rawData)
            => new DecodedHGSSOldRodMapData(rawData);

        // スロット入替処理.
        protected override string[] ResolveAlternatingSlots(DecodedHGSSMapData<WrappedOldRod> mapData, HGSSQueryArgs args)
        {
            var t = GetBasicTable(mapData, args);
            var alt = decodedMapData.AltSlots;
            if (alt == null || args == null) return mapData.BasicTable.ToArray();

            if (args.Outbreak && alt.Outbreak != null)
                t[0] = alt.Outbreak;

            return t;
        }

        protected override Slot[] BuildTable(DecodedHGSSMapData<WrappedOldRod> mapData, HGSSQueryArgs args)
        {
            // basicTableとprotoTableの長さは同じになっていることが期待される.
            return ResolveAlternatingSlots(mapData, args).Zip(mapData.ProtoTable, (poke, slot) => slot.GetSlot(poke)).ToArray();
        }

        public HGSSOldRodMapProtoType(string mapData) : base(mapData, MapType.OldRod) { }
    }

    class HGSSOldRodFeebasMapProtoType: HGSSOldRodMapProtoType
    {
        private static Slot GetFeebasSlot()
            => new Slot() { Pokemon = Pokemon.GetPokemon("ヒンバス"), BasicLv = 10, VariableLv = 11, MaxLv = 20 };
        protected override Slot[] ResolveOptionalSlots(DecodedHGSSMapData<WrappedOldRod> mapData, HGSSQueryArgs args)
            => new Slot[1] { GetFeebasSlot() };

        public HGSSOldRodFeebasMapProtoType(string mapData) : base(mapData) { }
    }
}
