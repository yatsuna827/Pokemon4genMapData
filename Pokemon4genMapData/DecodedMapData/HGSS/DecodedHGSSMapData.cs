using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon4genMapData
{
    class DecodedHGSSMapData<T> : DecodedMapData<WrappedHGSS, HGSSAltSlots>
        where T : IWrappedEncounterType<WrappedHGSS>
    {
        public string[] DayTable { get; protected set; }
        public string[] NightTable { get; protected set; }
    }
}
