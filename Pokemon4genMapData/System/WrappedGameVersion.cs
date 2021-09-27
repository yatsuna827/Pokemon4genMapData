using System;
using System.Collections.Generic;
using System.Text;
using PokemonStandardLibrary.PokeDex.Gen4;

namespace Pokemon4genMapData
{
    public interface IWrappedGameVersion : IEnumWapper<GameVersion> { }

    public static class GameVersions
    {
        public static readonly WrappedDiamond Diamond = default(WrappedDiamond);
        public static readonly WrappedPearl Pearl = default(WrappedPearl);
        public static readonly WrappedPlatinum Platinum = default(WrappedPlatinum);
        public static readonly WrappedHeartGold HeartGold = default(WrappedHeartGold);
        public static readonly WrappedSoulSilver SoulSilver = default(WrappedSoulSilver);
    }

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
