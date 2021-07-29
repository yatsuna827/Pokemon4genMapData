namespace Pokemon4genMapData
{
    class SlotProtoType
    {
        public readonly uint basicLv;
        public readonly uint variableLv;
        public readonly uint probability;
        public Slot GetSlot(string pokemon)
        {
            return new Slot()
            {
                Pokemon = pokemon,
                BasicLv = basicLv,
                VariableLv = variableLv,
                MaxLv = basicLv + variableLv - 1,
                Probability = probability
            };
        }
        public Slot GetSlot(string pokemon, uint maxLv)
        {
            return new Slot()
            {
                Pokemon = pokemon,
                BasicLv = basicLv,
                VariableLv = variableLv,
                MaxLv = maxLv,
                Probability = probability
            };
        }

        public SlotProtoType(uint b, uint v, uint p)
            => (basicLv, variableLv, probability) = (b, v, p);
    }

}
