using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Netxtendable.Collections.Tests {

    [TestClass]
    public class TrieTests {

        private static readonly string lipsumText = @"Lorem ipsum dolor sit amet, consectetur
adipiscing elit. Fusce eu quam at velit tincidunt eleifend. Nulla facilisi. Class aptent taciti
sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Morbi faucibus dui vitae
sapien semper porta. Donec eget enim sed ex volutpat eleifend at ac turpis. Etiam imperdiet at arcu
at dictum. Fusce nisi lacus, imperdiet id velit vel, vehicula tempus tellus. Nunc pulvinar diam et
eros auctor aliquet. Phasellus suscipit finibus odio, at congue nibh accumsan eget. Phasellus
vulputate semper maximus. Vivamus pulvinar sapien ex, id congue nibh accumsan eu. Orci varius
natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Pellentesque magna felis,
cursus nec fermentum ut, iaculis sit amet lacus. Nunc varius et risus ac porttitor. Praesent id erat
lectus.".Replace("\r\n", " ").Replace('\n', ' ');

        private static readonly string[]
            strings = { "", "asd", "def", "abc", "abcd", "dfg" },
            sortedStrings = { "", "abc", "abcd", "asd", "def", "dfg" },
            lipsumWords = { "consectetur", "torquent", "tellus", "cursus" };

        [TestMethod]
        public void Trie_Test1() {
            _ = new Trie();
        }

        [TestMethod]
        public void Trie_Test2() {
            var trie = new Trie(strings);
            foreach (var str in strings) {
                Assert.IsTrue(trie.Contains(str));
            }
            Assert.ThrowsException<ArgumentNullException>(() => new Trie(null!));
            Assert.ThrowsException<ArgumentException>(() => new Trie(new[] { "ghi", null! }));
        }

        [TestMethod]
        public void Add_Test() {
            var trie = new Trie();
            foreach (var str in strings) {
                trie.Add(str);
                Assert.IsTrue(trie.Contains(str));
            }
            trie.Add("abc");
            Assert.ThrowsException<ArgumentNullException>(() => trie.Add(null!));
        }

        [TestMethod]
        public void AddRange_Test() {
            var trie = new Trie();
            trie.AddRange(strings);
            foreach (var str in strings) {
                Assert.IsTrue(trie.Contains(str));
            }
            Assert.ThrowsException<ArgumentNullException>(() => trie.AddRange(null!));
            Assert.ThrowsException<ArgumentException>(() => trie.AddRange(new[] { "ghi", null! }));
        }

        [TestMethod]
        public void Count_Test() {
            Assert.AreEqual(0, new Trie().Count);
            Assert.AreEqual(3, new Trie { "abc", "abd", "abc", "ef" }.Count);
            Assert.AreEqual(strings.Length, new Trie(strings).Count);
        }

        [TestMethod]
        public void Clear_Test() {
            var trie = new Trie();
            foreach (var str in strings) {
                trie.Add(str);
            }
            trie.Clear();
            foreach (var str in strings) {
                Assert.IsFalse(trie.Contains(str));
            }
        }

        [TestMethod]
        public void Contains_Test() {
            var trie = new Trie { "abcdef", "test", "abc", "hello", "hobby", "abcdE" };
            Assert.IsTrue(trie.Contains("test"));
            Assert.IsTrue(trie.Contains("hello"));
            Assert.IsTrue(trie.Contains("abcdef"));
            Assert.IsTrue(trie.Contains("abc"));
            Assert.IsFalse(trie.Contains("abcde"));
            Assert.IsFalse(trie.Contains("atest"));
            Assert.IsFalse(trie.Contains("hell"));
            Assert.IsFalse(trie.Contains(""));
            Assert.ThrowsException<ArgumentNullException>(() => trie.Contains(null!));
        }

        [TestMethod]
        public void ContainsPrefix_Test() {
            var trie = new Trie { "abcdef", "test", "abc", "hello", "hobby", "abcdE" };
            Assert.IsTrue(trie.ContainsPrefix("te"));
            Assert.IsTrue(trie.ContainsPrefix("hello"));
            Assert.IsTrue(trie.ContainsPrefix("ab"));
            Assert.IsTrue(trie.ContainsPrefix("abcd"));
            Assert.IsFalse(trie.ContainsPrefix("abcdf"));
            Assert.IsFalse(trie.ContainsPrefix("atest"));
            Assert.IsFalse(trie.ContainsPrefix("hellow"));
            Assert.IsTrue(trie.ContainsPrefix(""));
            Assert.ThrowsException<ArgumentNullException>(() => trie.ContainsPrefix(null!));
        }

        [TestMethod]
        public void Search_Test_s_i() {
            var trie = new Trie(lipsumWords);
            int i = 0, length = 0;
            foreach (var word in lipsumWords) {
                (i, length) = trie.Search(lipsumText, i + length);
                Assert.AreEqual(lipsumText.IndexOf(word, StringComparison.Ordinal), i);
                Assert.AreEqual(word.Length, length);
            }
            Assert.ThrowsException<ArgumentNullException>(() => trie.Search(null!));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => trie.Search("Hello", -5));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => trie.Search("Hello", 100));
            Assert.AreEqual((-1, -1), trie.Search(""));
            trie.Add("");
            Assert.AreEqual((0, 0), trie.Search(""));
            Assert.AreEqual((0, 0), trie.Search("Hello"));
        }

        [TestMethod]
        public void Search_Test_s_i_i() {
            var trie = new Trie(lipsumWords) { "facilisi" };
            Assert.AreEqual((-1, -1), trie.Search(lipsumText, 0, 38));
            Assert.AreEqual((106, 8), trie.Search(lipsumText, 100, 120));
            trie = new() { "at" };
            List<int> occurences = new();
            int i = 200, length;
            while (true) {
                (i, length) = trie.Search(lipsumText, i, i + 100);
                if (i < 0) {
                    Assert.AreEqual(-1, length);
                    break;
                } else {
                    Assert.AreEqual(2, length);
                    occurences.Add(i);
                    i += 2;
                }
            }
            CollectionAssert.AreEqual(new[] { 283, 295, 325, 333 }, occurences);
            Assert.ThrowsException<ArgumentNullException>(() => trie.Search(null!, 0, 10));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => trie.Search("Hello", -5, 5));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => trie.Search("Hello", 10, 12));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => trie.Search("Hello", 0, 10));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => trie.Search("Hello", 0, -5));
            Assert.ThrowsException<ArgumentException>(() => trie.Search("Hello", 4, 2));
        }

        [TestMethod]
        public void Search_Test_s_r() {
            var trie = new Trie(lipsumWords) { "facilisi" };
            Assert.AreEqual((-1, -1), trie.Search(lipsumText, ..38));
            Assert.AreEqual((-1, -1), trie.Search(lipsumText, ^820..^792));
            Assert.AreEqual((106, 8), trie.Search(lipsumText, 100..120));
            Assert.AreEqual((28, 11), trie.Search(lipsumText, ^809..^789));
            trie = new() { "at" };
            List<int> occurences = new();
            int i = 200, length;
            while (true) {
                (i, length) = trie.Search(lipsumText, i..(i + 100));
                if (i < 0) {
                    Assert.AreEqual(-1, length);
                    break;
                } else {
                    Assert.AreEqual(2, length);
                    occurences.Add(i);
                    i += 2;
                }
            }
            CollectionAssert.AreEqual(new[] { 283, 295, 325, 333 }, occurences);
            Assert.ThrowsException<ArgumentNullException>(() => trie.Search(null!, ..10));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => trie.Search("Hello", ^10..122));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => trie.Search("Hello", 10..12));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => trie.Search("Hello", ..^10));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => trie.Search("Hello", ..10));
            Assert.ThrowsException<ArgumentException>(() => trie.Search("Hello", 4..2));
        }

        [TestMethod]
        public void SearchAll_Test_s_i() {
            var trie = new Trie(lipsumWords);
            CollectionAssert.AreEqual(
                lipsumWords.Select(
                               word => (
                                   lipsumText.IndexOf(word, StringComparison.Ordinal),
                                   word.Length
                               )
                           )
                           .ToArray(),
                trie.SearchAll(lipsumText).ToArray()
            );
            trie = new() { "i", "ips", "ipsum" };
            CollectionAssert.AreEqual(
                new[] { (6, 1), (6, 3), (6, 5), (19, 1) },
                trie.SearchAll("Lorem ipsum dolor sit amet").ToArray()
            );
            trie = new() { "abc", "", "abcdef" };
            CollectionAssert.AreEqual(
                new[] { (0, 0), (1, 0), (2, 0), (2, 3), (3, 0), (4, 0), (5, 0), (6, 0), (7, 0) },
                trie.SearchAll("ababcab").ToArray()
            );
            Assert.ThrowsException<ArgumentNullException>(() => trie.SearchAll(null!));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => trie.SearchAll("Hello", -5));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => trie.SearchAll("Hello", 100));
        }

        [TestMethod]
        public void SearchAll_Test_s_i_i() {
            var trie = new Trie { "i", "ips", "ipsum" };
            CollectionAssert.AreEqual(
                new[] { (6, 1), (6, 3), (6, 5) },
                trie.SearchAll("Lorem ipsum dolor sit amet", 5, 15).ToArray()
            );
            trie = new() { "abc", "", "abcdef" };
            CollectionAssert.AreEqual(
                new[] { (3, 0), (4, 0), (5, 0), (6, 0) },
                trie.SearchAll("ababcab", 3, 6).ToArray()
            );
            Assert.ThrowsException<ArgumentNullException>(() => trie.SearchAll(null!, 0, 10));
            foreach (var (s, e) in new[] { (-5, 5), (10, 12), (10, -3), (2, 12) }) {
                Assert.ThrowsException<ArgumentOutOfRangeException>(
                    () => trie.SearchAll("Hello", s, e)
                );
            }
            Assert.ThrowsException<ArgumentException>(() => trie.SearchAll("Hello", 4, 2));
        }

        [TestMethod]
        public void SearchAll_Test_s_r() {
            var trie = new Trie { "i", "ips", "ipsum" };
            CollectionAssert.AreEqual(
                new[] { (6, 1), (6, 3), (6, 5) },
                trie.SearchAll("Lorem ipsum dolor sit amet", 5..15).ToArray()
            );
            trie = new() { "abc", "", "abcdef" };
            CollectionAssert.AreEqual(
                new[] { (3, 0), (4, 0), (5, 0), (6, 0) },
                trie.SearchAll("ababcab", 3..6).ToArray()
            );
            Assert.ThrowsException<ArgumentNullException>(() => trie.SearchAll(null!, ..10));
            foreach (var (s, e) in new[] { (-5, 5), (10, 12), (10, -3), (2, 12) }) {
                Assert.ThrowsException<ArgumentOutOfRangeException>(
                    () => trie.SearchAll("Hello", s..e)
                );
            }
            Assert.ThrowsException<ArgumentException>(() => trie.SearchAll("Hello", 4..2));
        }

        [TestMethod]
        public void CopyTo_Test() {
            var trie = new Trie(strings);
            var array = new string[trie.Count];
            trie.CopyTo(array, 0);
            CollectionAssert.AreEquivalent(strings, array);
            trie = new() { "hello" };
            array = new[] { "0", "1", "2", "3" };
            trie.CopyTo(array, 2);
            CollectionAssert.AreEqual(new[] { "0", "1", "hello", "3" }, array);
            Assert.ThrowsException<ArgumentNullException>(() => trie.CopyTo(null!, 0));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => trie.CopyTo(array, -5));
            Assert.ThrowsException<ArgumentException>(() => trie.CopyTo(array, 6));
        }

        [TestMethod]
        public void CopyToSorted_Test() {
            var trie = new Trie(strings);
            var array = new string[trie.Count];
            trie.CopyToSorted(array, 0);
            CollectionAssert.AreEqual(sortedStrings, array);
            trie = new() { "hello", "blue" };
            array = new[] { "0", "1", "2", "3" };
            trie.CopyToSorted(array, 1);
            CollectionAssert.AreEqual(new[] { "0", "blue", "hello", "3" }, array);
            Assert.ThrowsException<ArgumentNullException>(() => trie.CopyToSorted(null!, 0));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => trie.CopyToSorted(array, -5));
            Assert.ThrowsException<ArgumentException>(() => trie.CopyToSorted(array, 3));
        }

        [TestMethod]
        public void Remove_Test() {
            var trie = new Trie(strings);
            Assert.IsTrue(trie.Remove("abc"));
            Assert.IsTrue(trie.Contains("abcd"));
            Assert.IsFalse(trie.Contains("abc"));
            Assert.IsFalse(trie.Remove("d"));
            Assert.IsTrue(trie.Contains("def"));
            Assert.IsTrue(trie.Contains("dfg"));
            Assert.IsTrue(trie.Remove("def"));
            Assert.IsFalse(trie.Contains("def"));
            Assert.AreEqual(4, trie.Count);
            Assert.ThrowsException<ArgumentNullException>(() => trie.Remove(null!));
        }

        [TestMethod]
        public void RemoveAll_Test() {
            var trie = new Trie(strings);
            Assert.AreEqual(3, trie.RemoveAll(s => s.StartsWith('a')));
            foreach (var str in strings) {
                Assert.AreEqual(!str.StartsWith('a'), trie.Contains(str));
            }
            Assert.ThrowsException<ArgumentNullException>(() => trie.RemoveAll(null!));
        }

        [TestMethod]
        public void IsReadOnly_Test() {
            Assert.AreEqual(false, new Trie().IsReadOnly);
        }

        [TestMethod]
        public void IsEmpty_Test() {
            Assert.AreEqual(true, new Trie().IsEmpty);
            Assert.AreEqual(false, new Trie { "abc", "abd", "abc", "ef" }.IsEmpty);
            var trie = new Trie(strings);
            Assert.AreEqual(false, trie.IsEmpty);
            trie.Clear();
            Assert.AreEqual(true, trie.IsEmpty);
        }
        
        [TestMethod]
        public void GetEnumerator_Test() {
            List<string> list = new();
            using var enumerator = new Trie(strings).GetEnumerator();
            while (enumerator.MoveNext()) {
                list.Add(enumerator.Current);
            }
            CollectionAssert.AreEquivalent(strings, list);
            list.Clear();
            var enumerator2 = ((IEnumerable)new Trie(strings)).GetEnumerator();
            while (enumerator2.MoveNext()) {
                Assert.IsInstanceOfType(enumerator2.Current, typeof(string));
                list.Add((string)enumerator2.Current);
            }
            CollectionAssert.AreEquivalent(strings, list);
        }

        [TestMethod]
        public void EnumerateSorted_Test() {
            CollectionAssert.AreEquivalent(
                sortedStrings,
                new List<string>(new Trie(strings).EnumerateSorted())
            );
        }

        [TestMethod]
        public void ToArray_Test() {
            CollectionAssert.AreEquivalent(strings, new Trie(strings).ToArray());
        }

        [TestMethod]
        public void ToSortedArray_Test() {
            CollectionAssert.AreEqual(sortedStrings, new Trie(strings).ToSortedArray());
        }

        [TestMethod]
        public void ToList_Test() {
            CollectionAssert.AreEquivalent(strings, new Trie(strings).ToList());
        }

        [TestMethod]
        public void ToSortedList_Test() {
            CollectionAssert.AreEqual(sortedStrings, new Trie(strings).ToSortedList());
        }

        [TestMethod]
        public void ToHashSet_Test() {
            CollectionAssert.AreEquivalent(strings, new Trie(strings).ToHashSet().ToArray());
        }
    }
}
