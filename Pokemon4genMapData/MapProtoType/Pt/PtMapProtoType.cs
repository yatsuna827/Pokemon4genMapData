namespace Pokemon4genMapData
{
    abstract class PtMapProtoType<TEncType> : MapProtoType<WrappedDPt, TEncType, PtQueryArgs, DecodedDPtMapData<TEncType>, DPtAltSlots>
        where TEncType : IWrappedEncounterType<WrappedDPt>
    {
        protected override Slot[] ResolveOptionalSlots(DecodedDPtMapData<TEncType> mapData, PtQueryArgs args)
        {
            return new Slot[0];
        }

        public PtMapProtoType(string mapData, MapType type) : base(mapData, type) { }
    }
}
