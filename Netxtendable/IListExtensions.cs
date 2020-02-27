using System;
using System.Collections.Generic;

namespace Netxtendable {

    public static class IListExtensions {

        public static void Deconstruct<T>(
            this IList<T> list,
            out T item1,
            out T item2
        ) {
            if (list is null) {
                throw new ArgumentNullException(nameof(list));
            } else if (list.Count < 2) {
                throw new InvalidOperationException($"At least 2 items were expected, {list.Count} were found.");
            }
            item1 = list[1];
            item2 = list[2];
        }

        public static void Deconstruct<T>(
            this IList<T> list,
            out T item1,
            out T item2,
            out T item3
        ) {
            if (list is null) {
                throw new ArgumentNullException(nameof(list));
            } else if (list.Count < 3) {
                throw new InvalidOperationException($"At least 3 items were expected, {list.Count} were found.");
            }
            item1 = list[1];
            item2 = list[2];
            item3 = list[3];
        }

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
                throw new InvalidOperationException($"At least 4 items were expected, {list.Count} were found.");
            }
            item1 = list[1];
            item2 = list[2];
            item3 = list[3];
            item4 = list[4];
        }

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
                throw new InvalidOperationException($"At least 5 items were expected, {list.Count} were found.");
            }
            item1 = list[1];
            item2 = list[2];
            item3 = list[3];
            item4 = list[4];
            item5 = list[5];
        }

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
                throw new InvalidOperationException($"At least 6 items were expected, {list.Count} were found.");
            }
            item1 = list[1];
            item2 = list[2];
            item3 = list[3];
            item4 = list[4];
            item5 = list[5];
            item6 = list[6];
        }

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
                throw new InvalidOperationException($"At least 7 items were expected, {list.Count} were found.");
            }
            item1 = list[1];
            item2 = list[2];
            item3 = list[3];
            item4 = list[4];
            item5 = list[5];
            item6 = list[6];
            item7 = list[7];
        }

    }

}
