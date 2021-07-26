using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon4genMapData
{
    abstract class HGSSMapProtoType<T> : MapProtoType<WrappedHGSS, HGSSQueryArgs, DecodedHGSSMapData<T>, HGSSAltSlots>
        where T : IWrappedEncounterType<WrappedHGSS>
    {
        public override MapData BuildMapData(HGSSQueryArgs args)
        {
            if (decodedMapData == null)
                decodedMapData = DecodeMap(rawMapData);

            return new MapData()
            {
                MapName = decodedMapData.MapName,
                BasicEncounterRate = decodedMapData.BasicRate,
                Type = mapType,
                EncounterTable = BuildTable(decodedMapData, args),
                OptionalSlots = new Slot[0],
            };
        }

        protected override Slot[] ResolveOptionalSlots(DecodedHGSSMapData<T> mapData, HGSSQueryArgs args)
        {
            return new Slot[0];
        }

        protected string[] GetBasicTable(DecodedHGSSMapData<T> mapData, HGSSQueryArgs args)
        {
            if (args == null || mapData.DayTable == null || mapData.NightTable == null) return mapData.BasicTable;

            switch (args.TimeSlot)
            {
                case TimeSlot.Day:
                    return mapData.DayTable;
                case TimeSlot.Night:
                    return mapData.NightTable;
                default:
                    return mapData.BasicTable;
            }
        }

        public HGSSMapProtoType(string mapData, MapType type) : base(mapData, type) { }
    }
}
