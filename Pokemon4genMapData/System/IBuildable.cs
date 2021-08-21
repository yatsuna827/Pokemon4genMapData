﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon4genMapData
{
    // MapProtoTypeの『MapDataを組み立てる』責務を切り出したインタフェース.
    interface IBuildable<in TVerison, in TArg>
        where TVerison : IWrappedGameVersion
        where TArg : IQueryArgs<TVerison>
    {
        IMapData<TVerison> BuildMapData(TArg args);
    }

}
