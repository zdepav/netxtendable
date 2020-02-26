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
        
        public static IEnumerable<T> Flatten<T>(this IEnumerable<IEnumerable<T>> enumerable) =>
            enumerable.SelectMany(e => e);

        #nullable disable

        public static Dictionary<K, V> ToDictionary<K, V>(this IEnumerable<(K, V)> enumerable) =>
            enumerable.ToDictionary(pair => pair.Item1, pair => pair.Item2);

        #nullable restore

    }

}
