using System.Linq;
using Newtonsoft.Json;

namespace Pokemon4genMapData
{
    class DecodedHGSSGrassMapData : DecodedHGSSMapData<WrappedGrass>
    {
        private static readonly uint[] probabilities = new uint[] { 20, 20, 10, 10, 10, 10, 5, 5, 4, 4, 1, 1 };

        public DecodedHGSSGrassMapData(string mapData)
        {
            var obj = JsonConvert.DeserializeAnonymousType(mapData, new
            {
                MapName = "",
                BasicEncounterRate = 0u,
                SlotProtoType = new[] { new { BasicLv = 0u, VariableLv = 1u } },
                MorningTable = new string[0],
                DayTable = new string[0],
                NightTable = new string[0],
                AltSlots = new
                {
                    Outbreak = "",
                    RadioSound = new
                    {
                        Hoenn = new string[0],
                        Sinnoh = new string[0],
                    }
                }
            });

            this.MapName = obj.MapName;
            this.BasicRate = obj.BasicEncounterRate;
            this.ProtoTable = Enumerable.Range(0, 12).Select(i => new SlotProtoType(obj.SlotProtoType[i].BasicLv, obj.SlotProtoType[i].VariableLv, probabilities[i])).ToArray();
            this.BasicTable = obj.MorningTable;
            this.DayTable = obj.DayTable;
            this.NightTable = obj.NightTable;
            this.AltSlots = new HGSSAltSlots();

            var alt = obj.AltSlots;
            if (alt != null)
            {
                var outbreak = alt.Outbreak;
                if (outbreak != null && outbreak != "")
                    this.AltSlots.Outbreak = outbreak;

                var hoenn = alt.RadioSound?.Hoenn;
                if (hoenn != null)
                    this.AltSlots.RadioSound.Hoenn = (hoenn[0], hoenn[1]);
                
                var sinnoh = alt.RadioSound?.Sinnoh;
                if (sinnoh != null)
                    this.AltSlots.RadioSound.Sinnoh = (sinnoh[0], sinnoh[1]);
            }

        }
    }
}
