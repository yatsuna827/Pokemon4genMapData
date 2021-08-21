using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon4genMapData
{
    public interface IEnumWapper<E> where E : Enum
    {
        E Unwrap();
    }
}
