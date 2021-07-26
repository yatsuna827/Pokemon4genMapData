using System.Linq;
using Newtonsoft.Json;

namespace Pokemon4genMapData
{
    class DecodedDPtGrassMapData : DecodedDPtMapData<WrappedGrass>
    {
        private static readonly uint[] probabilities = new uint[] { 20, 20, 10, 10, 10, 10, 5, 5, 4, 4, 1, 1 };

        public DecodedDPtGrassMapData(string mapData)
        {
            var obj = JsonConvert.DeserializeAnonymousType(mapData, new
            {
                MapName = "",
                BasicEncounterRate = 0u,
                SlotProtoType = new[] { new { BasicLv = 0u, VariableLv = 1u } },
                BasicTable = new string[0],
                AltSlots = new
                {
                    TimeSlot = new
                    {
                        Day = new string[0],
                        Night = new string[0],
                    },
                    Outbreak = new string[0],
                    PokeTracer = new
                    {
                        Common = new string[0],
                        Rare = new string[0],
                    },
                    DoubleSlot = new
                    {
                        Ruby = new string[0],
                        Sapphire = new string[0],
                        Emerald = new string[0],
                        FireRed = new string[0],
                        LeafGreen = new string[0],
                    }
                }
            });

            this.MapName = obj.MapName;
            this.BasicRate = obj.BasicEncounterRate;
            this.ProtoTable = Enumerable.Range(0, 12).Select(i => new SlotProtoType(obj.SlotProtoType[i].BasicLv, obj.SlotProtoType[i].VariableLv, probabilities[i])).ToArray();
            this.BasicTable = obj.BasicTable;
            this.AltSlots = new DPtAltSlots();

            var alt = obj.AltSlots;
            if (alt != null)
            {
                var day = alt.TimeSlot?.Day;
                var night = alt.TimeSlot?.Night;
                if (day?.Length == 2) AltSlots.TimeSlot.Day = (day[0], day[1]);
                if (night?.Length == 2) AltSlots.TimeSlot.Night = (night[0], night[1]);

                var outbreak = alt.Outbreak;
                if (outbreak?.Length == 2) AltSlots.Outbreak = (outbreak[0], outbreak[1]);

                var common = alt.PokeTracer?.Common;
                var rare = alt.PokeTracer?.Rare;
                if (common?.Length == 2) AltSlots.PokeTracer.Common = (common[0], common[1]);
                if (rare?.Length == 2) AltSlots.PokeTracer.Rare = (rare[0], rare[1]);

                var ruby = alt.DoubleSlot?.Ruby;
                var sapphire = alt.DoubleSlot?.Sapphire;
                var emerald = alt.DoubleSlot?.Emerald;
                var fireRed = alt.DoubleSlot?.FireRed;
                var leafGreen = alt.DoubleSlot?.LeafGreen;
                if (ruby?.Length == 2) AltSlots.DoubleSlot.Ruby = (ruby[0], ruby[1]);
                if (sapphire?.Length == 2) AltSlots.DoubleSlot.Sapphire = (sapphire[0], sapphire[1]);
                if (emerald?.Length == 2) AltSlots.DoubleSlot.Emerald = (emerald[0], emerald[1]);
                if (fireRed?.Length == 2) AltSlots.DoubleSlot.FireRed = (fireRed[0], fireRed[1]);
                if (leafGreen?.Length == 2) AltSlots.DoubleSlot.LeafGreen = (leafGreen[0], leafGreen[1]);
            }

        }
    }
}
