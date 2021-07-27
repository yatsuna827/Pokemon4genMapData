using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon4genMapData
{
    class DecodedHGSSMapData<TEncType> : DecodedMapData<WrappedHGSS, TEncType, HGSSAltSlots>
        where TEncType : IWrappedEncounterType<WrappedHGSS>
    {
        public string[] DayTable { get; protected set; }
        public string[] NightTable { get; protected set; }
    }
}
