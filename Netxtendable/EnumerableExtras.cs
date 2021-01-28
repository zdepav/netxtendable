using System;
using System.Collections.Generic;

namespace Netxtendable {

    /// <summary>Class with generic method that create various enumerables</summary>
    public static class EnumerableExtras {

        /// <summary>
        /// Creates <see cref="IEnumerable{T}"/> with infinite sequence consisting of values
        /// returned by <paramref name="generator"/>
        /// </summary>
        /// <typeparam name="T">Type of the values</typeparam>
        /// <param name="generator">Function used to generate values in the sequence</param>
        /// <returns>
        /// Infinite <see cref="IEnumerable{T}"/> with the lazily generated sequence
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="generator"/> is null
        /// </exception>
        /// <example><code>
        /// var random = new Random();
        /// var values = EnumerableExtras
        ///     .Generate(() => random.Next(100))
        ///     .Take(10)
        ///     .ToList();
        /// </code></example>
        public static IEnumerable<T> Generate<T>(Func<T> generator) {
            if (generator is null) {
                throw new ArgumentNullException(nameof(generator));
            }
            while (true) {
                yield return generator();
            }
        }

        /// <summary>
        /// Creates <see cref="IEnumerable{T}"/> with infinite sequence starting with
        /// <paramref name="seed"/> with following values generated from previous one using
        /// <paramref name="generator"/>
        /// </summary>
        /// <typeparam name="T">Type of the values</typeparam>
        /// <param name="seed">First value of the generated sequence</param>
        /// <param name="generator">Function used to generate values in the sequence</param>
        /// <returns>
        /// Infinite <see cref="IEnumerable{T}"/> with the lazily generated sequence
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="generator"/> is null
        /// </exception>
        /// <example><code>
        /// var collatzConjecture = EnumerableExtras
        ///     .Generate(27, n => n % 2 == 0 ? n / 2 : 3 * n + 1)
        ///     .TakeWhile(n => n != 1)
        ///     .ToList();
        /// </code></example>
        public static IEnumerable<T> Generate<T>(T seed, Func<T, T> generator) {
            if (generator is null) {
                throw new ArgumentNullException(nameof(generator));
            }
            yield return seed;
            while (true) {
                yield return seed = generator(seed);
            }
        }

        /// <summary>
        /// Creates <see cref="IEnumerable{T}"/> with infinite sequence starting with
        /// <paramref name="seed1"/> and <paramref name="seed2"/> with following values generated
        /// from previous ones using <paramref name="generator"/>
        /// </summary>
        /// <typeparam name="T">Type of the values</typeparam>
        /// <param name="seed1">First value of the generated sequence</param>
        /// <param name="seed2">Second value of the generated sequence</param>
        /// <param name="generator">Function used to generate values in the sequence</param>
        /// <returns>
        /// Infinite <see cref="IEnumerable{T}"/> with the lazily generated sequence
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="generator"/> is null
        /// </exception>
        /// <example><code>
        /// var fibonacci = EnumerableExtras
        ///     .Generate(0, 1, (a, b) => a + b)
        ///     .Take(25)
        ///     .ToList();
        /// </code></example>
        public static IEnumerable<T> Generate<T>(T seed1, T seed2, Func<T, T, T> generator) {
            if (generator is null) {
                throw new ArgumentNullException(nameof(generator));
            }
            yield return seed1;
            yield return seed2;
            while (true) {
                var newValue = generator(seed1, seed2);
                yield return newValue;
                seed1 = seed2;
                seed2 = newValue;
            }
        }

        /// <summary>
        /// Creates <see cref="IEnumerable{T}"/> with infinite sequence starting with
        /// <paramref name="seed1"/>, <paramref name="seed2"/> and <paramref name="seed3"/> with
        /// following values generated from previous ones using <paramref name="generator"/>
        /// </summary>
        /// <typeparam name="T">Type of the values</typeparam>
        /// <param name="seed1">First value of the generated sequence</param>
        /// <param name="seed2">Second value of the generated sequence</param>
        /// <param name="seed3">Third value of the generated sequence</param>
        /// <param name="generator">Function used to generate values in the sequence</param>
        /// <returns>
        /// Infinite <see cref="IEnumerable{T}"/> with the lazily generated sequence
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="generator"/> is null
        /// </exception>
        /// <example><code>
        /// var fibonacci = EnumerableExtras
        ///     .Generate(0, 1, 1, (a, b, c) => a + b - c)
        ///     .Take(20)
        ///     .ToArray()
        /// </code></example>
        public static IEnumerable<T> Generate<T>(
            T seed1,
            T seed2,
            T seed3,
            Func<T, T, T, T> generator
        ) {
            if (generator is null) {
                throw new ArgumentNullException(nameof(generator));
            }
            yield return seed1;
            yield return seed2;
            yield return seed3;
            while (true) {
                var newValue = generator(seed1, seed2, seed3);
                yield return newValue;
                seed1 = seed2;
                seed2 = seed3;
                seed3 = newValue;
            }
        }

        /// <summary>
        /// Creates <see cref="IEnumerable{T}"/> that contains only <paramref name="value"/>
        /// </summary>
        /// <typeparam name="T">Type of the value</typeparam>
        /// <param name="value">Value to use</param>
        /// <returns>
        /// <see cref="IEnumerable{T}"/> that contains only <paramref name="value"/>
        /// </returns>
        public static IEnumerable<T> One<T>(T value) {
            yield return value;
        }

        /// <summary>
        /// Creates <see cref="IEnumerable{T}"/> that infinitely repeats <paramref name="value"/>
        /// </summary>
        /// <typeparam name="T">Type of the value</typeparam>
        /// <param name="value">Value to use</param>
        /// <returns>
        /// <see cref="IEnumerable{T}"/> that infinitely repeats <paramref name="value"/>
        /// </returns>
        public static IEnumerable<T> Repeat<T>(T value) {
            while (true) {
                yield return value;
            }
        }
    }
}
