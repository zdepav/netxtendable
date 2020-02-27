using System;
using System.Collections.Generic;
using System.Linq;

namespace Netxtendable {

    public static class IEnumerableExtensions {

        public static string ConcatToString<T>(this IEnumerable<T> enumerable) =>
            string.Concat(enumerable ?? throw new ArgumentNullException(nameof(enumerable)));

        public static string Join<T>(this IEnumerable<T> enumerable, string delimiter) =>
            string.Join(delimiter ?? throw new ArgumentNullException(nameof(delimiter)), enumerable);

        public static string Join<T>(this IEnumerable<T> enumerable, char delimiter) =>
            string.Join(delimiter.ToString(), enumerable);

        public static IEnumerable<U> Map<T, U>(this IEnumerable<T> enumerable, Func<T, U> action) {
            if (action is null) {
                throw new ArgumentNullException(nameof(action));
            }
            return enumerable.Select(action);
        }

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

        public static bool None<T>(this IEnumerable<T> enumerable, Func<T, bool> predicate) {
            if (predicate is null) {
                throw new ArgumentNullException(nameof(predicate));
            }
            return enumerable.All(t => !predicate(t));
        }

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

        public static T MaxBy<T>(this IEnumerable<T> enumerable, Func<T, IComparable> selector) {
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

        public static T MinBy<T>(this IEnumerable<T> enumerable, Func<T, IComparable> selector) {
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
        
        public static IEnumerable<T> WhereNot<T>(this IEnumerable<T> enumerable, Func<T, bool> predicate) {
            if (predicate is null) {
                throw new ArgumentNullException(nameof(predicate));
            }
            return enumerable.Where(item => !predicate(item));
        }
        
        public static IEnumerable<T> WhereNotNull<T>(this IEnumerable<T> enumerable) =>
            enumerable.Where(item => !(item is null));

        public static IEnumerable<T> Flatten<T>(this IEnumerable<IEnumerable<T>> enumerable) =>
            enumerable.SelectMany(e => e);

        #nullable disable

        public static Dictionary<K, V> ToDictionary<K, V>(this IEnumerable<(K, V)> enumerable) =>
            enumerable.ToDictionary(pair => pair.Item1, pair => pair.Item2);

        #nullable restore

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
                : throw new InvalidOperationException("At least 2 items were expected, 0 were found.");
            item2 = enumerator.MoveNext()
                ? enumerator.Current
                : throw new InvalidOperationException("At least 2 items were expected, 1 were found.");
        }

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
                : throw new InvalidOperationException("At least 3 items were expected, 0 were found.");
            item2 = enumerator.MoveNext()
                ? enumerator.Current
                : throw new InvalidOperationException("At least 3 items were expected, 1 were found.");
            item3 = enumerator.MoveNext()
                ? enumerator.Current
                : throw new InvalidOperationException("At least 3 items were expected, 2 were found.");
        }

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
                : throw new InvalidOperationException("At least 4 items were expected, 0 were found.");
            item2 = enumerator.MoveNext()
                ? enumerator.Current
                : throw new InvalidOperationException("At least 4 items were expected, 1 were found.");
            item3 = enumerator.MoveNext()
                ? enumerator.Current
                : throw new InvalidOperationException("At least 4 items were expected, 2 were found.");
            item4 = enumerator.MoveNext()
                ? enumerator.Current
                : throw new InvalidOperationException("At least 4 items were expected, 3 were found.");
        }

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
                : throw new InvalidOperationException("At least 5 items were expected, 0 were found.");
            item2 = enumerator.MoveNext()
                ? enumerator.Current
                : throw new InvalidOperationException("At least 5 items were expected, 1 were found.");
            item3 = enumerator.MoveNext()
                ? enumerator.Current
                : throw new InvalidOperationException("At least 5 items were expected, 2 were found.");
            item4 = enumerator.MoveNext()
                ? enumerator.Current
                : throw new InvalidOperationException("At least 5 items were expected, 3 were found.");
            item5 = enumerator.MoveNext()
                ? enumerator.Current
                : throw new InvalidOperationException("At least 5 items were expected, 4 were found.");
        }

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
                : throw new InvalidOperationException("At least 6 items were expected, 0 were found.");
            item2 = enumerator.MoveNext()
                ? enumerator.Current
                : throw new InvalidOperationException("At least 6 items were expected, 1 were found.");
            item3 = enumerator.MoveNext()
                ? enumerator.Current
                : throw new InvalidOperationException("At least 6 items were expected, 2 were found.");
            item4 = enumerator.MoveNext()
                ? enumerator.Current
                : throw new InvalidOperationException("At least 6 items were expected, 3 were found.");
            item5 = enumerator.MoveNext()
                ? enumerator.Current
                : throw new InvalidOperationException("At least 6 items were expected, 4 were found.");
            item6 = enumerator.MoveNext()
                ? enumerator.Current
                : throw new InvalidOperationException("At least 6 items were expected, 5 were found.");
        }

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
                : throw new InvalidOperationException("At least 7 items were expected, 0 were found.");
            item2 = enumerator.MoveNext()
                ? enumerator.Current
                : throw new InvalidOperationException("At least 7 items were expected, 1 were found.");
            item3 = enumerator.MoveNext()
                ? enumerator.Current
                : throw new InvalidOperationException("At least 7 items were expected, 2 were found.");
            item4 = enumerator.MoveNext()
                ? enumerator.Current
                : throw new InvalidOperationException("At least 7 items were expected, 3 were found.");
            item5 = enumerator.MoveNext()
                ? enumerator.Current
                : throw new InvalidOperationException("At least 7 items were expected, 4 were found.");
            item6 = enumerator.MoveNext()
                ? enumerator.Current
                : throw new InvalidOperationException("At least 7 items were expected, 5 were found.");
            item7 = enumerator.MoveNext()
                ? enumerator.Current
                : throw new InvalidOperationException("At least 7 items were expected, 6 were found.");
        }

    }

}
