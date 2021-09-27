﻿namespace Pokemon4genMapData
{
    public sealed class HGSSQueryArgs : IQueryArgs<IWrappedHGSS>
    {
        public TimeSlot TimeSlot { get; set; }
        public bool Outbreak { get; set; }
        public RadioSound RadioSound { get; set; }
    }

}
