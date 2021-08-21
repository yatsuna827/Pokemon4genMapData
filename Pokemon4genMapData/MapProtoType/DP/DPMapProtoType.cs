namespace Pokemon4genMapData
{
    abstract class DPMapProtoType<TEncType> 
        : MapProtoType<IWrappedDP, TEncType, DPQueryArgs, DecodedDPtMapData<TEncType>, DPtAltSlots>
        where TEncType : IWrappedEncounterType<IWrappedDPt>
    {
        protected override Slot[] ResolveOptionalSlots(DecodedDPtMapData<TEncType> mapData, DPQueryArgs args)
        {
            return new Slot[0];
        }

        public DPMapProtoType(string mapData, MapType type) : base(mapData, type) { }
    }
}
