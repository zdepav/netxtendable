using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;

namespace Netxtendable {

    public static class StringExtensions {

        public static Match Match(this string str, Regex regex) =>
            regex.Match(str);

        public static Match Match(this string str, string regex) =>
            Regex.Match(str, regex);

        public static string Replace(this string str, Regex regex, string replacement) =>
            regex.Replace(str, replacement);

        public static string RegexReplace(this string str, string regex, string replacement) =>
            Regex.Replace(str, regex, replacement);

        public static string? Find(this string str, Regex regex) {
            var m = regex.Match(str);
            return m.Success ? m.Value : null;
        }

        public static string? FindRegex(this string str, string regex) {
            var m = Regex.Match(str, regex);
            return m.Success ? m.Value : null;
        }

        public static string? FindRegexGroup(this string str, Regex regex, int groupId) {
            var m = regex.Match(str);
            return m.Success ? m.Groups[groupId].Value : null;
        }

        public static string? FindRegexGroup(this string str, string regex, int groupId) {
            var m = Regex.Match(str, regex);
            return m.Success ? m.Groups[groupId].Value : null;
        }

        public static bool IsMatch(this string str, Regex regex) =>
            regex.IsMatch(str);

        public static bool IsMatch(this string str, string regex) =>
            Regex.IsMatch(str, regex);

        private static string ConvertLineEndings(string str, string lineEnding) {
            if (string.IsNullOrEmpty(str)) {
                return str;
            }
            var buffer = new StringBuilder();
            for (var i = 0; i < str.Length; i++) {
                switch (str[i]) {
                    case '\r':
                        buffer.Append(lineEnding);
                        if (i + 1 < str.Length && str[i + 1] == '\n') {
                            ++i;
                        }
                        break;
                    case '\n':
                    case '\u2028':
                        buffer.Append(lineEnding);
                        break;
                    default:
                        buffer.Append(str[i]);
                        break;
                }
            }
            return buffer.ToString();
        }

        public static string LineEndingsToLf(this string str) =>
            ConvertLineEndings(str, "\n");

        public static string LineEndingsToCr(this string str) =>
            ConvertLineEndings(str, "\r");

        public static string LineEndingsToCrLf(this string str) =>
            ConvertLineEndings(str, "\r\n");

        public static string LineEndingsToLs(this string str) =>
            ConvertLineEndings(str, "\u2028");

        public static IEnumerable<string> EnumerateLines(this string str, bool skipEmpty = false) {
            var buffer = new StringBuilder();
            for (var i = 0; i < str.Length; i++) {
                switch (str[i]) {
                    case '\r':
                    case '\n':
                    case '\u2028':
                        if (buffer.Length > 0) {
                            yield return buffer.ToString();
                            buffer.Clear();
                        } else if (!skipEmpty) {
                            yield return "";
                        }
                        if (i + 1 < str.Length && str[i] == '\r' && str[i + 1] == '\n') {
                            ++i;
                        }
                        break;
                    default:
                        buffer.Append(str[i]);
                        break;
                }
            }
        }

        public static string[] SplitLines(this string str) =>
            EnumerateLines(str).ToArray();

        public static string ExpandHtmlEntities(this string str) =>
            WebUtility.HtmlDecode(str);

        public static string CollapseWhitespace(this string str) {
            if (str is null) {
                throw  new ArgumentNullException(nameof(str));
            }
            var sb = new StringBuilder();
            str = str.TrimEnd();
            var prevWasWhitespace = true;
            foreach (var c in str) {
                if (char.IsWhiteSpace(c)) {
                    if (!prevWasWhitespace) {
                        sb.Append(' ');
                        prevWasWhitespace = true;
                    }
                } else {
                    prevWasWhitespace = false;
                    sb.Append(c);
                }
            }
            return sb.ToString();
        }

        public static sbyte ParseSByte(this string str) =>
            sbyte.Parse(str);

        public static byte ParseByte(this string str) =>
            byte.Parse(str);

        public static short ParseInt16(this string str) =>
            short.Parse(str);

        public static ushort ParseUInt16(this string str) =>
            ushort.Parse(str);

        public static int ParseInt(this string str) =>
            int.Parse(str);

        public static uint ParseUInt(this string str) =>
            uint.Parse(str);

        public static long ParseLong(this string str) =>
            long.Parse(str);

        public static ulong ParseUInt64(this string str) =>
            ulong.Parse(str);

        public static float ParseSingle(this string str) =>
            float.Parse(str);

        public static double ParseDouble(this string str) =>
            double.Parse(str);

        public static decimal ParseDecimal(this string str) =>
            decimal.Parse(str);

        public static sbyte ParseSByteOrDefault(this string str, sbyte @default) =>
            sbyte.TryParse(str, out var value) ? value : @default;

        public static byte ParseByteOrDefault(this string str, byte @default) =>
            byte.TryParse(str, out var value) ? value : @default;

        public static short ParseInt16OrDefault(this string str, short @default) =>
            short.TryParse(str, out var value) ? value : @default;

        public static ushort ParseUInt16OrDefault(this string str, ushort @default) =>
            ushort.TryParse(str, out var value) ? value : @default;

        public static int ParseIntOrDefault(this string str, int @default) =>
            int.TryParse(str, out var value) ? value : @default;

        public static uint ParseUInt32OrDefault(this string str, uint @default) =>
            uint.TryParse(str, out var value) ? value : @default;

        public static long ParseInt64OrDefault(this string str, long @default) =>
            long.TryParse(str, out var value) ? value : @default;

        public static ulong ParseUInt64OrDefault(this string str, ulong @default) =>
            ulong.TryParse(str, out var value) ? value : @default;

        public static float ParseSingleOrDefault(this string str, float @default) =>
            float.TryParse(str, out var value) ? value : @default;

        public static double ParseDoubleOrDefault(this string str, double @default) =>
            double.TryParse(str, out var value) ? value : @default;

        public static decimal ParseDecimalOrDefault(this string str, decimal @default) =>
            decimal.TryParse(str, out var value) ? value : @default;

    }
}
