using System.Collections.Generic;

namespace Netxtendable.Collections {

/// <summary>Class with extension methods for <see cref="KeyValuePair{TKey, TValue}"/>.</summary>
    public static class KeyValuePairExtensions {

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
