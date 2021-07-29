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
    
    // 返す用のクラス.
    public class MapData
    {
        public string MapName { get; internal set; }
        public MapType Type { get; internal set; }
        public uint BasicEncounterRate { get; internal set; }
        public IReadOnlyList<Slot> EncounterTable { get; internal set; }
        public IReadOnlyList<Slot> OptionalSlots { get; internal set; }
    }

    // API
    public static class MapDataServer
    {
        public static string[] GetDiamondMapNames(EncounterType encounterType)
        {
            var prefix = $"d_{encounterType.ToPrefix()}_";
            return MapDataStore.diamondMapDataStore.Select(_ => _.Key).Where(_ => _.Contains(prefix)).Select(_=>_.Replace(prefix, string.Empty)).ToArray();
        }
        public static string[] GetPearlMapNames(EncounterType encounterType)
        {
            var prefix = $"p_{encounterType.ToPrefix()}_";
            return MapDataStore.pearlMapDataStore.Select(_ => _.Key).Where(_ => _.Contains(prefix)).Select(_ => _.Replace(prefix, string.Empty)).ToArray();
        }
        public static string[] GetPlatinumMapNames(EncounterType encounterType)
        {
            var prefix = $"pt_{encounterType.ToPrefix()}_";
            return MapDataStore.platinumMapDataStore.Select(_ => _.Key).Where(_ => _.Contains(prefix)).Select(_ => _.Replace(prefix, string.Empty)).ToArray();
        }
        public static string[] GetHeartGoldMapNames(EncounterType encounterType)
        {
            var prefix = $"hg_{encounterType.ToPrefix()}_";
            return MapDataStore.heartGoldMapDataStore.Select(_ => _.Key).Where(_ => _.Contains(prefix)).Select(_ => _.Replace(prefix, string.Empty)).ToArray();
        }
        public static string[] GetSoulSilverMapNames(EncounterType encounterType)
        {
            var prefix = $"ss_{encounterType.ToPrefix()}_";
            return MapDataStore.soulSilverMapDataStore.Select(_ => _.Key).Where(_ => _.Contains(prefix)).Select(_ => _.Replace(prefix, string.Empty)).ToArray();
        }

        public static MapData GetDiamondMap(string name, EncounterType encounterType, DPQueryArgs args = null)
        {
            var key = $"d_{encounterType.ToPrefix()}_{name}";

            if (!MapDataStore.diamondMapDataStore.TryGetValue(key, out var map))
                return null;

            return map.BuildMapData(args);
        }
        public static MapData GetPearlMap(string name, EncounterType encounterType, DPQueryArgs args = null)
        {
            var key = $"p_{encounterType.ToPrefix()}_{name}";

            if (!MapDataStore.pearlMapDataStore.TryGetValue(key, out var map))
                return null;

            return map.BuildMapData(args);
        }
        public static MapData GetPlatinumMap(string name, EncounterType encounterType, PtQueryArgs args = null)
        {
            var key = $"pt_{encounterType.ToPrefix()}_{name}";

            if (!MapDataStore.platinumMapDataStore.TryGetValue(key, out var map))
                return null;

            return map.BuildMapData(args);
        }
        public static MapData GetHeartGoldMap(string name, EncounterType encounterType, HGSSQueryArgs args = null)
        {
            var key = $"hg_{encounterType.ToPrefix()}_{name}";

            if (!MapDataStore.heartGoldMapDataStore.TryGetValue(key, out var map))
                return null;

            return map.BuildMapData(args);
        }
        public static MapData GetSoulSilverMap(string name, EncounterType encounterType, HGSSQueryArgs args = null)
        {
            var key = $"ss_{encounterType.ToPrefix()}_{name}";

            if (!MapDataStore.soulSilverMapDataStore.TryGetValue(key, out var map))
                return null;

            return map.BuildMapData(args);
        }
    }

}
