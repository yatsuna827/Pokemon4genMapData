using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon4genMapData
{
    // バージョンごとのスロット入替の構造を表現するためのタグ用クラス.
    interface IAltSlots<in TVersion>
        where TVersion : IWrappedGameVersion
    { }
}
