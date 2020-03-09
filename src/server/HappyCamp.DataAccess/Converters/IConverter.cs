using System;
using System.Collections.Generic;
using System.Text;

namespace HappyCamp.DataAccess.Converters
{
    interface IConverter<T, K>
    {
        K Convert(T from);
    }
}
