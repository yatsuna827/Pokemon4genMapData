﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon4genMapData
{
    // JSONデータと外部に渡すデータの橋渡しをするクラス.
    abstract class MapProtoType<TVersion, TEncType, TArg, TDecodedMap, TAltSlots> : IBuildable<TVersion, TArg>
        where TVersion : IWrappedGameVersion
        where TEncType : IWrappedEncounterType<TVersion>
        where TArg : IQueryArgs<TVersion>
        where TDecodedMap : DecodedMapData<TVersion, TEncType, TAltSlots>
        where TAltSlots : IAltSlots<TVersion>
    {
        public MapData BuildMapData(TArg args)
        {
            if (decodedMapData == null)
                decodedMapData = DecodeMap(rawMapData);

            return new MapData()
            {
                MapName = decodedMapData.MapName,
                BasicEncounterRate = decodedMapData.BasicRate,
                Type = mapType,
                EncounterTable = BuildTable(decodedMapData, args),
                OptionalSlots = ResolveOptionalSlots(decodedMapData, args),
            };
        }

        // コンストラクタから渡されたJSONデータ
        protected readonly string rawMapData;

        // JSONデータを解析したマップデータオブジェクト
        protected TDecodedMap decodedMapData;

        // 返すマップタイプ(Grassとかよりも細かい単位で指定できるよ)
        protected readonly MapType mapType;

        // JSONの解釈, 遅延評価する.
        protected abstract TDecodedMap DecodeMap(string rawData);

        // スロット入替処理.
        protected abstract string[] ResolveAlternatingSlots(TDecodedMap mapData, TArg args);

        // スロット入替込みのテーブルを返す.
        protected abstract Slot[] BuildTable(TDecodedMap mapData, TArg args);


        // オプションスロット(スロット決定より前に判定が入る固有スロット)の解決.
        protected abstract Slot[] ResolveOptionalSlots(TDecodedMap mapData, TArg args);

        public MapProtoType(string mapData, MapType type)
            => (rawMapData, mapType) = (mapData, type);
    }

}
