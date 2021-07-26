using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon4genMapData
{
    // MapProtoTypeの『MapDataを組み立てる』責務を切り出したインタフェース.
    interface IBuildable<TVerison, TArg>
        where TVerison : WrappedGameVersion
        where TArg : IQueryArgs<TVerison>
    {
        MapData BuildMapData(TArg args);
    }

}
