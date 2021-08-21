using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon4genMapData
{
    class DecodedDPtMapData<TEncType> : DecodedMapData<IWrappedDPt, TEncType, DPtAltSlots>
        where TEncType : IWrappedEncounterType<IWrappedDPt>
    {

    }
}
