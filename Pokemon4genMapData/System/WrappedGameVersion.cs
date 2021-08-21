using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon4genMapData
{
    public interface IWrappedGameVersion : IEnumWapper<GameVersion> { }

    public interface IWrappedDPt: IWrappedGameVersion { }
    public interface IWrappedDP : IWrappedDPt { }

    public interface IWrappedDiamond : IWrappedDP { }
    public interface IWrappedPearl : IWrappedDP { }
    public interface IWrappedPlatinum : IWrappedDPt { }

    public interface IWrappedHGSS : IWrappedGameVersion { }
    public interface IWrappedHeartGold : IWrappedHGSS { }
    public interface IWrappedSoulSilver : IWrappedHGSS { }
}
