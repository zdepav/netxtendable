#nullable enable
using System;
using System.Collections.Generic;
using System.Linq;

namespace Netxtendable.Extensions.Utils {

    /// <summary>Class with extension methods for <see cref="Random"/></summary>
    public static class RandomExtensions {

        /// <summary>Returns a random float value between 0 (inclusive) and 1 (exclusive)</summary>
        /// <param name="random"><see cref="Random"/> instance to use</param>
        /// <returns>Random float value from [0, 1)</returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="random"/> is null
        /// </exception>
        public static float NextSingle(this Random random) =>
            random is null
                ? throw new ArgumentNullException(nameof(random))
                : (float)random.NextDouble();

        /// <summary>
        /// Returns a random float value between 0 (inclusive) and <paramref name="max"/>
        /// (exclusive)
        /// </summary>
        /// <param name="random"><see cref="Random"/> instance to use</param>
        /// <param name="max">Maximal value (exclusive)</param>
        /// <returns>Random float value from [0, max)</returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="random"/> is null
        /// </exception>
        public static float NextSingle(this Random random, float max) {
            if (random is null) {
                throw new ArgumentNullException(nameof(random));
            }
            if (max <= 0) {
                throw new ArgumentOutOfRangeException(
                    nameof(max),
                    max,
                    "Maximum must be positive."
                );
            }
            return (float)random.NextDouble() * max;
        }

        /// <summary>
        /// Returns a random float value between <paramref name="min"/> (inclusive) and
        /// <paramref name="max"/> (exclusive)
        /// </summary>
        /// <param name="random"><see cref="Random"/> instance to use</param>
        /// <param name="min">Minimal value (inclusive)</param>
        /// <param name="max">Maximal value (exclusive)</param>
        /// <returns>Random float value from [min, max)</returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="random"/> is null
        /// </exception>
        public static float NextSingle(this Random random, float min, float max) {
            if (random is null) {
                throw new ArgumentNullException(nameof(random));
            }
            if (max <= min) {
                throw new ArgumentOutOfRangeException(
                    nameof(max),
                    max,
                    "Maximum must be greater tham minimum."
                );
            }
            return min + (float)random.NextDouble() * (max - min);
        }

        /// <summary>
        /// Returns a random double value between 0 (inclusive) and <paramref name="max"/>
        /// (exclusive)
        /// </summary>
        /// <param name="random"><see cref="Random"/> instance to use</param>
        /// <param name="max">Maximal value (exclusive)</param>
        /// <returns>Random float value from [0, max)</returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="random"/> is null
        /// </exception>
        public static double NextDouble(this Random random, double max) {
            if (random is null) {
                throw new ArgumentNullException(nameof(random));
            }
            if (max <= 0) {
                throw new ArgumentOutOfRangeException(
                    nameof(max),
                    max,
                    "Maximum must be positive."
                );
            }
            return random.NextDouble() * max;
        }

        /// <summary>
        /// Returns a random double value between <paramref name="min"/> (inclusive) and
        /// <paramref name="max"/> (exclusive)
        /// </summary>
        /// <param name="random"><see cref="Random"/> instance to use</param>
        /// <param name="min">Minimal value (inclusive)</param>
        /// <param name="max">Maximal value (exclusive)</param>
        /// <returns>Random float value from [min, max)</returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="random"/> is null
        /// </exception>
        public static double NextDouble(this Random random, double min, double max) {
            if (random is null) {
                throw new ArgumentNullException(nameof(random));
            }
            if (max <= min) {
                throw new ArgumentOutOfRangeException(
                    nameof(max),
                    max,
                    "Maximum must be greater tham minimum."
                );
            }
            return min + random.NextDouble() * (max - min);
        }

        /// <summary>
        /// Returns a random decimal value between 0 (inclusive) and 1 (exclusive)
        /// </summary>
        /// <param name="random"><see cref="Random"/> instance to use</param>
        /// <returns>Random decimal value from [0, 1)</returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="random"/> is null
        /// </exception>
        public static decimal NextDecimal(this Random random) =>
            random is null
                ? throw new ArgumentNullException(nameof(random))
                : (decimal)random.NextDouble();

        /// <summary>
        /// Returns a random decimal value between 0 (inclusive) and <paramref name="max"/>
        /// (exclusive)
        /// </summary>
        /// <param name="random"><see cref="Random"/> instance to use</param>
        /// <param name="max">Maximal value (exclusive)</param>
        /// <returns>Random float value from [0, max)</returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="random"/> is null
        /// </exception>
        public static decimal NextDecimal(this Random random, decimal max) {
            if (random is null) {
                throw new ArgumentNullException(nameof(random));
            }
            if (max <= 0) {
                throw new ArgumentOutOfRangeException(
                    nameof(max),
                    max,
                    "Maximum must be positive."
                );
            }
            return (decimal)random.NextDouble() * max;
        }

        /// <summary>
        /// Returns a random decimal value between <paramref name="min"/> (inclusive) and
        /// <paramref name="max"/> (exclusive)
        /// </summary>
        /// <param name="random"><see cref="Random"/> instance to use</param>
        /// <param name="min">Minimal value (inclusive)</param>
        /// <param name="max">Maximal value (exclusive)</param>
        /// <returns>Random float value from [min, max)</returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="random"/> is null
        /// </exception>
        public static decimal NextDecimal(this Random random, decimal min, decimal max) {
            if (random is null) {
                throw new ArgumentNullException(nameof(random));
            }
            if (max <= min) {
                throw new ArgumentOutOfRangeException(
                    nameof(max),
                    max,
                    "Maximum must be greater tham minimum."
                );
            }
            return min + (decimal)random.NextDouble() * (max - min);
        }

        /// <summary>Returns a random byte</summary>
        /// <param name="random"><see cref="Random"/> instance to use</param>
        /// <returns>A random byte</returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="random"/> is null
        /// </exception>
        public static byte NextByte(this Random random) =>
            random is null
                ? throw new ArgumentNullException(nameof(random))
                : (byte)random.Next(256);

        /// <summary>Returns a random boolean value</summary>
        /// <param name="random"><see cref="Random"/> instance to use</param>
        /// <returns>Random boolean value</returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="random"/> is null
        /// </exception>
        public static bool NextBoolean(this Random random) =>
            random is null
                ? throw new ArgumentNullException(nameof(random))
                : random.NextDouble(2) < 0.5;

#if NET_CORE
        /// <summary>Returns a random integer from the given range</summary>
        /// <param name="random"><see cref="Random"/> instance to use</param>
        /// <param name="range">
        /// <see cref="Range"/> to return value from. From-end index can be used as a negative
        /// number
        /// </param>
        /// <returns>Integer from the given range</returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="random"/> is null
        /// </exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown when <paramref name="range"/>.End is not greater than
        /// <paramref name="range"/>.Start
        /// </exception>
        /// <example>
        /// var n = rand.Next(^2..3); // n can be any of the following: -2, -1, 0, 1, 2
        /// </example>
        public static int Next(this Random random, Range range) {
            if (random is null) {
                throw new ArgumentNullException(nameof(random));
            }
            return random.Next(
                range.Start.IsFromEnd ? -range.Start.Value : range.Start.Value,
                range.End.IsFromEnd ? -range.End.Value : range.End.Value
            );
        }
#endif

        /// <summary>Fills a given array with random non-negative integers</summary>
        /// <param name="random"><see cref="Random"/> instance to use</param>
        /// <param name="buffer">Array to fill with random values</param>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="random"/> or <paramref name="buffer"/> is null
        /// </exception>
        public static void NextInt32s(this Random random, int[] buffer) {
            if (random is null) {
                throw new ArgumentNullException(nameof(random));
            }
            if (buffer is null) {
                throw new ArgumentNullException(nameof(buffer));
            }
            for (var i = 0; i < buffer.Length; ++i) {
                buffer[i] = random.Next();
            }
        }

        /// <summary>Fills a given array with random non-negative integers</summary>
        /// <param name="random"><see cref="Random"/> instance to use</param>
        /// <param name="buffer">Array to fill with random values</param>
        /// <param name="max">Maximal value (exclusive)</param>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="random"/> or <paramref name="buffer"/> is null
        /// </exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown when <paramref name="max"/> is not positive
        /// </exception>
        public static void NextInt32s(this Random random, int[] buffer, int max) {
            if (random is null) {
                throw new ArgumentNullException(nameof(random));
            }
            if (buffer is null) {
                throw new ArgumentNullException(nameof(buffer));
            }
            if (max <= 0) {
                throw new ArgumentOutOfRangeException(
                    nameof(max),
                    max,
                    "Maximum must be positive."
                );
            }
            if (max == 1) {
                for (var i = 0; i < buffer.Length; ++i) {
                    buffer[i] = 0;
                }
            } else {
                for (var i = 0; i < buffer.Length; ++i) {
                    buffer[i] = random.Next(max);
                }
            }
        }

        /// <summary>Fills a given array with random integers from a given range</summary>
        /// <param name="random"><see cref="Random"/> instance to use</param>
        /// <param name="buffer">Array to fill with random values</param>
        /// <param name="min">Minimal value (inclusive)</param>
        /// <param name="max">Maximal value (exclusive)</param>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="random"/> or <paramref name="buffer"/> is null
        /// </exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown when <paramref name="max"/> is not greater than <paramref name="min"/>
        /// </exception>
        public static void NextInt32s(this Random random, int[] buffer, int min, int max) {
            if (random is null) {
                throw new ArgumentNullException(nameof(random));
            }
            if (buffer is null) {
                throw new ArgumentNullException(nameof(buffer));
            }
            if (max <= min) {
                throw new ArgumentOutOfRangeException(
                    nameof(max),
                    max,
                    "Maximum can't be lower than or equal to minimum."
                );
            } else if (min + 1 == max) {
                for (var i = 0; i < buffer.Length; ++i) {
                    buffer[i] = min;
                }
            } else {
                for (var i = 0; i < buffer.Length; ++i) {
                    buffer[i] = random.Next(min, max);
                }
            }
        }

#if NET_CORE
        /// <summary>Fills a given array with random integers from a given range</summary>
        /// <param name="random"><see cref="Random"/> instance to use</param>
        /// <param name="buffer">Array to fill with random values</param>
        /// <param name="range">
        /// <see cref="Range"/> to return values from. From-end index can be used as a negative
        /// number
        /// </param>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="random"/> or <paramref name="buffer"/> is null
        /// </exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown when <paramref name="range"/>.End is not greater than
        /// <paramref name="range"/>.Start
        /// </exception>
        public static void NextInt32s(this Random random, int[] buffer, Range range) =>
            NextInt32s(
                random,
                buffer,
                range.Start.IsFromEnd ? -range.Start.Value : range.Start.Value,
                range.End.IsFromEnd ? -range.End.Value : range.End.Value
            );
#endif

        /// <summary>
        /// Fills a given array with random values from between 0 (inclusive) and 1 (exclusive)
        /// </summary>
        /// <param name="random"><see cref="Random"/> instance to use</param>
        /// <param name="buffer">Array to fill with random values</param>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="random"/> or <paramref name="buffer"/> is null
        /// </exception>
        public static void NextSingles(this Random random, float[] buffer) {
            if (random is null) {
                throw new ArgumentNullException(nameof(random));
            }
            if (buffer is null) {
                throw new ArgumentNullException(nameof(buffer));
            }
            for (var i = 0; i < buffer.Length; ++i) {
                buffer[i] = (float)random.NextDouble();
            }
        }

        /// <summary>
        /// Fills a given array with random values from between 0 (inclusive) and 1 (exclusive)
        /// </summary>
        /// <param name="random"><see cref="Random"/> instance to use</param>
        /// <param name="buffer">Array to fill with random values</param>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="random"/> or <paramref name="buffer"/> is null
        /// </exception>
        public static void NextDoubles(this Random random, double[] buffer) {
            if (random is null) {
                throw new ArgumentNullException(nameof(random));
            }
            if (buffer is null) {
                throw new ArgumentNullException(nameof(buffer));
            }
            for (var i = 0; i < buffer.Length; ++i) {
                buffer[i] = random.NextDouble();
            }
        }

        /// <summary>
        /// Fills a given array with random values from between 0 (inclusive) and 1 (exclusive)
        /// </summary>
        /// <param name="random"><see cref="Random"/> instance to use</param>
        /// <param name="buffer">Array to fill with random values</param>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="random"/> or <paramref name="buffer"/> is null
        /// </exception>
        public static void NextDecimals(this Random random, decimal[] buffer) {
            if (random is null) {
                throw new ArgumentNullException(nameof(random));
            }
            if (buffer is null) {
                throw new ArgumentNullException(nameof(buffer));
            }
            for (var i = 0; i < buffer.Length; ++i) {
                buffer[i] = (decimal)random.NextDouble();
            }
        }

        /// <summary>Creates an array with random bytes</summary>
        /// <param name="random"><see cref="Random"/> instance to use</param>
        /// <param name="count">Length of the generated array</param>
        /// <returns>Array with given length filled with random values</returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="random"/> is null
        /// </exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown when <paramref name="count"/> is negative
        /// </exception>
        public static byte[] NextBytes(this Random random, int count) {
            if (random is null) {
                throw new ArgumentNullException(nameof(random));
            }
            if (count < 0) {
                throw new ArgumentOutOfRangeException(
                    nameof(count),
                    count,
                    "Array size can't be negative."
                );
            } else if (count == 0) {
                return Array.Empty<byte>();
            }
            var buffer = new byte[count];
            random.NextBytes(buffer);
            return buffer;
        }

        /// <summary>Creates an array with random non-negative integers</summary>
        /// <param name="random"><see cref="Random"/> instance to use</param>
        /// <param name="count">Length of the generated array</param>
        /// <returns>Array with given length filled with random values</returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="random"/> is null
        /// </exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown when <paramref name="count"/> is negative
        /// </exception>
        public static int[] NextInt32s(this Random random, int count) {
            if (random is null) {
                throw new ArgumentNullException(nameof(random));
            }
            if (count < 0) {
                throw new ArgumentOutOfRangeException(
                    nameof(count),
                    count,
                    "Array size can't be negative."
                );
            } else if (count == 0) {
                return Array.Empty<int>();
            }
            var buffer = new int[count];
            for (var i = 0; i < buffer.Length; ++i) {
                buffer[i] = random.Next();
            }
            return buffer;
        }

        /// <summary>Creates an array with random non-negative integers</summary>
        /// <param name="random"><see cref="Random"/> instance to use</param>
        /// <param name="count">Length of the generated array</param>
        /// <param name="max">Maximal value (exclusive)</param>
        /// <returns>Array with given length filled with random values</returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="random"/> is null
        /// </exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown when <paramref name="count"/> is negative or <paramref name="max"/> is not
        /// positive
        /// </exception>
        public static int[] NextInt32s(this Random random, int count, int max) {
            if (random is null) {
                throw new ArgumentNullException(nameof(random));
            }
            if (max <= 0) {
                throw new ArgumentOutOfRangeException(
                    nameof(max),
                    max,
                    "Maximum must be positive."
                );
            }
            if (count < 0) {
                throw new ArgumentOutOfRangeException(
                    nameof(count),
                    count,
                    "Array size can't be negative."
                );
            } else if (count == 0) {
                return Array.Empty<int>();
            }
            var buffer = new int[count];
            if (max == 1) {
                for (var i = 0; i < buffer.Length; ++i) {
                    buffer[i] = 0;
                }
            } else {
                for (var i = 0; i < buffer.Length; ++i) {
                    buffer[i] = random.Next(max);
                }
            }
            return buffer;
        }

        /// <summary>Creates an array with random integers from a given range</summary>
        /// <param name="random"><see cref="Random"/> instance to use</param>
        /// <param name="count">Length of the generated array</param>
        /// <param name="min">Minimal value (inclusive)</param>
        /// <param name="max">Maximal value (exclusive)</param>
        /// <returns>Array with given length filled with random values</returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="random"/> is null
        /// </exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown when <paramref name="count"/> is negative or <paramref name="max"/> is not
        /// greater than <paramref name="min"/>
        /// </exception>
        public static int[] NextInt32s(this Random random, int count, int min, int max) {
            if (random is null) {
                throw new ArgumentNullException(nameof(random));
            }
            if (max <= min) {
                throw new ArgumentOutOfRangeException(
                    nameof(max),
                    max,
                    "Maximum can't be lower than or equal to minimum."
                );
            }
            if (count < 0) {
                throw new ArgumentOutOfRangeException(
                    nameof(count),
                    count,
                    "Array size can't be negative."
                );
            } else if (count == 0) {
                return Array.Empty<int>();
            }
            var buffer = new int[count];
            if (min + 1 == max) {
                for (var i = 0; i < buffer.Length; ++i) {
                    buffer[i] = min;
                }
            } else {
                for (var i = 0; i < buffer.Length; ++i) {
                    buffer[i] = random.Next(min, max);
                }
            }
            return buffer;
        }

#if NET_CORE
        /// <summary>Creates an array with random integers from a given range</summary>
        /// <param name="random"><see cref="Random"/> instance to use</param>
        /// <param name="count">Length of the generated array</param>
        /// <param name="range">
        /// <see cref="Range"/> to return values from. From-end index can be used as a negative
        /// number
        /// </param>
        /// <returns>Array with given length filled with random values</returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="random"/> is null
        /// </exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown when <paramref name="count"/> is negative or <paramref name="range"/>.End is not
        /// greater than <paramref name="range"/>.Start
        /// </exception>
        public static int[] NextInt32s(this Random random, int count, Range range) =>
            NextInt32s(
                random,
                count,
                range.Start.IsFromEnd ? -range.Start.Value : range.Start.Value,
                range.End.IsFromEnd ? -range.End.Value : range.End.Value
            );
#endif

        /// <summary>
        /// Creates an array with random values between 0 (inclusive) and 1 (exclusive)
        /// </summary>
        /// <param name="random"><see cref="Random"/> instance to use</param>
        /// <param name="count">Length of the generated array</param>
        /// <returns>Array with given length filled with random values</returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="random"/> is null
        /// </exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown when <paramref name="count"/> is negative
        /// </exception>
        public static float[] NextSingles(this Random random, int count) {
            if (random is null) {
                throw new ArgumentNullException(nameof(random));
            }
            if (count < 0) {
                throw new ArgumentOutOfRangeException(
                    nameof(count),
                    count,
                    "Array size can't be negative."
                );
            } else if (count == 0) {
                return Array.Empty<float>();
            }
            var buffer = new float[count];
            for (var i = 0; i < buffer.Length; ++i) {
                buffer[i] = (float)random.NextDouble();
            }
            return buffer;
        }

        /// <summary>
        /// Creates an array with random values between 0 (inclusive) and 1 (exclusive)
        /// </summary>
        /// <param name="random"><see cref="Random"/> instance to use</param>
        /// <param name="count">Length of the generated array</param>
        /// <returns>Array with given length filled with random values</returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="random"/> is null
        /// </exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown when <paramref name="count"/> is negative
        /// </exception>
        public static double[] NextDoubles(this Random random, int count) {
            if (random is null) {
                throw new ArgumentNullException(nameof(random));
            }
            if (count < 0) {
                throw new ArgumentOutOfRangeException(
                    nameof(count),
                    count,
                    "Array size can't be negative."
                );
            } else if (count == 0) {
                return Array.Empty<double>();
            }
            var buffer = new double[count];
            for (var i = 0; i < buffer.Length; ++i) {
                buffer[i] = random.NextDouble();
            }
            return buffer;
        }

        /// <summary>
        /// Creates an array with random values between 0 (inclusive) and 1 (exclusive)
        /// </summary>
        /// <param name="random"><see cref="Random"/> instance to use</param>
        /// <param name="count">Length of the generated array</param>
        /// <returns>Array with given length filled with random values</returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="random"/> is null
        /// </exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown when <paramref name="count"/> is negative
        /// </exception>
        public static decimal[] NextDecimals(this Random random, int count) {
            if (random is null) {
                throw new ArgumentNullException(nameof(random));
            }
            if (count < 0) {
                throw new ArgumentOutOfRangeException(
                    nameof(count),
                    count,
                    "Array size can't be negative."
                );
            } else if (count == 0) {
                return Array.Empty<decimal>();
            }
            var buffer = new decimal[count];
            for (var i = 0; i < buffer.Length; ++i) {
                buffer[i] = (decimal)random.NextDouble();
            }
            return buffer;
        }

        /// <summary>
        /// Creates <see cref="IEnumerable{T}"/> with infinite sequence of random non-negative
        /// integers
        /// </summary>
        /// <param name="random"><see cref="Random"/> instance to use</param>
        /// <returns>
        /// Infinite <see cref="IEnumerable{T}"/> with the lazily generated sequence
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="random"/> is null
        /// </exception>
        public static IEnumerable<int> Int32Stream(this Random random) {
            if (random is null) {
                throw new ArgumentNullException(nameof(random));
            }
            while (true) {
                yield return random.Next();
            }
        }

        /// <summary>
        /// Creates <see cref="IEnumerable{T}"/> with infinite sequence of random non-negative
        /// integers
        /// </summary>
        /// <param name="random"><see cref="Random"/> instance to use</param>
        /// <param name="max">Maximal value (exclusive)</param>
        /// <returns>
        /// Infinite <see cref="IEnumerable{T}"/> with the lazily generated sequence
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="random"/> is null
        /// </exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown when <paramref name="max"/> is not positive
        /// </exception>
        public static IEnumerable<int> Int32Stream(this Random random, int max) {
            if (random is null) {
                throw new ArgumentNullException(nameof(random));
            }
            if (max <= 0) {
                throw new ArgumentOutOfRangeException(
                    nameof(max),
                    max,
                    "Maximum must be positive."
                );
            }
            if (max == 1) {
                while (true) {
                    yield return 0;
                }
            } else {
                while (true) {
                    yield return random.Next(max);
                }
            }
        }

        /// <summary>
        /// Creates <see cref="IEnumerable{T}"/> with infinite sequence of random integers from the
        /// given range
        /// </summary>
        /// <param name="random"><see cref="Random"/> instance to use</param>
        /// <param name="min">Minimal value (inclusive)</param>
        /// <param name="max">Maximal value (exclusive)</param>
        /// <returns>
        /// Infinite <see cref="IEnumerable{T}"/> with the lazily generated sequence
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="random"/> is null
        /// </exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown when <paramref name="max"/> is not greater than <paramref name="min"/>
        /// </exception>
        public static IEnumerable<int> Int32Stream(this Random random, int min, int max) {
            if (random is null) {
                throw new ArgumentNullException(nameof(random));
            }
            if (max <= min) {
                throw new ArgumentOutOfRangeException(
                    nameof(max),
                    max,
                    "Maximum can't be lower than or equal to minimum."
                );
            } else if (min + 1 == max) {
                while (true) {
                    yield return min;
                }
            } else {
                while (true) {
                    yield return random.Next(min, max);
                }
            }
        }

#if NET_CORE
        /// <summary>
        /// Creates <see cref="IEnumerable{T}"/> with infinite sequence of random integers from the
        /// given range
        /// </summary>
        /// <param name="random"><see cref="Random"/> instance to use</param>
        /// <param name="range">
        /// <see cref="Range"/> to return values from. From-end index can be used as a negative
        /// number
        /// </param>
        /// <returns>
        /// Infinite <see cref="IEnumerable{T}"/> with the lazily generated sequence
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="random"/> is null
        /// </exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown when <paramref name="range"/>.End is not greater than
        /// <paramref name="range"/>.Start
        /// </exception>
        public static IEnumerable<int> Int32Stream(this Random random, Range range) =>
            Int32Stream(
                random,
                range.Start.IsFromEnd ? -range.Start.Value : range.Start.Value,
                range.End.IsFromEnd ? -range.End.Value : range.End.Value
            );
#endif

        /// <summary>
        /// Creates <see cref="IEnumerable{T}"/> with infinite sequence of random values between 0
        /// (inclusive) and 1 (exclusive)
        /// </summary>
        /// <param name="random"><see cref="Random"/> instance to use</param>
        /// <returns>
        /// Infinite <see cref="IEnumerable{T}"/> with the lazily generated sequence
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="random"/> is null
        /// </exception>
        public static IEnumerable<float> SingleStream(this Random random) {
            if (random is null) {
                throw new ArgumentNullException(nameof(random));
            }
            while (true) {
                yield return (float)random.NextDouble();
            }
        }

        /// <summary>
        /// Creates <see cref="IEnumerable{T}"/> with infinite sequence of random values between 0
        /// (inclusive) and 1 (exclusive)
        /// </summary>
        /// <param name="random"><see cref="Random"/> instance to use</param>
        /// <returns>
        /// Infinite <see cref="IEnumerable{T}"/> with the lazily generated sequence
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="random"/> is null
        /// </exception>
        public static IEnumerable<double> DoubleStream(this Random random) {
            if (random is null) {
                throw new ArgumentNullException(nameof(random));
            }
            while (true) {
                yield return random.NextDouble();
            }
        }

        /// <summary>
        /// Creates <see cref="IEnumerable{T}"/> with infinite sequence of random values between 0
        /// (inclusive) and 1 (exclusive)
        /// </summary>
        /// <param name="random"><see cref="Random"/> instance to use</param>
        /// <returns>
        /// Infinite <see cref="IEnumerable{T}"/> with the lazily generated sequence
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="random"/> is null
        /// </exception>
        public static IEnumerable<decimal> DecimalStream(this Random random) {
            if (random is null) {
                throw new ArgumentNullException(nameof(random));
            }
            while (true) {
                yield return (decimal)random.NextDouble();
            }
        }

        /// <summary>Returns a random element from the given collection</summary>
        /// <typeparam name="T">Type of items in <paramref name="collection"/></typeparam>
        /// <param name="random"><see cref="Random"/> instance to use</param>
        /// <param name="collection">Collection to choose items from</param>
        /// <returns>Randomly chosen element from <paramref name="collection"/></returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="random"/> or <paramref name="collection"/> is null
        /// </exception>
        /// <exception cref="ArgumentException">
        /// Thrown when <paramref name="collection"/> is empty
        /// </exception>
        public static T Choice<T>(this Random random, ICollection<T> collection) {
            if (random is null) {
                throw new ArgumentNullException(nameof(random));
            }
            if (collection is null) {
                throw new ArgumentNullException(nameof(collection));
            }
            if (collection.Count == 0) {
                throw new ArgumentException("Item collection can't be empty.", nameof(collection));
            }
            return collection.ElementAt(random.Next(collection.Count));
        }

        /// <summary>Returns a random element from the given list</summary>
        /// <typeparam name="T">Type of items in <paramref name="list"/></typeparam>
        /// <param name="random"><see cref="Random"/> instance to use</param>
        /// <param name="list">List to choose from</param>
        /// <returns>Randomly chosen element from <paramref name="list"/></returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="random"/> or <paramref name="list"/> is null
        /// </exception>
        /// <exception cref="ArgumentException">
        /// Thrown when <paramref name="list"/> is empty
        /// </exception>
        public static T Choice<T>(this Random random, IList<T> list) {
            if (random is null) {
                throw new ArgumentNullException(nameof(random));
            }
            if (list is null) {
                throw new ArgumentNullException(nameof(list));
            }
            if (list.Count == 0) {
                throw new ArgumentException("Item list can't be empty.", nameof(list));
            }
            return list[random.Next(list.Count)];
        }

        /// <summary>
        /// Returns an array with random elements from the given list. Values from
        /// <paramref name="list"/> can appear multiple times in the returned array
        /// </summary>
        /// <typeparam name="T">Type of items in <paramref name="list"/></typeparam>
        /// <param name="random"><see cref="Random"/> instance to use</param>
        /// <param name="list">List to choose from</param>
        /// <param name="count">Length of the returned array</param>
        /// <returns>Array with randomly chosen elements from <paramref name="list"/></returns>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown when count is negative
        /// </exception>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="random"/> or <paramref name="list"/> is null
        /// </exception>
        /// <exception cref="ArgumentException">
        /// Thrown when <paramref name="list"/> is empty
        /// </exception>
        public static T[] Choices<T>(this Random random, IList<T> list, int count) {
            if (random is null) {
                throw new ArgumentNullException(nameof(random));
            }
            if (list is null) {
                throw new ArgumentNullException(nameof(list));
            }
            if (count < 0) {
                throw new ArgumentOutOfRangeException(
                    nameof(count),
                    count,
                    "Sample count can't be negative"
                );
            }
            if (count == 0) {
                return Array.Empty<T>();
            }
            if (list.Count == 0) {
                throw new ArgumentException("Item list can't be empty.", nameof(list));
            }
            var array = new T[count];
            if (list.Count == 1) {
                var item = list[0];
                for (var i = 0; i < array.Length; ++i) {
                    array[i] = item;
                }
            } else {
                for (var i = 0; i < count; ++i) {
                    array[i] = list[random.Next(list.Count)];
                }
            }
            return array;
        }

        /// <summary>
        /// Returns an array with random elements from the given list. Every item from
        /// <paramref name="list"/> can be only used once
        /// </summary>
        /// <param name="random"><see cref="Random"/> instance to use</param>
        /// <param name="list"><see cref="IList{T}"/> to choose from</param>
        /// <param name="count">Length of the returned array</param>
        /// <returns>Array with randomly chosen characters from <paramref name="list"/></returns>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown when count is negative or greater than the length of the input list
        /// </exception>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="random"/> or <paramref name="list"/> is null
        /// </exception>
        /// <exception cref="ArgumentException">
        /// Thrown when <paramref name="list"/> is empty
        /// </exception>
        public static T[] Sample<T>(this Random random, IList<T> list, int count) {
            if (random is null) {
                throw new ArgumentNullException(nameof(random));
            }
            if (list is null) {
                throw new ArgumentNullException(nameof(list));
            }
            if (count < 0) {
                throw new ArgumentOutOfRangeException(
                    nameof(count),
                    count,
                    "Sample count can't be negative."
                );
            } else if (count == 0) {
                return Array.Empty<T>();
            } else if (count > list.Count) {
                throw new ArgumentOutOfRangeException(
                    nameof(count),
                    count,
                    "Sample count can't be greater than input list length."
                );
            }
            var src = new T[list.Count];
            for (var i = 0; i < src.Length; ++i) {
                src[i] = list[i];
            }
            if (count == list.Count) {
                Shuffle(random, src);
                return src;
            }
            var array = new T[count];
            for (int i = 0, j = list.Count - 1; i < count; ++i, --j) {
                var k = random.Next(j + 1);
                array[i] = src[k];
                if (k != j) {
                    src[k] = src[j];
                }
            }
            return array;
        }

        /// <summary>
        /// Creates <see cref="IEnumerable{T}"/> with infinite sequence of randomly chosen elements
        /// from <paramref name="list"/>
        /// </summary>
        /// <param name="random"><see cref="Random"/> instance to use</param>
        /// <param name="list"><see cref="IList{T}"/> to choose items from</param>
        /// <returns>
        /// Infinite <see cref="IEnumerable{T}"/> with the lazily generated sequence
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="random"/> or <paramref name="list"/> is null
        /// </exception>
        /// <exception cref="ArgumentException">
        /// Thrown when <paramref name="list"/> is empty
        /// </exception>
        public static IEnumerable<T> ChoiceStream<T>(this Random random, IList<T> list) {
            if (random is null) {
                throw new ArgumentNullException(nameof(random));
            }
            if (list is null) {
                throw new ArgumentNullException(nameof(list));
            }
            switch (list.Count) {
                case 0: throw new ArgumentException("Item list can't be empty.", nameof(list));
                case 1:
                    var item = list[0];
                    while (true) {
                        yield return item;
                    }
                default:
                    while (true) {
                        yield return list[random.Next(list.Count)];
                    }
            }
        }

        /// <summary>Returns a random character from the given string</summary>
        /// <param name="random"><see cref="Random"/> instance to use</param>
        /// <param name="str">String to choose from</param>
        /// <returns>Randomly chosen character from <paramref name="str"/></returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="random"/> or <paramref name="str"/> is null
        /// </exception>
        /// <exception cref="ArgumentException">
        /// Thrown when <paramref name="str"/> is empty
        /// </exception>
        public static char Choice(this Random random, string str) {
            if (random is null) {
                throw new ArgumentNullException(nameof(random));
            }
            if (str is null) {
                throw new ArgumentNullException(nameof(str));
            }
            if (str.Length == 0) {
                throw new ArgumentException("Input string can't be empty.", nameof(str));
            }
            return str[random.Next(str.Length)];
        }

        /// <summary>
        /// Returns an array with random characters from the given string. Characters from
        /// <paramref name="str"/> can appear multiple times in the returned array
        /// </summary>
        /// <param name="random"><see cref="Random"/> instance to use</param>
        /// <param name="str">String to choose from</param>
        /// <param name="count">Length of the returned array</param>
        /// <returns>Array with randomly chosen characters from <paramref name="str"/></returns>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown when count is negative
        /// </exception>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="random"/> or <paramref name="str"/> is null
        /// </exception>
        /// <exception cref="ArgumentException">
        /// Thrown when <paramref name="str"/> is empty
        /// </exception>
        public static char[] Choices(this Random random, string str, int count) {
            if (random is null) {
                throw new ArgumentNullException(nameof(random));
            }
            if (str is null) {
                throw new ArgumentNullException(nameof(str));
            }
            if (count < 0) {
                throw new ArgumentOutOfRangeException(
                    nameof(count),
                    count,
                    "Sample count can't be negative"
                );
            }
            if (count == 0) {
                return Array.Empty<char>();
            }
            if (str.Length == 0) {
                throw new ArgumentException("Input string can't be empty.", nameof(str));
            }
            var array = new char[count];
            if (str.Length == 1) {
                var ch = str[0];
                for (var i = 0; i < array.Length; ++i) {
                    array[i] = ch;
                }
            } else {
                for (var i = 0; i < count; ++i) {
                    array[i] = str[random.Next(str.Length)];
                }
            }
            return array;
        }

        /// <summary>
        /// Creates <see cref="IEnumerable{T}"/> with infinite sequence of randomly chosen
        /// characters from <paramref name="str"/>
        /// </summary>
        /// <param name="random"><see cref="Random"/> instance to use</param>
        /// <param name="str">String to choose from</param>
        /// <returns>
        /// Infinite <see cref="IEnumerable{T}"/> with the lazily generated sequence
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="random"/> or <paramref name="str"/> is null
        /// </exception>
        /// <exception cref="ArgumentException">
        /// Thrown when <paramref name="str"/> is empty
        /// </exception>
        public static IEnumerable<char> ChoiceStream(this Random random, string str) {
            if (random is null) {
                throw new ArgumentNullException(nameof(random));
            }
            if (str is null) {
                throw new ArgumentNullException(nameof(str));
            }
            switch (str.Length) {
                case 0: throw new ArgumentException("Item collection can't be empty.", nameof(str));
                case 1:
                    var c = str[0];
                    while (true) {
                        yield return c;
                    }
                default:
                    while (true) {
                        yield return str[random.Next(str.Length)];
                    }
            }
        }

        /// <summary>
        /// Returns an array with random characters from the given string. Every character from
        /// <paramref name="str"/> can be only used once
        /// </summary>
        /// <param name="random"><see cref="Random"/> instance to use</param>
        /// <param name="str">String to choose from</param>
        /// <param name="count">Length of the returned array</param>
        /// <returns>Array with randomly chosen characters from <paramref name="str"/></returns>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown when count is negative or greater than the length of the input string
        /// </exception>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="random"/> or <paramref name="str"/> is null
        /// </exception>
        public static char[] Sample(this Random random, string str, int count) {
            if (random is null) {
                throw new ArgumentNullException(nameof(random));
            }
            if (str is null) {
                throw new ArgumentNullException(nameof(str));
            }
            if (count < 0) {
                throw new ArgumentOutOfRangeException(
                    nameof(count),
                    count,
                    "Sample count can't be negative."
                );
            } else if (count == 0) {
                return Array.Empty<char>();
            } else if (count > str.Length) {
                throw new ArgumentOutOfRangeException(
                    nameof(count),
                    count,
                    "Sample count can't be greater than input string length."
                );
            }
            var src = str.ToCharArray();
            if (count == str.Length) {
                Shuffle(random, src);
                return src;
            }
            var array = new char[count];
            for (int i = 0, j = str.Length - 1; i < count; ++i, --j) {
                var k = random.Next(j + 1);
                array[i] = src[k];
                if (k != j) {
                    src[k] = src[j];
                }
            }
            return array;
        }

        /// <summary>Randomly shuffles items in <paramref name="list"/></summary>
        /// <typeparam name="T">Type of items in <paramref name="list"/></typeparam>
        /// <param name="random"><see cref="Random"/> instance to use</param>
        /// <param name="list"><see cref="IList{T}"/> to shuffle</param>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="random"/> or <paramref name="list"/> is null
        /// </exception>
        public static void Shuffle<T>(this Random random, IList<T> list) {
            if (random is null) {
                throw new ArgumentNullException(nameof(random));
            }
            if (list is null) {
                throw new ArgumentNullException(nameof(list));
            }
            if (list.Count == 2) {
                if (random.Next(2) == 0) {
                    var buf = list[0];
                    list[0] = list[1];
                    list[1] = buf;
                }
            } else if (list.Count > 2) {
                for (var i = list.Count - 1; i > 0; --i) {
                    var j = random.Next(i + 1);
                    if (i != j) {
                        var buf = list[i];
                        list[i] = list[j];
                        list[j] = buf;
                    }
                }
            }
        }

        /// <summary>
        /// Returns a copy of <paramref name="list"/> with randomly shuffled items
        /// </summary>
        /// <typeparam name="T">Type of items in <paramref name="list"/></typeparam>
        /// <param name="random"><see cref="Random"/> instance to use</param>
        /// <param name="list"><see cref="IList{T}"/> to copy and shuffle</param>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="random"/> or <paramref name="list"/> is null
        /// </exception>
        public static T[] ShuffleCopy<T>(this Random random, IList<T> list) {
            if (random is null) {
                throw new ArgumentNullException(nameof(random));
            }
            if (list is null) {
                throw new ArgumentNullException(nameof(list));
            }
            switch (list.Count) {
                case 0: return Array.Empty<T>();
                case 1: return new[] { list[0] };
                default:
                    var copy = new T[list.Count];
                    for (var i = 0; i < copy.Length; ++i) {
                        copy[i] = list[i];
                    }
                    Shuffle(random, copy);
                    return copy;
            }
        }
    }
}
