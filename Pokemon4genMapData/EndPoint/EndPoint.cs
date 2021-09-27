using System;
using System.Linq;
using System.Collections.Generic;

namespace Pokemon4genMapData
{
    // 返す用のクラス.
    public class Slot<T>
    {
        public T Pokemon { get; internal set; }
        public uint BasicLv { get; internal set; }
        public uint VariableLv { get; internal set; }
        public uint MaxLv { get; internal set; }
        public uint Probability { get; internal set; }
    }
    public class Slot : Slot<string>
    {
        public Slot<T> Convert<T>(Func<string, T> converter)
        {
            return new Slot<T>()
            {
                Pokemon = converter(Pokemon),
                BasicLv = BasicLv,
                VariableLv = VariableLv,
                MaxLv = MaxLv,
                Probability = Probability,
            };
        }
    }
    
    // API
    public static class MapDataServer
    {
        public static string[] GetMapNames<TEncounterType>(WrappedDiamond gameVersion)
            where TEncounterType : struct, IWrappedEncounterType<IWrappedDiamond>
        {
            var encounterType = default(TEncounterType).Unwrap();
            var prefix = $"d_{encounterType.ToPrefix()}_";
            return MapDataStore.diamondMapDataStore.Select(_ => _.Key).Where(_ => _.Contains(prefix)).Select(_=>_.Replace(prefix, string.Empty)).ToArray();
        }
        public static string[] GetMapNames<TEncounterType>(WrappedPearl gameVersion)
            where TEncounterType : struct, IWrappedEncounterType<IWrappedPearl>
        {
            var encounterType = default(TEncounterType).Unwrap();
            var prefix = $"p_{encounterType.ToPrefix()}_";
            return MapDataStore.pearlMapDataStore.Select(_ => _.Key).Where(_ => _.Contains(prefix)).Select(_ => _.Replace(prefix, string.Empty)).ToArray();
        }
        public static string[] GetMapNames<TEncounterType>(WrappedPlatinum gameVersion)
            where TEncounterType : struct, IWrappedEncounterType<IWrappedPlatinum>
        {
            var encounterType = default(TEncounterType).Unwrap();
            var prefix = $"pt_{encounterType.ToPrefix()}_";
            return MapDataStore.platinumMapDataStore.Select(_ => _.Key).Where(_ => _.Contains(prefix)).Select(_ => _.Replace(prefix, string.Empty)).ToArray();
        }
        public static string[] GetMapNames<TEncounterType>(WrappedHeartGold gameVersion)
            where TEncounterType : struct, IWrappedEncounterType<IWrappedSoulSilver>
        {
            var encounterType = default(TEncounterType).Unwrap();
            var prefix = $"hg_{encounterType.ToPrefix()}_";

            var data = MapDataStore.heartGoldMapDataStore.Select(_ => _.Key).Where(_ => _.Contains(prefix)).Select(_ => _.Replace(prefix, string.Empty)).ToArray();

            if (typeof(TEncounterType) == typeof(WrappedRuinOfAlph))
                data = data.Where(_ => _ == ("アルフのいせき(広間)")).ToArray();
            return data;
        }
        public static string[] GetMapNames<TEncounterType>(WrappedSoulSilver gameVersion)
            where TEncounterType : struct, IWrappedEncounterType<IWrappedHeartGold>
        {
            var encounterType = default(TEncounterType).Unwrap();
            var prefix = $"ss_{encounterType.ToPrefix()}_";

            var data = MapDataStore.soulSilverMapDataStore.Select(_ => _.Key).Where(_ => _.Contains(prefix)).Select(_ => _.Replace(prefix, string.Empty)).ToArray();

            if (typeof(TEncounterType) == typeof(WrappedRuinOfAlph))
                data = data.Where(_ => _ == ("アルフのいせき(広間)")).ToArray();
            return data;
        }

        public static IMapData<WrappedDiamond, TEncounterType> GetMap<TEncounterType>(WrappedDiamond gameVersion, string name, DPQueryArgs args = null)
            where TEncounterType : struct, IWrappedEncounterType<WrappedDiamond>
        {
            var encounterType = default(TEncounterType).Unwrap();
            var key = $"d_{encounterType.ToPrefix()}_{name}";

            if (!MapDataStore.diamondMapDataStore.TryGetValue(key, out var map))
                return null;

            return map.BuildMapData<WrappedDiamond, TEncounterType>(args);
        }
        public static IMapData<WrappedPearl, TEncounterType> GetMap<TEncounterType>(WrappedPearl gameVersion, string name, DPQueryArgs args = null)
            where TEncounterType : struct, IWrappedEncounterType<WrappedPearl>
        {
            var encounterType = default(TEncounterType).Unwrap();
            var key = $"d_{encounterType.ToPrefix()}_{name}";

            if (!MapDataStore.pearlMapDataStore.TryGetValue(key, out var map))
                return null;

            return map.BuildMapData<WrappedPearl, TEncounterType>(args);
        }
        public static IMapData<WrappedPlatinum, TEncounterType> GetMap<TEncounterType>(WrappedPlatinum gameVersion, string name, PtQueryArgs args = null)
            where TEncounterType : struct, IWrappedEncounterType<WrappedPlatinum>
        {
            var encounterType = default(TEncounterType).Unwrap();
            var key = $"d_{encounterType.ToPrefix()}_{name}";

            if (!MapDataStore.platinumMapDataStore.TryGetValue(key, out var map))
                return null;

            return map.BuildMapData<WrappedPlatinum, TEncounterType>(args);
        }
        public static IMapData<WrappedHeartGold, TEncounterType> GetMap<TEncounterType>(WrappedHeartGold gameVersion, string name, HGSSQueryArgs args = null)
            where TEncounterType : struct, IWrappedEncounterType<WrappedHeartGold>
        {
            var encounterType = default(TEncounterType).Unwrap();
            var key = $"d_{encounterType.ToPrefix()}_{name}";

            if (!MapDataStore.heartGoldMapDataStore.TryGetValue(key, out var map))
                return null;

            return map.BuildMapData<WrappedHeartGold, TEncounterType>(args);
        }
        public static IMapData<WrappedSoulSilver, TEncounterType> GetMap<TEncounterType>(WrappedSoulSilver gameVersion, string name, HGSSQueryArgs args = null)
            where TEncounterType : struct, IWrappedEncounterType<WrappedSoulSilver>
        {
            var encounterType = default(TEncounterType).Unwrap();
            var key = $"d_{encounterType.ToPrefix()}_{name}";

            if (!MapDataStore.soulSilverMapDataStore.TryGetValue(key, out var map))
                return null;

            return map.BuildMapData<WrappedSoulSilver, TEncounterType>(args);
        }

    }

}
