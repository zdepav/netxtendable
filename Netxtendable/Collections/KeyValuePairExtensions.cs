using System.Collections.Generic;

namespace Netxtendable.Collections {

    /// <summary>Class with extension methods for <see cref="KeyValuePair{TKey, TValue}"/>.</summary>
    public static class KeyValuePairExtensions {

        /// <summary>Deconstructs <paramref name="pair"/>.</summary>
        /// <typeparam name="TKey">Type of the key in <paramref name="pair"/>.</typeparam>
        /// <typeparam name="TValue">Type of the value in <paramref name="pair"/>.</typeparam>
        /// <param name="pair">Key-value pair to deconstruct.</param>
        /// <param name="key">Key part of <paramref name="pair"/>.</param>
        /// <param name="value">Value part of <paramref name="pair"/>.</param>
        public static void Deconstruct<TKey, TValue>(
            this KeyValuePair<TKey, TValue> pair,
            out TKey key,
            out TValue value
        ) {
            key = pair.Key;
            value = pair.Value;
        }
    }
}
