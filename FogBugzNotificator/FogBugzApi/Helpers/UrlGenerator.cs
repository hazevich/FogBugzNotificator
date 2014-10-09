using System.Collections.Generic;

namespace FogBugzApi.Helpers
{
    public static class UrlGenerator
    {
        public static string ToArgsString(this Dictionary<string, string> dictionary)
        {
            string args = string.Empty;

            if (dictionary == null || dictionary.Count == 0)
                return args;

            bool endOfQuery = false;
            int currentCount = 0;

            foreach (var key in dictionary.Keys)
            {
                if (currentCount == dictionary.Count - 1)
                    endOfQuery = true;

                if (endOfQuery)
                    args += key + "=" + dictionary[key];
                else
                    args += key + "=" + dictionary[key] + "&";

                currentCount++;
            }

            return args;
        }

        public static string AppendUrlResource(this string url, string urlRes)
        {
            string separator = string.Empty;

            if (!url.EndsWith("/") && !urlRes.StartsWith("/"))
                separator = "/";

            return string.Concat(url, separator, urlRes);
        }
    }
}
