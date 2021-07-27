using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon4genMapData
{
    abstract class HGSSMapProtoType<TEncType> : MapProtoType<WrappedHGSS, TEncType, HGSSQueryArgs, DecodedHGSSMapData<TEncType>, HGSSAltSlots>
        where TEncType : IWrappedEncounterType<WrappedHGSS>
    {
        protected override Slot[] ResolveOptionalSlots(DecodedHGSSMapData<TEncType> mapData, HGSSQueryArgs args)
        {
            return new Slot[0];
        }

        protected string[] GetBasicTable(DecodedHGSSMapData<TEncType> mapData, HGSSQueryArgs args)
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
