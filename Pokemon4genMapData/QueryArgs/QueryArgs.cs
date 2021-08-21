using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon4genMapData
{
    // 外部から叩くときに渡してもらう引数のタグ.
    interface IQueryArgs<in TVersion>
        where TVersion : IWrappedGameVersion
    { }

}
