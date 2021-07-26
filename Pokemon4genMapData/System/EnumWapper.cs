using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon4genMapData
{
    interface IEnumWapper<E> where E : Enum
    {
        E Unwrap();
    }
}
