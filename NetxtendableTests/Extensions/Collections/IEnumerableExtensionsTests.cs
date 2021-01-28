using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Netxtendable.Extensions.Collections.Tests {

    [TestClass]
    public partial class IEnumerableExtensionsTests {

        [TestMethod]
        public void ConcatToString_Test() {
            Assert.AreEqual("HelloHelloHelloHello", Enumerable.Repeat("Hello", 4).ConcatToString());
        }

        [TestMethod]
        public void JoinToString_Test1() {
            Assert.AreEqual(
                "Hello and Hello and Hello",
                Enumerable.Repeat("Hello", 3).JoinToString(" and ")
            );
        }

        [TestMethod]
        public void JoinToString_Test2() {
            Assert.AreEqual(
                "Hello,Hello,Hello",
                Enumerable.Repeat("Hello", 3).JoinToString(',')
            );
        }

        [TestMethod]
        public void JoinToString_Test3() {
            Assert.AreEqual(
                "Hello, Hello, Hello",
                Enumerable.Repeat("Hello", 3).JoinToString()
            );
        }

        [TestMethod]
        public void MapWhere_Test1() {
            var values = new[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H' };
            var output = new[] { 'A', 'B', 'c', 'd', 'e', 'F', 'G', 'H' };
            CollectionAssert.AreEqual(
                output,
                values.MapWhere(c => c >= 'C' && c <= 'E', char.ToLower).ToArray()
            );
            Assert.ThrowsException<ArgumentNullException>(
                () => (null as IEnumerable<char>).MapWhere(c => true, c => c)
            );
            Assert.ThrowsException<ArgumentNullException>(
                () => values.MapWhere(null, c => c)
            );
            Assert.ThrowsException<ArgumentNullException>(
                () => values.MapWhere(c => true, null)
            );
        }

        [TestMethod]
        public void MapWhere_Test2() {
            var values = new[] { "A", "B", "C", "D", "E", "F", "G", "H" };
            var output = new[] { "A", "1", "C", "3", "E", "5", "G", "7" };
            CollectionAssert.AreEqual(
                output,
                values.MapWhere((_, i) => i % 2 == 1, (_, i) => i.ToString()).ToArray()
            );
            Assert.ThrowsException<ArgumentNullException>(
                () => (null as IEnumerable<char>).MapWhere((c, i) => true, (c, i) => c)
            );
            Assert.ThrowsException<ArgumentNullException>(
                () => values.MapWhere(null, (c, i) => c)
            );
            Assert.ThrowsException<ArgumentNullException>(
                () => values.MapWhere((c, i) => true, null)
            );
        }

        [TestMethod]
        public void Map_Test1() {
            var values = new[] {
                "123", "12345", "1", "1234567", "12", "123456789", "1234", "123456", "12345678"
            };
            CollectionAssert.AreEqual(
                values.Select(s => s.Length).ToArray(),
                values.Map(s => s.Length).ToArray()
            );
            Assert.ThrowsException<ArgumentNullException>(
                () => (null as IEnumerable<string>).Map(s => s)
            );
            Assert.ThrowsException<ArgumentNullException>(
                () => values.Map((Func<string, int>)null)
            );
        }

        [TestMethod]
        public void Map_Test2() {
            var values = new[] {
                "123", "12345", "1", "1234567", "12", "123456789", "1234", "123456", "12345678"
            };
            CollectionAssert.AreEqual(
                values.Select((s, i) => s.Length + i).ToArray(),
                values.Map((s, i) => s.Length + i).ToArray()
            );
            Assert.ThrowsException<ArgumentNullException>(
                () => (null as IEnumerable<string>).Map((s, i) => s)
            );
            Assert.ThrowsException<ArgumentNullException>(
                () => values.Map((Func<string, int, int>)null)
            );
        }

        [TestMethod]
        public void Partition_Test() {
            var (l1, l2) = Enumerable.Range(1, 10).Partition(i => i % 3 > 0);
            CollectionAssert.AreEqual(new[] { 1, 2, 4, 5, 7, 8, 10 }, l1);
            CollectionAssert.AreEqual(new[] { 3, 6, 9 }, l2);
            Assert.ThrowsException<ArgumentNullException>(
                () => (null as IEnumerable<int>).Partition(i => true)
            );
            Assert.ThrowsException<ArgumentNullException>(
                () => Enumerable.Range(1, 10).Partition(null)
            );
        }

        [TestMethod]
        public void None_Test() {
            Assert.IsTrue(new[] { 1, 2, 4, 5, 7, 8, 10 }.None(i => i == 6));
            Assert.IsFalse(new[] { 1, 2, 4, 6, 7, 8, 10 }.None(i => i == 6));
            Assert.ThrowsException<ArgumentNullException>(
                () => (null as IEnumerable<int>).None(i => true)
            );
        }

        [TestMethod]
        public void ForEach_Test() {
            var l = new List<int>();
            var values = new[] { 1, 2, 4, 5, 7, 8, 10 };
            values.ForEach(i => l.Add(i));
            CollectionAssert.AreEqual(values, l);
            Assert.ThrowsException<ArgumentNullException>(
                () => (null as IEnumerable<string>).ForEach(i => { })
            );
            Assert.ThrowsException<ArgumentNullException>(
                () => values.ForEach(null)
            );
        }

        [TestMethod]
        public void MaxBy_Test() {
            var values = new[] {
                "123", "12345", "1", "1234567", "12", "123456789", "1234", "123456", "12345678"
            };
            Assert.AreEqual("123456789", values.MaxBy(s => s.Length));
            Assert.ThrowsException<ArgumentNullException>(
                () => (null as IEnumerable<string>).MaxBy(s => s.Length)
            );
            Assert.ThrowsException<ArgumentNullException>(
                () => values.MaxBy(null as Func<string, int>)
            );
            Assert.ThrowsException<InvalidOperationException>(
                () => Array.Empty<string>().MaxBy(s => s.Length)
            );
        }

        [TestMethod]
        public void MinBy_Test() {
            var values = new[] {
                "123", "12345", "1", "1234567", "12", "123456789", "1234", "123456", "12345678"
            };
            Assert.AreEqual("1", values.MinBy(s => s.Length));
            Assert.ThrowsException<ArgumentNullException>(
                () => (null as IEnumerable<string>).MinBy(s => s.Length)
            );
            Assert.ThrowsException<ArgumentNullException>(
                () => values.MinBy(null as Func<string, int>)
            );
            Assert.ThrowsException<InvalidOperationException>(
                () => Array.Empty<string>().MinBy(s => s.Length)
            );
        }

        [TestMethod]
        public void WhereNot_Test() {
            var values = new[] {
                "123", "12345", "1", "1234567", "12", "123456789", "1234", "123456", "12345678"
            };
            CollectionAssert.AreEqual(
                values.Where(s => s.Length <= 4).ToArray(),
                values.WhereNot(s => s.Length > 4).ToArray()
            );
            Assert.ThrowsException<ArgumentNullException>(
                () => (null as IEnumerable<string>).WhereNot(s => false)
            );
            Assert.ThrowsException<ArgumentNullException>(
                () => values.WhereNot(null)
            );
        }

        [TestMethod]
        public void WhereNotNull_Test() {
            var values = new[] {
                "123", null, "1", "1234567", null, null, "1234", null, "12345678"
            };
            CollectionAssert.AreEqual(
                new[] { "123", "1", "1234567", "1234", "12345678" },
                values.WhereNotNull().ToArray()
            );
            Assert.ThrowsException<ArgumentNullException>(
                () => (null as IEnumerable<string>).WhereNotNull()
            );
        }

        [TestMethod]
        public void WhereNotEmpty_Test1() {
            var values = new[] {
                new[] { 1, 2, 3 },
                Array.Empty<int>(),
                new[] { 1 },
                null,
                Array.Empty<int>(),
                new[] { 1, 2 }
            };
            CollectionAssert.AreEqual(
                new[] { values[0], values[2], values[5] },
                values.WhereNotEmpty().ToArray()
            );
            Assert.ThrowsException<ArgumentNullException>(
                () => (null as IEnumerable<string>).WhereNotEmpty()
            );
        }

        [TestMethod]
        public void WhereNotEmpty_Test2() {
            var values = new[] {
                "123", "", " \n", "1234567", null, "", "1234  ", null, "12345678", "   "
            };
            CollectionAssert.AreEqual(
                new[] { "123", " \n", "1234567", "1234  ", "12345678", "   " },
                values.WhereNotEmpty().ToArray()
            );
            Assert.ThrowsException<ArgumentNullException>(
                () => (null as IEnumerable<string>).WhereNotEmpty()
            );
        }

        [TestMethod]
        public void WhereNotWhiteSpace_Test() {
            var values = new[] {
                "123", "", " \n", "1234567", null, "", "1234  ", null, "12345678", "   "
            };
            CollectionAssert.AreEqual(
                new[] { "123", "1234567", "1234  ", "12345678" },
                values.WhereNotWhiteSpace().ToArray()
            );
            Assert.ThrowsException<ArgumentNullException>(
                () => (null as IEnumerable<string>).WhereNotWhiteSpace()
            );
        }

        [TestMethod]
        public void Matching_Test1() {
            var values = new[] {
                "123", "12E45", "1", "1234567", "I2", "123A5:7B9", "1234", "1234?6", "12345678"
            };
            var regex = new Regex(@"^\d+$");
            CollectionAssert.AreEqual(
                new[] { "123", "1", "1234567", "1234", "12345678" },
                values.Matching(regex).ToArray()
            );
            Assert.ThrowsException<ArgumentNullException>(
                () => (null as IEnumerable<string>).Matching(regex)
            );
            Assert.ThrowsException<ArgumentNullException>(
                () => values.Matching(null as Regex)
            );
        }

        [TestMethod]
        public void Matching_Test2() {
            var values = new[] {
                "123", "12E45", "1", "1234567", "I2", "123A5:7B9", "1234", "1234?6", "12345678"
            };
            CollectionAssert.AreEqual(
                new[] { "123", "1", "1234567", "1234", "12345678" },
                values.Matching(@"^\d+$").ToArray()
            );
            Assert.ThrowsException<ArgumentNullException>(
                () => (null as IEnumerable<string>).Matching("")
            );
            Assert.ThrowsException<ArgumentNullException>(
                () => values.Matching(null as string)
            );
        }

        [TestMethod]
        public void Flatten_Test() {
            var flat = new[] {
                "123", "12345", "1", "1234567", "12", "123456789", "1234", "123456", "12345678"
            };
            var input = new[] {
                new[] { flat[0], flat[1] },
                new[] { flat[2] },
                new[] { flat[3], flat[4], flat[5], flat[6] },
                new[] { flat[7], flat[8] }
            };
            CollectionAssert.AreEqual(flat, input.Flatten().ToArray());
        }

        [TestMethod]
        public void FlatMap_Test() {
            var values = new[] { "123:12345", "1", "1234567:12:123456789:1234", "123456:12345678" };
            CollectionAssert.AreEqual(
                new[] { 3, 5, 1, 7, 2, 9, 4, 6, 8 },
                values.FlatMap(s => s.Split(':').Select(i => i.Length)).ToArray()
            );
            Assert.ThrowsException<ArgumentNullException>(
                () => (null as IEnumerable<string>).FlatMap(s => s)
            );
            Assert.ThrowsException<ArgumentNullException>(
                () => values.FlatMap((Func<string, char[]>)null)
            );
        }

        [TestMethod]
        public void ToDictionary_Test() {
            var input = new[] { ("1", 4), ("2", 5), ("3", 6), ("4", 7) };
            CollectionAssert.AreEquivalent(
                new[] {
                    new KeyValuePair<string, int>("1", 4),
                    new KeyValuePair<string, int>("2", 5),
                    new KeyValuePair<string, int>("3", 6),
                    new KeyValuePair<string, int>("4", 7)
                }, input.ToDictionary()
            );
        }

        [TestMethod]
        public void ZipWithNext_Test() {
            CollectionAssert.AreEqual(
                new[] { (0, 1), (1, 2), (2, 3), (3, 4), (4, 5), (5, 6), (6, 7), (7, 8), (8, 9) },
                Enumerable.Range(0, 10).ZipWithNext().ToArray()
            );
            CollectionAssert.AreEqual(
                Array.Empty<(int, int)>(),
                Enumerable.Repeat(0, 1).ZipWithNext().ToArray()
            );
            CollectionAssert.AreEqual(
                Array.Empty<(int, int)>(),
                Enumerable.Empty<int>().ZipWithNext().ToArray()
            );
            Assert.ThrowsException<ArgumentNullException>(
                () => (null as IEnumerable<int>).ZipWithNext()
                                                .GetEnumerator()
                                                .MoveNext()
            );
        }
    }
}
