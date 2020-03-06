using System;
using System.Collections.Generic;

// GENERATED CODE - DO NOT MODIFY

namespace Netxtendable.Collections {

    /// <summary>Class with extension methods for <see cref="IEnumerable{T}"/></summary>
    public static partial class IEnumerableExtensions {

        /// <summary>Extracts first 2 values from <paramref name="enumerable"/>.</summary>
        /// <typeparam name="T">Type of items in <paramref name="enumerable"/>.</typeparam>
        /// <param name="enumerable"><see cref="IEnumerable{T}"/> to deconstruct.</param>
        /// <param name="item1">First output item.</param>
        /// <param name="item2">Second output item.</param>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="enumerable"/> is null.
        /// </exception>
        /// <exception cref="InvalidOperationException">
        /// Thrown when <paramref name="enumerable"/> does not have enought items.
        /// </exception>
        public static void Deconstruct<T>(
            this IEnumerable<T> enumerable,
            out T item1,
            out T item2
        ) {
            if (enumerable is null) {
                throw new ArgumentNullException(nameof(enumerable));
            }
            using var enumerator = enumerable.GetEnumerator();
            item1 = enumerator.MoveNext()
                ? enumerator.Current
                : throw new InvalidOperationException(
                    "At least 2 items were expected, 0 were found.");
            item2 = enumerator.MoveNext()
                ? enumerator.Current
                : throw new InvalidOperationException(
                    "At least 2 items were expected, 1 were found.");
        }

        /// <summary>Extracts first 3 values from <paramref name="enumerable"/>.</summary>
        /// <typeparam name="T">Type of items in <paramref name="enumerable"/>.</typeparam>
        /// <param name="enumerable"><see cref="IEnumerable{T}"/> to deconstruct.</param>
        /// <param name="item1">First output item.</param>
        /// <param name="item2">Second output item.</param>
        /// <param name="item3">Third output item.</param>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="enumerable"/> is null.
        /// </exception>
        /// <exception cref="InvalidOperationException">
        /// Thrown when <paramref name="enumerable"/> does not have enought items.
        /// </exception>
        public static void Deconstruct<T>(
            this IEnumerable<T> enumerable,
            out T item1,
            out T item2,
            out T item3
        ) {
            if (enumerable is null) {
                throw new ArgumentNullException(nameof(enumerable));
            }
            using var enumerator = enumerable.GetEnumerator();
            item1 = enumerator.MoveNext()
                ? enumerator.Current
                : throw new InvalidOperationException(
                    "At least 3 items were expected, 0 were found.");
            item2 = enumerator.MoveNext()
                ? enumerator.Current
                : throw new InvalidOperationException(
                    "At least 3 items were expected, 1 were found.");
            item3 = enumerator.MoveNext()
                ? enumerator.Current
                : throw new InvalidOperationException(
                    "At least 3 items were expected, 2 were found.");
        }

        /// <summary>Extracts first 4 values from <paramref name="enumerable"/>.</summary>
        /// <typeparam name="T">Type of items in <paramref name="enumerable"/>.</typeparam>
        /// <param name="enumerable"><see cref="IEnumerable{T}"/> to deconstruct.</param>
        /// <param name="item1">First output item.</param>
        /// <param name="item2">Second output item.</param>
        /// <param name="item3">Third output item.</param>
        /// <param name="item4">Fourth output item.</param>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="enumerable"/> is null.
        /// </exception>
        /// <exception cref="InvalidOperationException">
        /// Thrown when <paramref name="enumerable"/> does not have enought items.
        /// </exception>
        public static void Deconstruct<T>(
            this IEnumerable<T> enumerable,
            out T item1,
            out T item2,
            out T item3,
            out T item4
        ) {
            if (enumerable is null) {
                throw new ArgumentNullException(nameof(enumerable));
            }
            using var enumerator = enumerable.GetEnumerator();
            item1 = enumerator.MoveNext()
                ? enumerator.Current
                : throw new InvalidOperationException(
                    "At least 4 items were expected, 0 were found.");
            item2 = enumerator.MoveNext()
                ? enumerator.Current
                : throw new InvalidOperationException(
                    "At least 4 items were expected, 1 were found.");
            item3 = enumerator.MoveNext()
                ? enumerator.Current
                : throw new InvalidOperationException(
                    "At least 4 items were expected, 2 were found.");
            item4 = enumerator.MoveNext()
                ? enumerator.Current
                : throw new InvalidOperationException(
                    "At least 4 items were expected, 3 were found.");
        }

        /// <summary>Extracts first 5 values from <paramref name="enumerable"/>.</summary>
        /// <typeparam name="T">Type of items in <paramref name="enumerable"/>.</typeparam>
        /// <param name="enumerable"><see cref="IEnumerable{T}"/> to deconstruct.</param>
        /// <param name="item1">First output item.</param>
        /// <param name="item2">Second output item.</param>
        /// <param name="item3">Third output item.</param>
        /// <param name="item4">Fourth output item.</param>
        /// <param name="item5">Fifth output item.</param>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="enumerable"/> is null.
        /// </exception>
        /// <exception cref="InvalidOperationException">
        /// Thrown when <paramref name="enumerable"/> does not have enought items.
        /// </exception>
        public static void Deconstruct<T>(
            this IEnumerable<T> enumerable,
            out T item1,
            out T item2,
            out T item3,
            out T item4,
            out T item5
        ) {
            if (enumerable is null) {
                throw new ArgumentNullException(nameof(enumerable));
            }
            using var enumerator = enumerable.GetEnumerator();
            item1 = enumerator.MoveNext()
                ? enumerator.Current
                : throw new InvalidOperationException(
                    "At least 5 items were expected, 0 were found.");
            item2 = enumerator.MoveNext()
                ? enumerator.Current
                : throw new InvalidOperationException(
                    "At least 5 items were expected, 1 were found.");
            item3 = enumerator.MoveNext()
                ? enumerator.Current
                : throw new InvalidOperationException(
                    "At least 5 items were expected, 2 were found.");
            item4 = enumerator.MoveNext()
                ? enumerator.Current
                : throw new InvalidOperationException(
                    "At least 5 items were expected, 3 were found.");
            item5 = enumerator.MoveNext()
                ? enumerator.Current
                : throw new InvalidOperationException(
                    "At least 5 items were expected, 4 were found.");
        }

        /// <summary>Extracts first 6 values from <paramref name="enumerable"/>.</summary>
        /// <typeparam name="T">Type of items in <paramref name="enumerable"/>.</typeparam>
        /// <param name="enumerable"><see cref="IEnumerable{T}"/> to deconstruct.</param>
        /// <param name="item1">First output item.</param>
        /// <param name="item2">Second output item.</param>
        /// <param name="item3">Third output item.</param>
        /// <param name="item4">Fourth output item.</param>
        /// <param name="item5">Fifth output item.</param>
        /// <param name="item6">Sixth output item.</param>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="enumerable"/> is null.
        /// </exception>
        /// <exception cref="InvalidOperationException">
        /// Thrown when <paramref name="enumerable"/> does not have enought items.
        /// </exception>
        public static void Deconstruct<T>(
            this IEnumerable<T> enumerable,
            out T item1,
            out T item2,
            out T item3,
            out T item4,
            out T item5,
            out T item6
        ) {
            if (enumerable is null) {
                throw new ArgumentNullException(nameof(enumerable));
            }
            using var enumerator = enumerable.GetEnumerator();
            item1 = enumerator.MoveNext()
                ? enumerator.Current
                : throw new InvalidOperationException(
                    "At least 6 items were expected, 0 were found.");
            item2 = enumerator.MoveNext()
                ? enumerator.Current
                : throw new InvalidOperationException(
                    "At least 6 items were expected, 1 were found.");
            item3 = enumerator.MoveNext()
                ? enumerator.Current
                : throw new InvalidOperationException(
                    "At least 6 items were expected, 2 were found.");
            item4 = enumerator.MoveNext()
                ? enumerator.Current
                : throw new InvalidOperationException(
                    "At least 6 items were expected, 3 were found.");
            item5 = enumerator.MoveNext()
                ? enumerator.Current
                : throw new InvalidOperationException(
                    "At least 6 items were expected, 4 were found.");
            item6 = enumerator.MoveNext()
                ? enumerator.Current
                : throw new InvalidOperationException(
                    "At least 6 items were expected, 5 were found.");
        }

        /// <summary>Extracts first 7 values from <paramref name="enumerable"/>.</summary>
        /// <typeparam name="T">Type of items in <paramref name="enumerable"/>.</typeparam>
        /// <param name="enumerable"><see cref="IEnumerable{T}"/> to deconstruct.</param>
        /// <param name="item1">First output item.</param>
        /// <param name="item2">Second output item.</param>
        /// <param name="item3">Third output item.</param>
        /// <param name="item4">Fourth output item.</param>
        /// <param name="item5">Fifth output item.</param>
        /// <param name="item6">Sixth output item.</param>
        /// <param name="item7">Seventh output item.</param>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="enumerable"/> is null.
        /// </exception>
        /// <exception cref="InvalidOperationException">
        /// Thrown when <paramref name="enumerable"/> does not have enought items.
        /// </exception>
        public static void Deconstruct<T>(
            this IEnumerable<T> enumerable,
            out T item1,
            out T item2,
            out T item3,
            out T item4,
            out T item5,
            out T item6,
            out T item7
        ) {
            if (enumerable is null) {
                throw new ArgumentNullException(nameof(enumerable));
            }
            using var enumerator = enumerable.GetEnumerator();
            item1 = enumerator.MoveNext()
                ? enumerator.Current
                : throw new InvalidOperationException(
                    "At least 7 items were expected, 0 were found.");
            item2 = enumerator.MoveNext()
                ? enumerator.Current
                : throw new InvalidOperationException(
                    "At least 7 items were expected, 1 were found.");
            item3 = enumerator.MoveNext()
                ? enumerator.Current
                : throw new InvalidOperationException(
                    "At least 7 items were expected, 2 were found.");
            item4 = enumerator.MoveNext()
                ? enumerator.Current
                : throw new InvalidOperationException(
                    "At least 7 items were expected, 3 were found.");
            item5 = enumerator.MoveNext()
                ? enumerator.Current
                : throw new InvalidOperationException(
                    "At least 7 items were expected, 4 were found.");
            item6 = enumerator.MoveNext()
                ? enumerator.Current
                : throw new InvalidOperationException(
                    "At least 7 items were expected, 5 were found.");
            item7 = enumerator.MoveNext()
                ? enumerator.Current
                : throw new InvalidOperationException(
                    "At least 7 items were expected, 6 were found.");
        }

    }

}
