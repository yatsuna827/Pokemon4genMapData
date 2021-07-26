using System.Linq;
using Newtonsoft.Json;

namespace Pokemon4genMapData
{
    class DecodedDPtOldRodMapData : DecodedDPtMapData<WrappedOldRod>
    {
        private static readonly uint[] probabilities = new uint[] { 60, 30, 5, 4, 1 };

        public DecodedDPtOldRodMapData(string mapData)
        {
            var obj = JsonConvert.DeserializeAnonymousType(mapData, new
            {
                MapName = "",
                BasicEncounterRate = 0u,
                SlotProtoType = new[] { new { BasicLv = 0u, VariableLv = 1u } },
                BasicTable = new string[0],
            });

            this.MapName = obj.MapName;
            this.BasicRate = obj.BasicEncounterRate;
            this.ProtoTable = Enumerable.Range(0, 5).Select(i => new SlotProtoType(obj.SlotProtoType[i].BasicLv, obj.SlotProtoType[i].VariableLv, probabilities[i])).ToArray();
            this.BasicTable = obj.BasicTable;

        }
    }
}
