namespace Pokemon4genMapData
{
    abstract class DPMapProtoType<T> : MapProtoType<WrappedDPt, DPQueryArgs, DecodedDPtMapData<T>, DPtAltSlots>
        where T : WrappedMapType
    {
        public override MapData BuildMapData(DPQueryArgs args)
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

        protected override Slot[] ResolveOptionalSlots(DecodedDPtMapData<T> mapData, DPQueryArgs args)
        {
            return new Slot[0];
        }

        public DPMapProtoType(string mapData, MapType type) : base(mapData, type) { }
    }
}
