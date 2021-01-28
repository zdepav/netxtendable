#nullable enable
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Netxtendable.Collections {

    /// <summary>A basic trie implementation</summary>
    /// <remarks>Uses <see cref="Dictionary{TKey, TValue}"/> to store tree edges</remarks>
    public class Trie : ICollection<string> {

        private class Node : IEnumerable<string> {

            public bool isWord;

            public Dictionary<char, Node?>? edges;

            public int Count { get; private set; }

            public bool IsEmpty => Count == 0;

            public Node() {
                isWord = false;
                edges = null;
                Count = 0;
            }

            public int Search(string str, int pos, int endIndex) {
                if (pos > endIndex) {
                    return -1;
                } else if (isWord) {
                    return pos;
                } else if (pos == endIndex) {
                    return -1;
                } else if (
                    pos < str.Length &&
                    edges != null &&
                    edges.TryGetValue(str[pos], out var node)
                ) {
                    return node!.Search(str, pos + 1, endIndex);
                } else {
                    return -1;
                }
            }

            public IEnumerable<(int start, int length)> SearchAll(
                string str,
                int pos,
                int endIndex
            ) {
                if (pos > endIndex) {
                    yield break;
                }
                for (var start = pos; start <= endIndex; pos = ++start) {
                    for (var current = this; pos <= endIndex; ++pos) {
                        if (current.isWord) {
                            yield return (start, pos - start);
                        }
                        if (pos < str.Length &&
                            current.edges != null &&
                            current.edges.TryGetValue(str[pos], out var node)
                        ) {
                            current = node!;
                        } else {
                            break;
                        }
                    }
                }
            }

            public bool ContainsPrefix(string str, int pos) {
                if (pos < str.Length) {
                    return edges != null &&
                           edges.TryGetValue(str[pos], out var node) &&
                           node!.ContainsPrefix(str, pos + 1);
                } else {
                    return true;
                }
            }

            public bool Contains(string str, int pos) {
                if (pos < str.Length) {
                    return edges != null &&
                           edges.TryGetValue(str[pos], out var node) &&
                           node!.Contains(str, pos + 1);
                } else {
                    return isWord;
                }
            }

            public bool Add(string str, int pos) {
                if (pos < str.Length) {
                    edges ??= new Dictionary<char, Node?>();
                    if (!edges.TryGetValue(str[pos], out var node)) {
                        edges.Add(str[pos], node = new Node());
                    }
                    if (node!.Add(str, pos + 1)) {
                        ++Count;
                        return true;
                    } else {
                        return false;
                    }
                } else {
                    if (isWord) {
                        return false;
                    } else {
                        ++Count;
                        isWord = true;
                        return true;
                    }
                }
            }

            public bool Remove(string str, int pos) {
                if (pos < str.Length) {
                    if (edges is null) {
                        return false;
                    } else if (edges.TryGetValue(str[pos], out var node)) {
                        var removed = node!.Remove(str, pos + 1);
                        if (removed) {
                            --Count;
                        }
                        if (node.IsEmpty) {
                            edges.Remove(str[pos]);
                        }
                        return removed;
                    }
                    return false;
                } else {
                    if (isWord) {
                        isWord = false;
                        --Count;
                        return true;
                    } else {
                        return false;
                    }
                }
            }

            public int RemoveAll(Predicate<string> match, string strBase = "") {
                var removed = 0;
                if (isWord && match(strBase)) {
                    isWord = false;
                    removed = 1;
                }
                if (edges != null) {
                    List<char>? toRemove = null;
                    foreach (var pair in edges) {
                        removed += pair.Value!.RemoveAll(match, strBase + pair.Key);
                        if (pair.Value!.IsEmpty) {
                            (toRemove ??= new List<char>()).Add(pair.Key);
                        }
                    }
                    if (toRemove != null) {
                        foreach (var c in toRemove) {
                            edges.Remove(c);
                        }
                    }
                }
                Count -= removed;
                return removed;
            }

            public void Clear() {
                isWord = false;
                Count = 0;
                edges?.Clear();
            }

            IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

            public IEnumerator<string> GetEnumerator() {
                if (isWord) {
                    yield return "";
                }
                if (edges is null) {
                    yield break;
                }
                foreach (var pair in edges) {
                    foreach (var str in pair.Value!) {
                        yield return pair.Key + str;
                    }
                }
            }

            public IEnumerable<string> EnumerateSorted() {
                if (isWord) {
                    yield return "";
                }
                if (edges is null) {
                    yield break;
                }
                foreach (var pair in edges.OrderBy(p => p.Key)) {
                    foreach (var str in pair.Value!.EnumerateSorted()) {
                        yield return pair.Key + str;
                    }
                }
            }
        }

        private readonly Node root;

        /// <inheritdoc/>
        public int Count => root.Count;

        /// <inheritdoc/>
        public bool IsReadOnly => false;

        /// <summary>Returns true when <see cref="Count"/> is 0</summary>
        public bool IsEmpty => Count == 0;

        /// <summary>Creates an empty trie</summary>
        public Trie() {
            root = new Node();
        }

        /// <summary>Creates a trie that contains a given set of strings</summary>
        /// <param name="items">Strings to add</param>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="items"/> is null
        /// </exception>
        /// <exception cref="ArgumentException">
        /// Thrown when <paramref name="items"/> contains null
        /// </exception>
        public Trie(IEnumerable<string> items) {
            root = new Node();
            AddRange(items);
        }

        /// <inheritdoc/>
        public IEnumerator<string> GetEnumerator() => root.GetEnumerator();

        /// <inheritdoc/>
        IEnumerator IEnumerable.GetEnumerator() => root.GetEnumerator();

        /// <inheritdoc/>
        public void Add(string item) {
            if (item is null) {
                throw new ArgumentNullException(nameof(item));
            }
            root.Add(item, 0);
        }

        /// <summary>Adds all strings from <paramref name="items"/></summary>
        /// <param name="items">Strings to add</param>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="items"/> is null
        /// </exception>
        /// <exception cref="ArgumentException">
        /// Thrown when <paramref name="items"/> contains null
        /// </exception>
        public void AddRange(IEnumerable<string> items) {
            if (items is null) {
                throw new ArgumentNullException(nameof(items));
            }
            foreach (var item in items) {
                if (item is null) {
                    throw new ArgumentException("Null value can't be added.", nameof(items));
                }
                root.Add(item, 0);
            }
        }

        /// <inheritdoc/>
        public void Clear() =>
            root.Clear();

        /// <inheritdoc/>
        public bool Contains(string item) {
            if (item is null) {
                throw new ArgumentNullException(nameof(item));
            }
            return root.Contains(item, 0);
        }

        /// <summary>
        /// Checks if any string in this trie starts with <paramref name="prefix"/>
        /// </summary>
        /// <param name="prefix">Prefix to search for</param>
        /// <returns>
        /// True if any string in this trie starts with <paramref name="prefix"/>, false otherwise
        /// </returns>
        public bool ContainsPrefix(string prefix) {
            if (prefix is null) {
                throw new ArgumentNullException(nameof(prefix));
            }
            return root.ContainsPrefix(prefix, 0);
        }

        /// <summary>
        /// Searches for the first occurence of any string from this trie in the specified string
        /// </summary>
        /// <param name="haystack">String to search in</param>
        /// <param name="startIndex">
        /// Index in <paramref name="haystack"/> to start searching from, defaults to 0
        /// </param>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="haystack"/> is null
        /// </exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown when <paramref name="startIndex"/> is outside of <paramref name="haystack"/>
        /// </exception>
        /// <returns>
        /// Tuple with starting index and length of the detected substring. If nothing is found,
        /// (-1, -1) is returned.
        /// </returns>
        public (int index, int length) Search(string haystack, int startIndex = 0) =>
            SearchImpl(
                haystack ?? throw new ArgumentNullException(nameof(haystack)),
                startIndex,
                haystack.Length
            );

        /// <summary>
        /// Searches for the first occurence of any string from this trie in the specified string
        /// </summary>
        /// <param name="haystack">String to search in</param>
        /// <param name="startIndex">
        /// Index in <paramref name="haystack"/> to start searching from
        /// </param>
        /// <param name="endIndex">
        /// Index in <paramref name="haystack"/> to stop searching before or
        /// <paramref name="haystack"/>.Length
        /// </param>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="haystack"/> is null
        /// </exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown when <paramref name="startIndex"/> or <paramref name="endIndex"/> is out of range
        /// </exception>
        /// <exception cref="ArgumentException">
        /// Thrown when <paramref name="startIndex"/> is greater or equal to
        /// <paramref name="endIndex"/>
        /// </exception>
        /// <remarks>
        /// trie.Search(str, a, b) is equivalent to trie.Search(str.Substring(a, b - a))
        /// </remarks>
        /// <returns>
        /// Tuple with starting index and length of the detected substring. If nothing is found,
        /// (-1, -1) is returned.
        /// </returns>
        public (int index, int length) Search(string haystack, int startIndex, int endIndex) =>
            SearchImpl(
                haystack ?? throw new ArgumentNullException(nameof(haystack)),
                startIndex,
                endIndex
            );

#if NET_CORE
        /// <summary>
        /// Searches for the first occurence of any string from this trie in the specified string
        /// </summary>
        /// <param name="haystack">String to search in</param>
        /// <param name="searchRange">Range in <paramref name="haystack"/> to search</param>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="haystack"/> is null
        /// </exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown when <paramref name="searchRange"/> does not represent a substring of
        /// <paramref name="haystack"/>
        /// </exception>
        /// <exception cref="ArgumentException">
        /// Thrown when <paramref name="searchRange"/>.End is greater or equal to
        /// <paramref name="searchRange"/>.Start
        /// </exception>
        /// <remarks>
        /// trie.Search(str, a..b) is equivalent to trie.Search(str[a..b])
        /// </remarks>
        /// <returns>
        /// Tuple with starting index and length of the detected substring. If nothing is found,
        /// (-1, -1) is returned.
        /// </returns>
        public (int index, int length) Search(string haystack, Range searchRange) =>
            SearchImpl(
                haystack ?? throw new ArgumentNullException(nameof(haystack)),
                searchRange.Start.GetOffset(haystack.Length),
                searchRange.End.GetOffset(haystack.Length)
            );
#endif

        private (int index, int length) SearchImpl(string haystack, int startIndex, int endIndex) {
            if (root.isWord) {
                return (startIndex, 0);
            } else if (haystack.Length == 0) {
                return (-1, -1);
            } else if (startIndex < 0 || startIndex >= haystack.Length) {
                throw new ArgumentOutOfRangeException(nameof(startIndex));
            } else if (endIndex < 0 || endIndex > haystack.Length) {
                throw new ArgumentOutOfRangeException(nameof(endIndex));
            } else if (startIndex >= endIndex) {
                throw new ArgumentException("endIndex must be greater than startIndex.");
            }
            for (var i = startIndex; i <= endIndex; ++i) {
                var end = root.Search(haystack, i, endIndex);
                if (end >= 0) {
                    return (i, end - i);
                }
            }
            return (-1, -1);
        }

        /// <summary>
        /// Lazily searches for all occurences of strings from this trie in the specified string
        /// </summary>
        /// <param name="haystack">String to search in</param>
        /// <param name="startIndex">
        /// Index in <paramref name="haystack"/> to start searching from, defaults to 0
        /// </param>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="haystack"/> is null
        /// </exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown when <paramref name="startIndex"/> is outside of <paramref name="haystack"/>
        /// </exception>
        /// <returns>
        /// <see cref="IEnumerable{T}"/> with tuples containing starting index and length of the
        /// detected substrings.
        /// </returns>
        public IEnumerable<(int index, int length)> SearchAll(
            string haystack, int startIndex = 0
        ) =>
            SearchAllImpl(
                haystack ?? throw new ArgumentNullException(nameof(haystack)),
                startIndex,
                haystack.Length
            );

        /// <summary>
        /// Lazily searches for all occurences of strings from this trie in the specified string
        /// </summary>
        /// <param name="haystack">String to search in</param>
        /// <param name="startIndex">
        /// Index in <paramref name="haystack"/> to start searching from
        /// </param>
        /// <param name="endIndex">
        /// Index in <paramref name="haystack"/> to stop searching before or
        /// <paramref name="haystack"/>.Length
        /// </param>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="haystack"/> is null
        /// </exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown when <paramref name="startIndex"/> or <paramref name="endIndex"/> is out of range
        /// </exception>
        /// <exception cref="ArgumentException">
        /// Thrown when <paramref name="startIndex"/> is greater or equal to
        /// <paramref name="endIndex"/>
        /// </exception>
        /// <remarks>
        /// trie.SearchAll(str, a, b) is equivalent to trie.SearchAll(str.Substring(a, b - a))
        /// </remarks>
        /// <returns>
        /// <see cref="IEnumerable{T}"/> with tuples containing starting index and length of the
        /// detected substrings.
        /// </returns>
        public IEnumerable<(int index, int length)> SearchAll(
            string haystack,
            int startIndex,
            int endIndex
        ) {
            return SearchAllImpl(
                haystack ?? throw new ArgumentNullException(nameof(haystack)),
                startIndex,
                endIndex
            );
        }

#if NET_CORE
        /// <summary>
        /// Lazily searches for all occurences of strings from this trie in the specified string
        /// </summary>
        /// <param name="haystack">String to search in</param>
        /// <param name="searchRange">Range in <paramref name="haystack"/> to search</param>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="haystack"/> is null
        /// </exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown when <paramref name="searchRange"/> does not represent a substring of
        /// <paramref name="haystack"/>
        /// </exception>
        /// <exception cref="ArgumentException">
        /// Thrown when <paramref name="searchRange"/>.End is greater or equal to
        /// <paramref name="searchRange"/>.Start
        /// </exception>
        /// <remarks>
        /// trie.SearchAll(str, a..b) is equivalent to trie.SearchAll(str[a..b])
        /// </remarks>
        /// <returns>
        /// <see cref="IEnumerable{T}"/> with tuples containing starting index and length of the
        /// detected substrings.
        /// </returns>
        public IEnumerable<(int index, int length)> SearchAll(string haystack, Range searchRange) =>
            SearchAllImpl(
                haystack ?? throw new ArgumentNullException(nameof(haystack)),
                searchRange.Start.GetOffset(haystack.Length),
                searchRange.End.GetOffset(haystack.Length)
            );
#endif

        private IEnumerable<(int index, int length)> SearchAllImpl(
            string haystack,
            int startIndex,
            int endIndex
        ) {
            if (startIndex < 0 || startIndex >= haystack.Length) {
                throw new ArgumentOutOfRangeException(nameof(startIndex));
            } else if (endIndex < 0 || endIndex > haystack.Length) {
                throw new ArgumentOutOfRangeException(nameof(endIndex));
            } else if (startIndex >= endIndex) {
                throw new ArgumentException("endIndex must be greater than startIndex.");
            }
            return root.SearchAll(haystack, startIndex, endIndex);
        }

        /// <inheritdoc/>
        public void CopyTo(string[] array, int index) {
            if (array is null) {
                throw new ArgumentNullException(nameof(array));
            }
            if (index < 0) {
                throw new ArgumentOutOfRangeException(nameof(index));
            }
            if (index + Count > array.Length) {
                throw new ArgumentException("Given array is too small.");
            }
            foreach (var item in root) {
                array[index++] = item;
            }
        }

        /// <summary>
        /// Copies all strings from this trie in ascending order into a given array
        /// </summary>
        /// <param name="array">Array to fill with strings</param>
        /// <param name="index">Starting index in <paramref name="array"/></param>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="array"/> is null
        /// </exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown when <paramref name="index"/> is negative
        /// </exception>
        /// <exception cref="ArgumentException">
        /// Thrown when <paramref name="array"/> is too small
        /// </exception>
        public void CopyToSorted(string[] array, int index) {
            if (array is null) {
                throw new ArgumentNullException(nameof(array));
            }
            if (index < 0) {
                throw new ArgumentOutOfRangeException(nameof(index));
            }
            if (index + Count > array.Length) {
                throw new ArgumentException("Given array is too small.");
            }
            foreach (var item in root.EnumerateSorted()) {
                array[index++] = item;
            }
        }

        /// <inheritdoc/>
        public bool Remove(string item) {
            if (item is null) {
                throw new ArgumentNullException(nameof(item));
            }
            return root.Remove(item, 0);
        }

        /// <summary>Removes all string matched by <paramref name="match"/></summary>
        /// <param name="match">Predicate to check against string in this trie</param>
        /// <returns>Number of removed strings</returns>
        public int RemoveAll(Predicate<string> match) {
            if (match is null) {
                throw new ArgumentNullException(nameof(match));
            }
            return root.RemoveAll(match);
        }

        /// <summary>Enumerates strings in ascending order</summary>
        /// <returns><see cref="IEnumerable{T}"/> with strings from this trie</returns>
        public IEnumerable<string> EnumerateSorted() =>
            root.EnumerateSorted();

        /// <summary>Creates an array containing all strings from this trie</summary>
        /// <returns>Array with strings from this trie</returns>
        public string[] ToArray() {
            var array = new string[Count];
            var i = 0;
            foreach (var item in root) {
                array[i++] = item;
            }
            return array;
        }

        /// <summary>
        /// Creates an array containing all strings from this trie in ascending order
        /// </summary>
        /// <returns>Array with strings from this trie</returns>
        public string[] ToSortedArray() {
            var array = ToArray();
            Array.Sort(array);
            return array;
        }

        /// <summary>Creates a List containing all strings from this trie</summary>
        /// <returns>List with strings from this trie</returns>
        public List<string> ToList() =>
            new List<string>(root);

        /// <summary>
        /// Creates a List containing all strings from this trie in ascending order
        /// </summary>
        /// <returns>List with strings from this trie</returns>
        public List<string> ToSortedList() {
            var list = new List<string>(root);
            list.Sort();
            return list;
        }

        /// <summary>Creates a HashSet containing all strings from this trie</summary>
        /// <returns>HashSet with strings from this trie</returns>
        public HashSet<string> ToHashSet() =>
            new HashSet<string>(root);
    }
}
