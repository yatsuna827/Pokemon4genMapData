namespace Pokemon4genMapData
{
    abstract class DPMapProtoType<TEncType> : MapProtoType<WrappedDPt, TEncType, DPQueryArgs, DecodedDPtMapData<TEncType>, DPtAltSlots>
        where TEncType : IWrappedEncounterType<WrappedDPt>
    {
        protected override Slot[] ResolveOptionalSlots(DecodedDPtMapData<TEncType> mapData, DPQueryArgs args)
        {
            return new Slot[0];
        }

        public DPMapProtoType(string mapData, MapType type) : base(mapData, type) { }
    }
}
