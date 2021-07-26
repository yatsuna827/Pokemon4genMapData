using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon4genMapData
{
    // 外部から叩くときに渡してもらう引数のタグ.
    interface IQueryArgs<TVersion>
        where TVersion : IWrappedGameVersion
    { }

}
