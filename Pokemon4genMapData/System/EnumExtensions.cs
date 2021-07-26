using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon4genMapData
{
    static class EnumExtensions
    {
        public static string ToPrefix(this EncounterType encounterType)
        {
            if (!Enum.IsDefined(typeof(EncounterType), encounterType))
                throw new ArgumentException("不正なEncounterTypeです");

            switch (encounterType)
            {
                case EncounterType.Grass:
                    return "grass";
                case EncounterType.Surf:
                    return "surf";
                case EncounterType.OldRod:
                    return "oldrod";
                case EncounterType.GoodRod:
                    return "goodrod";
                case EncounterType.SuperRod:
                    return "superrod";
                case EncounterType.RockSmash:
                    return "rocksmash";
                case EncounterType.Headbutt:
                    return "headbutt";
                case EncounterType.BugCatching:
                    return "bugcatching";
                default:
                    return "";
            }
        }


        public static string ToPrefix(this GameVersion version)
        {
            if (!Enum.IsDefined(typeof(GameVersion), version))
                throw new ArgumentException("不正なGameVersionです");

            switch (version)
            {
                case GameVersion.Diamond:
                    return "d";
                case GameVersion.Pearl:
                    return "p";
                case GameVersion.Platinum:
                    return "pt";
                case GameVersion.HeartGold:
                    return "hg";
                case GameVersion.SoulSilver:
                    return "ss";
                default:
                    return "";
            }
        }


    }
}
