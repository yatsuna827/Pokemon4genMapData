using System.Linq;

namespace Pokemon4genMapData
{
    class DPGrassMapProtoType : DPMapProtoType<WrappedGrass>
    {
        protected override DecodedDPtMapData<WrappedGrass> DecodeMap(string rawData)
            => new DecodedDPtGrassMapData(rawData);

        // スロット入替処理.
        // 大量発生   -> 0/1
        // 時間帯     -> 2/3
        // 小揺れ     -> 4/5
        // 湿原・裏庭 -> 6/7
        // ダブスロ   -> 8/9
        // 大揺れ     -> 10/11
        protected override string[] ResolveAlternatingSlots(DecodedDPtMapData<WrappedGrass> mapData, DPQueryArgs args)
        {
            var t = mapData.BasicTable.ToArray();
            var alt = decodedMapData.AltSlots;
            if (alt == null || args == null) return t;

            if (args.Outbreak && alt.Outbreak != null)
                (t[0], t[1]) = alt.Outbreak.Value;

            if (args.TimeSlot == TimeSlot.Day && alt.TimeSlot?.Day != null)
                (t[2], t[3]) = alt.TimeSlot.Day.Value;

            if (args.TimeSlot == TimeSlot.Night && alt.TimeSlot?.Night != null)
                (t[2], t[3]) = alt.TimeSlot.Night.Value;

            if (args.PokeTracer && alt.PokeTracer?.Common != null)
                (t[4], t[5]) = alt.PokeTracer.Common.Value;

            switch (args.DoubleSlotCartridge)
            {
                case DoubleSlotCartridge.Ruby:
                    if (alt.DoubleSlot?.Ruby != null)
                        (t[8], t[9]) = alt.DoubleSlot.Ruby.Value;
                    break;

                case DoubleSlotCartridge.Sapphire:
                    if (alt.DoubleSlot?.Sapphire != null)
                        (t[8], t[9]) = alt.DoubleSlot.Sapphire.Value;
                    break;

                case DoubleSlotCartridge.Emerald:
                    if (alt.DoubleSlot?.Emerald != null)
                        (t[8], t[9]) = alt.DoubleSlot.Emerald.Value;
                    break;

                case DoubleSlotCartridge.FireRed:
                    if (alt.DoubleSlot?.FireRed != null)
                        (t[8], t[9]) = alt.DoubleSlot.FireRed.Value;
                    break;

                case DoubleSlotCartridge.LeafGreen:
                    if (alt.DoubleSlot?.LeafGreen != null)
                        (t[8], t[9]) = alt.DoubleSlot.LeafGreen.Value;
                    break;

                default: break;
            }

            if (args.PokeTracer && alt.PokeTracer?.Rare != null)
                (t[10], t[11]) = alt.PokeTracer.Rare.Value;

            return t;
        }

        protected override Slot[] BuildTable(DecodedDPtMapData<WrappedGrass> mapData, DPQueryArgs args)
        {
            // basicTableとprotoTableの長さは同じになっていることが期待される.
            var p = ResolveAlternatingSlots(mapData, args).Zip(mapData.ProtoTable, (poke, slot) => (poke, slot)).ToArray();

            // 草むら・洞窟エンカに限り、スロットの枠を超えて同種族から最大レベルが取得される.
            return p.Select((val) => val.slot.GetSlot(val.poke, p.Where(_ => _.poke == val.poke).Max(_ => _.slot.basicLv))).ToArray();
        }

        public DPGrassMapProtoType(string mapData) : base(mapData, MapType.Grass) { }
        public DPGrassMapProtoType(string mapData, MapType type) : base(mapData, type) { }
    }

    class DPTrophyGardenProtoType : DPGrassMapProtoType
    {
        private static readonly string[] boastedPokemons = new string[]
        {
            "",
            "イーブイ",
            "ウソハチ",
            "ピンプク",
            "ニャース",
            "ピィ",
            "ピッピ",
            "ププリン",
            "プラスル",
            "プリン",
            "メタモン",
            "ポワルン",
            "マイナン",
            "マネネ",
            "マリル",
            "ラッキー",
            "ルリリ"
        };

        protected override string[] ResolveAlternatingSlots(DecodedDPtMapData<WrappedGrass> mapData, DPQueryArgs args)
        {
            var t = base.ResolveAlternatingSlots(mapData, args);

            if(args != null)
            {
                var (today, yesterday) = args.BoastedPokemon;
                if (today != DPBoastedPokemon.None && System.Enum.IsDefined(typeof(DPBoastedPokemon), today))
                    t[6] = boastedPokemons[(int)today];
                if (yesterday != DPBoastedPokemon.None && System.Enum.IsDefined(typeof(DPBoastedPokemon), yesterday))
                    t[7] = boastedPokemons[(int)yesterday];
            }

            return t;
        }

        public DPTrophyGardenProtoType(string mapData) : base(mapData) { }
    }

    class DPGreatMarshProtoType : DPGrassMapProtoType
    {

        public DPGreatMarshProtoType(string mapData) : base(mapData) { }
    }
}
