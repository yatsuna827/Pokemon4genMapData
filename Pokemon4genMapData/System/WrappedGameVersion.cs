using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon4genMapData
{
    interface IWrappedGameVersion : IEnumWapper<GameVersion>
    {

    } 
    struct WrappedDPt : IWrappedGameVersion
    {
        public GameVersion Unwrap() => GameVersion.DPt;
    }
    struct WrappedHGSS : IWrappedGameVersion
    {
        public GameVersion Unwrap() => GameVersion.HGSS;
    }
}
