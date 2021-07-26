using System;
using System.Collections.Generic;
using PokemonStandardLibrary.PokeDex.Gen4;

namespace Pokemon4genMapData
{
    // 返す用のクラス.
    public class Slot
    {
        public Pokemon.Species Pokemon { get; internal set; }
        public uint BasicLv { get; internal set; }
        public uint VariableLv { get; internal set; }
        public uint MaxLv { get; internal set; }
        public uint Probability { get; internal set; }
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
        public static MapData GetDiamondMap(string name, DPQueryArgs args = null)
        {
            // マップを組み立てます。
            if (!MapDataStore.diamondMapDataStore.TryGetValue(name, out var map))
                return null;

            return map.BuildMapData(args);
        }
    }

}
