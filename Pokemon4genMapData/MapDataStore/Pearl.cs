﻿using System.Collections.Generic;
using static Pokemon4genMapData.Properties.Resources;

namespace Pokemon4genMapData
{
    static partial class MapDataStore
    {
        public static Dictionary<string, IBuildable<IWrappedPearl, DPQueryArgs>> pearlMapDataStore = new Dictionary<string, IBuildable<IWrappedPearl, DPQueryArgs>>()
        {
            #region Grass
            { "p_grass_201ばんどうろ", new DPGrassMapProtoType(p_grass_201ばんどうろ) },
            { "p_grass_202ばんどうろ", new DPGrassMapProtoType(p_grass_202ばんどうろ) },
            { "p_grass_203ばんどうろ", new DPGrassMapProtoType(p_grass_203ばんどうろ) },
            { "p_grass_204ばんどうろ(北)", new DPGrassMapProtoType(p_grass_204ばんどうろ_北_) },
            { "p_grass_204ばんどうろ(南)", new DPGrassMapProtoType(p_grass_204ばんどうろ_南_) },
            { "p_grass_205ばんどうろ(北東)", new DPGrassMapProtoType(p_grass_205ばんどうろ_北東_) },
            { "p_grass_205ばんどうろ(南西)", new DPGrassMapProtoType(p_grass_205ばんどうろ_南西_) },
            { "p_grass_206ばんどうろ", new DPGrassMapProtoType(p_grass_206ばんどうろ) },
            { "p_grass_207ばんどうろ", new DPGrassMapProtoType(p_grass_207ばんどうろ) },
            { "p_grass_208ばんどうろ", new DPGrassMapProtoType(p_grass_208ばんどうろ) },
            { "p_grass_209ばんどうろ", new DPGrassMapProtoType(p_grass_209ばんどうろ) },
            { "p_grass_210ばんどうろ(北)", new DPGrassMapProtoType(p_grass_210ばんどうろ_北_) },
            { "p_grass_210ばんどうろ(南)", new DPGrassMapProtoType(p_grass_210ばんどうろ_南_) },
            { "p_grass_211ばんどうろ(東)", new DPGrassMapProtoType(p_grass_211ばんどうろ_東_) },
            { "p_grass_211ばんどうろ(西)", new DPGrassMapProtoType(p_grass_211ばんどうろ_西_) },
            { "p_grass_212ばんどうろ(北)", new DPGrassMapProtoType(p_grass_212ばんどうろ_北_) },
            { "p_grass_212ばんどうろ(南)", new DPGrassMapProtoType(p_grass_212ばんどうろ_南_) },
            { "p_grass_213ばんどうろ", new DPGrassMapProtoType(p_grass_213ばんどうろ) },
            { "p_grass_214ばんどうろ", new DPGrassMapProtoType(p_grass_214ばんどうろ) },
            { "p_grass_215ばんどうろ", new DPGrassMapProtoType(p_grass_215ばんどうろ) },
            { "p_grass_216ばんどうろ", new DPGrassMapProtoType(p_grass_216ばんどうろ) },
            { "p_grass_217ばんどうろ", new DPGrassMapProtoType(p_grass_217ばんどうろ) },
            { "p_grass_218ばんどうろ", new DPGrassMapProtoType(p_grass_218ばんどうろ) },
            { "p_grass_221ばんどうろ", new DPGrassMapProtoType(p_grass_221ばんどうろ) },
            { "p_grass_222ばんどうろ", new DPGrassMapProtoType(p_grass_222ばんどうろ) },
            { "p_grass_224ばんどうろ", new DPGrassMapProtoType(p_grass_224ばんどうろ) },
            { "p_grass_225ばんどうろ", new DPGrassMapProtoType(p_grass_225ばんどうろ) },
            { "p_grass_226ばんすいどう", new DPGrassMapProtoType(p_grass_226ばんすいどう) },
            { "p_grass_227ばんどうろ", new DPGrassMapProtoType(p_grass_227ばんどうろ) },
            { "p_grass_228ばんどうろ", new DPGrassMapProtoType(p_grass_228ばんどうろ) },
            { "p_grass_229ばんどうろ", new DPGrassMapProtoType(p_grass_229ばんどうろ) },
            { "p_grass_230ばんすいどう", new DPGrassMapProtoType(p_grass_230ばんすいどう) },
            { "p_grass_あれたぬけみち", new DPGrassMapProtoType(p_grass_あれたぬけみち) },
            { "p_grass_いせきマニアのあな(中期)", new DPGrassMapProtoType(p_grass_いせきマニアのあな_中期_) },
            { "p_grass_いせきマニアのあな(初期)", new DPGrassMapProtoType(p_grass_いせきマニアのあな_初期_) },
            { "p_grass_おくりのいずみ", new DPGrassMapProtoType(p_grass_おくりのいずみ) },
            { "p_grass_こうてつじま(1F)", new DPGrassMapProtoType(p_grass_こうてつじま_1F_) },
            { "p_grass_こうてつじま(B1F)", new DPGrassMapProtoType(p_grass_こうてつじま_B1F_) },
            { "p_grass_こうてつじま(B2F-右)", new DPGrassMapProtoType(p_grass_こうてつじま_B2F_右_) },
            { "p_grass_こうてつじま(B2F-左)", new DPGrassMapProtoType(p_grass_こうてつじま_B2F_左_) },
            { "p_grass_こうてつじま(B3F)", new DPGrassMapProtoType(p_grass_こうてつじま_B3F_) },
            { "p_grass_じまんのうらにわ", new DPTrophyGardenProtoType(p_grass_じまんのうらにわ) },
            { "p_grass_たにまのはつでんしょ", new DPGrassMapProtoType(p_grass_たにまのはつでんしょ) },
            { "p_grass_まよいのどうくつ(1F)", new DPGrassMapProtoType(p_grass_まよいのどうくつ_1F_) },
            { "p_grass_まよいのどうくつ(B1F)", new DPGrassMapProtoType(p_grass_まよいのどうくつ_B1F_) },
            { "p_grass_もどりのどうくつ(0本)", new DPGrassMapProtoType(p_grass_もどりのどうくつ_0本_) },
            { "p_grass_もどりのどうくつ(1本)", new DPGrassMapProtoType(p_grass_もどりのどうくつ_1本_) },
            { "p_grass_もどりのどうくつ(2本)", new DPGrassMapProtoType(p_grass_もどりのどうくつ_2本_) },
            { "p_grass_もりのようかん", new DPGrassMapProtoType(p_grass_もりのようかん) },
            { "p_grass_もりのようかん(絵)", new DPGrassMapProtoType(p_grass_もりのようかん_絵_) },
            { "p_grass_エイチこ", new DPGrassMapProtoType(p_grass_エイチこ) },
            { "p_grass_エイチこのほとり", new DPGrassMapProtoType(p_grass_エイチこのほとり) },
            { "p_grass_キッサキしんでん(1F)", new DPGrassMapProtoType(p_grass_キッサキしんでん_1F_) },
            { "p_grass_キッサキしんでん(B1F)", new DPGrassMapProtoType(p_grass_キッサキしんでん_B1F_) },
            { "p_grass_キッサキしんでん(B2F)", new DPGrassMapProtoType(p_grass_キッサキしんでん_B2F_) },
            { "p_grass_キッサキしんでん(B3F)", new DPGrassMapProtoType(p_grass_キッサキしんでん_B3F_) },
            { "p_grass_キッサキしんでん(B4F)", new DPGrassMapProtoType(p_grass_キッサキしんでん_B4F_) },
            { "p_grass_キッサキしんでん(B5F)", new DPGrassMapProtoType(p_grass_キッサキしんでん_B5F_) },
            { "p_grass_クロガネたんこう(1F)", new DPGrassMapProtoType(p_grass_クロガネたんこう_1F_) },
            { "p_grass_クロガネたんこう(B1F)", new DPGrassMapProtoType(p_grass_クロガネたんこう_B1F_) },
            { "p_grass_クロガネゲート(1F)", new DPGrassMapProtoType(p_grass_クロガネゲート_1F_) },
            { "p_grass_クロガネゲート(B1F)", new DPGrassMapProtoType(p_grass_クロガネゲート_B1F_) },
            { "p_grass_シンジこ", new DPGrassMapProtoType(p_grass_シンジこ) },
            { "p_grass_シンジこ(イベント後)", new DPGrassMapProtoType(p_grass_シンジこ_イベント後_) },
            { "p_grass_ズイのいせき(D)", new DPGrassMapProtoType(p_grass_ズイのいせき_D_, MapType.RuinHall_D) },
            { "p_grass_ズイのいせき(E)", new DPGrassMapProtoType(p_grass_ズイのいせき_E_, MapType.RuinHall_E) },
            { "p_grass_ズイのいせき(F)", new DPGrassMapProtoType(p_grass_ズイのいせき_F_, MapType.RuinHall_F) },
            { "p_grass_ズイのいせき(I)", new DPGrassMapProtoType(p_grass_ズイのいせき_I_, MapType.RuinHall_I) },
            { "p_grass_ズイのいせき(N)", new DPGrassMapProtoType(p_grass_ズイのいせき_N_, MapType.RuinHall_N) },
            { "p_grass_ズイのいせき(R)", new DPGrassMapProtoType(p_grass_ズイのいせき_R_, MapType.RuinHall_R) },
            { "p_grass_ズイのいせき(小部屋)", new DPGrassMapProtoType(p_grass_ズイのいせき_小部屋_, MapType.RuinCubicle) },
            { "p_grass_ズイのいせき(隠し)", new DPGrassMapProtoType(p_grass_ズイのいせき_隠し_, MapType.RuinHiddenRoom) },
            { "p_grass_タタラせいてつじょ", new DPGrassMapProtoType(p_grass_タタラせいてつじょ) },
            { "p_grass_チャンピオンロード(1F)", new DPGrassMapProtoType(p_grass_チャンピオンロード_1F_) },
            { "p_grass_チャンピオンロード(2F)", new DPGrassMapProtoType(p_grass_チャンピオンロード_2F_) },
            { "p_grass_チャンピオンロード(B1F)", new DPGrassMapProtoType(p_grass_チャンピオンロード_B1F_) },
            { "p_grass_チャンピオンロード(B1F-奥)", new DPGrassMapProtoType(p_grass_チャンピオンロード_B1F_奥_) },
            { "p_grass_チャンピオンロード(奥)", new DPGrassMapProtoType(p_grass_チャンピオンロード_奥_) },
            { "p_grass_テンガンざん(1F-中央)", new DPGrassMapProtoType(p_grass_テンガンざん_1F_中央_) },
            { "p_grass_テンガンざん(1F-北)", new DPGrassMapProtoType(p_grass_テンガンざん_1F_北_) },
            { "p_grass_テンガンざん(1F-南)", new DPGrassMapProtoType(p_grass_テンガンざん_1F_南_) },
            { "p_grass_テンガンざん(2F)", new DPGrassMapProtoType(p_grass_テンガンざん_2F_) },
            { "p_grass_テンガンざん(3F)", new DPGrassMapProtoType(p_grass_テンガンざん_3F_) },
            { "p_grass_テンガンざん(4F)", new DPGrassMapProtoType(p_grass_テンガンざん_4F_) },
            { "p_grass_テンガンざん(5F)", new DPGrassMapProtoType(p_grass_テンガンざん_5F_) },
            { "p_grass_テンガンざん(6F)", new DPGrassMapProtoType(p_grass_テンガンざん_6F_) },
            { "p_grass_テンガンざん(7F)", new DPGrassMapProtoType(p_grass_テンガンざん_7F_) },
            { "p_grass_テンガンざん(B1F)", new DPGrassMapProtoType(p_grass_テンガンざん_B1F_) },
            { "p_grass_テンガンざん(外壁)", new DPGrassMapProtoType(p_grass_テンガンざん_外壁_) },
            { "p_grass_テンガンざん(横穴)", new DPGrassMapProtoType(p_grass_テンガンざん_横穴_) },
            { "p_grass_ノモセだいしつげん(エリア1)", new DPGreatMarshProtoType(p_grass_ノモセだいしつげん_エリア1_) },
            { "p_grass_ノモセだいしつげん(エリア2)", new DPGreatMarshProtoType(p_grass_ノモセだいしつげん_エリア2_) },
            { "p_grass_ノモセだいしつげん(エリア3)", new DPGreatMarshProtoType(p_grass_ノモセだいしつげん_エリア3_) },
            { "p_grass_ノモセだいしつげん(エリア4)", new DPGreatMarshProtoType(p_grass_ノモセだいしつげん_エリア4_) },
            { "p_grass_ノモセだいしつげん(エリア5)", new DPGreatMarshProtoType(p_grass_ノモセだいしつげん_エリア5_) },
            { "p_grass_ノモセだいしつげん(エリア6)", new DPGreatMarshProtoType(p_grass_ノモセだいしつげん_エリア6_) },
            { "p_grass_ハクタイのもり", new DPGrassMapProtoType(p_grass_ハクタイのもり) },
            { "p_grass_ハードマウンテン(入り口)", new DPGrassMapProtoType(p_grass_ハードマウンテン_入り口_) },
            { "p_grass_ハードマウンテン(奥)", new DPGrassMapProtoType(p_grass_ハードマウンテン_奥_) },
            { "p_grass_ハードマウンテン", new DPGrassMapProtoType(p_grass_ハードマウンテン) },
            { "p_grass_マニアトンネル", new DPGrassMapProtoType(p_grass_マニアトンネル) },
            { "p_grass_リッシこ", new DPGrassMapProtoType(p_grass_リッシこ) },
            { "p_grass_リッシこのほとり", new DPGrassMapProtoType(p_grass_リッシこのほとり) },
            { "p_grass_ロストタワー(1F)", new DPGrassMapProtoType(p_grass_ロストタワー_1F_) },
            { "p_grass_ロストタワー(2F)", new DPGrassMapProtoType(p_grass_ロストタワー_2F_) },
            { "p_grass_ロストタワー(3F)", new DPGrassMapProtoType(p_grass_ロストタワー_3F_) },
            { "p_grass_ロストタワー(4F)", new DPGrassMapProtoType(p_grass_ロストタワー_4F_) },
            { "p_grass_ロストタワー(5F)", new DPGrassMapProtoType(p_grass_ロストタワー_5F_) },
            #endregion

            #region Surf
            { "p_surf_203ばんどうろ", new DPSurfMapProtoType(p_surf_203ばんどうろ) },
            { "p_surf_204ばんどうろ", new DPSurfMapProtoType(p_surf_204ばんどうろ) },
            { "p_surf_205ばんどうろ(北東)", new DPSurfMapProtoType(p_surf_205ばんどうろ_北東_) },
            { "p_surf_205ばんどうろ(南西)", new DPSurfMapProtoType(p_surf_205ばんどうろ_南西_) },
            { "p_surf_208ばんどうろ", new DPSurfMapProtoType(p_surf_208ばんどうろ) },
            { "p_surf_209ばんどうろ", new DPSurfMapProtoType(p_surf_209ばんどうろ) },
            { "p_surf_210ばんどうろ", new DPSurfMapProtoType(p_surf_210ばんどうろ) },
            { "p_surf_212ばんどうろ(北)", new DPSurfMapProtoType(p_surf_212ばんどうろ_北_) },
            { "p_surf_212ばんどうろ(南)", new DPSurfMapProtoType(p_surf_212ばんどうろ_南_) },
            { "p_surf_213ばんどうろ", new DPSurfMapProtoType(p_surf_213ばんどうろ) },
            { "p_surf_214ばんどうろ", new DPSurfMapProtoType(p_surf_214ばんどうろ) },
            { "p_surf_218ばんどうろ", new DPSurfMapProtoType(p_surf_218ばんどうろ) },
            { "p_surf_219ばんどうろ", new DPSurfMapProtoType(p_surf_219ばんどうろ) },
            { "p_surf_220ばんすいどう", new DPSurfMapProtoType(p_surf_220ばんすいどう) },
            { "p_surf_221ばんどうろ", new DPSurfMapProtoType(p_surf_221ばんどうろ) },
            { "p_surf_222ばんどうろ", new DPSurfMapProtoType(p_surf_222ばんどうろ) },
            { "p_surf_223ばんすいどう", new DPSurfMapProtoType(p_surf_223ばんすいどう) },
            { "p_surf_224ばんどうろ", new DPSurfMapProtoType(p_surf_224ばんどうろ) },
            { "p_surf_225ばんどうろ", new DPSurfMapProtoType(p_surf_225ばんどうろ) },
            { "p_surf_226ばんすいどう", new DPSurfMapProtoType(p_surf_226ばんすいどう) },
            { "p_surf_227ばんどうろ", new DPSurfMapProtoType(p_surf_227ばんどうろ) },
            { "p_surf_228ばんどうろ", new DPSurfMapProtoType(p_surf_228ばんどうろ) },
            { "p_surf_229ばんどうろ", new DPSurfMapProtoType(p_surf_229ばんどうろ) },
            { "p_surf_230ばんすいどう", new DPSurfMapProtoType(p_surf_230ばんすいどう) },
            { "p_surf_あれたぬけみち", new DPSurfMapProtoType(p_surf_あれたぬけみち) },
            { "p_surf_おくりのいずみ", new DPSurfMapProtoType(p_surf_おくりのいずみ) },
            { "p_surf_こうてつじま", new DPSurfMapProtoType(p_surf_こうてつじま) },
            { "p_surf_たにまのはつでんしょ", new DPSurfMapProtoType(p_surf_たにまのはつでんしょ) },
            { "p_surf_エイチこ", new DPSurfMapProtoType(p_surf_エイチこ) },
            { "p_surf_カンナギタウン", new DPSurfMapProtoType(p_surf_カンナギタウン) },
            { "p_surf_クロガネゲート", new DPSurfMapProtoType(p_surf_クロガネゲート) },
            { "p_surf_シンジこ", new DPSurfMapProtoType(p_surf_シンジこ) },
            { "p_surf_タタラせいてつじょ", new DPSurfMapProtoType(p_surf_タタラせいてつじょ) },
            { "p_surf_チャンピオンロード(B1F)", new DPSurfMapProtoType(p_surf_チャンピオンロード_B1F_) },
            { "p_surf_チャンピオンロード(B1F-奥)", new DPSurfMapProtoType(p_surf_チャンピオンロード_B1F_奥_) },
            { "p_surf_テンガンざん", new DPSurfMapProtoType(p_surf_テンガンざん) },
            { "p_surf_ナギサシティ", new DPSurfMapProtoType(p_surf_ナギサシティ) },
            { "p_surf_ノモセだいしつげん", new DPSurfMapProtoType(p_surf_ノモセだいしつげん) },
            { "p_surf_ノモセシティ", new DPSurfMapProtoType(p_surf_ノモセシティ) },
            { "p_surf_ハクタイシティ", new DPSurfMapProtoType(p_surf_ハクタイシティ) },
            { "p_surf_フタバタウン", new DPSurfMapProtoType(p_surf_フタバタウン) },
            { "p_surf_ポケモンリーグ", new DPSurfMapProtoType(p_surf_ポケモンリーグ) },
            { "p_surf_ミオシティ", new DPSurfMapProtoType(p_surf_ミオシティ) },
            { "p_surf_リゾートエリア", new DPSurfMapProtoType(p_surf_リゾートエリア) },
            { "p_surf_リッシこ", new DPSurfMapProtoType(p_surf_リッシこ) },
            #endregion

            #region OldRod
            { "p_oldrod_203ばんどうろ", new DPOldRodMapProtoType(p_oldrod_203ばんどうろ) },
            { "p_oldrod_204ばんどうろ", new DPOldRodMapProtoType(p_oldrod_204ばんどうろ) },
            { "p_oldrod_205ばんどうろ", new DPOldRodMapProtoType(p_oldrod_205ばんどうろ) },
            { "p_oldrod_208ばんどうろ", new DPOldRodMapProtoType(p_oldrod_208ばんどうろ) },
            { "p_oldrod_209ばんどうろ", new DPOldRodMapProtoType(p_oldrod_209ばんどうろ) },
            { "p_oldrod_210ばんどうろ", new DPOldRodMapProtoType(p_oldrod_210ばんどうろ) },
            { "p_oldrod_212ばんどうろ", new DPOldRodMapProtoType(p_oldrod_212ばんどうろ) },
            { "p_oldrod_213ばんどうろ", new DPOldRodMapProtoType(p_oldrod_213ばんどうろ) },
            { "p_oldrod_214ばんどうろ", new DPOldRodMapProtoType(p_oldrod_214ばんどうろ) },
            { "p_oldrod_218ばんどうろ", new DPOldRodMapProtoType(p_oldrod_218ばんどうろ) },
            { "p_oldrod_219ばんどうろ", new DPOldRodMapProtoType(p_oldrod_219ばんどうろ) },
            { "p_oldrod_220ばんすいどう", new DPOldRodMapProtoType(p_oldrod_220ばんすいどう) },
            { "p_oldrod_221ばんどうろ", new DPOldRodMapProtoType(p_oldrod_221ばんどうろ) },
            { "p_oldrod_222ばんどうろ", new DPOldRodMapProtoType(p_oldrod_222ばんどうろ) },
            { "p_oldrod_223ばんすいどう", new DPOldRodMapProtoType(p_oldrod_223ばんすいどう) },
            { "p_oldrod_224ばんどうろ", new DPOldRodMapProtoType(p_oldrod_224ばんどうろ) },
            { "p_oldrod_225ばんどうろ", new DPOldRodMapProtoType(p_oldrod_225ばんどうろ) },
            { "p_oldrod_226ばんすいどう", new DPOldRodMapProtoType(p_oldrod_226ばんすいどう) },
            { "p_oldrod_227ばんどうろ", new DPOldRodMapProtoType(p_oldrod_227ばんどうろ) },
            { "p_oldrod_228ばんどうろ", new DPOldRodMapProtoType(p_oldrod_228ばんどうろ) },
            { "p_oldrod_229ばんどうろ", new DPOldRodMapProtoType(p_oldrod_229ばんどうろ) },
            { "p_oldrod_230ばんすいどう", new DPOldRodMapProtoType(p_oldrod_230ばんすいどう) },
            { "p_oldrod_あれたぬけみち", new DPOldRodMapProtoType(p_oldrod_あれたぬけみち) },
            { "p_oldrod_おくりのいずみ", new DPOldRodMapProtoType(p_oldrod_おくりのいずみ) },
            { "p_oldrod_こうてつじま", new DPOldRodMapProtoType(p_oldrod_こうてつじま) },
            { "p_oldrod_たにまのはつでんしょ", new DPOldRodMapProtoType(p_oldrod_たにまのはつでんしょ) },
            { "p_oldrod_エイチこ", new DPOldRodMapProtoType(p_oldrod_エイチこ) },
            { "p_oldrod_カンナギタウン", new DPOldRodMapProtoType(p_oldrod_カンナギタウン) },
            { "p_oldrod_クロガネゲート", new DPOldRodMapProtoType(p_oldrod_クロガネゲート) },
            { "p_oldrod_シンジこ", new DPOldRodMapProtoType(p_oldrod_シンジこ) },
            { "p_oldrod_タタラせいてつじょ", new DPOldRodMapProtoType(p_oldrod_タタラせいてつじょ) },
            { "p_oldrod_チャンピオンロード", new DPOldRodMapProtoType(p_oldrod_チャンピオンロード) },
            { "p_oldrod_テンガンざん", new DPOldRodMapProtoType(p_oldrod_テンガンざん) },
            { "p_oldrod_テンガンざん(B1F-ヒンバススポット)", new DPOldRodFeebasMapProtoType(p_oldrod_テンガンざん_B1F_ヒンバススポット_) },
            { "p_oldrod_ナギサシティ", new DPOldRodMapProtoType(p_oldrod_ナギサシティ) },
            { "p_oldrod_ノモセだいしつげん", new DPOldRodMapProtoType(p_oldrod_ノモセだいしつげん) },
            { "p_oldrod_ノモセシティ", new DPOldRodMapProtoType(p_oldrod_ノモセシティ) },
            { "p_oldrod_ハクタイシティ", new DPOldRodMapProtoType(p_oldrod_ハクタイシティ) },
            { "p_oldrod_フタバタウン", new DPOldRodMapProtoType(p_oldrod_フタバタウン) },
            { "p_oldrod_ポケモンリーグ", new DPOldRodMapProtoType(p_oldrod_ポケモンリーグ) },
            { "p_oldrod_ミオシティ", new DPOldRodMapProtoType(p_oldrod_ミオシティ) },
            { "p_oldrod_リゾートエリア", new DPOldRodMapProtoType(p_oldrod_リゾートエリア) },
            { "p_oldrod_リッシこ", new DPOldRodMapProtoType(p_oldrod_リッシこ) },
            #endregion

            #region GoodRod
            { "p_goodrod_203ばんどうろ", new DPGoodRodMapProtoType(p_goodrod_203ばんどうろ) },
            { "p_goodrod_204ばんどうろ", new DPGoodRodMapProtoType(p_goodrod_204ばんどうろ) },
            { "p_goodrod_205ばんどうろ(北東)", new DPGoodRodMapProtoType(p_goodrod_205ばんどうろ_北東_) },
            { "p_goodrod_205ばんどうろ(南西)", new DPGoodRodMapProtoType(p_goodrod_205ばんどうろ_南西_) },
            { "p_goodrod_208ばんどうろ", new DPGoodRodMapProtoType(p_goodrod_208ばんどうろ) },
            { "p_goodrod_209ばんどうろ", new DPGoodRodMapProtoType(p_goodrod_209ばんどうろ) },
            { "p_goodrod_210ばんどうろ", new DPGoodRodMapProtoType(p_goodrod_210ばんどうろ) },
            { "p_goodrod_212ばんどうろ(北)", new DPGoodRodMapProtoType(p_goodrod_212ばんどうろ_北_) },
            { "p_goodrod_212ばんどうろ(南)", new DPGoodRodMapProtoType(p_goodrod_212ばんどうろ_南_) },
            { "p_goodrod_213ばんどうろ", new DPGoodRodMapProtoType(p_goodrod_213ばんどうろ) },
            { "p_goodrod_214ばんどうろ", new DPGoodRodMapProtoType(p_goodrod_214ばんどうろ) },
            { "p_goodrod_218ばんどうろ", new DPGoodRodMapProtoType(p_goodrod_218ばんどうろ) },
            { "p_goodrod_219ばんどうろ", new DPGoodRodMapProtoType(p_goodrod_219ばんどうろ) },
            { "p_goodrod_220ばんすいどう", new DPGoodRodMapProtoType(p_goodrod_220ばんすいどう) },
            { "p_goodrod_221ばんどうろ", new DPGoodRodMapProtoType(p_goodrod_221ばんどうろ) },
            { "p_goodrod_222ばんどうろ", new DPGoodRodMapProtoType(p_goodrod_222ばんどうろ) },
            { "p_goodrod_223ばんすいどう", new DPGoodRodMapProtoType(p_goodrod_223ばんすいどう) },
            { "p_goodrod_224ばんどうろ", new DPGoodRodMapProtoType(p_goodrod_224ばんどうろ) },
            { "p_goodrod_225ばんどうろ", new DPGoodRodMapProtoType(p_goodrod_225ばんどうろ) },
            { "p_goodrod_226ばんすいどう", new DPGoodRodMapProtoType(p_goodrod_226ばんすいどう) },
            { "p_goodrod_227ばんどうろ", new DPGoodRodMapProtoType(p_goodrod_227ばんどうろ) },
            { "p_goodrod_228ばんどうろ", new DPGoodRodMapProtoType(p_goodrod_228ばんどうろ) },
            { "p_goodrod_229ばんどうろ", new DPGoodRodMapProtoType(p_goodrod_229ばんどうろ) },
            { "p_goodrod_230ばんすいどう", new DPGoodRodMapProtoType(p_goodrod_230ばんすいどう) },
            { "p_goodrod_あれたぬけみち", new DPGoodRodMapProtoType(p_goodrod_あれたぬけみち) },
            { "p_goodrod_おくりのいずみ", new DPGoodRodMapProtoType(p_goodrod_おくりのいずみ) },
            { "p_goodrod_こうてつじま", new DPGoodRodMapProtoType(p_goodrod_こうてつじま) },
            { "p_goodrod_たにまのはつでんしょ", new DPGoodRodMapProtoType(p_goodrod_たにまのはつでんしょ) },
            { "p_goodrod_エイチこ", new DPGoodRodMapProtoType(p_goodrod_エイチこ) },
            { "p_goodrod_カンナギタウン", new DPGoodRodMapProtoType(p_goodrod_カンナギタウン) },
            { "p_goodrod_クロガネゲート", new DPGoodRodMapProtoType(p_goodrod_クロガネゲート) },
            { "p_goodrod_シンジこ", new DPGoodRodMapProtoType(p_goodrod_シンジこ) },
            { "p_goodrod_タタラせいてつじょ", new DPGoodRodMapProtoType(p_goodrod_タタラせいてつじょ) },
            { "p_goodrod_チャンピオンロード", new DPGoodRodMapProtoType(p_goodrod_チャンピオンロード) },
            { "p_goodrod_テンガンざん", new DPGoodRodMapProtoType(p_goodrod_テンガンざん) },
            { "p_goodrod_テンガンざん(B1F-ヒンバススポット)", new DPGoodRodFeebasMapProtoType(p_goodrod_テンガンざん_B1F_ヒンバススポット_) },
            { "p_goodrod_ナギサシティ", new DPGoodRodMapProtoType(p_goodrod_ナギサシティ) },
            { "p_goodrod_ノモセだいしつげん", new DPGoodRodMapProtoType(p_goodrod_ノモセだいしつげん) },
            { "p_goodrod_ノモセシティ", new DPGoodRodMapProtoType(p_goodrod_ノモセシティ) },
            { "p_goodrod_ハクタイシティ", new DPGoodRodMapProtoType(p_goodrod_ハクタイシティ) },
            { "p_goodrod_フタバタウン", new DPGoodRodMapProtoType(p_goodrod_フタバタウン) },
            { "p_goodrod_ポケモンリーグ", new DPGoodRodMapProtoType(p_goodrod_ポケモンリーグ) },
            { "p_goodrod_ミオシティ", new DPGoodRodMapProtoType(p_goodrod_ミオシティ) },
            { "p_goodrod_リゾートエリア", new DPGoodRodMapProtoType(p_goodrod_リゾートエリア) },
            { "p_goodrod_リッシこ", new DPGoodRodMapProtoType(p_goodrod_リッシこ) },
            #endregion
            
            #region SuperRod
            { "p_superrod_203ばんどうろ", new DPSuperRodMapProtoType(p_superrod_203ばんどうろ) },
            { "p_superrod_204ばんどうろ", new DPSuperRodMapProtoType(p_superrod_204ばんどうろ) },
            { "p_superrod_205ばんどうろ(北東)", new DPSuperRodMapProtoType(p_superrod_205ばんどうろ_北東_) },
            { "p_superrod_205ばんどうろ(南西)", new DPSuperRodMapProtoType(p_superrod_205ばんどうろ_南西_) },
            { "p_superrod_208ばんどうろ", new DPSuperRodMapProtoType(p_superrod_208ばんどうろ) },
            { "p_superrod_209ばんどうろ", new DPSuperRodMapProtoType(p_superrod_209ばんどうろ) },
            { "p_superrod_210ばんどうろ", new DPSuperRodMapProtoType(p_superrod_210ばんどうろ) },
            { "p_superrod_212ばんどうろ(北)", new DPSuperRodMapProtoType(p_superrod_212ばんどうろ_北_) },
            { "p_superrod_212ばんどうろ(南)", new DPSuperRodMapProtoType(p_superrod_212ばんどうろ_南_) },
            { "p_superrod_213ばんどうろ", new DPSuperRodMapProtoType(p_superrod_213ばんどうろ) },
            { "p_superrod_214ばんどうろ", new DPSuperRodMapProtoType(p_superrod_214ばんどうろ) },
            { "p_superrod_218ばんどうろ", new DPSuperRodMapProtoType(p_superrod_218ばんどうろ) },
            { "p_superrod_219ばんどうろ", new DPSuperRodMapProtoType(p_superrod_219ばんどうろ) },
            { "p_superrod_220ばんすいどう", new DPSuperRodMapProtoType(p_superrod_220ばんすいどう) },
            { "p_superrod_221ばんどうろ", new DPSuperRodMapProtoType(p_superrod_221ばんどうろ) },
            { "p_superrod_222ばんどうろ", new DPSuperRodMapProtoType(p_superrod_222ばんどうろ) },
            { "p_superrod_223ばんすいどう", new DPSuperRodMapProtoType(p_superrod_223ばんすいどう) },
            { "p_superrod_224ばんどうろ", new DPSuperRodMapProtoType(p_superrod_224ばんどうろ) },
            { "p_superrod_225ばんどうろ", new DPSuperRodMapProtoType(p_superrod_225ばんどうろ) },
            { "p_superrod_226ばんすいどう", new DPSuperRodMapProtoType(p_superrod_226ばんすいどう) },
            { "p_superrod_227ばんどうろ", new DPSuperRodMapProtoType(p_superrod_227ばんどうろ) },
            { "p_superrod_228ばんどうろ", new DPSuperRodMapProtoType(p_superrod_228ばんどうろ) },
            { "p_superrod_229ばんどうろ", new DPSuperRodMapProtoType(p_superrod_229ばんどうろ) },
            { "p_superrod_230ばんすいどう", new DPSuperRodMapProtoType(p_superrod_230ばんすいどう) },
            { "p_superrod_あれたぬけみち", new DPSuperRodMapProtoType(p_superrod_あれたぬけみち) },
            { "p_superrod_おくりのいずみ", new DPSuperRodMapProtoType(p_superrod_おくりのいずみ) },
            { "p_superrod_こうてつじま", new DPSuperRodMapProtoType(p_superrod_こうてつじま) },
            { "p_superrod_たにまのはつでんしょ", new DPSuperRodMapProtoType(p_superrod_たにまのはつでんしょ) },
            { "p_superrod_エイチこ", new DPSuperRodMapProtoType(p_superrod_エイチこ) },
            { "p_superrod_カンナギタウン", new DPSuperRodMapProtoType(p_superrod_カンナギタウン) },
            { "p_superrod_クロガネゲート", new DPSuperRodMapProtoType(p_superrod_クロガネゲート) },
            { "p_superrod_シンジこ", new DPSuperRodMapProtoType(p_superrod_シンジこ) },
            { "p_superrod_タタラせいてつじょ", new DPSuperRodMapProtoType(p_superrod_タタラせいてつじょ) },
            { "p_superrod_チャンピオンロード", new DPSuperRodMapProtoType(p_superrod_チャンピオンロード) },
            { "p_superrod_テンガンざん(1F)", new DPSuperRodMapProtoType(p_superrod_テンガンざん_1F_) },
            { "p_superrod_テンガンざん(4F)", new DPSuperRodMapProtoType(p_superrod_テンガンざん_4F_) },
            { "p_superrod_テンガンざん(B1F)", new DPSuperRodMapProtoType(p_superrod_テンガンざん_B1F_) },
            { "p_superrod_テンガンざん(B1F-ヒンバススポット)", new DPSuperRodFeebasMapProtoType(p_superrod_テンガンざん_B1F_ヒンバススポット_) },
            { "p_superrod_ナギサシティ", new DPSuperRodMapProtoType(p_superrod_ナギサシティ) },
            { "p_superrod_ノモセだいしつげん", new DPSuperRodMapProtoType(p_superrod_ノモセだいしつげん) },
            { "p_superrod_ノモセシティ", new DPSuperRodMapProtoType(p_superrod_ノモセシティ) },
            { "p_superrod_ハクタイシティ", new DPSuperRodMapProtoType(p_superrod_ハクタイシティ) },
            { "p_superrod_フタバタウン", new DPSuperRodMapProtoType(p_superrod_フタバタウン) },
            { "p_superrod_ポケモンリーグ", new DPSuperRodMapProtoType(p_superrod_ポケモンリーグ) },
            { "p_superrod_ミオシティ", new DPSuperRodMapProtoType(p_superrod_ミオシティ) },
            { "p_superrod_リゾートエリア", new DPSuperRodMapProtoType(p_superrod_リゾートエリア) },
            { "p_superrod_リッシこ", new DPSuperRodMapProtoType(p_superrod_リッシこ) },
            #endregion
        };
    }
}
