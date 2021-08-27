using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon4genMapData
{
    public interface IWrappedGameVersion : IEnumWapper<GameVersion> { }

    public interface IWrappedDPt: IWrappedGameVersion { }
    public interface IWrappedDP : IWrappedDPt { }

    public interface IWrappedDiamond : IWrappedDP { }
    public struct WrappedDiamond : IWrappedDiamond
    {
        public GameVersion Unwrap() => GameVersion.Diamond;
    }
    public interface IWrappedPearl : IWrappedDP { }
    public struct WrappedPearl : IWrappedPearl
    {
        public GameVersion Unwrap() => GameVersion.Pearl;
    }
    public interface IWrappedPlatinum : IWrappedDPt { }
    public struct WrappedPlatinum : IWrappedPlatinum
    {
        public GameVersion Unwrap() => GameVersion.Platinum;
    }

    public interface IWrappedHGSS : IWrappedGameVersion { }
    public interface IWrappedHeartGold : IWrappedHGSS { }
    public struct WrappedHeartGold : IWrappedHeartGold
    {
        public GameVersion Unwrap() => GameVersion.HeartGold;
    }
    public interface IWrappedSoulSilver : IWrappedHGSS { }
    public struct WrappedSoulSilver : IWrappedSoulSilver
    {
        public GameVersion Unwrap() => GameVersion.SoulSilver;
    }
}
