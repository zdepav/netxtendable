using System;
using System.Text;

namespace Netxtendable.Text {

    /// <summary>Class with extension methods for <see cref="Int32"/>.</summary>
    public static class Int32Extensions {

        /// <summary>
        /// Converts <paramref name="i"/> to ordinal (e.g. "2nd", "45th", etc.).
        /// </summary>
        /// <param name="i">Number to convert.</param>
        /// <returns>Resulting string.</returns>
        /// <example><code>
        /// for (var i = 0; i &lt; objects.Count; ++i) {
        ///     if (objects[i].IsEmpty()) {
        ///         Log.Debug($"{i.ToOrdinal()} object was empty.");
        ///     }
        /// }
        /// </code></example>
        public static string ToOrdinal(this int i) {
            var buffer = new StringBuilder();
            if (i < 0) {
                buffer.Append('-');
                i = -i;
            }
            buffer.Append(i);
            var t = i % 100;
            if (t > 10 && t < 20) {
                buffer.Append("th");
            } else {
                buffer.Append((i % 10) switch {
                    1 => "st",
                    2 => "nd",
                    3 => "rd",
                    _ => "th"
                });
            }
            return buffer.ToString();
        }

        private static readonly string[] textNumbers = {
            "zero", "one", "two", "three", "four",
            "five", "six", "seven", "eight", "nine",
            "ten", "eleven", "twelve", "thirteen", "fourteen",
            "fifteen", "sixteen", "seventeen", "eighteen", "nineteen"
        };

        private static readonly string[] textNumbersTens = {
            "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety"
        };

        private static readonly (long upperBound, int divisor, int mod, string divisorString)[]
            textNumberLevels = {
                (1_000, 100, 10, "hundred"),
                (1_000_000, 1_000, 1_000, "thousand"),
                (1_000_000_000, 1_000_000, 1_000, "million"),
                (int.MaxValue + 1L, 1_000_000_000, 1_000, "billion")
            };

        private static void ToWordsUnsigned(this int i, StringBuilder buffer) {
            if (i < 20) {
                buffer.Append(textNumbers[i]);
            } else if (i < 100) {
                var units = i % 10;
                var tens = i / 10 % 10;
                buffer.Append(textNumbersTens[tens - 2]);
                if (units > 0) {
                    buffer.Append('-');
                    buffer.Append(textNumbers[units]);
                }
            } else {
                foreach (var (upperBound, divisor, mod, divisorString) in textNumberLevels) {
                    if (i < upperBound) {
                        var count = i / divisor % mod;
                        if (count > 0) {
                            ToWordsUnsigned(count, buffer);
                            buffer.Append(' ');
                            buffer.Append(divisorString);
                        }
                        var rem = i % divisor;
                        if (rem > 0) {
                            buffer.Append(' ');
                            ToWordsUnsigned(rem, buffer);
                        }
                        break;
                    }
                }
            }
        }

        /// <summary>
        /// Converts <paramref name="i"/> to words (e.g. "two hundred thirty four").
        /// </summary>
        /// <param name="i">Number to convert.</param>
        /// <returns>Resulting string.</returns>
        public static string ToWords(this int i) {
            var buffer = new StringBuilder();
            if (i < 0) {
                buffer.Append("minus ");
                ToWordsUnsigned(-i, buffer);
            } else {
                ToWordsUnsigned(i, buffer);
            }
            return buffer.ToString();
        }

        private static readonly string[] longOrdinals = {
            "zeroth", "first", "second", "third", "fourth",
            "fifth", "sixth", "seventh", "eighth", "ninth",
            "tenth", "eleventh", "twelfth", "thirteenth", "fourteenth",
            "fifteenth", "sixteenth", "seventeenth", "eighteenth", "nineteenth"
        };

        private static readonly string[] longOrdinalsTens = {
            "twentieth", "thirtieth", "fourtieth", "fiftieth",
            "sixty", "seventieth", "eightieth", "ninetieth"
        };

        private static void ToWordsOrdinalUnsigned(this int i, StringBuilder buffer) {
            if (i < 20) {
                buffer.Append(longOrdinals[i]);
            } else if (i < 100) {
                var units = i % 10;
                var tens = i / 10 % 10;
                if (units == 0) {
                    buffer.Append(longOrdinalsTens[tens - 2]);
                } else {
                    buffer.Append(textNumbersTens[tens - 2]);
                    buffer.Append('-');
                    buffer.Append(longOrdinals[units]);
                }
            } else {
                ToWordsUnsigned(i / 100 * 100, buffer);
                var rem = i % 100;
                if (rem > 0) {
                    buffer.Append(' ');
                    ToWordsOrdinalUnsigned(rem, buffer);
                } else {
                    buffer.Append("th");
                }
            }
        }

        /// <summary>
        /// Converts <paramref name="i"/> to ordinal words (e.g. "two hundred thirty second").
        /// </summary>
        /// <param name="i">Number to convert.</param>
        /// <returns>Resulting string.</returns>
        public static string ToWordsOrdinal(this int i) {
            var buffer = new StringBuilder();
            if (i < 0) {
                buffer.Append("minus ");
                ToWordsOrdinalUnsigned(-i, buffer);
            } else {
                ToWordsOrdinalUnsigned(i, buffer);
            }
            return buffer.ToString();
        }
    }
}
