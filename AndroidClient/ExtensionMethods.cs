using System.Linq;

namespace AndroidClient
{
    public static class ExtensionMethods
    {
        public static bool StartsWith(this string s, params string[] prefixes)
            => prefixes.Any(s.StartsWith);

        public static bool Is(this string s, params string[] strings)
            => strings.Any(ss => s == ss);
    }
}