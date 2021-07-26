using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon4genMapData
{
    interface WrappedGameVersion : IEnumWapper<GameVersion>
    {

    }

    struct WrappedDPt : WrappedGameVersion
    {
        public GameVersion Unwrap() => GameVersion.DPt;
    }
    struct WrappedHGSS : WrappedGameVersion
    {
        public GameVersion Unwrap() => GameVersion.HGSS;
    }
}
