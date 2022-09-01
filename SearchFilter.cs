using System.Reflection;

namespace ExtensionMethods;
public static class SearchFilter
{
    public static IEnumerable<T> Search<T, I>(this List<T> inputs, I searchParam)
    {
        foreach (T input in inputs)
        {
            if (input == null || searchParam == null)
                continue;

            var props = input.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance)
                          .Where(p => p.PropertyType == searchParam.GetType());

            foreach (var prop in props)
            {
                var pTmp = prop?.GetValue(input);

                if (pTmp != null)
                {
                    if (pTmp.GetType() == typeof(string))
                    {
                        string stringParam = searchParam as string ?? "";
                        if (!stringParam.Equals(string.Empty) && ((string)pTmp).Contains(stringParam))
                            yield return input;
                    }
                    else
                    {
                        if (pTmp.Equals(searchParam))
                            yield return input;
                    }
                }
            }
        }
    }
}