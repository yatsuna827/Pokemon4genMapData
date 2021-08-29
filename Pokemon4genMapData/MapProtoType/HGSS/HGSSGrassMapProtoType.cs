using System;
using System.Collections.Generic;
using System.Linq;

namespace Pokemon4genMapData
{
    class HGSSGrassMapProtoType : HGSSMapProtoType<WrappedGrass>
    {
        protected override DecodedHGSSMapData<WrappedGrass> DecodeMap(string rawData)
            => new DecodedHGSSGrassMapData(rawData);

        // スロット入替処理.
        protected override string[] ResolveAlternatingSlots(DecodedHGSSMapData<WrappedGrass> mapData, HGSSQueryArgs args)
        {
            var t = GetBasicTable(mapData, args);
            var alt = decodedMapData.AltSlots;
            if (alt == null || args == null) return mapData.BasicTable.ToArray();

            if (args.RadioSound == RadioSound.HoennSound && alt.RadioSound.Hoenn != null)
            {
                t[2] = t[3] = alt.RadioSound.Hoenn.Value.Alt1;
                t[4] = t[5] = alt.RadioSound.Hoenn.Value.Alts2;
            }

            if (args.RadioSound == RadioSound.SinnohSound && alt.RadioSound.Sinnoh != null)
            {
                t[2] = t[3] = alt.RadioSound.Sinnoh.Value.Alt1;
                t[4] = t[5] = alt.RadioSound.Sinnoh.Value.Alts2;
            }

            if (args.Outbreak && alt.Outbreak != null)
                (t[0], t[1]) = (alt.Outbreak, alt.Outbreak);

            return t;
        }

        protected override Slot[] BuildTable(DecodedHGSSMapData<WrappedGrass> mapData, HGSSQueryArgs args)
        {
            // basicTableとprotoTableの長さは同じになっていることが期待される.
            var p = ResolveAlternatingSlots(mapData, args).Zip(mapData.ProtoTable, (poke, slot) => (poke, slot)).ToArray();

            // 草むら・洞窟エンカに限り、スロットの枠を超えて同種族から最大レベルが取得される.
            return p.Select((val) => val.slot.GetSlot(val.poke, p.Where(_ => _.poke == val.poke).Max(_ => _.slot.basicLv))).ToArray();
        }

        public HGSSGrassMapProtoType(string mapData) : base(mapData, MapType.Grass) { }
        public HGSSGrassMapProtoType(string mapData, MapType type) : base(mapData, type) { }
    }

}
