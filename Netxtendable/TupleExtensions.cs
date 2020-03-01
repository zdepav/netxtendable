using System;
using System.Collections.Generic;

namespace Netxtendable {

    /// <summary>Class with extension methods for <see cref="Tuple"/></summary>
    public static class TupleExtensions {

        public static void Deconstruct<T1, T2>(this Tuple<T1, T2> t, out T1 item1, out T2 item2) {
            item1 = t.Item1;
            item2 = t.Item2;
        }

        public static void Deconstruct<T1, T2, T3>(
            this Tuple<T1, T2, T3> t,
            out T1 item1,
            out T2 item2,
            out T3 item3
        ) {
            item1 = t.Item1;
            item2 = t.Item2;
            item3 = t.Item3;
        }

        public static void Deconstruct<T1, T2, T3, T4>(
            this Tuple<T1, T2, T3, T4> t,
            out T1 item1,
            out T2 item2,
            out T3 item3,
            out T4 item4
        ) {
            item1 = t.Item1;
            item2 = t.Item2;
            item3 = t.Item3;
            item4 = t.Item4;
        }

        public static void Deconstruct<T1, T2, T3, T4, T5>(
            this Tuple<T1, T2, T3, T4, T5> t,
            out T1 item1,
            out T2 item2,
            out T3 item3,
            out T4 item4,
            out T5 item5
        ) {
            item1 = t.Item1;
            item2 = t.Item2;
            item3 = t.Item3;
            item4 = t.Item4;
            item5 = t.Item5;
        }

        public static void Deconstruct<T1, T2, T3, T4, T5, T6>(
            this Tuple<T1, T2, T3, T4, T5, T6> t,
            out T1 item1,
            out T2 item2,
            out T3 item3,
            out T4 item4,
            out T5 item5,
            out T6 item6
        ) {
            item1 = t.Item1;
            item2 = t.Item2;
            item3 = t.Item3;
            item4 = t.Item4;
            item5 = t.Item5;
            item6 = t.Item6;
        }

        public static void Deconstruct<T1, T2, T3, T4, T5, T6, T7>(
            this Tuple<T1, T2, T3, T4, T5, T6, T7> t,
            out T1 item1,
            out T2 item2,
            out T3 item3,
            out T4 item4,
            out T5 item5,
            out T6 item6,
            out T7 item7
        ) {
            item1 = t.Item1;
            item2 = t.Item2;
            item3 = t.Item3;
            item4 = t.Item4;
            item5 = t.Item5;
            item6 = t.Item6;
            item7 = t.Item7;
        }

        public static T[] ToArray<T>(this Tuple<T, T> t) =>
            new[] { t.Item1, t.Item2 };

        public static T[] ToArray<T>(this Tuple<T, T, T> t) =>
            new[] { t.Item1, t.Item2, t.Item3 };

        public static T[] ToArray<T>(this Tuple<T, T, T, T> t) =>
            new[] { t.Item1, t.Item2, t.Item3, t.Item4 };

        public static T[] ToArray<T>(this Tuple<T, T, T, T, T> t) =>
            new[] { t.Item1, t.Item2, t.Item3, t.Item4, t.Item5 };

        public static T[] ToArray<T>(this Tuple<T, T, T, T, T, T> t) =>
            new[] { t.Item1, t.Item2, t.Item3, t.Item4, t.Item5, t.Item6 };

        public static T[] ToArray<T>(this Tuple<T, T, T, T, T, T, T> t) =>
            new[] { t.Item1, t.Item2, t.Item3, t.Item4, t.Item5, t.Item6, t.Item7 };

        public static IList<T> ToList<T>(this Tuple<T, T> t) =>
            new List<T> { t.Item1, t.Item2 };

        public static IList<T> ToList<T>(this Tuple<T, T, T> t) =>
            new List<T> { t.Item1, t.Item2, t.Item3 };

        public static IList<T> ToList<T>(this Tuple<T, T, T, T> t) =>
            new List<T> { t.Item1, t.Item2, t.Item3, t.Item4 };

        public static IList<T> ToList<T>(this Tuple<T, T, T, T, T> t) =>
            new List<T> { t.Item1, t.Item2, t.Item3, t.Item4, t.Item5 };

        public static IList<T> ToList<T>(this Tuple<T, T, T, T, T, T> t) =>
            new List<T> { t.Item1, t.Item2, t.Item3, t.Item4, t.Item5, t.Item6 };

        public static IList<T> ToList<T>(this Tuple<T, T, T, T, T, T, T> t) =>
            new List<T> { t.Item1, t.Item2, t.Item3, t.Item4, t.Item5, t.Item6, t.Item7 };

        public static ISet<T> ToSet<T>(this Tuple<T, T> t) =>
            new HashSet<T> { t.Item1, t.Item2 };

        public static ISet<T> ToSet<T>(this Tuple<T, T, T> t) =>
            new HashSet<T> { t.Item1, t.Item2, t.Item3 };

        public static ISet<T> ToSet<T>(this Tuple<T, T, T, T> t) =>
            new HashSet<T> { t.Item1, t.Item2, t.Item3, t.Item4 };

        public static ISet<T> ToSet<T>(this Tuple<T, T, T, T, T> t) =>
            new HashSet<T> { t.Item1, t.Item2, t.Item3, t.Item4, t.Item5 };

        public static ISet<T> ToSet<T>(this Tuple<T, T, T, T, T, T> t) =>
            new HashSet<T> { t.Item1, t.Item2, t.Item3, t.Item4, t.Item5, t.Item6 };

        public static ISet<T> ToSet<T>(this Tuple<T, T, T, T, T, T, T> t) =>
            new HashSet<T> { t.Item1, t.Item2, t.Item3, t.Item4, t.Item5, t.Item6, t.Item7 };

        public static IDictionary<K, V> ToDictionary<K, V>(
            this Tuple<(K, V), (K, V)> t
        ) where K : notnull {
            return new Dictionary<K, V> {
                { t.Item1.Item1, t.Item1.Item2 },
                { t.Item2.Item1, t.Item2.Item2 },
            };
        }

        public static IDictionary<K, V> ToDictionary<K, V>(
            this Tuple<(K, V), (K, V), (K, V)> t
        ) where K : notnull {
            return new Dictionary<K, V> {
                { t.Item1.Item1, t.Item1.Item2 },
                { t.Item2.Item1, t.Item2.Item2 },
                { t.Item3.Item1, t.Item3.Item2 },
            };
        }

        public static IDictionary<K, V> ToDictionary<K, V>(
            this Tuple<(K, V), (K, V), (K, V), (K, V)> t
        ) where K : notnull {
            return new Dictionary<K, V> {
                { t.Item1.Item1, t.Item1.Item2 },
                { t.Item2.Item1, t.Item2.Item2 },
                { t.Item3.Item1, t.Item3.Item2 },
                { t.Item4.Item1, t.Item4.Item2 },
            };
        }

        public static IDictionary<K, V> ToDictionary<K, V>(
            this Tuple<(K, V), (K, V), (K, V), (K, V), (K, V)> t
        ) where K : notnull {
            return new Dictionary<K, V> {
                { t.Item1.Item1, t.Item1.Item2 },
                { t.Item2.Item1, t.Item2.Item2 },
                { t.Item3.Item1, t.Item3.Item2 },
                { t.Item4.Item1, t.Item4.Item2 },
                { t.Item5.Item1, t.Item5.Item2 },
            };
        }

        public static IDictionary<K, V> ToDictionary<K, V>(
            this Tuple<(K, V), (K, V), (K, V), (K, V), (K, V), (K, V)> t
        ) where K : notnull {
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
            this Tuple<(K, V), (K, V), (K, V), (K, V), (K, V), (K, V), (K, V)> t
        ) where K : notnull {
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
        
        public static IEnumerable<T> Enumerate<T>(this Tuple<T, T> t) {
            yield return t.Item1;
            yield return t.Item2;
        }

        public static IEnumerable<T> Enumerate<T>(this Tuple<T, T, T> t) {
            yield return t.Item1;
            yield return t.Item2;
            yield return t.Item3;
        }

        public static IEnumerable<T> Enumerate<T>(this Tuple<T, T, T, T> t) {
            yield return t.Item1;
            yield return t.Item2;
            yield return t.Item3;
            yield return t.Item4;
        }

        public static IEnumerable<T> Enumerate<T>(this Tuple<T, T, T, T, T> t) {
            yield return t.Item1;
            yield return t.Item2;
            yield return t.Item3;
            yield return t.Item4;
            yield return t.Item5;
        }

        public static IEnumerable<T> Enumerate<T>(this Tuple<T, T, T, T, T, T> t) {
            yield return t.Item1;
            yield return t.Item2;
            yield return t.Item3;
            yield return t.Item4;
            yield return t.Item5;
            yield return t.Item6;
        }

        public static IEnumerable<T> Enumerate<T>(this Tuple<T, T, T, T, T, T, T> t) {
            yield return t.Item1;
            yield return t.Item2;
            yield return t.Item3;
            yield return t.Item4;
            yield return t.Item5;
            yield return t.Item6;
            yield return t.Item7;
        }

    }

}
