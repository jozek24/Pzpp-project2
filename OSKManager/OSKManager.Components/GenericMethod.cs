using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace OSKManager.Components
{
    public static class GenericMethod
    {
        public static bool GenericTryParse<T>(this string input, out T value)
        {
            var converter = TypeDescriptor.GetConverter(typeof(T));

            if (converter != null && converter.IsValid(input))
            {
                value = (T)converter.ConvertFromString(input);
                return true;
            }
            value = default(T);
            return false;
        }
    }
}
