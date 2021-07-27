﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon4genMapData
{
    // JSONデータから翻訳されただけのデータ.
    abstract class DecodedMapData<TVersion, TEncType, TAltSlots>
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
