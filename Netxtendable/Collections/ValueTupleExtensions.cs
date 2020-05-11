#nullable enable
using System;
using System.Collections.Generic;

// GENERATED CODE - DO NOT MODIFY

namespace Netxtendable.Collections {

    /// <summary>Class with extension methods for <see cref="Tuple"/></summary>
    public static class ValueTupleExtensions {

        /// <summary>Creates an array using items from <paramref name="t"/>.</summary>
        /// <typeparam name="T">Type of items in <paramref name="t"/>.</typeparam>
        /// <param name="t">Tuple whose items will be inserted into the array.</param>
        /// <returns>
        /// Array of size 2 whose elements are items of <paramref name="t"/>.
        /// </returns>
        public static T[] ToArray<T>(this ValueTuple<T, T> t) =>
            new[] { t.Item1, t.Item2 };

        /// <summary>Creates an array using items from <paramref name="t"/>.</summary>
        /// <typeparam name="T">Type of items in <paramref name="t"/>.</typeparam>
        /// <param name="t">Tuple whose items will be inserted into the array.</param>
        /// <returns>
        /// Array of size 3 whose elements are items of <paramref name="t"/>.
        /// </returns>
        public static T[] ToArray<T>(this ValueTuple<T, T, T> t) =>
            new[] { t.Item1, t.Item2, t.Item3 };

        /// <summary>Creates an array using items from <paramref name="t"/>.</summary>
        /// <typeparam name="T">Type of items in <paramref name="t"/>.</typeparam>
        /// <param name="t">Tuple whose items will be inserted into the array.</param>
        /// <returns>
        /// Array of size 4 whose elements are items of <paramref name="t"/>.
        /// </returns>
        public static T[] ToArray<T>(this ValueTuple<T, T, T, T> t) =>
            new[] { t.Item1, t.Item2, t.Item3, t.Item4 };

        /// <summary>Creates an array using items from <paramref name="t"/>.</summary>
        /// <typeparam name="T">Type of items in <paramref name="t"/>.</typeparam>
        /// <param name="t">Tuple whose items will be inserted into the array.</param>
        /// <returns>
        /// Array of size 5 whose elements are items of <paramref name="t"/>.
        /// </returns>
        public static T[] ToArray<T>(this ValueTuple<T, T, T, T, T> t) =>
            new[] { t.Item1, t.Item2, t.Item3, t.Item4, t.Item5 };

        /// <summary>Creates an array using items from <paramref name="t"/>.</summary>
        /// <typeparam name="T">Type of items in <paramref name="t"/>.</typeparam>
        /// <param name="t">Tuple whose items will be inserted into the array.</param>
        /// <returns>
        /// Array of size 6 whose elements are items of <paramref name="t"/>.
        /// </returns>
        public static T[] ToArray<T>(this ValueTuple<T, T, T, T, T, T> t) =>
            new[] { t.Item1, t.Item2, t.Item3, t.Item4, t.Item5, t.Item6 };

        /// <summary>Creates an array using items from <paramref name="t"/>.</summary>
        /// <typeparam name="T">Type of items in <paramref name="t"/>.</typeparam>
        /// <param name="t">Tuple whose items will be inserted into the array.</param>
        /// <returns>
        /// Array of size 7 whose elements are items of <paramref name="t"/>.
        /// </returns>
        public static T[] ToArray<T>(this ValueTuple<T, T, T, T, T, T, T> t) =>
            new[] { t.Item1, t.Item2, t.Item3, t.Item4, t.Item5, t.Item6, t.Item7 };

        /// <summary>Creates a list using items from <paramref name="t"/>.</summary>
        /// <typeparam name="T">Type of items in <paramref name="t"/>.</typeparam>
        /// <param name="t">Tuple whose items will be inserted into the list.</param>
        /// <returns>
        /// <see cref="List{T}"/> of size 2 whose elements are items of <paramref name="t"/>.
        /// </returns>
        public static List<T> ToList<T>(this ValueTuple<T, T> t) =>
            new List<T>(2) { t.Item1, t.Item2 };

        /// <summary>Creates a list using items from <paramref name="t"/>.</summary>
        /// <typeparam name="T">Type of items in <paramref name="t"/>.</typeparam>
        /// <param name="t">Tuple whose items will be inserted into the list.</param>
        /// <returns>
        /// <see cref="List{T}"/> of size 3 whose elements are items of <paramref name="t"/>.
        /// </returns>
        public static List<T> ToList<T>(this ValueTuple<T, T, T> t) =>
            new List<T>(3) { t.Item1, t.Item2, t.Item3 };

        /// <summary>Creates a list using items from <paramref name="t"/>.</summary>
        /// <typeparam name="T">Type of items in <paramref name="t"/>.</typeparam>
        /// <param name="t">Tuple whose items will be inserted into the list.</param>
        /// <returns>
        /// <see cref="List{T}"/> of size 4 whose elements are items of <paramref name="t"/>.
        /// </returns>
        public static List<T> ToList<T>(this ValueTuple<T, T, T, T> t) =>
            new List<T>(4) { t.Item1, t.Item2, t.Item3, t.Item4 };

        /// <summary>Creates a list using items from <paramref name="t"/>.</summary>
        /// <typeparam name="T">Type of items in <paramref name="t"/>.</typeparam>
        /// <param name="t">Tuple whose items will be inserted into the list.</param>
        /// <returns>
        /// <see cref="List{T}"/> of size 5 whose elements are items of <paramref name="t"/>.
        /// </returns>
        public static List<T> ToList<T>(this ValueTuple<T, T, T, T, T> t) =>
            new List<T>(5) { t.Item1, t.Item2, t.Item3, t.Item4, t.Item5 };

        /// <summary>Creates a list using items from <paramref name="t"/>.</summary>
        /// <typeparam name="T">Type of items in <paramref name="t"/>.</typeparam>
        /// <param name="t">Tuple whose items will be inserted into the list.</param>
        /// <returns>
        /// <see cref="List{T}"/> of size 6 whose elements are items of <paramref name="t"/>.
        /// </returns>
        public static List<T> ToList<T>(this ValueTuple<T, T, T, T, T, T> t) =>
            new List<T>(6) { t.Item1, t.Item2, t.Item3, t.Item4, t.Item5, t.Item6 };

        /// <summary>Creates a list using items from <paramref name="t"/>.</summary>
        /// <typeparam name="T">Type of items in <paramref name="t"/>.</typeparam>
        /// <param name="t">Tuple whose items will be inserted into the list.</param>
        /// <returns>
        /// <see cref="List{T}"/> of size 7 whose elements are items of <paramref name="t"/>.
        /// </returns>
        public static List<T> ToList<T>(this ValueTuple<T, T, T, T, T, T, T> t) =>
            new List<T>(7) { t.Item1, t.Item2, t.Item3, t.Item4, t.Item5, t.Item6, t.Item7 };

        /// <summary>Creates a set using items from <paramref name="t"/>.</summary>
        /// <typeparam name="T">Type of items in <paramref name="t"/>.</typeparam>
        /// <param name="t">Tuple whose items will be inserted into the set.</param>
        /// <returns>
        /// <see cref="HashSet{T}"/> of size 2 whose elements are items of <paramref name="t"/>.
        /// </returns>
        public static HashSet<T> ToSet<T>(this ValueTuple<T, T> t) =>
            new HashSet<T>(2) { t.Item1, t.Item2 };

        /// <summary>Creates a set using items from <paramref name="t"/>.</summary>
        /// <typeparam name="T">Type of items in <paramref name="t"/>.</typeparam>
        /// <param name="t">Tuple whose items will be inserted into the set.</param>
        /// <returns>
        /// <see cref="HashSet{T}"/> of size 3 whose elements are items of <paramref name="t"/>.
        /// </returns>
        public static HashSet<T> ToSet<T>(this ValueTuple<T, T, T> t) =>
            new HashSet<T>(3) { t.Item1, t.Item2, t.Item3 };

        /// <summary>Creates a set using items from <paramref name="t"/>.</summary>
        /// <typeparam name="T">Type of items in <paramref name="t"/>.</typeparam>
        /// <param name="t">Tuple whose items will be inserted into the set.</param>
        /// <returns>
        /// <see cref="HashSet{T}"/> of size 4 whose elements are items of <paramref name="t"/>.
        /// </returns>
        public static HashSet<T> ToSet<T>(this ValueTuple<T, T, T, T> t) =>
            new HashSet<T>(4) { t.Item1, t.Item2, t.Item3, t.Item4 };

        /// <summary>Creates a set using items from <paramref name="t"/>.</summary>
        /// <typeparam name="T">Type of items in <paramref name="t"/>.</typeparam>
        /// <param name="t">Tuple whose items will be inserted into the set.</param>
        /// <returns>
        /// <see cref="HashSet{T}"/> of size 5 whose elements are items of <paramref name="t"/>.
        /// </returns>
        public static HashSet<T> ToSet<T>(this ValueTuple<T, T, T, T, T> t) =>
            new HashSet<T>(5) { t.Item1, t.Item2, t.Item3, t.Item4, t.Item5 };

        /// <summary>Creates a set using items from <paramref name="t"/>.</summary>
        /// <typeparam name="T">Type of items in <paramref name="t"/>.</typeparam>
        /// <param name="t">Tuple whose items will be inserted into the set.</param>
        /// <returns>
        /// <see cref="HashSet{T}"/> of size 6 whose elements are items of <paramref name="t"/>.
        /// </returns>
        public static HashSet<T> ToSet<T>(this ValueTuple<T, T, T, T, T, T> t) =>
            new HashSet<T>(6) { t.Item1, t.Item2, t.Item3, t.Item4, t.Item5, t.Item6 };

        /// <summary>Creates a set using items from <paramref name="t"/>.</summary>
        /// <typeparam name="T">Type of items in <paramref name="t"/>.</typeparam>
        /// <param name="t">Tuple whose items will be inserted into the set.</param>
        /// <returns>
        /// <see cref="HashSet{T}"/> of size 7 whose elements are items of <paramref name="t"/>.
        /// </returns>
        public static HashSet<T> ToSet<T>(this ValueTuple<T, T, T, T, T, T, T> t) =>
            new HashSet<T>(7) { t.Item1, t.Item2, t.Item3, t.Item4, t.Item5, t.Item6, t.Item7 };

        /// <summary>Creates a dictionary using items from <paramref name="t"/>.</summary>
        /// <typeparam name="K">Type of keys in key-value pairs in <paramref name="t"/>.</typeparam>
        /// <typeparam name="V">
        /// Type of values in key-value pairs in <paramref name="t"/>.
        /// </typeparam>
        /// <param name="t">
        /// Tuple with key-value pairs that will be inserted into the dictionary.
        /// </param>
        /// <returns>
        /// <see cref="Dictionary{K,V}"/> of size 2 whose elements are items of <paramref name="t"/>.
        /// </returns>
        public static Dictionary<K, V> ToDictionary<K, V>(
            this ValueTuple<(K, V), (K, V)> t
        ) where K : notnull {
            return new Dictionary<K, V>(2) {
                { t.Item1.Item1, t.Item1.Item2 },
                { t.Item2.Item1, t.Item2.Item2 }
            };
        }

        /// <summary>Creates a dictionary using items from <paramref name="t"/>.</summary>
        /// <typeparam name="K">Type of keys in key-value pairs in <paramref name="t"/>.</typeparam>
        /// <typeparam name="V">
        /// Type of values in key-value pairs in <paramref name="t"/>.
        /// </typeparam>
        /// <param name="t">
        /// Tuple with key-value pairs that will be inserted into the dictionary.
        /// </param>
        /// <returns>
        /// <see cref="Dictionary{K,V}"/> of size 3 whose elements are items of <paramref name="t"/>.
        /// </returns>
        public static Dictionary<K, V> ToDictionary<K, V>(
            this ValueTuple<(K, V), (K, V), (K, V)> t
        ) where K : notnull {
            return new Dictionary<K, V>(3) {
                { t.Item1.Item1, t.Item1.Item2 },
                { t.Item2.Item1, t.Item2.Item2 },
                { t.Item3.Item1, t.Item3.Item2 }
            };
        }

        /// <summary>Creates a dictionary using items from <paramref name="t"/>.</summary>
        /// <typeparam name="K">Type of keys in key-value pairs in <paramref name="t"/>.</typeparam>
        /// <typeparam name="V">
        /// Type of values in key-value pairs in <paramref name="t"/>.
        /// </typeparam>
        /// <param name="t">
        /// Tuple with key-value pairs that will be inserted into the dictionary.
        /// </param>
        /// <returns>
        /// <see cref="Dictionary{K,V}"/> of size 4 whose elements are items of <paramref name="t"/>.
        /// </returns>
        public static Dictionary<K, V> ToDictionary<K, V>(
            this ValueTuple<(K, V), (K, V), (K, V), (K, V)> t
        ) where K : notnull {
            return new Dictionary<K, V>(4) {
                { t.Item1.Item1, t.Item1.Item2 },
                { t.Item2.Item1, t.Item2.Item2 },
                { t.Item3.Item1, t.Item3.Item2 },
                { t.Item4.Item1, t.Item4.Item2 }
            };
        }

        /// <summary>Creates a dictionary using items from <paramref name="t"/>.</summary>
        /// <typeparam name="K">Type of keys in key-value pairs in <paramref name="t"/>.</typeparam>
        /// <typeparam name="V">
        /// Type of values in key-value pairs in <paramref name="t"/>.
        /// </typeparam>
        /// <param name="t">
        /// Tuple with key-value pairs that will be inserted into the dictionary.
        /// </param>
        /// <returns>
        /// <see cref="Dictionary{K,V}"/> of size 5 whose elements are items of <paramref name="t"/>.
        /// </returns>
        public static Dictionary<K, V> ToDictionary<K, V>(
            this ValueTuple<(K, V), (K, V), (K, V), (K, V), (K, V)> t
        ) where K : notnull {
            return new Dictionary<K, V>(5) {
                { t.Item1.Item1, t.Item1.Item2 },
                { t.Item2.Item1, t.Item2.Item2 },
                { t.Item3.Item1, t.Item3.Item2 },
                { t.Item4.Item1, t.Item4.Item2 },
                { t.Item5.Item1, t.Item5.Item2 }
            };
        }

        /// <summary>Creates a dictionary using items from <paramref name="t"/>.</summary>
        /// <typeparam name="K">Type of keys in key-value pairs in <paramref name="t"/>.</typeparam>
        /// <typeparam name="V">
        /// Type of values in key-value pairs in <paramref name="t"/>.
        /// </typeparam>
        /// <param name="t">
        /// Tuple with key-value pairs that will be inserted into the dictionary.
        /// </param>
        /// <returns>
        /// <see cref="Dictionary{K,V}"/> of size 6 whose elements are items of <paramref name="t"/>.
        /// </returns>
        public static Dictionary<K, V> ToDictionary<K, V>(
            this ValueTuple<(K, V), (K, V), (K, V), (K, V), (K, V), (K, V)> t
        ) where K : notnull {
            return new Dictionary<K, V>(6) {
                { t.Item1.Item1, t.Item1.Item2 },
                { t.Item2.Item1, t.Item2.Item2 },
                { t.Item3.Item1, t.Item3.Item2 },
                { t.Item4.Item1, t.Item4.Item2 },
                { t.Item5.Item1, t.Item5.Item2 },
                { t.Item6.Item1, t.Item6.Item2 }
            };
        }

        /// <summary>Creates a dictionary using items from <paramref name="t"/>.</summary>
        /// <typeparam name="K">Type of keys in key-value pairs in <paramref name="t"/>.</typeparam>
        /// <typeparam name="V">
        /// Type of values in key-value pairs in <paramref name="t"/>.
        /// </typeparam>
        /// <param name="t">
        /// Tuple with key-value pairs that will be inserted into the dictionary.
        /// </param>
        /// <returns>
        /// <see cref="Dictionary{K,V}"/> of size 7 whose elements are items of <paramref name="t"/>.
        /// </returns>
        public static Dictionary<K, V> ToDictionary<K, V>(
            this ValueTuple<(K, V), (K, V), (K, V), (K, V), (K, V), (K, V), (K, V)> t
        ) where K : notnull {
            return new Dictionary<K, V>(7) {
                { t.Item1.Item1, t.Item1.Item2 },
                { t.Item2.Item1, t.Item2.Item2 },
                { t.Item3.Item1, t.Item3.Item2 },
                { t.Item4.Item1, t.Item4.Item2 },
                { t.Item5.Item1, t.Item5.Item2 },
                { t.Item6.Item1, t.Item6.Item2 },
                { t.Item7.Item1, t.Item7.Item2 }
            };
        }

        /// <summary>Enumerates items in <paramref name="t"/>.</summary>
        /// <typeparam name="T">Type of items in <paramref name="t"/>.</typeparam>
        /// <param name="t">Tuple whose items will be enumerated.</param>
        /// <returns>
        /// <see cref="IEnumerable{T}"/> with items of <paramref name="t"/>.
        /// </returns>
        public static IEnumerable<T> Enumerate<T>(this ValueTuple<T, T> t) {
            yield return t.Item1;
            yield return t.Item2;
        }

        /// <summary>Enumerates items in <paramref name="t"/>.</summary>
        /// <typeparam name="T">Type of items in <paramref name="t"/>.</typeparam>
        /// <param name="t">Tuple whose items will be enumerated.</param>
        /// <returns>
        /// <see cref="IEnumerable{T}"/> with items of <paramref name="t"/>.
        /// </returns>
        public static IEnumerable<T> Enumerate<T>(this ValueTuple<T, T, T> t) {
            yield return t.Item1;
            yield return t.Item2;
            yield return t.Item3;
        }

        /// <summary>Enumerates items in <paramref name="t"/>.</summary>
        /// <typeparam name="T">Type of items in <paramref name="t"/>.</typeparam>
        /// <param name="t">Tuple whose items will be enumerated.</param>
        /// <returns>
        /// <see cref="IEnumerable{T}"/> with items of <paramref name="t"/>.
        /// </returns>
        public static IEnumerable<T> Enumerate<T>(this ValueTuple<T, T, T, T> t) {
            yield return t.Item1;
            yield return t.Item2;
            yield return t.Item3;
            yield return t.Item4;
        }

        /// <summary>Enumerates items in <paramref name="t"/>.</summary>
        /// <typeparam name="T">Type of items in <paramref name="t"/>.</typeparam>
        /// <param name="t">Tuple whose items will be enumerated.</param>
        /// <returns>
        /// <see cref="IEnumerable{T}"/> with items of <paramref name="t"/>.
        /// </returns>
        public static IEnumerable<T> Enumerate<T>(this ValueTuple<T, T, T, T, T> t) {
            yield return t.Item1;
            yield return t.Item2;
            yield return t.Item3;
            yield return t.Item4;
            yield return t.Item5;
        }

        /// <summary>Enumerates items in <paramref name="t"/>.</summary>
        /// <typeparam name="T">Type of items in <paramref name="t"/>.</typeparam>
        /// <param name="t">Tuple whose items will be enumerated.</param>
        /// <returns>
        /// <see cref="IEnumerable{T}"/> with items of <paramref name="t"/>.
        /// </returns>
        public static IEnumerable<T> Enumerate<T>(this ValueTuple<T, T, T, T, T, T> t) {
            yield return t.Item1;
            yield return t.Item2;
            yield return t.Item3;
            yield return t.Item4;
            yield return t.Item5;
            yield return t.Item6;
        }

        /// <summary>Enumerates items in <paramref name="t"/>.</summary>
        /// <typeparam name="T">Type of items in <paramref name="t"/>.</typeparam>
        /// <param name="t">Tuple whose items will be enumerated.</param>
        /// <returns>
        /// <see cref="IEnumerable{T}"/> with items of <paramref name="t"/>.
        /// </returns>
        public static IEnumerable<T> Enumerate<T>(this ValueTuple<T, T, T, T, T, T, T> t) {
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
