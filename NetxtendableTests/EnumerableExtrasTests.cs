using System.Linq;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Netxtendable.Tests {

    [TestClass]
    public class EnumerableExtrasTests {

        [TestMethod]
        public void Generate_Test1() {
            var i = 0;
            CollectionAssert.AreEqual(
                new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 },
                EnumerableExtras
                    .Generate(() => i++)
                    .Take(21)
                    .ToArray()
            );
        }

        [TestMethod]
        public void Generate_Test2() {
            CollectionAssert.AreEqual(
                new[] {
                    1, 2, 4, 8, 16, 32, 64, 128, 256, 512, 1024, 2048, 4096, 8192, 16384, 32768
                },
                EnumerableExtras
                    .Generate(1, n => n * 2)
                    .Take(16)
                    .ToArray()
            );
            var rules = new Regex("[AB]");
            CollectionAssert.AreEqual(
                new[] {
                    "A",
                    "B-A-B",
                    "A+B+A-B-A-B-A+B+A",
                    "B-A-B+A+B+A+B-A-B-A+B+A-B-A-B-A+B+A-B-A-B+A+B+A+B-A-B",
                    "A+B+A-B-A-B-A+B+A+B-A-B+A+B+A+B-A-B+A+B+A-B-A-B-A+B+A-B-A-B+A+B+A+B-A-B-A+" +
                    "B+A-B-A-B-A+B+A-B-A-B+A+B+A+B-A-B-A+B+A-B-A-B-A+B+A+B-A-B+A+B+A+B-A-B+A+B+" +
                    "A-B-A-B-A+B+A"
                },
                EnumerableExtras
                    .Generate(
                        "A",
                        str => rules.Replace(
                            str,
                            m => m.Value[0] switch {
                                'A' => "B-A-B",
                                'B' => "A+B+A",
                                _   => ""
                            }
                        )
                    )
                    .Take(5)
                    .ToArray()
            );
        }

        [TestMethod]
        public void Generate_Test3() {
            CollectionAssert.AreEqual(
                new[] {
                    0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, 1597, 2584,
                    4181, 6765, 10946, 17711, 28657, 46368, 75025, 121393, 196418, 317811, 514229
                },
                EnumerableExtras
                    .Generate(0, 1, (a, b) => a + b)
                    .Take(30)
                    .ToArray()
            );
            CollectionAssert.AreEqual(
                new[] { "", "a", "a", "aa", "aaa", "aaaaa", "aaaaaaaa", "aaaaaaaaaaaaa" },
                EnumerableExtras
                    .Generate("", "a", (a, b) => a + b)
                    .Take(8)
                    .ToArray()
            );
        }

        [TestMethod]
        public void Generate_Test4() {
            CollectionAssert.AreEqual(
                new[] { 0, 1, 1, 0, 2, -1, 3, -2, 4, -3, 5, -4, 6, -5, 7, -6, 8, -7, 9, -8 },
                EnumerableExtras
                    .Generate(0, 1, 1, (a, b, c) => a + b - c)
                    .Take(20)
                    .ToArray()
            );
            CollectionAssert.AreEqual(
                new[] {
                    "A", "B", "C", "ACB", "BACBC",
                    "CBACBCACB", "ACBCBACBCACBBACBC",
                    "BACBCACBCBACBCACBBACBCCBACBCACB",
                    "CBACBCACBBACBCACBCBACBCACBBACBCCBACBCACBACBCBACBCACBBACBC"
                },
                EnumerableExtras
                    .Generate("A", "B", "C", (a, b, c) => a + c + b)
                    .Take(9)
                    .ToArray()
            );
        }

        [TestMethod]
        public void One_Test() {
            CollectionAssert.AreEqual(
                new[] { 12 },
                EnumerableExtras
                    .One(12)
                    .ToArray()
            );
            CollectionAssert.AreEqual(
                new[] { "Hello" },
                EnumerableExtras
                    .One("Hello")
                    .ToArray()
            );
            CollectionAssert.AreEqual(
                new object[] { null },
                EnumerableExtras
                    .One<object>(null)
                    .ToArray()
            );
        }

        private static void CheckRepeat<T>(T value) {
            using var enumerator = EnumerableExtras.Repeat(value).GetEnumerator();
            for (var i = 0; i < 10000; ++i) {
                Assert.IsTrue(enumerator.MoveNext());
                Assert.AreEqual(value, enumerator.Current);
            }
        }

        [TestMethod]
        public void Repeat_Test() {
            CheckRepeat(12);
            CheckRepeat("Hello");
            CheckRepeat<object>(null);
        }
    }
}
