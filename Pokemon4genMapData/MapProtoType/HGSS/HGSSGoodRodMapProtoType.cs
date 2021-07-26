using System.Linq;

namespace Pokemon4genMapData
{
    class HGSSGoodRodMapProtoType : HGSSMapProtoType<WrappedGoodRod>
    {
        protected override DecodedHGSSMapData<WrappedGoodRod> DecodeMap(string rawData)
            => new DecodedHGSSGoodRodMapData(rawData);

        // スロット入替処理.
        protected override string[] ResolveAlternatingSlots(DecodedHGSSMapData<WrappedGoodRod> mapData, HGSSQueryArgs args)
        {
            var t = GetBasicTable(mapData, args);
            var alt = decodedMapData.AltSlots;
            if (alt == null || args == null) return mapData.BasicTable.ToArray();

            if (args.Outbreak && alt.Outbreak != null)
                t[0] = alt.Outbreak;

            return t;
        }

        protected override Slot[] BuildTable(DecodedHGSSMapData<WrappedGoodRod> mapData, HGSSQueryArgs args)
        {
            // basicTableとprotoTableの長さは同じになっていることが期待される.
            return ResolveAlternatingSlots(mapData, args).Zip(mapData.ProtoTable, (poke, slot) => slot.GetSlot(poke)).ToArray();
        }

        public HGSSGoodRodMapProtoType(string mapData) : base(mapData, MapType.GoodRod) { }
    }

}
