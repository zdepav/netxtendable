#if NET_CORE
using System;
using System.Collections.Generic;

namespace Netxtendable.Extensions.Utils {

    /// <summary>Class with extension methods for <see cref="Range"/></summary>
    public static class RangeExtensions {

#if NET_5
        /// <summary>Returns an enumerator for the given range</summary>
        /// <param name="range">
        /// <see cref="Range"/> to enumerate. From-end index can be used as a negative number.
        /// </param>
        /// <returns><see cref="IEnumerator{T}"/> for the given range</returns>
        public static IEnumerator<int> GetEnumerator(this Range range) =>
            ToEnumerable(range).GetEnumerator();
#endif

        /// <summary>Returns an enumerable for the given range</summary>
        /// <param name="range">
        /// <see cref="Range"/> to enumerate. From-end index can be used as a negative number.
        /// </param>
        /// <returns><see cref="IEnumerable{T}"/> for the given range</returns>
        public static IEnumerable<int> ToEnumerable(this Range range) {
            var start = range.Start.IsFromEnd ? -range.Start.Value : range.Start.Value;
            var end = range.End.IsFromEnd ? -range.End.Value : range.End.Value;
            if (start == end) {
                yield break;
            } else if (start < end) {
                for (var i = start; i < end; ++i) {
                    yield return i;
                }
            } else {
                for (var i = start; i > end; --i) {
                    yield return i;
                }
            }
        }
    }
}
#endif
