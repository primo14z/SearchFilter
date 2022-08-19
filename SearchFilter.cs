using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace CustomFilter
{
    public static class SearchFilter
    {
        public static object Search<T>(List<T> inputs, string searchParam)
        {
            foreach (T input in inputs)
            {
                var props = input.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance)
                              .Where(p => p.PropertyType == typeof(string));

                foreach (var prop in props)
                {
                    if (prop.GetValue(input).Equals(searchParam))
                        return input;
                }
            }

            return null;
        }
    }
}