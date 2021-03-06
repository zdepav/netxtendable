#nullable enable
using System;
using System.Collections.Generic;
#if NET_CORE
using System.Diagnostics.CodeAnalysis;
#endif
using System.Globalization;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using static Netxtendable.NetxtendableConfig;

namespace Netxtendable.Extensions.Text {

    /// <summary>Class with extension methods for <see cref="string"/></summary>
    public static class StringExtensions {

        /// <summary>Reverses given string</summary>
        /// <param name="str">String to reverse</param>
        /// <returns>Reversed copy of <paramref name="str"/></returns>
        public static string Reverse(this string str) {
            if (string.IsNullOrEmpty(str)) {
                return str;
            }
            var chars = new char[str.Length];
            for (int i = 0, last = str.Length - 1; i <= last; ++i) {
                chars[i] = str[last - i];
            }
            return new string(chars);
        }

        /// <summary>
        /// Encodes the string using Base64. If no encoding is supplied UTF-8 will be used.
        /// </summary>
        /// <param name="str">String to encode</param>
        /// <param name="encoding">Encoding to use. If null (default) UTF-8 will be used</param>
        /// <returns>Base64 representation of <paramref name="str"/></returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="str"/> is null
        /// </exception>
        public static string ToBase64(this string str, Encoding? encoding = null) =>
            str is null
                ? throw new ArgumentNullException(nameof(str))
                : Convert.ToBase64String((encoding ?? Encoding.UTF8).GetBytes(str));

        /// <summary>
        /// Decodes string from Base64. Automatically adds missing padding if necessary.
        /// If no encoding is supplied UTF-8 will be used.
        /// </summary>
        /// <param name="base64String">Base64 string to decode</param>
        /// <param name="encoding">Encoding to use. If null (default) UTF-8 will be used</param>
        /// <returns>String represented by <paramref name="base64String"/></returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="base64String"/> is null
        /// </exception>
        /// <exception cref="FormatException">
        /// Thrown when given string is not a valid Base64 string
        /// </exception>
        public static string FromBase64(this string base64String, Encoding? encoding = null) {
            if (base64String is null) {
                throw new ArgumentNullException(nameof(base64String));
            } else if (base64String.Length == 0) {
                return "";
            } else if (base64String.Length % 4 > 0) {
                base64String += new string('=', 4 - base64String.Length % 4);
            }
            return (encoding ?? Encoding.UTF8).GetString(Convert.FromBase64String(base64String));
        }

        /// <summary>
        /// Converts the string to a byte array using the given encoding.
        /// If no encoding is supplied UTF-8 will be used.
        /// </summary>
        /// <param name="str">String to convert</param>
        /// <param name="encoding">Encoding to use. If null (default) UTF-8 will be used</param>
        /// <returns>Byte array representing <paramref name="str"/></returns>
        public static byte[] ToByteArray(this string str, Encoding? encoding = null) =>
            str is null
                ? throw new ArgumentNullException(nameof(str))
                : (encoding ?? Encoding.UTF8).GetBytes(str);

        /// <summary>Verifies if all characters in a given string are ASCII characters</summary>
        /// <param name="str">String to check</param>
        /// <returns>False if any non-ascii characters are found, true otherwise</returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="str"/> is null
        /// </exception>
        public static bool IsAscii(this string str) {
            if (str is null) {
                throw new ArgumentNullException(nameof(str));
            }
            for (var i = 0; i < str.Length; ++i) {
                if (str[i] > 127) {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Searches <paramref name="str"/> for the first occurrence of <paramref name="regex"/>.
        /// </summary>
        /// <param name="str">String to search in</param>
        /// <param name="regex">Regular expression to search for</param>
        /// <returns>
        /// <see cref="System.Text.RegularExpressions.Match"/> object with information about the
        /// match
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="str"/> or <paramref name="regex"/> is null
        /// </exception>
        public static Match Match(this string str, Regex regex) =>
            regex is null
                ? throw new ArgumentNullException(nameof(regex))
                : regex.Match(str);

        /// <summary>
        /// Searches <paramref name="str"/> for the first occurrence of <paramref name="pattern"/>.
        /// </summary>
        /// <param name="str">String to search in</param>
        /// <param name="pattern">Regular expression to search for</param>
        /// <returns>
        /// <see cref="System.Text.RegularExpressions.Match"/> object with information about the
        /// match
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="str"/> or <paramref name="pattern"/> is null
        /// </exception>
        public static Match Match(this string str, string pattern) =>
            Regex.Match(str, pattern);

        /// <summary>
        /// Searches <paramref name="str"/> for all occurrences of <paramref name="regex"/>
        /// </summary>
        /// <param name="str">String to search in</param>
        /// <param name="regex">Regular expression to search for</param>
        /// <returns>
        /// <see cref="IEnumerable{T}"/> of the <see cref="System.Text.RegularExpressions.Match"/>
        /// objects found by the search
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="str"/> or <paramref name="regex"/> is null
        /// </exception>
        public static IEnumerable<Match> Matches(this string str, Regex regex) =>
            regex is null
                ? throw new ArgumentNullException(nameof(regex))
#if NET_CORE
                : regex.Matches(str);
#else
                : regex.Matches(str).OfType<Match>();
#endif
        /// <summary>
        /// Searches <paramref name="str"/> for all occurrences of <paramref name="pattern"/>.
        /// </summary>
        /// <param name="str">String to search in</param>
        /// <param name="pattern">Regular expression to search for</param>
        /// <returns>
        /// A <see cref="IEnumerable{T}"/> of the
        /// <see cref="System.Text.RegularExpressions.Match"/> objects found by the search
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="str"/> or <paramref name="pattern"/> is null
        /// </exception>
        public static IEnumerable<Match> Matches(this string str, string pattern) =>
#if NET_CORE
            Regex.Matches(str, pattern);
#else
            Regex.Matches(str, pattern).OfType<Match>();
#endif

        /// <summary>
        /// Replaces all occurences of <paramref name="regex"/> in <paramref name="str"/> by
        /// <paramref name="replacement"/>.
        /// </summary>
        /// <param name="str">String to search in</param>
        /// <param name="regex">Regular expression to search for</param>
        /// <param name="replacement">Replacement string</param>
        /// <returns>Resulting string</returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="str"/>, <paramref name="regex"/> or
        /// <paramref name="replacement"/> is null
        /// </exception>
        public static string Replace(this string str, Regex regex, string replacement) =>
            regex is null
                ? throw new ArgumentNullException(nameof(regex))
                : regex.Replace(str, replacement);

        /// <summary>
        /// Replaces all occurences of <paramref name="regex"/> in <paramref name="str"/> by
        /// replacement string returned by <paramref name="evaluator"/>
        /// </summary>
        /// <param name="str">String to search in</param>
        /// <param name="regex">Regular expression to search for</param>
        /// <param name="evaluator">
        /// A method that creates a replacement string for each match
        /// </param>
        /// <returns>Resulting string</returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="str"/>, <paramref name="regex"/> or
        /// <paramref name="evaluator"/> is null
        /// </exception>
        public static string Replace(this string str, Regex regex, MatchEvaluator evaluator) =>
            regex is null
                ? throw new ArgumentNullException(nameof(regex))
                : regex.Replace(str, evaluator);

        /// <summary>
        /// Replaces all occurences of <paramref name="needle"/> in <paramref name="str"/> by
        /// <paramref name="replacement"/>
        /// </summary>
        /// <param name="str">String to search in</param>
        /// <param name="needle">Character to search for</param>
        /// <param name="replacement">Replacement string for each match</param>
        /// <returns>Resulting string</returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="str"/> is null
        /// </exception>
        public static string Replace(
            this string str,
            char needle,
            string replacement
        ) {
            if (str is null) {
                throw new ArgumentNullException(nameof(str));
            }
            if (str.Length == 0) {
                return str;
            }
            var buffer = new StringBuilder();
            var start = 0;
            var replacementNotEmpty = !string.IsNullOrEmpty(replacement);
            for (var i = 0; i < str.Length; i++) {
                if (str[i] == needle) {
                    if (i > start) {
                        buffer.Append(str, start, i - start);
                    }
                    if (replacementNotEmpty) {
                        buffer.Append(replacement);
                    }
                    start = i + 1;
                }
            }
            if (start < str.Length) {
                buffer.Append(str, start, str.Length - start);
            }
            return buffer.ToString();
        }

        /// <summary>
        /// Replaces all occurences of characters from <paramref name="needles"/> in
        /// <paramref name="str"/> by <paramref name="replacement"/>
        /// </summary>
        /// <param name="str">String to search in</param>
        /// <param name="needles">Characters to search for</param>
        /// <param name="replacement">Replacement string for each match</param>
        /// <returns>Resulting string</returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="str"/> or <paramref name="needles"/> is null
        /// </exception>
        public static string Replace(
            this string str,
            IList<char> needles,
            string replacement
        ) {
            if (str is null) {
                throw new ArgumentNullException(nameof(str));
            }
            if (needles is null) {
                throw new ArgumentNullException(nameof(needles));
            }
            if (needles.Count == 0 || str.Length == 0) {
                return str;
            }
            var set = needles.ToHashSet();
            var buffer = new StringBuilder();
            var start = 0;
            var replacementNotEmpty = !string.IsNullOrEmpty(replacement);
            for (var i = 0; i < str.Length; i++) {
                if (set.Contains(str[i])) {
                    if (i > start) {
                        buffer.Append(str, start, i - start);
                    }
                    if (replacementNotEmpty) {
                        buffer.Append(replacement);
                    }
                    start = i + 1;
                }
            }
            if (start < str.Length) {
                buffer.Append(str, start, str.Length - start);
            }
            return buffer.ToString();
        }

        /// <summary>
        /// Replaces all occurences of characters from <paramref name="needles"/> in
        /// <paramref name="str"/> by string returned by <paramref name="evaluator"/>
        /// </summary>
        /// <param name="str">String to search in</param>
        /// <param name="needles">Characters to search for</param>
        /// <param name="evaluator">
        /// A method that creates a replacement string for each matched character
        /// </param>
        /// <returns>Resulting string</returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="str"/>, <paramref name="needles"/> or
        /// <paramref name="evaluator"/> is null
        /// </exception>
        public static string Replace(
            this string str,
            IList<char> needles,
            Func<char, string> evaluator
        ) {
            if (str is null) {
                throw new ArgumentNullException(nameof(str));
            }
            if (needles is null) {
                throw new ArgumentNullException(nameof(needles));
            }
            if (evaluator is null) {
                throw new ArgumentNullException(nameof(needles));
            }
            if (needles.Count == 0 || str.Length == 0) {
                return str;
            }
            var set = needles.ToHashSet();
            var buffer = new StringBuilder();
            var start = 0;
            for (var i = 0; i < str.Length; i++) {
                if (set.Contains(str[i])) {
                    if (i > start) {
                        buffer.Append(str, start, i - start);
                    }
                    var replacement = evaluator(str[i]);
                    if (!string.IsNullOrEmpty(replacement)) {
                        buffer.Append(replacement);
                    }
                    start = i + 1;
                }
            }
            if (start < str.Length) {
                buffer.Append(str, start, str.Length - start);
            }
            return buffer.ToString();
        }

        /// <summary>
        /// Replaces all occurences of <paramref name="pattern"/> in <paramref name="str"/> by
        /// <paramref name="replacement"/>
        /// </summary>
        /// <param name="str">String to search in</param>
        /// <param name="pattern">Regular expression to search for</param>
        /// <param name="replacement">Replacement string</param>
        /// <returns>Resulting string</returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="str"/>, <paramref name="pattern"/> or
        /// <paramref name="replacement"/> is null
        /// </exception>
        public static string RegexReplace(this string str, string pattern, string replacement) =>
            Regex.Replace(str, pattern, replacement);

        /// <summary>
        /// Replaces all occurences of <paramref name="pattern"/> in <paramref name="str"/> by
        /// replacement string returned by <paramref name="evaluator"/>
        /// </summary>
        /// <param name="str">String to search in</param>
        /// <param name="pattern">Regular expression to search for</param>
        /// <param name="evaluator">
        /// A method that creates a replacement string for each match
        /// </param>
        /// <returns>Resulting string</returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="str"/>, <paramref name="pattern"/> or
        /// <paramref name="evaluator"/> is null
        /// </exception>
        public static string RegexReplace(
            this string str,
            string pattern,
            MatchEvaluator evaluator
        ) {
            return Regex.Replace(str, pattern, evaluator);
        }

        /// <summary>
        /// Splits <paramref name="str"/> into an array of substrings at the parts matched by
        /// <paramref name="regex"/>
        /// </summary>
        /// <param name="str">The string to split</param>
        /// <param name="regex">Regular expression to search for</param>
        /// <returns>Array of strings</returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="str"/> or <paramref name="regex"/> is null
        /// </exception>
        public static string[] Split(this string str, Regex regex) =>
            regex is null
                ? throw new ArgumentNullException(nameof(regex))
                : regex.Split(str);

        /// <summary>
        /// Splits <paramref name="str"/> into an array of substrings at the parts matched by
        /// <paramref name="pattern"/>
        /// </summary>
        /// <param name="str">The string to split</param>
        /// <param name="pattern">Regular expression to search for</param>
        /// <returns>Array of strings</returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="str"/> or <paramref name="pattern"/> is null
        /// </exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string[] RegexSplit(this string str, string pattern) =>
            Regex.Split(str, pattern);

        /// <summary>
        /// Searches <paramref name="str"/> for the first occurrence of <paramref name="regex"/>
        /// </summary>
        /// <param name="str">String to search in</param>
        /// <param name="regex">Regular expression to search for</param>
        /// <param name="default">
        /// Value that will be returned in case no match is found. Default is null
        /// </param>
        /// <returns>Matched part of the input string or <paramref name="default"/></returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="str"/> or <paramref name="regex"/> is null
        /// </exception>
#if NET_CORE
        [return: NotNullIfNotNull("default")]
#endif
        public static string? GetMatched(this string str, Regex regex, string? @default = null) =>
            regex is null
                ? throw new ArgumentNullException(nameof(regex))
                : regex.Match(str) is var m && m.Success
                    ? m.Value
                    : @default;

        /// <summary>
        /// Searches <paramref name="str"/> for the first occurrence of <paramref name="pattern"/>
        /// </summary>
        /// <param name="str">String to search in</param>
        /// <param name="pattern">Regular expression to search for</param>
        /// <param name="default">
        /// Value that will be returned in case no match is found. Default is null
        /// </param>
        /// <returns>Matched part of the input string or null</returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="str"/> or <paramref name="pattern"/> is null
        /// </exception>
#if NET_CORE
        [return: NotNullIfNotNull("default")]
#endif
        public static string? GetMatched(
            this string str,
            string pattern,
            string? @default = null
        ) {
            return Regex.Match(str, pattern) is var m && m.Success ? m.Value : @default;
        }

        /// <summary>
        /// Searches <paramref name="str"/> for the first occurrence of <paramref name="regex"/> and
        /// returns substring matched by the specified group
        /// </summary>
        /// <param name="str">String to search in</param>
        /// <param name="regex">Regular expression to search for</param>
        /// <param name="groupId">Index of the group that should be returned</param>
        /// <param name="default">
        /// Value that will be returned in case no match is found, default is null
        /// </param>
        /// <returns>
        /// Specified group of the matched part of <paramref name="str"/> or null
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="str"/> or <paramref name="regex"/> is null
        /// </exception>
#if NET_CORE
        [return: NotNullIfNotNull("default")]
#endif
        public static string? GetMatchedGroup(
            this string str,
            Regex regex,
            int groupId,
            string? @default = null
        ) {
            return regex is null
                ? throw new ArgumentNullException(nameof(regex))
                : regex.Match(str).Groups[groupId] is var g && g.Success
                    ? g.Value
                    : @default;
        }

        /// <summary>
        /// Searches <paramref name="str"/> for the first occurrence of <paramref name="pattern"/>
        /// and returns substring matched by the specified group
        /// </summary>
        /// <param name="str">String to search in</param>
        /// <param name="pattern">Regular expression to search for</param>
        /// <param name="groupId">Index of the group that should be returned</param>
        /// <param name="default">
        /// Value that will be returned in case no match is found, default is null
        /// </param>
        /// <returns>
        /// Specified group of the matched part of <paramref name="str"/> or null
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="str"/> or <paramref name="pattern"/> is null
        /// </exception>
#if NET_CORE
        [return: NotNullIfNotNull("default")]
#endif
        public static string? GetMatchedGroup(
            this string str,
            string pattern,
            int groupId,
            string? @default = null
        ) {
            return Regex.Match(str, pattern).Groups[groupId] is var g && g.Success
                ? g.Value
                : @default;
        }

        /// <summary>
        /// Searches <paramref name="str"/> for the first occurrence of <paramref name="regex"/> and
        /// returns substring matched by the specified group
        /// </summary>
        /// <param name="str">String to search in</param>
        /// <param name="regex">Regular expression to search for</param>
        /// <param name="groupName">Name of the group that should be returned</param>
        /// <param name="default">
        /// Value that will be returned in case no match is found. Default is null
        /// </param>
        /// <returns>
        /// Specified group of the matched part of <paramref name="str"/> or null
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="str"/>, <paramref name="regex"/> or
        /// <paramref name="groupName"/> is null
        /// </exception>
#if NET_CORE
        [return: NotNullIfNotNull("default")]
#endif
        public static string? GetMatchedGroup(
            this string str,
            Regex regex,
            string groupName,
            string? @default = null
        ) {
            return regex is null
                ? throw new ArgumentNullException(nameof(regex))
                : regex.Match(str).Groups[groupName] is var g && g.Success
                    ? g.Value
                    : @default;
        }

        /// <summary>
        /// Searches <paramref name="str"/> for the first occurrence of <paramref name="pattern"/>
        /// and returns substring matched by the specified group
        /// </summary>
        /// <param name="str">String to search in</param>
        /// <param name="pattern">Regular expression to search for</param>
        /// <param name="groupName">Index of the group that should be returned</param>
        /// <param name="default">
        /// Value that will be returned in case no match is found. Default is null
        /// </param>
        /// <returns>
        /// Specified group of the matched part of <paramref name="str"/> or null
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="str"/>, <paramref name="pattern"/> or
        /// <paramref name="groupName"/> is null
        /// </exception>
#if NET_CORE
        [return: NotNullIfNotNull("default")]
#endif
        public static string? GetMatchedGroup(
            this string str,
            string pattern,
            string groupName,
            string? @default = null
        ) {
            return Regex.Match(str, pattern).Groups[groupName] is var g && g.Success
                ? g.Value
                : @default;
        }

        /// <summary>
        /// Returns true if <paramref name="regex"/> finds a match, false otherwise
        /// </summary>
        /// <param name="str">String to search in</param>
        /// <param name="regex">Regular expression to search for</param>
        /// <returns>true if the regular expression finds a match, false otherwise</returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="str"/> or <paramref name="regex"/> is null
        /// </exception>
        public static bool IsMatch(this string str, Regex regex) =>
            regex?.IsMatch(str) ?? throw new ArgumentNullException(nameof(regex));

        /// <summary>
        /// Returns true if <paramref name="pattern"/> finds a match, false otherwise
        /// </summary>
        /// <param name="str">String to search in</param>
        /// <param name="pattern">Regular expression to search for</param>
        /// <returns>true if the regular expression finds a match, false otherwise</returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="str"/> or <paramref name="pattern"/> is null
        /// </exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsMatch(this string str, string pattern) =>
            Regex.IsMatch(str, pattern);

        /// <summary>Escapes characters with special meaning in regular expressions</summary>
        /// <param name="str">String to escape characters in</param>
        /// <returns>A string with escaped characters</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string RegexEscape(this string str) =>
            string.IsNullOrEmpty(str) ? str : Regex.Escape(str);

        /// <summary>Replaces characters with special meaning in XML by entities</summary>
        /// <param name="str">String to replace characters in</param>
        /// <returns>A string with replaced characters</returns>
        public static string XmlEscape(this string str) {
            if (string.IsNullOrEmpty(str)) {
                return str;
            }
            var buffer = new StringBuilder();
            for (var i = 0; i < str.Length; i++) {
                switch (str[i]) {
                    case '<':
                        buffer.Append("&lt;");
                        break;
                    case '>':
                        buffer.Append("&gt;");
                        break;
                    case '&':
                        buffer.Append("&amp;");
                        break;
                    case '\'':
                        buffer.Append("&apos;");
                        break;
                    case '"':
                        buffer.Append("&quot;");
                        break;
                    default:
                        buffer.Append(str[i]);
                        break;
                }
            }
            return buffer.ToString();
        }

        private static string ConvertLineEndings(string str, string lineEnding) {
            if (string.IsNullOrEmpty(str)) {
                return str;
            }
            var buffer = new StringBuilder();
            int i = 0, start = 0;
            for (; i < str.Length; i++) {
                switch (str[i]) {
                    case '\r':
                        if (i > start) {
                            buffer.Append(str, start, i - start);
                            start = i + 1;
                        } else {
                            ++start;
                        }
                        buffer.Append(lineEnding);
                        if (i + 1 < str.Length &&
                            str[i + 1] == '\n') {
                            ++i;
                            ++start;
                        }
                        break;
                    case '\n':
                    case '\u2028':
                        if (i > start) {
                            buffer.Append(str, start, i - start);
                            start = i + 1;
                        } else {
                            ++start;
                        }
                        buffer.Append(lineEnding);
                        break;
                }
            }
            if (i > start) {
                buffer.Append(str, start, i - start);
            }
            return buffer.ToString();
        }

        /// <summary>
        /// Unifies line endings in <paramref name="str"/> to Macintosh-style (CR)
        /// </summary>
        /// <param name="str">String to unify line endings in</param>
        /// <returns>Modified string</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string UnifyLineEndingsToCr(this string str) =>
            ConvertLineEndings(str, "\r");

        /// <summary>Unifies line endings in <paramref name="str"/> to Unix-style (LF)</summary>
        /// <param name="str">String to unify line endings in</param>
        /// <returns>Modified string</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string UnifyLineEndingsToLf(this string str) =>
            ConvertLineEndings(str, "\n");

        /// <summary>
        /// Unifies line endings in <paramref name="str"/> to Windows-style (CR LF)
        /// </summary>
        /// <param name="str">String to unify line endings in</param>
        /// <returns>Modified string</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string UnifyLineEndingsToCrLf(this string str) =>
            ConvertLineEndings(str, "\r\n");

        /// <summary>
        /// Unifies line endings in <paramref name="str"/> to Unicode line separator (LS)
        /// </summary>
        /// <param name="str">String to unify line endings in</param>
        /// <returns>Modified string</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string UnifyLineEndingsToLs(this string str) =>
            ConvertLineEndings(str, "\u2028");

        /// <summary>
        /// Similar to <see cref="string.Split(char[],StringSplitOptions)"/> but generetes string
        /// segments lazily as the returned <see cref="IEnumerable{T}"/> is enumerated
        /// </summary>
        /// <param name="str">String to split</param>
        /// <param name="delimiter">Character to split at</param>
        /// <param name="includeEmpty">
        /// Whether zero-length segments should be included in the returned
        /// <see cref="IEnumerable{T}"/>, default is true
        /// </param>
        /// <returns>IEnumerable with segments of the input string</returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="str"/> is null
        /// </exception>
        public static IEnumerable<string> LazySplit(
            this string str,
            char delimiter,
            bool includeEmpty = true
        ) {
            if (str is null) {
                throw new ArgumentNullException(nameof(str));
            }
            var buffer = new StringBuilder();
            var prevWasDelimiter = false;
            foreach (var c in str) {
                if (c == delimiter) {
                    if (buffer.Length > 0) {
                        yield return buffer.ToString();
                        buffer.Clear();
                    } else if (includeEmpty) {
                        yield return string.Empty;
                    }
                    prevWasDelimiter = true;
                } else {
                    buffer.Append(c);
                    prevWasDelimiter = false;
                }
            }
            if (buffer.Length > 0) {
                yield return buffer.ToString();
            } else if (prevWasDelimiter && includeEmpty) {
                yield return string.Empty;
            }
        }

        /// <summary>
        /// Similar to <see cref="string.Split(char[],StringSplitOptions)"/> but generetes string
        /// segments lazily as the returned <see cref="IEnumerable{T}"/> is enumerated
        /// </summary>
        /// <param name="str">String to split</param>
        /// <param name="delimiters">Characters to split at</param>
        /// <param name="includeEmpty">
        /// Whether zero-length segments should be included in the returned
        /// <see cref="IEnumerable{T}"/>, default is true
        /// </param>
        /// <returns>IEnumerable with segments of the input string</returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="str"/> or <paramref name="delimiters"/> is null
        /// </exception>
        public static IEnumerable<string> LazySplit(
            this string str,
            IList<char> delimiters,
            bool includeEmpty = true
        ) {
            if (str is null) {
                throw new ArgumentNullException(nameof(str));
            }
            if (delimiters is null) {
                throw new ArgumentNullException(nameof(delimiters));
            }
            var buffer = new StringBuilder();
            var prevWasDelimiter = false;
            foreach (var c in str) {
                if (delimiters.Contains(c)) {
                    if (buffer.Length > 0) {
                        yield return buffer.ToString();
                        buffer.Clear();
                    } else if (includeEmpty) {
                        yield return string.Empty;
                    }
                    prevWasDelimiter = true;
                } else {
                    buffer.Append(c);
                    prevWasDelimiter = false;
                }
            }
            if (buffer.Length > 0) {
                yield return buffer.ToString();
            } else if (prevWasDelimiter && includeEmpty) {
                yield return string.Empty;
            }
        }

        /// <summary>
        /// Similar to <see cref="string.Split(string[],StringSplitOptions)"/> but generetes string
        /// segments lazily as the returned <see cref="IEnumerable{T}"/> is enumerated
        /// </summary>
        /// <param name="str">String to split</param>
        /// <param name="delimiter">Substring to split at</param>
        /// <param name="includeEmpty">
        /// Whether zero-length segments should be included in the returned
        /// <see cref="IEnumerable{T}"/>, default is true
        /// </param>
        /// <returns>IEnumerable with segments of the input string</returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="str"/> or <paramref name="delimiter"/> is null
        /// </exception>
        /// <exception cref="ArgumentException">
        /// Thrown when <paramref name="delimiter"/> is empty
        /// </exception>
        public static IEnumerable<string> LazySplit(
            this string str,
            string delimiter,
            bool includeEmpty = true
        ) {
            if (str is null) {
                throw new ArgumentNullException(nameof(str));
            }
            if (delimiter is null) {
                throw new ArgumentNullException(nameof(delimiter));
            } else if (delimiter.Length == 0) {
                throw new ArgumentException("Delimiter can't be empty.", nameof(delimiter));
            }
            int start = 0, end;
            while ((end = str.IndexOf(delimiter, start, StringComparison.Ordinal)) >= 0) {
                if (end > start) {
#if NET_CORE
                    yield return str[start..end];
#else
                    yield return str.Substring(start, end - start);
#endif
                } else if (includeEmpty) {
                    yield return string.Empty;
                }
                start = end + delimiter.Length;
            }
            if (start < str.Length) {
                yield return str.Substring(start);
            } else if (includeEmpty) {
                yield return string.Empty;
            }
        }

        /// <summary>
        /// Lazily splits <paramref name="str"/> at line endings as the returned
        /// <see cref="IEnumerable{T}"/> is enumerated. Supports CR, LF, CRLF and LS as line
        /// endings.
        /// </summary>
        /// <param name="str">String to split</param>
        /// <param name="includeEmpty">
        /// Whether zero-length lines should be included in the returned
        /// <see cref="IEnumerable{T}"/>, default is true
        /// </param>
        /// <returns>IEnumerable with segments of the input string</returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="str"/> is null
        /// </exception>
        /// <example><code>
        /// foreach (var line in text.EnumerateLines(false)) {
        ///     ProcessLine(line);
        /// }
        /// </code></example>
        public static IEnumerable<string> EnumerateLines(
            this string str,
            bool includeEmpty = true
        ) {
            if (str is null) {
                throw new ArgumentNullException(nameof(str));
            }
            var buffer = new StringBuilder();
            for (var i = 0; i < str.Length; i++) {
                switch (str[i]) {
                    case '\r':
                    case '\n':
                    case '\u2028':
                        if (buffer.Length > 0) {
                            yield return buffer.ToString();
                            buffer.Clear();
                        } else if (includeEmpty) {
                            yield return string.Empty;
                        }
                        if (i + 1 < str.Length &&
                            str[i] == '\r' &&
                            str[i + 1] == '\n') {
                            ++i;
                        }
                        break;
                    default:
                        buffer.Append(str[i]);
                        break;
                }
            }
            if (buffer.Length > 0) {
                yield return buffer.ToString();
            }
        }

        /// <summary>
        /// Splits <paramref name="str"/> at line endings into an array. Supports CR, LF, CRLF and
        /// LS as line endings.
        /// </summary>
        /// <param name="str">String to split</param>
        /// <param name="includeEmpty">
        /// Whether zero-length lines should be included in the returned
        /// <see cref="IEnumerable{T}"/>, default is true
        /// </param>
        /// <returns>IEnumerable with segments of the input string</returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="str"/> is null
        /// </exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string[] SplitLines(this string str, bool includeEmpty = true) =>
            EnumerateLines(str, includeEmpty).ToArray();

        /// <summary>
        /// Replaces HTML entities in <paramref name="str"/> by the corresponding characters
        /// </summary>
        /// <param name="str">String to expand entities in</param>
        /// <returns>Modified string</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string ExpandHtmlEntities(this string str) =>
            WebUtility.HtmlDecode(str);

        /// <summary>
        /// Replaces all sequences of whitespace in <paramref name="str"/> by a single space and
        /// trims any whitespace at the start and end
        /// </summary>
        /// <param name="str">String to modify</param>
        /// <returns>Modified string</returns>
        public static string CollapseWhitespace(this string str) {
            if (string.IsNullOrEmpty(str)) {
                return str;
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

        /// <summary>Repeats a given string</summary>
        /// <param name="str">String to repeat</param>
        /// <param name="count">Repetition count, must be non-negative</param>
        /// <returns>
        /// Empty string when <paramref name="count"/> == 0, <paramref name="str"/> when
        /// <paramref name="count"/> == 1, otherwise, <paramref name="str"/> repeated
        /// <paramref name="count"/> times
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="str"/> is null
        /// </exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown when <paramref name="count"/> is negative
        /// </exception>
        public static string Repeat(this string str, int count) {
            if (str is null) {
                throw new ArgumentNullException(nameof(str));
            }
            if (count < 0) {
                throw new ArgumentOutOfRangeException(
                    nameof(count),
                    "Repetition count can't be negative."
                );
            } else if (count == 0) {
                return string.Empty;
            } else if (count == 1) {
                return str;
            }
            var buffer = new StringBuilder(str);
            for (var i = 1; i < count; ++i) {
                buffer.Append(str);
            }
            return buffer.ToString();
        }

        /// <summary>
        /// Changes first letter of each word to uppercase and all other letters to lowercase. Word
        /// is defined as a continuous sequence of letters.
        /// </summary>
        /// <param name="str">String to convert</param>
        /// <returns>Converted string</returns>
        /// <remarks>Uses <see cref="DefaultCulture"/> for case conversion</remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string ToCapitalCase(this string str) =>
            ToCapitalCase(str, DefaultCulture);

        /// <summary>
        /// Changes first letter of each word to uppercase and all other letters to lowercase. Word
        /// is defined as a continuous sequence of letters.
        /// </summary>
        /// <param name="str">String to convert</param>
        /// <param name="culture"><see cref="CultureInfo"/> to use for case conversion</param>
        /// <returns>Converted string</returns>
        public static string ToCapitalCase(this string str, CultureInfo culture) {
            if (str is null) {
                throw new ArgumentNullException(nameof(str));
            } else if (string.IsNullOrWhiteSpace(str)) {
                return str;
            }
            var sb = new StringBuilder(str.Length);
            var prevWasAlpha = false;
            for (var i = 0; i < str.Length; ++i) {
                var c = str[i];
                if (char.IsLetter(c)) {
                    sb.Append(prevWasAlpha ? char.ToLower(c, culture) : char.ToUpper(c, culture));
                    prevWasAlpha = true;
                } else {
                    sb.Append(c);
                    prevWasAlpha = false;
                }
            }
            return sb.ToString();
        }

        /// <summary>Alias for <see cref="string.IsNullOrEmpty"/></summary>
        /// <param name="str">String to check</param>
        /// <returns>True if <paramref name="str"/> is null or empty, false otherwise</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsNullOrEmpty(this string? str) =>
            string.IsNullOrEmpty(str);

        /// <summary>Alias for <see cref="string.IsNullOrWhiteSpace"/></summary>
        /// <param name="str">String to check</param>
        /// <returns>
        /// True if <paramref name="str"/> is null or only consists of whitespace characters, false
        /// otherwise
        /// </returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsNullOrWhiteSpace(this string? str) =>
            string.IsNullOrWhiteSpace(str);

        /// <summary>Alias for <see cref="SByte.Parse(string)"/></summary>
        /// <param name="str">String to parse</param>
        /// <param name="culture">
        /// <see cref="CultureInfo"/> to use for parsing. Wnen null, <see cref="DefaultCulture"/>
        /// is used, default is null.
        /// </param>
        /// <returns>Parsed value</returns>
        /// <exception cref="ArgumentException">
        /// Thrown when <paramref name="str"/> is null
        /// </exception>
        /// <exception cref="FormatException">
        /// Thrown when <paramref name="str"/> does not contain a valid <see cref="SByte"/> value
        /// </exception>
        /// <exception cref="OverflowException">
        /// Thrown when <paramref name="str"/> represents a value lower than
        /// <see cref="SByte.MinValue"/> or greater than <see cref="SByte.MaxValue"/>
        /// </exception>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte ParseSByte(this string str, CultureInfo? culture = null) =>
            sbyte.Parse(str, culture ?? DefaultCulture);

        /// <summary>Alias for <see cref="Byte.Parse(string)"/></summary>
        /// <param name="str">String to parse</param>
        /// <param name="culture">
        /// <see cref="CultureInfo"/> to use for parsing. Wnen null, <see cref="DefaultCulture"/>
        /// is used, default is null.
        /// </param>
        /// <returns>Parsed value</returns>
        /// <exception cref="ArgumentException">
        /// Thrown when <paramref name="str"/> is null
        /// </exception>
        /// <exception cref="FormatException">
        /// Thrown when <paramref name="str"/> does not contain a valid <see cref="Byte"/> value
        /// </exception>
        /// <exception cref="OverflowException">
        /// Thrown when <paramref name="str"/> represents a value lower than
        /// <see cref="Byte.MinValue"/> or greater than <see cref="Byte.MaxValue"/>
        /// </exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte ParseByte(this string str, CultureInfo? culture = null) =>
            byte.Parse(str, culture ?? DefaultCulture);

        /// <summary>Alias for <see cref="Int16.Parse(string)"/></summary>
        /// <param name="str">String to parse</param>
        /// <param name="culture">
        /// <see cref="CultureInfo"/> to use for parsing. Wnen null, <see cref="DefaultCulture"/>
        /// is used, default is null.
        /// </param>
        /// <returns>Parsed value</returns>
        /// <exception cref="ArgumentException">
        /// Thrown when <paramref name="str"/> is null
        /// </exception>
        /// <exception cref="FormatException">
        /// Thrown when <paramref name="str"/> does not contain a valid <see cref="Int16"/> value
        /// </exception>
        /// <exception cref="OverflowException">
        /// Thrown when <paramref name="str"/> represents a value lower than
        /// <see cref="Int16.MinValue"/> or greater than <see cref="Int16.MaxValue"/>
        /// </exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short ParseInt16(this string str, CultureInfo? culture = null) =>
            short.Parse(str, culture ?? DefaultCulture);

        /// <summary>Alias for <see cref="UInt16.Parse(string)"/></summary>
        /// <param name="str">String to parse</param>
        /// <param name="culture">
        /// <see cref="CultureInfo"/> to use for parsing. Wnen null, <see cref="DefaultCulture"/>
        /// is used, default is null.
        /// </param>
        /// <returns>Parsed value</returns>
        /// <exception cref="ArgumentException">
        /// Thrown when <paramref name="str"/> is null
        /// </exception>
        /// <exception cref="FormatException">
        /// Thrown when <paramref name="str"/> does not contain a valid <see cref="UInt16"/> value
        /// </exception>
        /// <exception cref="OverflowException">
        /// Thrown when <paramref name="str"/> represents a value lower than
        /// <see cref="UInt16.MinValue"/> or greater than <see cref="UInt16.MaxValue"/>
        /// </exception>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort ParseUInt16(this string str, CultureInfo? culture = null) =>
            ushort.Parse(str, culture ?? DefaultCulture);

        /// <summary>Alias for <see cref="Int32.Parse(string)"/></summary>
        /// <param name="str">String to parse</param>
        /// <param name="culture">
        /// <see cref="CultureInfo"/> to use for parsing. Wnen null, <see cref="DefaultCulture"/>
        /// is used, default is null.
        /// </param>
        /// <returns>Parsed value</returns>
        /// <exception cref="ArgumentException">
        /// Thrown when <paramref name="str"/> is null
        /// </exception>
        /// <exception cref="FormatException">
        /// Thrown when <paramref name="str"/> does not contain a valid <see cref="Int32"/> value
        /// </exception>
        /// <exception cref="OverflowException">
        /// Thrown when <paramref name="str"/> represents a value lower than
        /// <see cref="Int32.MinValue"/> or greater than <see cref="Int32.MaxValue"/>
        /// </exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int ParseInt(this string str, CultureInfo? culture = null) =>
            int.Parse(str, culture ?? DefaultCulture);

        /// <summary>Alias for <see cref="UInt32.Parse(string)"/></summary>
        /// <param name="str">String to parse</param>
        /// <param name="culture">
        /// <see cref="CultureInfo"/> to use for parsing. Wnen null, <see cref="DefaultCulture"/>
        /// is used, default is null.
        /// </param>
        /// <returns>Parsed value</returns>
        /// <exception cref="ArgumentException">
        /// Thrown when <paramref name="str"/> is null
        /// </exception>
        /// <exception cref="FormatException">
        /// Thrown when <paramref name="str"/> does not contain a valid <see cref="UInt32"/> value
        /// </exception>
        /// <exception cref="OverflowException">
        /// Thrown when <paramref name="str"/> represents a value lower than
        /// <see cref="UInt32.MinValue"/> or greater than <see cref="UInt32.MaxValue"/>
        /// </exception>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint ParseUInt32(this string str, CultureInfo? culture = null) =>
            uint.Parse(str, culture ?? DefaultCulture);

        /// <summary>Alias for <see cref="Int64.Parse(string)"/></summary>
        /// <param name="str">String to parse</param>
        /// <param name="culture">
        /// <see cref="CultureInfo"/> to use for parsing. Wnen null, <see cref="DefaultCulture"/>
        /// is used, default is null.
        /// </param>
        /// <returns>Parsed value</returns>
        /// <exception cref="ArgumentException">
        /// Thrown when <paramref name="str"/> is null
        /// </exception>
        /// <exception cref="FormatException">
        /// Thrown when <paramref name="str"/> does not contain a valid <see cref="Int64"/> value
        /// </exception>
        /// <exception cref="OverflowException">
        /// Thrown when <paramref name="str"/> represents a value lower than
        /// <see cref="Int64.MinValue"/> or greater than <see cref="Int64.MaxValue"/>
        /// </exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long ParseInt64(this string str, CultureInfo? culture = null) =>
            long.Parse(str, culture ?? DefaultCulture);

        /// <summary>Alias for <see cref="UInt64.Parse(string)"/></summary>
        /// <param name="str">String to parse</param>
        /// <param name="culture">
        /// <see cref="CultureInfo"/> to use for parsing. Wnen null, <see cref="DefaultCulture"/>
        /// is used, default is null.
        /// </param>
        /// <returns>Parsed value</returns>
        /// <exception cref="ArgumentException">
        /// Thrown when <paramref name="str"/> is null
        /// </exception>
        /// <exception cref="FormatException">
        /// Thrown when <paramref name="str"/> does not contain a valid <see cref="UInt64"/> value
        /// </exception>
        /// <exception cref="OverflowException">
        /// Thrown when <paramref name="str"/> represents a value lower than
        /// <see cref="UInt64.MinValue"/> or greater than <see cref="UInt64.MaxValue"/>
        /// </exception>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong ParseUInt64(this string str, CultureInfo? culture = null) =>
            ulong.Parse(str, culture ?? DefaultCulture);

        /// <summary>Alias for <see cref="Single.Parse(string)"/></summary>
        /// <param name="str">String to parse</param>
        /// <param name="culture">
        /// <see cref="CultureInfo"/> to use for parsing. Wnen null, <see cref="DefaultCulture"/>
        /// is used, default is null.
        /// </param>
        /// <returns>Parsed value</returns>
        /// <exception cref="ArgumentException">
        /// Thrown when <paramref name="str"/> is null
        /// </exception>
        /// <exception cref="FormatException">
        /// Thrown when <paramref name="str"/> does not contain a valid <see cref="Single"/> value
        /// </exception>
        /// <exception cref="OverflowException">
        /// Thrown when <paramref name="str"/> represents a value lower than
        /// <see cref="Single.MinValue"/> or greater than <see cref="Single.MaxValue"/>
        /// </exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float ParseSingle(this string str, CultureInfo? culture = null) =>
            float.Parse(str, culture ?? DefaultCulture);

        /// <summary>Alias for <see cref="Double.Parse(string)"/></summary>
        /// <param name="str">String to parse</param>
        /// <param name="culture">
        /// <see cref="CultureInfo"/> to use for parsing. Wnen null, <see cref="DefaultCulture"/>
        /// is used, default is null.
        /// </param>
        /// <returns>Parsed value</returns>
        /// <exception cref="ArgumentException">
        /// Thrown when <paramref name="str"/> is null
        /// </exception>
        /// <exception cref="FormatException">
        /// Thrown when <paramref name="str"/> does not contain a valid <see cref="Double"/> value
        /// </exception>
        /// <exception cref="OverflowException">
        /// Thrown when <paramref name="str"/> represents a value lower than
        /// <see cref="Double.MinValue"/> or greater than <see cref="Double.MaxValue"/>
        /// </exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double ParseDouble(this string str, CultureInfo? culture = null) =>
            double.Parse(str, culture ?? DefaultCulture);

        /// <summary>Alias for <see cref="Decimal.Parse(string)"/></summary>
        /// <param name="str">String to parse</param>
        /// <param name="culture">
        /// <see cref="CultureInfo"/> to use for parsing. Wnen null, <see cref="DefaultCulture"/>
        /// is used, default is null.
        /// </param>
        /// <returns>Parsed value</returns>
        /// <exception cref="ArgumentException">
        /// Thrown when <paramref name="str"/> is null
        /// </exception>
        /// <exception cref="FormatException">
        /// Thrown when <paramref name="str"/> does not contain a valid <see cref="Decimal"/> value
        /// </exception>
        /// <exception cref="OverflowException">
        /// Thrown when <paramref name="str"/> represents a value lower than
        /// <see cref="Decimal.MinValue"/> or greater than <see cref="Decimal.MaxValue"/>
        /// </exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static decimal ParseDecimal(this string str, CultureInfo? culture = null) =>
            decimal.Parse(str, NumberStyles.Float, culture ?? DefaultCulture);

        /// <summary>
        /// Tries to parse <paramref name="str"/> using
        /// <see cref="SByte.TryParse(string,out SByte)"/>. Returns <paramref name="default"/> when
        /// not successful.
        /// </summary>
        /// <param name="str">String to parse</param>
        /// <param name="culture">
        /// <see cref="CultureInfo"/> to use for parsing. Wnen null, <see cref="DefaultCulture"/>
        /// is used, default is null.
        /// </param>
        /// <param name="default">
        /// Value that should be returned in case of failure. Default is 0
        /// </param>
        /// <returns>Parsed value or <paramref name="default"/></returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte ParseSByteOrDefault(
            this string str,
            sbyte @default = 0,
            CultureInfo? culture = null
        ) {
            return sbyte.TryParse(str, NumberStyles.Integer, culture ?? DefaultCulture, out var v)
                ? v
                : @default;
        }

        /// <summary>
        /// Tries to parse <paramref name="str"/> using
        /// <see cref="Byte.TryParse(string,out Byte)"/>. Returns <paramref name="default"/> when
        /// not successful.
        /// </summary>
        /// <param name="str">String to parse</param>
        /// <param name="culture">
        /// <see cref="CultureInfo"/> to use for parsing. Wnen null, <see cref="DefaultCulture"/>
        /// is used, default is null.
        /// </param>
        /// <param name="default">
        /// Value that should be returned in case of failure, default is 0
        /// </param>
        /// <returns>Parsed value or <paramref name="default"/></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte ParseByteOrDefault(
            this string str,
            byte @default = 0,
            CultureInfo? culture = null
        ) {
            return byte.TryParse(str, NumberStyles.Integer, culture ?? DefaultCulture, out var v)
                ? v
                : @default;
        }

        /// <summary>
        /// Tries to parse <paramref name="str"/> using
        /// <see cref="Int16.TryParse(string,out Int16)"/>. Returns <paramref name="default"/> when
        /// not successful.
        /// </summary>
        /// <param name="str">String to parse</param>
        /// <param name="culture">
        /// <see cref="CultureInfo"/> to use for parsing. Wnen null, <see cref="DefaultCulture"/>
        /// is used, default is null.
        /// </param>
        /// <param name="default">
        /// Value that should be returned in case of failure, default is 0
        /// </param>
        /// <returns>Parsed value or <paramref name="default"/></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short ParseInt16OrDefault(
            this string str,
            short @default = 0,
            CultureInfo? culture = null
        ) {
            return short.TryParse(str, NumberStyles.Integer, culture ?? DefaultCulture, out var v)
                ? v
                : @default;
        }

        /// <summary>
        /// Tries to parse <paramref name="str"/> using
        /// <see cref="UInt16.TryParse(string,out UInt16)"/>. Returns <paramref name="default"/>
        /// when not successful.
        /// </summary>
        /// <param name="str">String to parse</param>
        /// <param name="culture">
        /// <see cref="CultureInfo"/> to use for parsing. Wnen null, <see cref="DefaultCulture"/>
        /// is used, default is null.
        /// </param>
        /// <param name="default">
        /// Value that should be returned in case of failure, default is 0
        /// </param>
        /// <returns>Parsed value or <paramref name="default"/></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [CLSCompliant(false)]
        public static ushort ParseUInt16OrDefault(
            this string str,
            ushort @default = 0,
            CultureInfo? culture = null
        ) {
            return ushort.TryParse(str, NumberStyles.Integer, culture ?? DefaultCulture, out var v)
                ? v
                : @default;
        }

        /// <summary>
        /// Tries to parse <paramref name="str"/> using
        /// <see cref="Int32.TryParse(string,out Int32)"/>. Returns <paramref name="default"/> when
        /// not successful.
        /// </summary>
        /// <param name="str">String to parse</param>
        /// <param name="culture">
        /// <see cref="CultureInfo"/> to use for parsing. Wnen null, <see cref="DefaultCulture"/>
        /// is used, default is null.
        /// </param>
        /// <param name="default">
        /// Value that should be returned in case of failure, default is 0
        /// </param>
        /// <returns>Parsed value or <paramref name="default"/></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int ParseIntOrDefault(
            this string str,
            int @default = 0,
            CultureInfo? culture = null
        ) {
            return int.TryParse(str, NumberStyles.Integer, culture ?? DefaultCulture, out var v)
                ? v
                : @default;
        }

        /// <summary>
        /// Tries to parse <paramref name="str"/> using
        /// <see cref="UInt32.TryParse(string,out UInt32)"/>. Returns <paramref name="default"/>
        /// when not successful.
        /// </summary>
        /// <param name="str">String to parse</param>
        /// <param name="culture">
        /// <see cref="CultureInfo"/> to use for parsing. Wnen null, <see cref="DefaultCulture"/>
        /// is used, default is null.
        /// </param>
        /// <param name="default">
        /// Value that should be returned in case of failure, default is 0
        /// </param>
        /// <returns>Parsed value or <paramref name="default"/></returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint ParseUInt32OrDefault(
            this string str,
            uint @default = 0U,
            CultureInfo? culture = null
        ) {
            return uint.TryParse(str, NumberStyles.Integer, culture ?? DefaultCulture, out var v)
                ? v
                : @default;
        }

        /// <summary>
        /// Tries to parse <paramref name="str"/> using
        /// <see cref="Int64.TryParse(string,out Int64)"/>. Returns <paramref name="default"/> when
        /// not successful.
        /// </summary>
        /// <param name="str">String to parse</param>
        /// <param name="culture">
        /// <see cref="CultureInfo"/> to use for parsing. Wnen null, <see cref="DefaultCulture"/>
        /// is used, default is null.
        /// </param>
        /// <param name="default">
        /// Value that should be returned in case of failure, default is 0
        /// </param>
        /// <returns>Parsed value or <paramref name="default"/></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long ParseInt64OrDefault(
            this string str,
            long @default = 0L,
            CultureInfo? culture = null
        ) {
            return long.TryParse(str, NumberStyles.Integer, culture ?? DefaultCulture, out var v)
                ? v
                : @default;
        }

        /// <summary>
        /// Tries to parse <paramref name="str"/> using
        /// <see cref="UInt64.TryParse(string,out UInt64)"/>. Returns <paramref name="default"/>
        /// when not successful.
        /// </summary>
        /// <param name="str">String to parse</param>
        /// <param name="culture">
        /// <see cref="CultureInfo"/> to use for parsing. Wnen null, <see cref="DefaultCulture"/>
        /// is used, default is null.
        /// </param>
        /// <param name="default">
        /// Value that should be returned in case of failure, default is 0
        /// </param>
        /// <returns>Parsed value or <paramref name="default"/></returns>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong ParseUInt64OrDefault(
            this string str,
            ulong @default = 0UL,
            CultureInfo? culture = null
        ) {
            return ulong.TryParse(str, NumberStyles.Integer, culture ?? DefaultCulture, out var v)
                ? v
                : @default;
        }

        /// <summary>
        /// Tries to parse <paramref name="str"/> using
        /// <see cref="Single.TryParse(string,out Single)"/>. Returns <paramref name="default"/>
        /// when  not successful.
        /// </summary>
        /// <param name="str">String to parse</param>
        /// <param name="culture">
        /// <see cref="CultureInfo"/> to use for parsing. Wnen null, <see cref="DefaultCulture"/>
        /// is used, default is null.
        /// </param>
        /// <param name="default">
        /// Value that should be returned in case of failure, default is 0
        /// </param>
        /// <returns>Parsed value or <paramref name="default"/></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float ParseSingleOrDefault(
            this string str,
            float @default = 0f,
            CultureInfo? culture = null
        ) {
            return float.TryParse(str, NumberStyles.Float, culture ?? DefaultCulture, out var v)
                ? v
                : @default;
        }

        /// <summary>
        /// Tries to parse <paramref name="str"/> using
        /// <see cref="Double.TryParse(string,out Double)"/>. Returns <paramref name="default"/>
        /// when  not successful.
        /// </summary>
        /// <param name="str">String to parse</param>
        /// <param name="default">
        /// Value that should be returned in case of failure, default is 0
        /// </param>
        /// <param name="culture">
        /// <see cref="CultureInfo"/> to use for parsing. Wnen null, <see cref="DefaultCulture"/>
        /// is used, default is null.
        /// </param>
        /// <returns>Parsed value or <paramref name="default"/></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double ParseDoubleOrDefault(
            this string str,
            double @default = 0d,
            CultureInfo? culture = null
        ) {
            return double.TryParse(str, NumberStyles.Float, culture ?? DefaultCulture, out var v)
                ? v
                : @default;
        }

        /// <summary>
        /// Tries to parse <paramref name="str"/> using
        /// <see cref="Decimal.TryParse(string,out Decimal)"/>. Returns <paramref name="default"/>
        /// when  not successful.
        /// </summary>
        /// <param name="str">String to parse</param>
        /// <param name="default">
        /// Value that should be returned in case of failure, default is 0
        /// </param>
        /// <param name="culture">
        /// <see cref="CultureInfo"/> to use for parsing. Wnen null, <see cref="DefaultCulture"/>
        /// is used, default is null.
        /// </param>
        /// <returns>Parsed value or <paramref name="default"/></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static decimal ParseDecimalOrDefault(
            this string str,
            decimal @default = 0m,
            CultureInfo? culture = null
        ) {
            return decimal.TryParse(str, NumberStyles.Float, culture ?? DefaultCulture, out var v)
                ? v
                : @default;
        }
    }
}
