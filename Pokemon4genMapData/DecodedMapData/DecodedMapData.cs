using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon4genMapData
{
    // JSONデータから翻訳されただけのデータ.
    interface IDecodedMapData<in TVersion, in TEncType, out TAltSlots>
        where TVersion : IWrappedGameVersion
        where TEncType : IWrappedEncounterType<TVersion>
        where TAltSlots : IAltSlots<TVersion>
    {
        string MapName { get; }
        uint BasicRate { get; }
        SlotProtoType[] ProtoTable { get; }
        string[] BasicTable { get; }
        TAltSlots AltSlots { get; }
    }

    abstract class DecodedMapData<TVersion, TEncType, TAltSlots>
        : IDecodedMapData<TVersion, TEncType, TAltSlots>
        where TVersion : IWrappedGameVersion
        where TEncType : IWrappedEncounterType<TVersion>
        where TAltSlots : IAltSlots<TVersion>
    {
        public string MapName { get; protected set; }
        public uint BasicRate { get; protected set; }
        public SlotProtoType[] ProtoTable { get; protected set; }
        public string[] BasicTable { get; protected set; }
        public TAltSlots AltSlots { get; protected set; }
    }

}
