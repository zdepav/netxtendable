using System;

namespace Netxtendable {

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

    }

}
