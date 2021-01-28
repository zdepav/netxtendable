#nullable enable
using System.Globalization;
using System.Runtime.CompilerServices;
using static Netxtendable.NetxtendableConfig;

namespace Netxtendable.Extensions.Text {

    /// <summary>Class with extension methods for <see cref="char"/></summary>
    public static class CharExtensions {

        /// <summary>Shorthand for char.ToUpper(c, culture)</summary>
        /// <param name="c">Character to convert</param>
        /// <param name="culture">
        /// <see cref="CultureInfo"/> to use for parsing. Wnen null, <see cref="DefaultCulture"/>
        /// is used, default is null.
        /// </param>
        /// <returns>Converted character</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static char ToUpper(this char c, CultureInfo? culture = null) =>
            char.ToUpper(c, culture ?? DefaultCulture);

        /// <summary>Shorthand for char.ToLower(c, culture)</summary>
        /// <param name="c">Character to convert</param>
        /// <param name="culture">
        /// <see cref="CultureInfo"/> to use for parsing. Wnen null, <see cref="DefaultCulture"/>
        /// is used, default is null.
        /// </param>
        /// <returns>Converted character</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static char ToLower(this char c, CultureInfo? culture = null) =>
            char.ToLower(c, culture ?? DefaultCulture);

        /// <summary>Shorthand for char.IsControl(c)</summary>
        /// <param name="c">Character to check</param>
        /// <returns>True if <paramref name="c"/> is a control character, false otherwise</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsControl(this char c) =>
            char.IsControl(c);

        /// <summary>Shorthand for char.IsLetter(c)</summary>
        /// <param name="c">Character to check</param>
        /// <returns>True if <paramref name="c"/> is a letter, false otherwise</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsLetter(this char c) =>
            char.IsLetter(c);

        /// <summary>Shorthand for char.IsDigit(c)</summary>
        /// <param name="c">Character to check</param>
        /// <returns>True if <paramref name="c"/> is a digit, false otherwise</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsDigit(this char c) =>
            char.IsDigit(c);

        /// <summary>Shorthand for char.IsLetterOrDigit(c)</summary>
        /// <param name="c">Character to check</param>
        /// <returns>True if <paramref name="c"/> is a letter or a digit, false otherwise</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsLetterOrDigit(this char c) =>
            char.IsLetterOrDigit(c);

        /// <summary>Shorthand for char.IsLower(c)</summary>
        /// <param name="c">Character to check</param>
        /// <returns>True if <paramref name="c"/> is a lowercase letter, false otherwise</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsLower(this char c) =>
            char.IsLower(c);

        /// <summary>Shorthand for char.IsUpper(c)</summary>
        /// <param name="c">Character to check</param>
        /// <returns>True if <paramref name="c"/> is an uppercase letter, false otherwise</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsUpper(this char c) =>
            char.IsUpper(c);

        /// <summary>Shorthand for char.IsPunctuation(c)</summary>
        /// <param name="c">Character to check</param>
        /// <returns>True if <paramref name="c"/> is a punctuation mark, false otherwise</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsPunctuation(this char c) =>
            char.IsPunctuation(c);

        /// <summary>Shorthand for char.IsWhiteSpace(c)</summary>
        /// <param name="c">Character to check</param>
        /// <returns>
        /// True if <paramref name="c"/> is a whitespace character, false otherwise
        /// </returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsWhiteSpace(this char c) =>
            char.IsWhiteSpace(c);

        /// <summary>Shorthand for char.IsSeparator(c)</summary>
        /// <param name="c">Character to check</param>
        /// <returns>True if <paramref name="c"/> is a separator character, false otherwise</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsSeparator(this char c) =>
            char.IsSeparator(c);

        /// <summary>Shorthand for char.IsSymbol(c)</summary>
        /// <param name="c">Character to check</param>
        /// <returns>True if <paramref name="c"/> is a symbol character, false otherwise</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsSymbol(this char c) =>
            char.IsSymbol(c);

        /// <summary>Shorthand for char.IsSurrogate(c)</summary>
        /// <param name="c">Character to check</param>
        /// <returns>
        /// True if <paramref name="c"/> is a high or low surrogate, false otherwise
        /// </returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsSurrogate(this char c) =>
            char.IsSurrogate(c);

        /// <summary>Shorthand for char.IsHighSurrogate(c)</summary>
        /// <param name="c">Character to check</param>
        /// <returns>True if <paramref name="c"/> is a high surrogate, false otherwise</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsHighSurrogate(this char c) =>
            char.IsHighSurrogate(c);

        /// <summary>Shorthand for char.IsLowSurrogate(c)</summary>
        /// <param name="c">Character to check</param>
        /// <returns>True if <paramref name="c"/> is a low surrogate, false otherwise</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsLowSurrogate(this char c) =>
            char.IsLowSurrogate(c);

        /// <summary>Shorthand for char.IsSurrogatePair(c)</summary>
        /// <param name="c">First character to check (high surrogate)</param>
        /// <param name="c2">Second character to check (low surrogate)</param>
        /// <returns>
        /// True if <paramref name="c"/> and <paramref name="c2"/> form a high-low surrogate pair,
        /// false otherwise
        /// </returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool FormsSurrogatePairWith(this char c, char c2) =>
            char.IsSurrogatePair(c, c2);
        
        /// <summary>Shorthand for char.GetUnicodeCategory(c)</summary>
        /// <param name="c">Character to get unicode category of</param>
        /// <returns>Unicode category of <paramref name="c"/></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UnicodeCategory GetUnicodeCategory(this char c) =>
            char.GetUnicodeCategory(c);
    }
}
