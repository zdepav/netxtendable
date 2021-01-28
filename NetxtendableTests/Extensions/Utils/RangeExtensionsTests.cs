using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Netxtendable.Extensions.Utils.Tests {

    [TestClass]
    public class RangeExtensionsTests {

        [TestMethod]
        public void ToEnumerable_Test() {
            CollectionAssert.AreEqual(
                new[] { -5, -4, -3, -2, -1, 0, 1, 2, 3, 4, 5 },
                (^5..6).ToEnumerable().ToArray()
            );
            Assert.AreEqual(8, (^4..4).ToEnumerable().Count());
            CollectionAssert.AreEqual(
                new[] { 12, 11, 10, 9, 8 },
                (12..7).ToEnumerable().ToArray()
            );
        }

        [TestMethod]
        public void GetEnumerator_Test() {
            var list = new List<int>();
            foreach (var i in ^5..6) {
                list.Add(i);
            }
            CollectionAssert.AreEqual(new[] { -5, -4, -3, -2, -1, 0, 1, 2, 3, 4, 5 }, list);
            list.Clear();
            foreach (var i in ^4..4) {
                list.Add(i);
            }
            Assert.AreEqual(8, list.Count);
            list.Clear();
            foreach (var i in 12..7) {
                list.Add(i);
            }
            CollectionAssert.AreEqual(new[] { 12, 11, 10, 9, 8 }, list);
        }
    }
}
