using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon4genMapData
{
    public interface IMapData<in TGameVersion>
        where TGameVersion : IWrappedGameVersion
    {
        string MapName { get; }
        MapType Type { get; }
        uint BasicEncounterRate { get; }
        IReadOnlyList<Slot> EncounterTable { get; }
        IReadOnlyList<Slot> OptionalSlots { get; }
    }

    // 返す用のクラス.
    class MapData<TGameVersion>
        : IMapData<TGameVersion>
        where TGameVersion : IWrappedGameVersion
    {
        public string MapName { get; internal set; }
        public MapType Type { get; internal set; }
        public uint BasicEncounterRate { get; internal set; }
        public IReadOnlyList<Slot> EncounterTable { get; internal set; }
        public IReadOnlyList<Slot> OptionalSlots { get; internal set; }
    }

}
