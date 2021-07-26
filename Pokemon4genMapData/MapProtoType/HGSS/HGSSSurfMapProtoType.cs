using System.Linq;

namespace Pokemon4genMapData
{
    class HGSSSurfMapProtoType : HGSSMapProtoType<WrappedSurf>
    {
        protected override DecodedHGSSMapData<WrappedSurf> DecodeMap(string rawData)
            => new DecodedHGSSSurfMapData(rawData);

        // スロット入替処理.
        protected override string[] ResolveAlternatingSlots(DecodedHGSSMapData<WrappedSurf> mapData, HGSSQueryArgs args)
        {
            var t = GetBasicTable(mapData, args);
            var alt = decodedMapData.AltSlots;
            if (alt == null || args == null) return mapData.BasicTable.ToArray();

            if (args.Outbreak && alt.Outbreak != null)
                t[0] = alt.Outbreak;

            return t;
        }

        protected override Slot[] BuildTable(DecodedHGSSMapData<WrappedSurf> mapData, HGSSQueryArgs args)
        {
            // basicTableとprotoTableの長さは同じになっていることが期待される.
            return ResolveAlternatingSlots(mapData, args).Zip(mapData.ProtoTable, (poke, slot) => slot.GetSlot(poke)).ToArray();
        }

        public HGSSSurfMapProtoType(string mapData) : base(mapData, MapType.Surf) { }
    }

}
