using System;
using System.Collections.Generic;

// GENERATED CODE - DO NOT MODIFY

namespace Netxtendable.Collections {

    /// <summary>Class with extension methods for <see cref="IList{T}"/></summary>
    public static class IListExtensions {

        /// <summary>Extracts first 2 values from <paramref name="list"/>.</summary>
        /// <typeparam name="T">Type of items in <paramref name="list"/>.</typeparam>
        /// <param name="list">List to deconstruct.</param>
        /// <param name="item1">First output item.</param>
        /// <param name="item2">Second output item.</param>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="list"/> is null.
        /// </exception>
        /// <exception cref="InvalidOperationException">
        /// Thrown when <paramref name="list"/> does not have enought items.
        /// </exception>
        public static void Deconstruct<T>(
            this IList<T> list,
            out T item1,
            out T item2
        ) {
            if (list is null) {
                throw new ArgumentNullException(nameof(list));
            } else if (list.Count < 2) {
                throw new InvalidOperationException(
                    $"At least 2 items were expected, {list.Count} were found.");
            }
            item1 = list[0];
            item2 = list[1];
        }

        /// <summary>Extracts first 3 values from <paramref name="list"/>.</summary>
        /// <typeparam name="T">Type of items in <paramref name="list"/>.</typeparam>
        /// <param name="list">List to deconstruct.</param>
        /// <param name="item1">First output item.</param>
        /// <param name="item2">Second output item.</param>
        /// <param name="item3">Third output item.</param>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="list"/> is null.
        /// </exception>
        /// <exception cref="InvalidOperationException">
        /// Thrown when <paramref name="list"/> does not have enought items.
        /// </exception>
        public static void Deconstruct<T>(
            this IList<T> list,
            out T item1,
            out T item2,
            out T item3
        ) {
            if (list is null) {
                throw new ArgumentNullException(nameof(list));
            } else if (list.Count < 3) {
                throw new InvalidOperationException(
                    $"At least 3 items were expected, {list.Count} were found.");
            }
            item1 = list[0];
            item2 = list[1];
            item3 = list[2];
        }

        /// <summary>Extracts first 4 values from <paramref name="list"/>.</summary>
        /// <typeparam name="T">Type of items in <paramref name="list"/>.</typeparam>
        /// <param name="list">List to deconstruct.</param>
        /// <param name="item1">First output item.</param>
        /// <param name="item2">Second output item.</param>
        /// <param name="item3">Third output item.</param>
        /// <param name="item4">Fourth output item.</param>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="list"/> is null.
        /// </exception>
        /// <exception cref="InvalidOperationException">
        /// Thrown when <paramref name="list"/> does not have enought items.
        /// </exception>
        public static void Deconstruct<T>(
            this IList<T> list,
            out T item1,
            out T item2,
            out T item3,
            out T item4
        ) {
            if (list is null) {
                throw new ArgumentNullException(nameof(list));
            } else if (list.Count < 4) {
                throw new InvalidOperationException(
                    $"At least 4 items were expected, {list.Count} were found.");
            }
            item1 = list[0];
            item2 = list[1];
            item3 = list[2];
            item4 = list[3];
        }

        /// <summary>Extracts first 5 values from <paramref name="list"/>.</summary>
        /// <typeparam name="T">Type of items in <paramref name="list"/>.</typeparam>
        /// <param name="list">List to deconstruct.</param>
        /// <param name="item1">First output item.</param>
        /// <param name="item2">Second output item.</param>
        /// <param name="item3">Third output item.</param>
        /// <param name="item4">Fourth output item.</param>
        /// <param name="item5">Fifth output item.</param>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="list"/> is null.
        /// </exception>
        /// <exception cref="InvalidOperationException">
        /// Thrown when <paramref name="list"/> does not have enought items.
        /// </exception>
        public static void Deconstruct<T>(
            this IList<T> list,
            out T item1,
            out T item2,
            out T item3,
            out T item4,
            out T item5
        ) {
            if (list is null) {
                throw new ArgumentNullException(nameof(list));
            } else if (list.Count < 5) {
                throw new InvalidOperationException(
                    $"At least 5 items were expected, {list.Count} were found.");
            }
            item1 = list[0];
            item2 = list[1];
            item3 = list[2];
            item4 = list[3];
            item5 = list[4];
        }

        /// <summary>Extracts first 6 values from <paramref name="list"/>.</summary>
        /// <typeparam name="T">Type of items in <paramref name="list"/>.</typeparam>
        /// <param name="list">List to deconstruct.</param>
        /// <param name="item1">First output item.</param>
        /// <param name="item2">Second output item.</param>
        /// <param name="item3">Third output item.</param>
        /// <param name="item4">Fourth output item.</param>
        /// <param name="item5">Fifth output item.</param>
        /// <param name="item6">Sixth output item.</param>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="list"/> is null.
        /// </exception>
        /// <exception cref="InvalidOperationException">
        /// Thrown when <paramref name="list"/> does not have enought items.
        /// </exception>
        public static void Deconstruct<T>(
            this IList<T> list,
            out T item1,
            out T item2,
            out T item3,
            out T item4,
            out T item5,
            out T item6
        ) {
            if (list is null) {
                throw new ArgumentNullException(nameof(list));
            } else if (list.Count < 6) {
                throw new InvalidOperationException(
                    $"At least 6 items were expected, {list.Count} were found.");
            }
            item1 = list[0];
            item2 = list[1];
            item3 = list[2];
            item4 = list[3];
            item5 = list[4];
            item6 = list[5];
        }

        /// <summary>Extracts first 7 values from <paramref name="list"/>.</summary>
        /// <typeparam name="T">Type of items in <paramref name="list"/>.</typeparam>
        /// <param name="list">List to deconstruct.</param>
        /// <param name="item1">First output item.</param>
        /// <param name="item2">Second output item.</param>
        /// <param name="item3">Third output item.</param>
        /// <param name="item4">Fourth output item.</param>
        /// <param name="item5">Fifth output item.</param>
        /// <param name="item6">Sixth output item.</param>
        /// <param name="item7">Seventh output item.</param>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="list"/> is null.
        /// </exception>
        /// <exception cref="InvalidOperationException">
        /// Thrown when <paramref name="list"/> does not have enought items.
        /// </exception>
        public static void Deconstruct<T>(
            this IList<T> list,
            out T item1,
            out T item2,
            out T item3,
            out T item4,
            out T item5,
            out T item6,
            out T item7
        ) {
            if (list is null) {
                throw new ArgumentNullException(nameof(list));
            } else if (list.Count < 7) {
                throw new InvalidOperationException(
                    $"At least 7 items were expected, {list.Count} were found.");
            }
            item1 = list[0];
            item2 = list[1];
            item3 = list[2];
            item4 = list[3];
            item5 = list[4];
            item6 = list[5];
            item7 = list[6];
        }

    }

}
