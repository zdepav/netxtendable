using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Netxtendable.Collections.Tests {

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
                Enumerable.Repeat("Hello", 3).JoinToString(" and "));
        }

        [TestMethod]
        public void JoinToString_Test2() {
            Assert.AreEqual(
                "Hello,Hello,Hello",
                Enumerable.Repeat("Hello", 3).JoinToString(','));
        }

        [TestMethod]
        public void JoinToString_Test3() {
            Assert.AreEqual(
                "Hello, Hello, Hello",
                Enumerable.Repeat("Hello", 3).JoinToString());
        }

        [TestMethod]
        public void MapWhere_Test1() {
            var values = new[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H' };
            var output = new[] { 'A', 'B', 'c', 'd', 'e', 'F', 'G', 'H' };
            CollectionAssert.AreEqual(
                output,
                values.MapWhere(c => c >= 'C' && c <= 'E', char.ToLower).ToArray());
        }

        [TestMethod]
        public void MapWhere_Test2() {
            var values = new[] { "A", "B", "C", "D", "E", "F", "G", "H" };
            var output = new[] { "A", "1", "C", "3", "E", "5", "G", "7" };
            CollectionAssert.AreEqual(
                output,
                values.MapWhere((_, i) => i % 2 == 1, (_, i) => i.ToString()).ToArray());
        }

        [TestMethod]
        public void Map_Test1() {
            var values = new[] {
                "123", "12345", "1", "1234567", "12", "123456789", "1234", "123456", "12345678"
            };
            CollectionAssert.AreEqual(
                values.Select(s => s.Length).ToArray(),
                values.Map(s => s.Length).ToArray());
        }

        [TestMethod]
        public void Map_Test2() {
            var values = new[] {
                "123", "12345", "1", "1234567", "12", "123456789", "1234", "123456", "12345678"
            };
            CollectionAssert.AreEqual(
                values.Select((s, i) => s.Length + i).ToArray(),
                values.Map((s, i) => s.Length + i).ToArray());
        }

        [TestMethod]
        public void Partition_Test() {
            var (l1, l2) = Enumerable.Range(1, 10).Partition(i => i % 3 > 0);
            CollectionAssert.AreEqual(new[] { 1, 2, 4, 5, 7, 8, 10 }, l1);
            CollectionAssert.AreEqual(new[] { 3, 6, 9 }, l2);
        }

        [TestMethod]
        public void None_Test() {
            Assert.IsTrue(new[] { 1, 2, 4, 5, 7, 8, 10 }.None(i => i == 6));
            Assert.IsFalse(new[] { 1, 2, 4, 6, 7, 8, 10 }.None(i => i == 6));
        }

        [TestMethod]
        public void ForEach_Test() {
            var l = new List<int>();
            var values = new[] { 1, 2, 4, 5, 7, 8, 10 };
            values.ForEach(i => l.Add(i));
            CollectionAssert.AreEqual(values, l);
        }

        [TestMethod]
        public void MaxBy_Test() {
            var values = new[] {
                "123", "12345", "1", "1234567", "12", "123456789", "1234", "123456", "12345678"
            };
            Assert.AreEqual("123456789", values.MaxBy(s => s.Length));
        }

        [TestMethod]
        public void MinBy_Test() {
            var values = new[] {
                "123", "12345", "1", "1234567", "12", "123456789", "1234", "123456", "12345678"
            };
            Assert.AreEqual("1", values.MinBy(s => s.Length));
        }

        [TestMethod]
        public void WhereNot_Test() {
            var values = new[] {
                "123", "12345", "1", "1234567", "12", "123456789", "1234", "123456", "12345678"
            };
            CollectionAssert.AreEqual(
                values.Where(s => s.Length <= 4).ToArray(),
                values.WhereNot(s => s.Length > 4).ToArray());
        }

        [TestMethod]
        public void NonNull_Test() {
            var values = new[] {
                "123", null, "1", "1234567", null, null, "1234", null, "12345678"
            };
            CollectionAssert.AreEqual(
                new[] { "123", "1", "1234567", "1234", "12345678" },
                values.NonNull().ToArray());
        }

        [TestMethod]
        public void Matching_Test1() {
            var values = new[] {
                "123", "12E45", "1", "1234567", "I2", "123A5:7B9", "1234", "1234?6", "12345678"
            };
            CollectionAssert.AreEqual(
                new[] { "123", "1", "1234567", "1234", "12345678" },
                values.Matching(new Regex(@"^\d+$")).ToArray());
        }

        [TestMethod]
        public void Matching_Test2() {
            var values = new[] {
                "123", "12E45", "1", "1234567", "I2", "123A5:7B9", "1234", "1234?6", "12345678"
            };
            CollectionAssert.AreEqual(
                new[] { "123", "1", "1234567", "1234", "12345678" },
                values.Matching(@"^\d+$").ToArray());
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
            var input = new[] { "123:12345", "1", "1234567:12:123456789:1234", "123456:12345678" };
            CollectionAssert.AreEqual(
                new[] { 3, 5, 1, 7, 2, 9, 4, 6, 8 },
                input.FlatMap(s => s.Split(':').Select(i => i.Length)).ToArray());
        }

        [TestMethod]
        public void ToDictionary_Test() {
            var input = new[] { ("1", 4), ("2", 5), ("3", 6), ("4", 7) };
            CollectionAssert.AreEquivalent(new[] {
                new KeyValuePair<string, int>("1", 4),
                new KeyValuePair<string, int>("2", 5),
                new KeyValuePair<string, int>("3", 6),
                new KeyValuePair<string, int>("4", 7)
            }, input.ToDictionary());
        }

    }

}
