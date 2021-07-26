namespace Pokemon4genMapData
{
    public class HGSSQueryArgs : IQueryArgs<WrappedHGSS>
    {
        public TimeSlot TimeSlot { get; set; }
        public bool Outbreak { get; set; }
        public RadioSound RadioSound { get; set; }
    }

}
