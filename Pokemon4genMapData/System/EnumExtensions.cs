using System;
using System.Collections.Generic;
using System.Text;
using PokemonStandardLibrary.PokeDex.Gen4;

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

        private static readonly string[] dpBoasted = new string[]
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
            "ポリゴン",
            "ポワルン",
            "マイナン",
            "マネネ",
            "マリル",
            "ラッキー",
            "ルリリ"
        };
        public static string ToJapanese(this DPBoastedPokemon pokemon)
        {
            if (!Enum.IsDefined(typeof(DPBoastedPokemon), pokemon))
                throw new ArgumentException("不正な引数です");

            return dpBoasted[(int)pokemon];
        }

        private static readonly string[] ptBoasted = new string[]
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
        public static string ToJapanese(this PtBoastedPokemon pokemon)
        {
            if (!Enum.IsDefined(typeof(PtBoastedPokemon), pokemon))
                throw new ArgumentException("不正な引数です");

            return ptBoasted[(int)pokemon];
        }

        private static readonly string[] dpMarsh = new string[]
        {
            "",
            "ゴルダック",
            "ロゼリア",
            "ムクバード",
            "スコルピ",
            "グレッグル",
            "マスキッパ",
            "マリル",
            "ウパー",
            "ヌオー",
            "ルリリ",
            "ビッパ",
            "ビーダル",
            "パラス",
            "タマタマ",
            "ガルーラ",
            "ヤンヤンマ",
            "キノココ",
            "ゴクリン",
            "ドラピオン",
            "ドクロッグ",
        };
        public static string ToJapanese(this DPMarshDairyPokemon pokemon)
        {
            if (!Enum.IsDefined(typeof(DPMarshDairyPokemon), pokemon))
                throw new ArgumentException("不正な引数です");

            return dpMarsh[(int)pokemon];
        }

        private static readonly string[] ptMarsh = new string[]
        {
            "ゴルダック",
            "モンジャラ",
            "ヤンヤンマ",
            "ヌオー",
            "トロピウス",
            "スコルピ",
            "グレッグル",
            "マスキッパ",

            "パラス",
            "タマタマ",
            "ガルーラ",
            "キノココ",
            "ゴクリン",
            "カクレオン",
            "ドラピオン",
            "ドクロッグ",
        };
        public static string ToJapanese(this PtMarshDairyPokemon pokemon)
        {
            if (!Enum.IsDefined(typeof(PtMarshDairyPokemon), pokemon))
                throw new ArgumentException("不正な引数です");

            return ptMarsh[(int)pokemon];
        }

    }
}
