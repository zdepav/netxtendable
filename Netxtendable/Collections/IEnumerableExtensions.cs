#nullable enable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Netxtendable.Collections {

    /// <summary>Class with extension methods for <see cref="IEnumerable{T}"/>.</summary>
    public static partial class IEnumerableExtensions {

        /// <summary>Calls string.Concat(<paramref name="enumerable"/>)</summary>
        /// <typeparam name="T">Type of items in <paramref name="enumerable"/>.</typeparam>
        /// <param name="enumerable"><see cref="IEnumerable{T}"/> to concat.</param>
        /// <returns>The concatenated string.</returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="enumerable"/> is null.
        /// </exception>
        public static string ConcatToString<T>(this IEnumerable<T> enumerable) =>
            string.Concat(enumerable ?? throw new ArgumentNullException(nameof(enumerable)));

        /// <summary>
        /// Calls string.Join(<paramref name="delimiter"/>, <paramref name="enumerable"/>)
        /// </summary>
        /// <typeparam name="T">Type of items in <paramref name="enumerable"/>.</typeparam>
        /// <param name="enumerable"><see cref="IEnumerable{T}"/> to join.</param>
        /// <param name="delimiter">The string to use as a separator.</param>
        /// <returns>
        /// A string that consists of items from <paramref name="enumerable"/> delimited by
        /// <paramref name="delimiter"/>.
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="enumerable"/> is null.
        /// </exception>
        public static string JoinToString<T>(this IEnumerable<T> enumerable, string delimiter) =>
            string.Join(delimiter ?? "", enumerable);

        /// <summary>
        /// Calls string.Join(<paramref name="delimiter"/>, <paramref name="enumerable"/>)
        /// </summary>
        /// <typeparam name="T">Type of items in <paramref name="enumerable"/>.</typeparam>
        /// <param name="enumerable"><see cref="IEnumerable{T}"/> to join.</param>
        /// <param name="delimiter">The string to use as a separator.</param>
        /// <returns>
        /// A string that consists of items from <paramref name="enumerable"/> delimited by
        /// <paramref name="delimiter"/>.
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="enumerable"/> is null.
        /// </exception>
        public static string JoinToString<T>(this IEnumerable<T> enumerable, char delimiter) =>
            string.Join(delimiter.ToString(), enumerable);

        /// <summary>Calls string.Join(", ", <paramref name="enumerable"/>)</summary>
        /// <typeparam name="T">Type of items in <paramref name="enumerable"/>.</typeparam>
        /// <param name="enumerable"><see cref="IEnumerable{T}"/> to join.</param>
        /// <returns>
        /// A string that consists of items from <paramref name="enumerable"/> delimited by ", ".
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="enumerable"/> is null.
        /// </exception>
        public static string JoinToString<T>(this IEnumerable<T> enumerable) =>
            string.Join(", ", enumerable);

        /// <summary>
        /// Like
        /// <see cref="Enumerable.Select{S,R}(IEnumerable{S},Func{S,R})"/>(<paramref name="enumerable"/>,
        /// <paramref name="action"/>),
        /// but only applies <paramref name="action"/> to items for which
        /// <paramref name="predicate"/> returns true (other items remain unchanged)
        /// </summary>
        /// <typeparam name="T">Type of items in <paramref name="enumerable"/>.</typeparam>
        /// <param name="enumerable"><see cref="IEnumerable{T}"/> to transform.</param>
        /// <param name="predicate">A function that chooses items to transforms.</param>
        /// <param name="action">
        /// A transform function to apply to matched <paramref name="enumerable"/> elements.
        /// </param>
        /// <returns>
        /// <see cref="IEnumerable{T}"/> whose elements are unmatched elements of
        /// <paramref name="enumerable"/> and results of invoking the transform function on matched
        /// elements of <paramref name="enumerable"/>.
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="enumerable"/>, <paramref name="predicate"/> or
        /// <paramref name="action"/> is null.
        /// </exception>
        public static IEnumerable<T> MapWhere<T>(
            this IEnumerable<T> enumerable,
            Func<T, bool> predicate,
            Func<T, T> action
        ) {
            if (predicate is null) {
                throw new ArgumentNullException(nameof(action));
            }
            if (action is null) {
                throw new ArgumentNullException(nameof(action));
            }
            return enumerable.Select(item => predicate(item) ? action(item) : item);
        }

        /// <summary>
        /// Like
        /// <see cref="Enumerable.Select{S,R}(IEnumerable{S},Func{S,int,R})"/>(<paramref name="enumerable"/>,
        /// <paramref name="action"/>),
        /// but only applies <paramref name="action"/> to items for which
        /// <paramref name="predicate"/> returns true (other items remain unchanged)
        /// </summary>
        /// <typeparam name="T">Type of items in <paramref name="enumerable"/>.</typeparam>
        /// <param name="enumerable"><see cref="IEnumerable{T}"/> to transform.</param>
        /// <param name="predicate">
        /// A function that chooses items to transforms, the second argument is the index of the
        /// item in the input sequence.
        /// </param>
        /// <param name="action">
        /// A transform function to apply to matched <paramref name="enumerable"/> elements, the
        /// second argument is the index of the item in the input sequence.
        /// </param>
        /// <returns>
        /// <see cref="IEnumerable{T}"/> whose elements are unmatched elements of
        /// <paramref name="enumerable"/> and results of invoking the transform function on matched
        /// elements of <paramref name="enumerable"/>.
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="enumerable"/>, <paramref name="predicate"/> or
        /// <paramref name="action"/> is null.
        /// </exception>
        public static IEnumerable<T> MapWhere<T>(
            this IEnumerable<T> enumerable,
            Func<T, int, bool> predicate,
            Func<T, int, T> action
        ) {
            if (predicate is null) {
                throw new ArgumentNullException(nameof(action));
            }
            if (action is null) {
                throw new ArgumentNullException(nameof(action));
            }
            return enumerable.Select((item, index) =>
                                         predicate(item, index) ? action(item, index) : item);
        }

        /// <summary>
        /// Alias for
        /// <see cref="Enumerable.Select{S,R}(IEnumerable{S},Func{S,R})"/>(<paramref name="enumerable"/>,
        /// <paramref name="action"/>)
        /// </summary>
        /// <typeparam name="T">Type of items in <paramref name="enumerable"/>.</typeparam>
        /// <typeparam name="U">
        /// The type of the return value of <paramref name="action"/>.
        /// </typeparam>
        /// <param name="enumerable"><see cref="IEnumerable{T}"/> to transform.</param>
        /// <param name="action">
        /// A transform function to apply to each item in <paramref name="enumerable"/>.
        /// </param>
        /// <returns>
        /// <see cref="IEnumerable{T}"/> whose items are returned by <paramref name="action"/> when
        /// passed items from <paramref name="enumerable"/>.
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="enumerable"/> or <paramref name="action"/> is null.
        /// </exception>
        public static IEnumerable<U> Map<T, U>(this IEnumerable<T> enumerable, Func<T, U> action) {
            if (action is null) {
                throw new ArgumentNullException(nameof(action));
            }
            return enumerable.Select(action);
        }

        /// <summary>
        /// Alias for
        /// <see cref="Enumerable.Select{S,R}(IEnumerable{S},Func{S,int,R})"/>(<paramref name="enumerable"/>,
        /// <paramref name="action"/>)
        /// </summary>
        /// <typeparam name="T">Type of items in <paramref name="enumerable"/>.</typeparam>
        /// <typeparam name="U">
        /// The type of the return value of <paramref name="action"/>.
        /// </typeparam>
        /// <param name="enumerable"><see cref="IEnumerable{T}"/> to transform.</param>
        /// <param name="action">
        /// A transform function to apply to each item in <paramref name="enumerable"/>, the second
        /// argument is the index of the item in the input sequence.
        /// </param>
        /// <returns>
        /// <see cref="IEnumerable{T}"/> whose items are returned by <paramref name="action"/> when
        /// passed items from <paramref name="enumerable"/>.
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="enumerable"/> or <paramref name="action"/> is null.
        /// </exception>
        public static IEnumerable<U> Map<T, U>(
            this IEnumerable<T> enumerable,
            Func<T, int, U> action
        ) {
            if (action is null) {
                throw new ArgumentNullException(nameof(action));
            }
            return enumerable.Select(action);
        }

        /// <summary>
        /// Splits items into two lists. Items matched by <paramref name="predicate"/> are in the
        /// first list, remaining items are in the second list
        /// </summary>
        /// <typeparam name="T">Type of items in <paramref name="enumerable"/>.</typeparam>
        /// <param name="enumerable"><see cref="IEnumerable{T}"/> to partition.</param>
        /// <param name="predicate">
        /// A function that categorizes items from the input sequence.
        /// </param>
        /// <returns>Lists with the items.</returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="enumerable"/> or <paramref name="predicate"/> is null.
        /// </exception>
        public static (List<T>, List<T>) Partition<T>(
            this IEnumerable<T> enumerable,
            Func<T, bool> predicate
        ) {
            if (enumerable is null) {
                throw new ArgumentNullException(nameof(enumerable));
            }
            if (predicate is null) {
                throw new ArgumentNullException(nameof(predicate));
            }
            var a = new List<T>();
            var b = new List<T>();
            foreach (var item in enumerable) {
                (predicate(item) ? a : b).Add(item);
            }
            return (a, b);
        }

        /// <summary>Returns true if no item matches the predicate, false otherwise</summary>
        /// <typeparam name="T">Type of items in <paramref name="enumerable"/>.</typeparam>
        /// <param name="enumerable"><see cref="IEnumerable{T}"/> to check.</param>
        /// <param name="predicate">
        /// Predicate function that will be checked against items from the input sequence.
        /// </param>
        /// <returns>true if no item matches the predicate, false otherwise</returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="enumerable"/> or <paramref name="predicate"/> is null.
        /// </exception>
        public static bool None<T>(this IEnumerable<T> enumerable, Func<T, bool> predicate) =>
            predicate is null
                ? throw new ArgumentNullException(nameof(predicate))
                : enumerable.All(t => !predicate(t));

        /// <summary>
        /// Returns a sequence equivalent to <paramref name="enumerable"/> with item at the given
        /// index replaced by a new value. If <paramref name="index"/> is outside
        /// <paramref name="enumerable"/> The returned sequence is the same as
        /// <paramref name="enumerable"/>.
        /// </summary>
        /// <typeparam name="T">Type of items in <paramref name="enumerable"/>.</typeparam>
        /// <param name="enumerable"><see cref="IEnumerable{T}"/> to use.</param>
        /// <param name="index">Index of the item that should be replaced.</param>
        /// <param name="newItem">
        /// Item that should be used instead of the item at the given index.
        /// </param>
        /// <returns>
        /// Sequence equivalent to <paramref name="enumerable"/> with item at the given index
        /// replaced by a new value.
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="enumerable"/> is null.
        /// </exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown when <paramref name="index"/> is negative.
        /// </exception>
        public static IEnumerable<T> Replace<T>(
            this IEnumerable<T> enumerable,
            int index,
            T newItem
        ) {
            if (enumerable is null) {
                throw new ArgumentNullException(nameof(enumerable));
            }
            if (index < 0) {
                throw new ArgumentOutOfRangeException(
                    nameof(index),
                    index,
                    "Index can't be negative."
                );
            }
            using var enumerator = enumerable.GetEnumerator();
            var i = 0;
            while (enumerator.MoveNext()) {
                yield return i == index ? newItem : enumerator.Current;
                ++i;
            }
        }

        /// <summary>
        /// Calls <paramref name="action"/> for each element of <paramref name="enumerable"/>
        /// </summary>
        /// <typeparam name="T">Type of items in <paramref name="enumerable"/>.</typeparam>
        /// <param name="enumerable"><see cref="IEnumerable{T}"/> to filter.</param>
        /// <param name="action">A function to call with each element.</param>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="enumerable"/> or <paramref name="action"/> is null.
        /// </exception>
        public static void ForEach<T>(this IEnumerable<T> enumerable, Action<T> action) {
            if (enumerable is null) {
                throw new ArgumentNullException(nameof(enumerable));
            }
            if (action is null) {
                throw new ArgumentNullException(nameof(action));
            }
            foreach (var item in enumerable) {
                action(item);
            }
        }

        /// <summary>
        /// Finds element of <paramref name="enumerable"/> for which <paramref name="selector"/>
        /// returns the maximum value.
        /// </summary>
        /// <typeparam name="T">Type of items in <paramref name="enumerable"/>.</typeparam>
        /// <typeparam name="V">Type returned by <paramref name="selector"/>.</typeparam>
        /// <param name="enumerable"><see cref="IEnumerable{T}"/> to search.</param>
        /// <param name="selector">
        /// A function that assigns a comparable value to each element.
        /// </param>
        /// <returns>
        /// Element of <paramref name="enumerable"/> for which <paramref name="selector"/> returns
        /// the maximum value.
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="enumerable"/> or <paramref name="selector"/> is null.
        /// </exception>
        public static T MaxBy<T, V>(
            this IEnumerable<T> enumerable,
            Func<T, V> selector
        ) where V : IComparable<V> {
            if (enumerable is null) {
                throw new ArgumentNullException(nameof(enumerable));
            }
            if (selector is null) {
                throw new ArgumentNullException(nameof(selector));
            }
            using var enumerator = enumerable.GetEnumerator();
            if (!enumerator.MoveNext()) {
                throw new InvalidOperationException("Collection can't be empty.");
            }
            var bestItem = enumerator.Current;
            var max = selector(bestItem);
            while (enumerator.MoveNext()) {
                var item = enumerator.Current;
                var value = selector(item);
                if (value.CompareTo(max) > 0) {
                    max = value;
                    bestItem = item;
                }
            }
            return bestItem;
        }

        /// <summary>
        /// Finds element of <paramref name="enumerable"/> for which <paramref name="selector"/>
        /// returns the minimum value.
        /// </summary>
        /// <typeparam name="T">Type of items in <paramref name="enumerable"/>.</typeparam>
        /// <typeparam name="V">Type returned by <paramref name="selector"/>.</typeparam>
        /// <param name="enumerable"><see cref="IEnumerable{T}"/> to search.</param>
        /// <param name="selector">
        /// A function that assigns a comparable value to each element.
        /// </param>
        /// <returns>
        /// Element of <paramref name="enumerable"/> for which <paramref name="selector"/> returns
        /// the minimum value.
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="enumerable"/> or <paramref name="selector"/> is null.
        /// </exception>
        public static T MinBy<T, V>(
            this IEnumerable<T> enumerable,
            Func<T, V> selector
        ) where V : IComparable<V> {
            if (enumerable is null) {
                throw new ArgumentNullException(nameof(enumerable));
            }
            if (selector is null) {
                throw new ArgumentNullException(nameof(selector));
            }
            using var enumerator = enumerable.GetEnumerator();
            if (!enumerator.MoveNext()) {
                throw new InvalidOperationException("Collection can't be empty.");
            }
            var bestItem = enumerator.Current;
            var max = selector(bestItem);
            while (enumerator.MoveNext()) {
                var item = enumerator.Current;
                var value = selector(item);
                if (value.CompareTo(max) < 0) {
                    max = value;
                    bestItem = item;
                }
            }
            return bestItem;
        }

        /// <summary>Filters a sequence of values based on <paramref name="predicate"/>.</summary>
        /// <typeparam name="T">Type of items in <paramref name="enumerable"/>.</typeparam>
        /// <param name="enumerable"><see cref="IEnumerable{T}"/> to filter.</param>
        /// <param name="predicate">
        /// Predicate function that will be checked against items from the input sequence.
        /// </param>
        /// <returns>
        /// <see cref="IEnumerable{T}"/> that contains elements from the input sequence that do not
        /// satisfy the condition.
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="enumerable"/> or <paramref name="predicate"/> is null.
        /// </exception>
        public static IEnumerable<T> WhereNot<T>(
            this IEnumerable<T> enumerable,
            Func<T, bool> predicate
        ) {
            if (predicate is null) {
                throw new ArgumentNullException(nameof(predicate));
            }
            return enumerable.Where(item => !predicate(item));
        }

        /// <summary>Removes all null values from a sequence.</summary>
        /// <typeparam name="T">Type of items in <paramref name="enumerable"/>.</typeparam>
        /// <param name="enumerable"><see cref="IEnumerable{T}"/> to filter.</param>
        /// <returns>
        /// <see cref="IEnumerable{T}"/> that contains non-null elements from the input sequence.
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="enumerable"/> is null.
        /// </exception>
        public static IEnumerable<T> WhereNotNull<T>(this IEnumerable<T> enumerable) =>
            enumerable.Where(item => !(item is null));

        /// <summary>Removes all null and empty collections from a sequence.</summary>
        /// <typeparam name="T">
        /// Type of items in collections in<paramref name="enumerable"/>.
        /// </typeparam>
        /// <param name="enumerable"><see cref="IEnumerable{T}"/> to filter.</param>
        /// <returns>
        /// <see cref="IEnumerable{T}"/> that contains non-null collections with at least
        /// one item from the input sequence.
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="enumerable"/> is null.
        /// </exception>
        public static IEnumerable<ICollection<T>> WhereNotEmpty<T>(
            this IEnumerable<ICollection<T>> enumerable
        ) {
            return enumerable.Where(item => !(item is null) && item.Count > 0);
        }

        /// <summary>Removes all null and empty strings from a sequence.</summary>
        /// <param name="enumerable"><see cref="IEnumerable{T}"/> to filter.</param>
        /// <returns>
        /// <see cref="IEnumerable{T}"/> that contains non-null strings with at least
        /// one character from the input sequence.
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="enumerable"/> is null.
        /// </exception>
        public static IEnumerable<string> WhereNotEmpty(this IEnumerable<string> enumerable) =>
            enumerable.Where(item => !string.IsNullOrEmpty(item));

        /// <summary>
        /// Removes all null values and strings that are either empty or consist only of whitespace
        /// characters from a sequence.
        /// </summary>
        /// <param name="enumerable"><see cref="IEnumerable{T}"/> to filter.</param>
        /// <returns>
        /// <see cref="IEnumerable{T}"/> that contains non-null strings with at least
        /// one none-whitespace character from the input sequence.
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="enumerable"/> is null.
        /// </exception>
        public static IEnumerable<string> WhereNotWhiteSpace(this IEnumerable<string> enumerable) =>
            enumerable.Where(item => !string.IsNullOrWhiteSpace(item));

        /// <summary>Filters a sequence of strings based on a regular expression.</summary>
        /// <param name="enumerable"><see cref="IEnumerable{T}"/> to filter.</param>
        /// <param name="regex">A regular expression to search for in each item.</param>
        /// <returns>
        /// <see cref="IEnumerable{T}"/> that contains elements from the input sequence that are
        /// matched by the regular expression
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="enumerable"/> or <paramref name="regex"/> is null.
        /// </exception>
        public static IEnumerable<string> Matching(
            this IEnumerable<string> enumerable,
            Regex regex
        ) {
            if (regex is null) {
                throw new ArgumentNullException(nameof(regex));
            }
            return enumerable.Where(item => item != null && regex.IsMatch(item));
        }

        /// <summary>Filters a sequence of strings based on a regular expression.</summary>
        /// <param name="enumerable"><see cref="IEnumerable{T}"/> to filter.</param>
        /// <param name="pattern">A regular expression to search for in each item.</param>
        /// <returns>
        /// <see cref="IEnumerable{T}"/> that contains elements from the input sequence that are
        /// matched by the regular expression
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="enumerable"/> or <paramref name="pattern"/> is null.
        /// </exception>
        public static IEnumerable<string> Matching(
            this IEnumerable<string> enumerable,
            string pattern
        ) {
            if (pattern is null) {
                throw new ArgumentNullException(nameof(pattern));
            }
            return enumerable.Where(item => item != null && Regex.IsMatch(item, pattern));
        }

        /// <summary>Flattens the sequences into one sequence.</summary>
        /// <typeparam name="T">
        /// Type of items in the sequences in <paramref name="enumerable"/>.
        /// </typeparam>
        /// <param name="enumerable"><see cref="IEnumerable{IEnumerable}"/> to flatten.</param>
        /// <returns>
        /// <see cref="IEnumerable{T}"/> with items of the sequences in the input sequence
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="enumerable"/> is null.
        /// </exception>
        public static IEnumerable<T> Flatten<T>(this IEnumerable<IEnumerable<T>> enumerable) =>
            enumerable.SelectMany(e => e);

        /// <summary>
        /// Applies 1-n transformation to the items in the input sequence and flattens the resulting
        /// sequences into one sequence.
        /// </summary>
        /// <typeparam name="T">Type of items in <paramref name="enumerable"/>.</typeparam>
        /// <typeparam name="U">
        /// Type of items in sequences returned by <paramref name="action"/>.
        /// </typeparam>
        /// <param name="enumerable"><see cref="IEnumerable{IEnumerable}"/> to flatten.</param>
        /// <param name="action">
        /// A transform function to apply to each item in <paramref name="enumerable"/>.
        /// </param>
        /// <returns>
        /// <see cref="IEnumerable{T}"/> with items from sequences returned by
        /// <paramref name="action"/>
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="enumerable"/> is null.
        /// </exception>
        public static IEnumerable<U> FlatMap<T, U>(
            this IEnumerable<T> enumerable,
            Func<T, IEnumerable<U>> action
        ) {
            if (action is null) {
                throw new ArgumentNullException(nameof(action));
            }
            return enumerable.SelectMany(action);
        }

        /// <summary>
        /// Creates a <see cref="Dictionary{TKey,TValue}"/> from a sequence of key-value pairs.
        /// </summary>
        /// <typeparam name="TKey">The type of the keys in the dictionary.</typeparam>
        /// <typeparam name="TValue">The type of the values in the dictionary.</typeparam>
        /// <param name="enumerable">An <see cref="IEnumerable{T}"/> with key-value pairs.</param>
        /// <returns>
        /// <see cref="Dictionary{TKey,TValue}"/> with key-value pairs from the input sequence.
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="enumerable"/> is null.
        /// </exception>
        public static Dictionary<TKey, TValue> ToDictionary<TKey, TValue>(
            this IEnumerable<(TKey, TValue)> enumerable
        ) where TKey : notnull {
            return enumerable.ToDictionary(pair => pair.Item1, pair => pair.Item2);
        }

        /// <summary>
        /// Pairs each but last item in <paramref name="enumerable"/> with the item after it.
        /// </summary>
        /// <typeparam name="T">Type of items in <paramref name="enumerable"/>.</typeparam>
        /// <param name="enumerable"><see cref="IEnumerable{T}"/> to zip with itself.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="enumerable"/> is null.
        /// </exception>
        public static IEnumerable<(T, T)> ZipWithNext<T>(this IEnumerable<T> enumerable) {
            if (enumerable is null) {
                throw new ArgumentNullException(nameof(enumerable));
            }
            using var enumerator = enumerable.GetEnumerator();
            if (!enumerator.MoveNext()) {
                yield break;
            }
            var first = enumerator.Current;
            while (enumerator.MoveNext()) {
                var second = enumerator.Current;
                yield return (first, second);
                first = second;
            }
        }
    }
}
