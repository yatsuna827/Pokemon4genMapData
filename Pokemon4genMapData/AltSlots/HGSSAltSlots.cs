using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon4genMapData
{
    class HGSSAltSlots : IAltSlots<IWrappedHGSS>
    {
        public string Outbreak;
        public RadioSoundAltSlots RadioSound = new RadioSoundAltSlots();
    }
    class RadioSoundAltSlots
    {
        public (string Alt1, string Alts2)? Hoenn;
        public (string Alt1, string Alts2)? Sinnoh;
    }
}
