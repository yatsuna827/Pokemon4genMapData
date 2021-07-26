using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon4genMapData
{
    class DecodedHGSSMapData<T> : DecodedMapData<WrappedHGSS, HGSSAltSlots>
        where T : WrappedMapType
    {
        public string[] DayTable { get; protected set; }
        public string[] NightTable { get; protected set; }
    }
}
