using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon4genMapData
{
    class DecodedDPtMapData<T> : DecodedMapData<WrappedDPt, DPtAltSlots>
        where T : IWrappedEncounterType<WrappedDPt>
    {

    }
}
