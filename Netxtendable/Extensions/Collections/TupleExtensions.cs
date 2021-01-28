#nullable enable
using System;
using System.Collections.Generic;

// GENERATED CODE - DO NOT MODIFY

namespace Netxtendable.Extensions.Collections {

    /// <summary>Class with extension methods for <see cref="Tuple"/></summary>
    public static class TupleExtensions {

        /// <summary>Deconstructs <paramref name="t"/></summary>
        /// <typeparam name="T1">Type of first item in <paramref name="t"/></typeparam>
        /// <typeparam name="T2">Type of second item in <paramref name="t"/></typeparam>
        /// <param name="t">Tuple to deconstruct</param>
        /// <param name="item1">First output item</param>
        /// <param name="item2">Second output item</param>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="t"/> is null
        /// </exception>
        public static void Deconstruct<T1, T2>(
            this Tuple<T1, T2> t,
            out T1 item1,
            out T2 item2
        ) {
            if (t is null) {
                throw new ArgumentNullException(nameof(t));
            }
            item1 = t.Item1;
            item2 = t.Item2;
        }

        /// <summary>Deconstructs <paramref name="t"/></summary>
        /// <typeparam name="T1">Type of first item in <paramref name="t"/></typeparam>
        /// <typeparam name="T2">Type of second item in <paramref name="t"/></typeparam>
        /// <typeparam name="T3">Type of third item in <paramref name="t"/></typeparam>
        /// <param name="t">Tuple to deconstruct</param>
        /// <param name="item1">First output item</param>
        /// <param name="item2">Second output item</param>
        /// <param name="item3">Third output item</param>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="t"/> is null
        /// </exception>
        public static void Deconstruct<T1, T2, T3>(
            this Tuple<T1, T2, T3> t,
            out T1 item1,
            out T2 item2,
            out T3 item3
        ) {
            if (t is null) {
                throw new ArgumentNullException(nameof(t));
            }
            item1 = t.Item1;
            item2 = t.Item2;
            item3 = t.Item3;
        }

        /// <summary>Deconstructs <paramref name="t"/></summary>
        /// <typeparam name="T1">Type of first item in <paramref name="t"/></typeparam>
        /// <typeparam name="T2">Type of second item in <paramref name="t"/></typeparam>
        /// <typeparam name="T3">Type of third item in <paramref name="t"/></typeparam>
        /// <typeparam name="T4">Type of fourth item in <paramref name="t"/></typeparam>
        /// <param name="t">Tuple to deconstruct</param>
        /// <param name="item1">First output item</param>
        /// <param name="item2">Second output item</param>
        /// <param name="item3">Third output item</param>
        /// <param name="item4">Fourth output item</param>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="t"/> is null
        /// </exception>
        public static void Deconstruct<T1, T2, T3, T4>(
            this Tuple<T1, T2, T3, T4> t,
            out T1 item1,
            out T2 item2,
            out T3 item3,
            out T4 item4
        ) {
            if (t is null) {
                throw new ArgumentNullException(nameof(t));
            }
            item1 = t.Item1;
            item2 = t.Item2;
            item3 = t.Item3;
            item4 = t.Item4;
        }

        /// <summary>Deconstructs <paramref name="t"/></summary>
        /// <typeparam name="T1">Type of first item in <paramref name="t"/></typeparam>
        /// <typeparam name="T2">Type of second item in <paramref name="t"/></typeparam>
        /// <typeparam name="T3">Type of third item in <paramref name="t"/></typeparam>
        /// <typeparam name="T4">Type of fourth item in <paramref name="t"/></typeparam>
        /// <typeparam name="T5">Type of fifth item in <paramref name="t"/></typeparam>
        /// <param name="t">Tuple to deconstruct</param>
        /// <param name="item1">First output item</param>
        /// <param name="item2">Second output item</param>
        /// <param name="item3">Third output item</param>
        /// <param name="item4">Fourth output item</param>
        /// <param name="item5">Fifth output item</param>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="t"/> is null
        /// </exception>
        public static void Deconstruct<T1, T2, T3, T4, T5>(
            this Tuple<T1, T2, T3, T4, T5> t,
            out T1 item1,
            out T2 item2,
            out T3 item3,
            out T4 item4,
            out T5 item5
        ) {
            if (t is null) {
                throw new ArgumentNullException(nameof(t));
            }
            item1 = t.Item1;
            item2 = t.Item2;
            item3 = t.Item3;
            item4 = t.Item4;
            item5 = t.Item5;
        }

        /// <summary>Deconstructs <paramref name="t"/></summary>
        /// <typeparam name="T1">Type of first item in <paramref name="t"/></typeparam>
        /// <typeparam name="T2">Type of second item in <paramref name="t"/></typeparam>
        /// <typeparam name="T3">Type of third item in <paramref name="t"/></typeparam>
        /// <typeparam name="T4">Type of fourth item in <paramref name="t"/></typeparam>
        /// <typeparam name="T5">Type of fifth item in <paramref name="t"/></typeparam>
        /// <typeparam name="T6">Type of sixth item in <paramref name="t"/></typeparam>
        /// <param name="t">Tuple to deconstruct</param>
        /// <param name="item1">First output item</param>
        /// <param name="item2">Second output item</param>
        /// <param name="item3">Third output item</param>
        /// <param name="item4">Fourth output item</param>
        /// <param name="item5">Fifth output item</param>
        /// <param name="item6">Sixth output item</param>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="t"/> is null
        /// </exception>
        public static void Deconstruct<T1, T2, T3, T4, T5, T6>(
            this Tuple<T1, T2, T3, T4, T5, T6> t,
            out T1 item1,
            out T2 item2,
            out T3 item3,
            out T4 item4,
            out T5 item5,
            out T6 item6
        ) {
            if (t is null) {
                throw new ArgumentNullException(nameof(t));
            }
            item1 = t.Item1;
            item2 = t.Item2;
            item3 = t.Item3;
            item4 = t.Item4;
            item5 = t.Item5;
            item6 = t.Item6;
        }

        /// <summary>Deconstructs <paramref name="t"/></summary>
        /// <typeparam name="T1">Type of first item in <paramref name="t"/></typeparam>
        /// <typeparam name="T2">Type of second item in <paramref name="t"/></typeparam>
        /// <typeparam name="T3">Type of third item in <paramref name="t"/></typeparam>
        /// <typeparam name="T4">Type of fourth item in <paramref name="t"/></typeparam>
        /// <typeparam name="T5">Type of fifth item in <paramref name="t"/></typeparam>
        /// <typeparam name="T6">Type of sixth item in <paramref name="t"/></typeparam>
        /// <typeparam name="T7">Type of seventh item in <paramref name="t"/></typeparam>
        /// <param name="t">Tuple to deconstruct</param>
        /// <param name="item1">First output item</param>
        /// <param name="item2">Second output item</param>
        /// <param name="item3">Third output item</param>
        /// <param name="item4">Fourth output item</param>
        /// <param name="item5">Fifth output item</param>
        /// <param name="item6">Sixth output item</param>
        /// <param name="item7">Seventh output item</param>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="t"/> is null
        /// </exception>
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
            if (t is null) {
                throw new ArgumentNullException(nameof(t));
            }
            item1 = t.Item1;
            item2 = t.Item2;
            item3 = t.Item3;
            item4 = t.Item4;
            item5 = t.Item5;
            item6 = t.Item6;
            item7 = t.Item7;
        }

        /// <summary>Creates an array using items from <paramref name="t"/></summary>
        /// <typeparam name="T">Type of items in <paramref name="t"/></typeparam>
        /// <param name="t">Tuple whose items will be inserted into the array</param>
        /// <returns>
        /// Array of size 2 whose elements are items of <paramref name="t"/>
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="t"/> is null
        /// </exception>
        public static T[] ToArray<T>(this Tuple<T, T> t) =>
            t is null
                ? throw new ArgumentNullException(nameof(t))
                : new[] { t.Item1, t.Item2 };

        /// <summary>Creates an array using items from <paramref name="t"/></summary>
        /// <typeparam name="T">Type of items in <paramref name="t"/></typeparam>
        /// <param name="t">Tuple whose items will be inserted into the array</param>
        /// <returns>
        /// Array of size 3 whose elements are items of <paramref name="t"/>
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="t"/> is null
        /// </exception>
        public static T[] ToArray<T>(this Tuple<T, T, T> t) =>
            t is null
                ? throw new ArgumentNullException(nameof(t))
                : new[] { t.Item1, t.Item2, t.Item3 };

        /// <summary>Creates an array using items from <paramref name="t"/></summary>
        /// <typeparam name="T">Type of items in <paramref name="t"/></typeparam>
        /// <param name="t">Tuple whose items will be inserted into the array</param>
        /// <returns>
        /// Array of size 4 whose elements are items of <paramref name="t"/>
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="t"/> is null
        /// </exception>
        public static T[] ToArray<T>(this Tuple<T, T, T, T> t) =>
            t is null
                ? throw new ArgumentNullException(nameof(t))
                : new[] { t.Item1, t.Item2, t.Item3, t.Item4 };

        /// <summary>Creates an array using items from <paramref name="t"/></summary>
        /// <typeparam name="T">Type of items in <paramref name="t"/></typeparam>
        /// <param name="t">Tuple whose items will be inserted into the array</param>
        /// <returns>
        /// Array of size 5 whose elements are items of <paramref name="t"/>
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="t"/> is null
        /// </exception>
        public static T[] ToArray<T>(this Tuple<T, T, T, T, T> t) =>
            t is null
                ? throw new ArgumentNullException(nameof(t))
                : new[] { t.Item1, t.Item2, t.Item3, t.Item4, t.Item5 };

        /// <summary>Creates an array using items from <paramref name="t"/></summary>
        /// <typeparam name="T">Type of items in <paramref name="t"/></typeparam>
        /// <param name="t">Tuple whose items will be inserted into the array</param>
        /// <returns>
        /// Array of size 6 whose elements are items of <paramref name="t"/>
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="t"/> is null
        /// </exception>
        public static T[] ToArray<T>(this Tuple<T, T, T, T, T, T> t) =>
            t is null
                ? throw new ArgumentNullException(nameof(t))
                : new[] { t.Item1, t.Item2, t.Item3, t.Item4, t.Item5, t.Item6 };

        /// <summary>Creates an array using items from <paramref name="t"/></summary>
        /// <typeparam name="T">Type of items in <paramref name="t"/></typeparam>
        /// <param name="t">Tuple whose items will be inserted into the array</param>
        /// <returns>
        /// Array of size 7 whose elements are items of <paramref name="t"/>
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="t"/> is null
        /// </exception>
        public static T[] ToArray<T>(this Tuple<T, T, T, T, T, T, T> t) =>
            t is null
                ? throw new ArgumentNullException(nameof(t))
                : new[] { t.Item1, t.Item2, t.Item3, t.Item4, t.Item5, t.Item6, t.Item7 };

        /// <summary>Creates a list using items from <paramref name="t"/></summary>
        /// <typeparam name="T">Type of items in <paramref name="t"/></typeparam>
        /// <param name="t">Tuple whose items will be inserted into the list</param>
        /// <returns>
        /// <see cref="List{T}"/> of size 2 whose elements are items of <paramref name="t"/>
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="t"/> is null
        /// </exception>
        public static List<T> ToList<T>(this Tuple<T, T> t) =>
            t is null
                ? throw new ArgumentNullException(nameof(t))
                : new List<T>(2) { t.Item1, t.Item2 };

        /// <summary>Creates a list using items from <paramref name="t"/></summary>
        /// <typeparam name="T">Type of items in <paramref name="t"/></typeparam>
        /// <param name="t">Tuple whose items will be inserted into the list</param>
        /// <returns>
        /// <see cref="List{T}"/> of size 3 whose elements are items of <paramref name="t"/>
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="t"/> is null
        /// </exception>
        public static List<T> ToList<T>(this Tuple<T, T, T> t) =>
            t is null
                ? throw new ArgumentNullException(nameof(t))
                : new List<T>(3) { t.Item1, t.Item2, t.Item3 };

        /// <summary>Creates a list using items from <paramref name="t"/></summary>
        /// <typeparam name="T">Type of items in <paramref name="t"/></typeparam>
        /// <param name="t">Tuple whose items will be inserted into the list</param>
        /// <returns>
        /// <see cref="List{T}"/> of size 4 whose elements are items of <paramref name="t"/>
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="t"/> is null
        /// </exception>
        public static List<T> ToList<T>(this Tuple<T, T, T, T> t) =>
            t is null
                ? throw new ArgumentNullException(nameof(t))
                : new List<T>(4) { t.Item1, t.Item2, t.Item3, t.Item4 };

        /// <summary>Creates a list using items from <paramref name="t"/></summary>
        /// <typeparam name="T">Type of items in <paramref name="t"/></typeparam>
        /// <param name="t">Tuple whose items will be inserted into the list</param>
        /// <returns>
        /// <see cref="List{T}"/> of size 5 whose elements are items of <paramref name="t"/>
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="t"/> is null
        /// </exception>
        public static List<T> ToList<T>(this Tuple<T, T, T, T, T> t) =>
            t is null
                ? throw new ArgumentNullException(nameof(t))
                : new List<T>(5) { t.Item1, t.Item2, t.Item3, t.Item4, t.Item5 };

        /// <summary>Creates a list using items from <paramref name="t"/></summary>
        /// <typeparam name="T">Type of items in <paramref name="t"/></typeparam>
        /// <param name="t">Tuple whose items will be inserted into the list</param>
        /// <returns>
        /// <see cref="List{T}"/> of size 6 whose elements are items of <paramref name="t"/>
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="t"/> is null
        /// </exception>
        public static List<T> ToList<T>(this Tuple<T, T, T, T, T, T> t) =>
            t is null
                ? throw new ArgumentNullException(nameof(t))
                : new List<T>(6) { t.Item1, t.Item2, t.Item3, t.Item4, t.Item5, t.Item6 };

        /// <summary>Creates a list using items from <paramref name="t"/></summary>
        /// <typeparam name="T">Type of items in <paramref name="t"/></typeparam>
        /// <param name="t">Tuple whose items will be inserted into the list</param>
        /// <returns>
        /// <see cref="List{T}"/> of size 7 whose elements are items of <paramref name="t"/>
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="t"/> is null
        /// </exception>
        public static List<T> ToList<T>(this Tuple<T, T, T, T, T, T, T> t) =>
            t is null
                ? throw new ArgumentNullException(nameof(t))
                : new List<T>(7) { t.Item1, t.Item2, t.Item3, t.Item4, t.Item5, t.Item6, t.Item7 };

        /// <summary>Creates a set using items from <paramref name="t"/></summary>
        /// <typeparam name="T">Type of items in <paramref name="t"/></typeparam>
        /// <param name="t">Tuple whose items will be inserted into the set</param>
        /// <returns>
        /// <see cref="HashSet{T}"/> of size 2 whose elements are items of <paramref name="t"/>
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="t"/> is null
        /// </exception>
        public static HashSet<T> ToSet<T>(this Tuple<T, T> t) =>
            t is null
                ? throw new ArgumentNullException(nameof(t))
                : new HashSet<T>(2) { t.Item1, t.Item2 };

        /// <summary>Creates a set using items from <paramref name="t"/></summary>
        /// <typeparam name="T">Type of items in <paramref name="t"/></typeparam>
        /// <param name="t">Tuple whose items will be inserted into the set</param>
        /// <returns>
        /// <see cref="HashSet{T}"/> of size 3 whose elements are items of <paramref name="t"/>
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="t"/> is null
        /// </exception>
        public static HashSet<T> ToSet<T>(this Tuple<T, T, T> t) =>
            t is null
                ? throw new ArgumentNullException(nameof(t))
                : new HashSet<T>(3) { t.Item1, t.Item2, t.Item3 };

        /// <summary>Creates a set using items from <paramref name="t"/></summary>
        /// <typeparam name="T">Type of items in <paramref name="t"/></typeparam>
        /// <param name="t">Tuple whose items will be inserted into the set</param>
        /// <returns>
        /// <see cref="HashSet{T}"/> of size 4 whose elements are items of <paramref name="t"/>
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="t"/> is null
        /// </exception>
        public static HashSet<T> ToSet<T>(this Tuple<T, T, T, T> t) =>
            t is null
                ? throw new ArgumentNullException(nameof(t))
                : new HashSet<T>(4) { t.Item1, t.Item2, t.Item3, t.Item4 };

        /// <summary>Creates a set using items from <paramref name="t"/></summary>
        /// <typeparam name="T">Type of items in <paramref name="t"/></typeparam>
        /// <param name="t">Tuple whose items will be inserted into the set</param>
        /// <returns>
        /// <see cref="HashSet{T}"/> of size 5 whose elements are items of <paramref name="t"/>
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="t"/> is null
        /// </exception>
        public static HashSet<T> ToSet<T>(this Tuple<T, T, T, T, T> t) =>
            t is null
                ? throw new ArgumentNullException(nameof(t))
                : new HashSet<T>(5) { t.Item1, t.Item2, t.Item3, t.Item4, t.Item5 };

        /// <summary>Creates a set using items from <paramref name="t"/></summary>
        /// <typeparam name="T">Type of items in <paramref name="t"/></typeparam>
        /// <param name="t">Tuple whose items will be inserted into the set</param>
        /// <returns>
        /// <see cref="HashSet{T}"/> of size 6 whose elements are items of <paramref name="t"/>
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="t"/> is null
        /// </exception>
        public static HashSet<T> ToSet<T>(this Tuple<T, T, T, T, T, T> t) =>
            t is null
                ? throw new ArgumentNullException(nameof(t))
                : new HashSet<T>(6) { t.Item1, t.Item2, t.Item3, t.Item4, t.Item5, t.Item6 };

        /// <summary>Creates a set using items from <paramref name="t"/></summary>
        /// <typeparam name="T">Type of items in <paramref name="t"/></typeparam>
        /// <param name="t">Tuple whose items will be inserted into the set</param>
        /// <returns>
        /// <see cref="HashSet{T}"/> of size 7 whose elements are items of <paramref name="t"/>
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="t"/> is null
        /// </exception>
        public static HashSet<T> ToSet<T>(this Tuple<T, T, T, T, T, T, T> t) =>
            t is null
                ? throw new ArgumentNullException(nameof(t))
                : new HashSet<T>(7) { t.Item1, t.Item2, t.Item3, t.Item4, t.Item5, t.Item6, t.Item7 };

        /// <summary>Creates a dictionary using items from <paramref name="t"/></summary>
        /// <typeparam name="K">Type of keys in key-value pairs in <paramref name="t"/></typeparam>
        /// <typeparam name="V">
        /// Type of values in key-value pairs in <paramref name="t"/>
        /// </typeparam>
        /// <param name="t">
        /// Tuple with key-value pairs that will be inserted into the dictionary
        /// </param>
        /// <returns>
        /// <see cref="Dictionary{K,V}"/> of size 2 whose elements are items of <paramref name="t"/>
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="t"/> is null
        /// </exception>
        public static Dictionary<K, V> ToDictionary<K, V>(
            this Tuple<(K, V), (K, V)> t
        ) where K : notnull {
            if (t is null) {
                throw new ArgumentNullException(nameof(t));
            }
            return new Dictionary<K, V>(2) {
                { t.Item1.Item1, t.Item1.Item2 },
                { t.Item2.Item1, t.Item2.Item2 }
            };
        }

        /// <summary>Creates a dictionary using items from <paramref name="t"/></summary>
        /// <typeparam name="K">Type of keys in key-value pairs in <paramref name="t"/></typeparam>
        /// <typeparam name="V">
        /// Type of values in key-value pairs in <paramref name="t"/>
        /// </typeparam>
        /// <param name="t">
        /// Tuple with key-value pairs that will be inserted into the dictionary
        /// </param>
        /// <returns>
        /// <see cref="Dictionary{K,V}"/> of size 3 whose elements are items of <paramref name="t"/>
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="t"/> is null
        /// </exception>
        public static Dictionary<K, V> ToDictionary<K, V>(
            this Tuple<(K, V), (K, V), (K, V)> t
        ) where K : notnull {
            if (t is null) {
                throw new ArgumentNullException(nameof(t));
            }
            return new Dictionary<K, V>(3) {
                { t.Item1.Item1, t.Item1.Item2 },
                { t.Item2.Item1, t.Item2.Item2 },
                { t.Item3.Item1, t.Item3.Item2 }
            };
        }

        /// <summary>Creates a dictionary using items from <paramref name="t"/></summary>
        /// <typeparam name="K">Type of keys in key-value pairs in <paramref name="t"/></typeparam>
        /// <typeparam name="V">
        /// Type of values in key-value pairs in <paramref name="t"/>
        /// </typeparam>
        /// <param name="t">
        /// Tuple with key-value pairs that will be inserted into the dictionary
        /// </param>
        /// <returns>
        /// <see cref="Dictionary{K,V}"/> of size 4 whose elements are items of <paramref name="t"/>
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="t"/> is null
        /// </exception>
        public static Dictionary<K, V> ToDictionary<K, V>(
            this Tuple<(K, V), (K, V), (K, V), (K, V)> t
        ) where K : notnull {
            if (t is null) {
                throw new ArgumentNullException(nameof(t));
            }
            return new Dictionary<K, V>(4) {
                { t.Item1.Item1, t.Item1.Item2 },
                { t.Item2.Item1, t.Item2.Item2 },
                { t.Item3.Item1, t.Item3.Item2 },
                { t.Item4.Item1, t.Item4.Item2 }
            };
        }

        /// <summary>Creates a dictionary using items from <paramref name="t"/></summary>
        /// <typeparam name="K">Type of keys in key-value pairs in <paramref name="t"/></typeparam>
        /// <typeparam name="V">
        /// Type of values in key-value pairs in <paramref name="t"/>
        /// </typeparam>
        /// <param name="t">
        /// Tuple with key-value pairs that will be inserted into the dictionary
        /// </param>
        /// <returns>
        /// <see cref="Dictionary{K,V}"/> of size 5 whose elements are items of <paramref name="t"/>
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="t"/> is null
        /// </exception>
        public static Dictionary<K, V> ToDictionary<K, V>(
            this Tuple<(K, V), (K, V), (K, V), (K, V), (K, V)> t
        ) where K : notnull {
            if (t is null) {
                throw new ArgumentNullException(nameof(t));
            }
            return new Dictionary<K, V>(5) {
                { t.Item1.Item1, t.Item1.Item2 },
                { t.Item2.Item1, t.Item2.Item2 },
                { t.Item3.Item1, t.Item3.Item2 },
                { t.Item4.Item1, t.Item4.Item2 },
                { t.Item5.Item1, t.Item5.Item2 }
            };
        }

        /// <summary>Creates a dictionary using items from <paramref name="t"/></summary>
        /// <typeparam name="K">Type of keys in key-value pairs in <paramref name="t"/></typeparam>
        /// <typeparam name="V">
        /// Type of values in key-value pairs in <paramref name="t"/>
        /// </typeparam>
        /// <param name="t">
        /// Tuple with key-value pairs that will be inserted into the dictionary
        /// </param>
        /// <returns>
        /// <see cref="Dictionary{K,V}"/> of size 6 whose elements are items of <paramref name="t"/>
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="t"/> is null
        /// </exception>
        public static Dictionary<K, V> ToDictionary<K, V>(
            this Tuple<(K, V), (K, V), (K, V), (K, V), (K, V), (K, V)> t
        ) where K : notnull {
            if (t is null) {
                throw new ArgumentNullException(nameof(t));
            }
            return new Dictionary<K, V>(6) {
                { t.Item1.Item1, t.Item1.Item2 },
                { t.Item2.Item1, t.Item2.Item2 },
                { t.Item3.Item1, t.Item3.Item2 },
                { t.Item4.Item1, t.Item4.Item2 },
                { t.Item5.Item1, t.Item5.Item2 },
                { t.Item6.Item1, t.Item6.Item2 }
            };
        }

        /// <summary>Creates a dictionary using items from <paramref name="t"/></summary>
        /// <typeparam name="K">Type of keys in key-value pairs in <paramref name="t"/></typeparam>
        /// <typeparam name="V">
        /// Type of values in key-value pairs in <paramref name="t"/>
        /// </typeparam>
        /// <param name="t">
        /// Tuple with key-value pairs that will be inserted into the dictionary
        /// </param>
        /// <returns>
        /// <see cref="Dictionary{K,V}"/> of size 7 whose elements are items of <paramref name="t"/>
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="t"/> is null
        /// </exception>
        public static Dictionary<K, V> ToDictionary<K, V>(
            this Tuple<(K, V), (K, V), (K, V), (K, V), (K, V), (K, V), (K, V)> t
        ) where K : notnull {
            if (t is null) {
                throw new ArgumentNullException(nameof(t));
            }
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

        #if NET_5
        /// <summary>Enumerates items in <paramref name="t"/></summary>
        /// <typeparam name="T">Type of items in <paramref name="t"/></typeparam>
        /// <param name="t">Tuple whose items will be enumerated</param>
        /// <returns>
        /// <see cref="IEnumerable{T}"/> with items of <paramref name="t"/>
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="t"/> is null
        /// </exception>
        public static IEnumerator<T> GetEnumerator<T>(this Tuple<T, T> t) {
            if (t is null) {
                throw new ArgumentNullException(nameof(t));
            }
            yield return t.Item1;
            yield return t.Item2;
        }
        #endif

        /// <summary>Enumerates items in <paramref name="t"/></summary>
        /// <typeparam name="T">Type of items in <paramref name="t"/></typeparam>
        /// <param name="t">Tuple whose items will be enumerated</param>
        /// <returns>
        /// <see cref="IEnumerable{T}"/> with items of <paramref name="t"/>
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="t"/> is null
        /// </exception>
        public static IEnumerable<T> Enumerate<T>(this Tuple<T, T> t) {
            if (t is null) {
                throw new ArgumentNullException(nameof(t));
            }
            yield return t.Item1;
            yield return t.Item2;
        }

        #if NET_5
        /// <summary>Enumerates items in <paramref name="t"/></summary>
        /// <typeparam name="T">Type of items in <paramref name="t"/></typeparam>
        /// <param name="t">Tuple whose items will be enumerated</param>
        /// <returns>
        /// <see cref="IEnumerable{T}"/> with items of <paramref name="t"/>
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="t"/> is null
        /// </exception>
        public static IEnumerator<T> GetEnumerator<T>(this Tuple<T, T, T> t) {
            if (t is null) {
                throw new ArgumentNullException(nameof(t));
            }
            yield return t.Item1;
            yield return t.Item2;
            yield return t.Item3;
        }
        #endif

        /// <summary>Enumerates items in <paramref name="t"/></summary>
        /// <typeparam name="T">Type of items in <paramref name="t"/></typeparam>
        /// <param name="t">Tuple whose items will be enumerated</param>
        /// <returns>
        /// <see cref="IEnumerable{T}"/> with items of <paramref name="t"/>
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="t"/> is null
        /// </exception>
        public static IEnumerable<T> Enumerate<T>(this Tuple<T, T, T> t) {
            if (t is null) {
                throw new ArgumentNullException(nameof(t));
            }
            yield return t.Item1;
            yield return t.Item2;
            yield return t.Item3;
        }

        #if NET_5
        /// <summary>Enumerates items in <paramref name="t"/></summary>
        /// <typeparam name="T">Type of items in <paramref name="t"/></typeparam>
        /// <param name="t">Tuple whose items will be enumerated</param>
        /// <returns>
        /// <see cref="IEnumerable{T}"/> with items of <paramref name="t"/>
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="t"/> is null
        /// </exception>
        public static IEnumerator<T> GetEnumerator<T>(this Tuple<T, T, T, T> t) {
            if (t is null) {
                throw new ArgumentNullException(nameof(t));
            }
            yield return t.Item1;
            yield return t.Item2;
            yield return t.Item3;
            yield return t.Item4;
        }
        #endif

        /// <summary>Enumerates items in <paramref name="t"/></summary>
        /// <typeparam name="T">Type of items in <paramref name="t"/></typeparam>
        /// <param name="t">Tuple whose items will be enumerated</param>
        /// <returns>
        /// <see cref="IEnumerable{T}"/> with items of <paramref name="t"/>
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="t"/> is null
        /// </exception>
        public static IEnumerable<T> Enumerate<T>(this Tuple<T, T, T, T> t) {
            if (t is null) {
                throw new ArgumentNullException(nameof(t));
            }
            yield return t.Item1;
            yield return t.Item2;
            yield return t.Item3;
            yield return t.Item4;
        }

        #if NET_5
        /// <summary>Enumerates items in <paramref name="t"/></summary>
        /// <typeparam name="T">Type of items in <paramref name="t"/></typeparam>
        /// <param name="t">Tuple whose items will be enumerated</param>
        /// <returns>
        /// <see cref="IEnumerable{T}"/> with items of <paramref name="t"/>
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="t"/> is null
        /// </exception>
        public static IEnumerator<T> GetEnumerator<T>(this Tuple<T, T, T, T, T> t) {
            if (t is null) {
                throw new ArgumentNullException(nameof(t));
            }
            yield return t.Item1;
            yield return t.Item2;
            yield return t.Item3;
            yield return t.Item4;
            yield return t.Item5;
        }
        #endif

        /// <summary>Enumerates items in <paramref name="t"/></summary>
        /// <typeparam name="T">Type of items in <paramref name="t"/></typeparam>
        /// <param name="t">Tuple whose items will be enumerated</param>
        /// <returns>
        /// <see cref="IEnumerable{T}"/> with items of <paramref name="t"/>
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="t"/> is null
        /// </exception>
        public static IEnumerable<T> Enumerate<T>(this Tuple<T, T, T, T, T> t) {
            if (t is null) {
                throw new ArgumentNullException(nameof(t));
            }
            yield return t.Item1;
            yield return t.Item2;
            yield return t.Item3;
            yield return t.Item4;
            yield return t.Item5;
        }

        #if NET_5
        /// <summary>Enumerates items in <paramref name="t"/></summary>
        /// <typeparam name="T">Type of items in <paramref name="t"/></typeparam>
        /// <param name="t">Tuple whose items will be enumerated</param>
        /// <returns>
        /// <see cref="IEnumerable{T}"/> with items of <paramref name="t"/>
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="t"/> is null
        /// </exception>
        public static IEnumerator<T> GetEnumerator<T>(this Tuple<T, T, T, T, T, T> t) {
            if (t is null) {
                throw new ArgumentNullException(nameof(t));
            }
            yield return t.Item1;
            yield return t.Item2;
            yield return t.Item3;
            yield return t.Item4;
            yield return t.Item5;
            yield return t.Item6;
        }
        #endif

        /// <summary>Enumerates items in <paramref name="t"/></summary>
        /// <typeparam name="T">Type of items in <paramref name="t"/></typeparam>
        /// <param name="t">Tuple whose items will be enumerated</param>
        /// <returns>
        /// <see cref="IEnumerable{T}"/> with items of <paramref name="t"/>
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="t"/> is null
        /// </exception>
        public static IEnumerable<T> Enumerate<T>(this Tuple<T, T, T, T, T, T> t) {
            if (t is null) {
                throw new ArgumentNullException(nameof(t));
            }
            yield return t.Item1;
            yield return t.Item2;
            yield return t.Item3;
            yield return t.Item4;
            yield return t.Item5;
            yield return t.Item6;
        }

        #if NET_5
        /// <summary>Enumerates items in <paramref name="t"/></summary>
        /// <typeparam name="T">Type of items in <paramref name="t"/></typeparam>
        /// <param name="t">Tuple whose items will be enumerated</param>
        /// <returns>
        /// <see cref="IEnumerable{T}"/> with items of <paramref name="t"/>
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="t"/> is null
        /// </exception>
        public static IEnumerator<T> GetEnumerator<T>(this Tuple<T, T, T, T, T, T, T> t) {
            if (t is null) {
                throw new ArgumentNullException(nameof(t));
            }
            yield return t.Item1;
            yield return t.Item2;
            yield return t.Item3;
            yield return t.Item4;
            yield return t.Item5;
            yield return t.Item6;
            yield return t.Item7;
        }
        #endif

        /// <summary>Enumerates items in <paramref name="t"/></summary>
        /// <typeparam name="T">Type of items in <paramref name="t"/></typeparam>
        /// <param name="t">Tuple whose items will be enumerated</param>
        /// <returns>
        /// <see cref="IEnumerable{T}"/> with items of <paramref name="t"/>
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="t"/> is null
        /// </exception>
        public static IEnumerable<T> Enumerate<T>(this Tuple<T, T, T, T, T, T, T> t) {
            if (t is null) {
                throw new ArgumentNullException(nameof(t));
            }
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
