namespace Pokemon4genMapData
{
    public class DPQueryArgs : IQueryArgs<IWrappedDP>
    {
        public TimeSlot TimeSlot { get; set; }
        public bool Outbreak { get; set; }
        public DoubleSlotCartridge DoubleSlotCartridge { get; set; }
        public bool PokeTracer { get; set; }
        public (DPBoastedPokemon Today, DPBoastedPokemon Yesterday) BoastedPokemon { get; set; } = (0, 0);
        public DPMarshDairyPokemon MarshDairyPokemon { get; set; }
    }
}
