using System.Linq;
using Newtonsoft.Json;

namespace Pokemon4genMapData
{
    class DecodedHGSSSuperRodMapData : DecodedHGSSMapData<WrappedSuperRod>
    {
        private static readonly uint[] probabilities = new uint[] { 40, 30, 15, 10, 5 };

        public DecodedHGSSSuperRodMapData(string mapData)
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
                }
            });

            this.MapName = obj.MapName;
            this.BasicRate = obj.BasicEncounterRate;
            this.ProtoTable = Enumerable.Range(0, 5).Select(i => new SlotProtoType(obj.SlotProtoType[i].BasicLv, obj.SlotProtoType[i].VariableLv, probabilities[i])).ToArray();
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
            }

        }
    }
}
