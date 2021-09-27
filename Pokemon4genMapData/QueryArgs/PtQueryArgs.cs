namespace Pokemon4genMapData
{
    public sealed class PtQueryArgs : IQueryArgs<IWrappedPlatinum>
    {
        public TimeSlot TimeSlot { get; set; }
        public bool Outbreak { get; set; }
        public DoubleSlotCartridge DoubleSlotCartridge { get; set; }
        public bool PokeTracer { get; set; }
        public (PtBoastedPokemon Today, PtBoastedPokemon Yesterday) BoastedPokemon { get; set; } = (0, 0);
        public PtMarshDairyPokemon MarshDairyPokemon { get; set; }
    }
}
