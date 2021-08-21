using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon4genMapData
{
    class DecodedHGSSMapData<TEncType> : DecodedMapData<IWrappedHGSS, TEncType, HGSSAltSlots>
        where TEncType : IWrappedEncounterType<IWrappedHGSS>
    {
        public string[] DayTable { get; protected set; }
        public string[] NightTable { get; protected set; }
    }
}
