using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon4genMapData
{
    class DecodedDPtMapData<TEncType> : DecodedMapData<WrappedDPt, TEncType, DPtAltSlots>
        where TEncType : IWrappedEncounterType<WrappedDPt>
    {

    }
}
