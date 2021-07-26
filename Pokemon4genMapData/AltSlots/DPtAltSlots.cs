using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon4genMapData
{
    class DPtAltSlots : IAltSlots<WrappedDPt>
    {
        public TimeSlotAltSlots TimeSlot = new TimeSlotAltSlots();
        public (string Alt1, string Alt2)? Outbreak;
        public PokeTracerAltSlots PokeTracer = new PokeTracerAltSlots();
        public DoubleSlotAltSlots DoubleSlot = new DoubleSlotAltSlots();
    }

    class TimeSlotAltSlots
    {
        public (string Alt1, string Alt2)? Day;
        public (string Alt1, string Alt2)? Night;
    }
    class PokeTracerAltSlots
    {
        public (string Alt1, string Alt2)? Common;
        public (string Alt1, string Alt2)? Rare;
    }
    class DoubleSlotAltSlots
    {
        public (string Alt1, string Alt2)? Ruby;
        public (string Alt1, string Alt2)? Sapphire;
        public (string Alt1, string Alt2)? Emerald;
        public (string Alt1, string Alt2)? FireRed;
        public (string Alt1, string Alt2)? LeafGreen;
    }

}
