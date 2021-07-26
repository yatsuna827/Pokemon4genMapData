using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon4genMapData
{
    [Flags]
    enum GameVersion
    {
        Undefined   = 0,

        Diamond     = 1 << 0,
        Pearl       = 1 << 1,
        
        Platinum    = 1 << 2,
        
        HeartGold   = 1 << 3,
        SoulSilver  = 1 << 4,

        DP = Diamond | Pearl,
        DPt = DP | Platinum,
        
        HGSS = HeartGold | SoulSilver
    }

    [Flags]
    public enum EncounterType
    {
        Grass       = 1 << 0,
        Surf        = 1 << 1,
        OldRod      = 1 << 2,
        GoodRod     = 1 << 3,
        SuperRod    = 1 << 4,

        RockSmash   = 1 << 5,
        Headbutt    = 1 << 6,
        BugCatching = 1 << 7,
    }

    public enum MapType
    {
        // 共通
        Grass,
        Surf,
        OldRod,
        GoodRod,
        SuperRod,

        // DPt
        RuinCubicle,
        RuinHall_F,
        RuinHall_R,
        RuinHall_I,
        RuinHall_E,
        RuinHall_N,
        RuinHall_D,
        RuinHiddenRoom,

        // HGSS
        RockSmash,
        Headbutt,
        BugCatching,
        SafariZone,
        RuinsOfAlph_Hall,
        RuinsOfAlph_Entrance,
    }

    // ここからDPt
    public enum TimeSlot
    {
        Morning, Day, Night
    }
    public enum DoubleSlotCartridge
    {
        None, Ruby, Sapphire, Emerald, FireRed, LeafGreen
    }
    public enum DPBoastedPokemon
    {
        None,
        Eevee,
        Bonsly,
        Happiny,
        Meowth,
        Cleffa,
        Clefairy,
        Igglybuff,
        Plusle,
        Jigglypuff,
        Porygon,
        Castform,
        Minun,
        Mime_Jr,
        Marill,
        Chansey,
        Azurill
    }
    public enum DPMarshDairyPokemon
    {
        ゴルダック,
        ロゼリア,
        ムクバード,
        スコルピ,
        グレッグル,
        マスキッパ,
        マリル,
        ウパー,
        ヌオー,
        ルリリ,
        ビッパ,
        ビーダル,
        パラス,
        タマタマ,
        ガルーラ,
        ヤンヤンマ,
        キノココ,
        ゴクリン,
        ドラピオン,
        ドクロッグ
    }
    public enum PtBoastedPokemon
    {
        None,
        Eevee,
        Bonsly,
        Happiny,
        Meowth,
        Cleffa,
        Clefairy,
        Igglybuff,
        Plusle,
        Jigglypuff,
        Ditto,
        Castform,
        Minun,
        Mime_Jr,
        Marill,
        Chansey,
        Azurill
    }
    public enum PtMarshDairyPokemon
    {

    }

    public enum DPHAIKAI
    {
        kyauun,
        kyuuun,
        kyouun,
    }

    public enum PtHAIKAI
    {

    }

    // ここからHGSS
    public enum RadioSound
    {
        None, HoennSound, SinnohSound
    }

    public enum HGSSHAIKAI
    {

    }
}
