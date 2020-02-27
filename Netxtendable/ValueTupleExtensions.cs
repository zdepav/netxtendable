using System;
using System.Collections.Generic;

namespace Netxtendable {

    public static class ValueTupleExtensions {

        public static T[] ToArray<T>(this ValueTuple<T, T> t) =>
            new[] { t.Item1, t.Item2 };

        public static T[] ToArray<T>(this ValueTuple<T, T, T> t) =>
            new[] { t.Item1, t.Item2, t.Item3 };

        public static T[] ToArray<T>(this ValueTuple<T, T, T, T> t) =>
            new[] { t.Item1, t.Item2, t.Item3, t.Item4 };

        public static T[] ToArray<T>(this ValueTuple<T, T, T, T, T> t) =>
            new[] { t.Item1, t.Item2, t.Item3, t.Item4, t.Item5 };

        public static T[] ToArray<T>(this ValueTuple<T, T, T, T, T, T> t) =>
            new[] { t.Item1, t.Item2, t.Item3, t.Item4, t.Item5, t.Item6 };

        public static T[] ToArray<T>(this ValueTuple<T, T, T, T, T, T, T> t) =>
            new[] { t.Item1, t.Item2, t.Item3, t.Item4, t.Item5, t.Item6, t.Item7 };

        public static IList<T> ToList<T>(this ValueTuple<T, T> t) =>
            new List<T> { t.Item1, t.Item2 };

        public static IList<T> ToList<T>(this ValueTuple<T, T, T> t) =>
            new List<T> { t.Item1, t.Item2, t.Item3 };

        public static IList<T> ToList<T>(this ValueTuple<T, T, T, T> t) =>
            new List<T> { t.Item1, t.Item2, t.Item3, t.Item4 };

        public static IList<T> ToList<T>(this ValueTuple<T, T, T, T, T> t) =>
            new List<T> { t.Item1, t.Item2, t.Item3, t.Item4, t.Item5 };

        public static IList<T> ToList<T>(this ValueTuple<T, T, T, T, T, T> t) =>
            new List<T> { t.Item1, t.Item2, t.Item3, t.Item4, t.Item5, t.Item6 };

        public static IList<T> ToList<T>(this ValueTuple<T, T, T, T, T, T, T> t) =>
            new List<T> { t.Item1, t.Item2, t.Item3, t.Item4, t.Item5, t.Item6, t.Item7 };

        public static ISet<T> ToSet<T>(this ValueTuple<T, T> t) =>
            new HashSet<T> { t.Item1, t.Item2 };

        public static ISet<T> ToSet<T>(this ValueTuple<T, T, T> t) =>
            new HashSet<T> { t.Item1, t.Item2, t.Item3 };

        public static ISet<T> ToSet<T>(this ValueTuple<T, T, T, T> t) =>
            new HashSet<T> { t.Item1, t.Item2, t.Item3, t.Item4 };

        public static ISet<T> ToSet<T>(this ValueTuple<T, T, T, T, T> t) =>
            new HashSet<T> { t.Item1, t.Item2, t.Item3, t.Item4, t.Item5 };

        public static ISet<T> ToSet<T>(this ValueTuple<T, T, T, T, T, T> t) =>
            new HashSet<T> { t.Item1, t.Item2, t.Item3, t.Item4, t.Item5, t.Item6 };

        public static ISet<T> ToSet<T>(this ValueTuple<T, T, T, T, T, T, T> t) =>
            new HashSet<T> { t.Item1, t.Item2, t.Item3, t.Item4, t.Item5, t.Item6, t.Item7 };

        #nullable disable

        public static IDictionary<K, V> ToDictionary<K, V>(
            this ValueTuple<(K, V), (K, V)> t
        ) {
            return new Dictionary<K, V> {
                { t.Item1.Item1, t.Item1.Item2 },
                { t.Item2.Item1, t.Item2.Item2 },
            };
        }

        public static IDictionary<K, V> ToDictionary<K, V>(
            this ValueTuple<(K, V), (K, V), (K, V)> t
        ) {
            return new Dictionary<K, V> {
                { t.Item1.Item1, t.Item1.Item2 },
                { t.Item2.Item1, t.Item2.Item2 },
                { t.Item3.Item1, t.Item3.Item2 },
            };
        }

        public static IDictionary<K, V> ToDictionary<K, V>(
            this ValueTuple<(K, V), (K, V), (K, V), (K, V)> t
        ) {
            return new Dictionary<K, V> {
                { t.Item1.Item1, t.Item1.Item2 },
                { t.Item2.Item1, t.Item2.Item2 },
                { t.Item3.Item1, t.Item3.Item2 },
                { t.Item4.Item1, t.Item4.Item2 },
            };
        }

        public static IDictionary<K, V> ToDictionary<K, V>(
            this ValueTuple<(K, V), (K, V), (K, V), (K, V), (K, V)> t
        ) {
            return new Dictionary<K, V> {
                { t.Item1.Item1, t.Item1.Item2 },
                { t.Item2.Item1, t.Item2.Item2 },
                { t.Item3.Item1, t.Item3.Item2 },
                { t.Item4.Item1, t.Item4.Item2 },
                { t.Item5.Item1, t.Item5.Item2 },
            };
        }

        public static IDictionary<K, V> ToDictionary<K, V>(
            this ValueTuple<(K, V), (K, V), (K, V), (K, V), (K, V), (K, V)> t
        ) {
            return new Dictionary<K, V> {
                { t.Item1.Item1, t.Item1.Item2 },
                { t.Item2.Item1, t.Item2.Item2 },
                { t.Item3.Item1, t.Item3.Item2 },
                { t.Item4.Item1, t.Item4.Item2 },
                { t.Item5.Item1, t.Item5.Item2 },
                { t.Item6.Item1, t.Item6.Item2 },
            };
        }

        public static IDictionary<K, V> ToDictionary<K, V>(
            this ValueTuple<(K, V), (K, V), (K, V), (K, V), (K, V), (K, V), (K, V)> t
        ) {
            return new Dictionary<K, V> {
                { t.Item1.Item1, t.Item1.Item2 },
                { t.Item2.Item1, t.Item2.Item2 },
                { t.Item3.Item1, t.Item3.Item2 },
                { t.Item4.Item1, t.Item4.Item2 },
                { t.Item5.Item1, t.Item5.Item2 },
                { t.Item6.Item1, t.Item6.Item2 },
                { t.Item7.Item1, t.Item7.Item2 },
            };
        }

        #nullable restore

    }

}
