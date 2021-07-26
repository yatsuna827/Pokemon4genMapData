namespace Pokemon4genMapData
{
    abstract class PtMapProtoType<T> : MapProtoType<WrappedDPt, PtQueryArgs, DecodedDPtMapData<T>, DPtAltSlots>
        where T : IWrappedEncounterType<WrappedDPt>
    {
        public override MapData BuildMapData(PtQueryArgs args)
        {
            if (decodedMapData == null)
                decodedMapData = DecodeMap(rawMapData);

            return new MapData()
            {
                MapName = decodedMapData.MapName,
                BasicEncounterRate = decodedMapData.BasicRate,
                Type = mapType,
                EncounterTable = BuildTable(decodedMapData, args),
                OptionalSlots = new Slot[0],
            };
        }

        protected override Slot[] ResolveOptionalSlots(DecodedDPtMapData<T> mapData, PtQueryArgs args)
        {
            return new Slot[0];
        }

        public PtMapProtoType(string mapData, MapType type) : base(mapData, type) { }
    }
}
