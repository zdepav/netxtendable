using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

// GENERATED CODE - DO NOT MODIFY

namespace Netxtendable.Extensions.Collections.Tests {

    [TestClass]
    public class ValueTupleExtensionsTests {

        [TestMethod]
        public void ToArray_2_Test() {
            var ints = (1, 2).ToArray();
            CollectionAssert.AreEqual(new[] { 1, 2 }, ints);
            var strings = ("1", "2").ToArray();
            CollectionAssert.AreEqual(new[] { "1", "2" }, strings);
        }

        [TestMethod]
        public void ToArray_3_Test() {
            var ints = (1, 2, 3).ToArray();
            CollectionAssert.AreEqual(new[] { 1, 2, 3 }, ints);
            var strings = ("1", "2", "3").ToArray();
            CollectionAssert.AreEqual(new[] { "1", "2", "3" }, strings);
        }

        [TestMethod]
        public void ToArray_4_Test() {
            var ints = (1, 2, 3, 4).ToArray();
            CollectionAssert.AreEqual(new[] { 1, 2, 3, 4 }, ints);
            var strings = ("1", "2", "3", "4").ToArray();
            CollectionAssert.AreEqual(new[] { "1", "2", "3", "4" }, strings);
        }

        [TestMethod]
        public void ToArray_5_Test() {
            var ints = (1, 2, 3, 4, 5).ToArray();
            CollectionAssert.AreEqual(new[] { 1, 2, 3, 4, 5 }, ints);
            var strings = ("1", "2", "3", "4", "5").ToArray();
            CollectionAssert.AreEqual(new[] { "1", "2", "3", "4", "5" }, strings);
        }

        [TestMethod]
        public void ToArray_6_Test() {
            var ints = (1, 2, 3, 4, 5, 6).ToArray();
            CollectionAssert.AreEqual(new[] { 1, 2, 3, 4, 5, 6 }, ints);
            var strings = ("1", "2", "3", "4", "5", "6").ToArray();
            CollectionAssert.AreEqual(new[] { "1", "2", "3", "4", "5", "6" }, strings);
        }

        [TestMethod]
        public void ToArray_7_Test() {
            var ints = (1, 2, 3, 4, 5, 6, 7).ToArray();
            CollectionAssert.AreEqual(new[] { 1, 2, 3, 4, 5, 6, 7 }, ints);
            var strings = ("1", "2", "3", "4", "5", "6", "7").ToArray();
            CollectionAssert.AreEqual(new[] { "1", "2", "3", "4", "5", "6", "7" }, strings);
        }

        [TestMethod]
        public void ToList_2_Test() {
            var ints = (1, 2).ToList();
            CollectionAssert.AreEqual(new[] { 1, 2 }, ints);
            var strings = ("1", "2").ToList();
            CollectionAssert.AreEqual(new[] { "1", "2" }, strings);
        }

        [TestMethod]
        public void ToList_3_Test() {
            var ints = (1, 2, 3).ToList();
            CollectionAssert.AreEqual(new[] { 1, 2, 3 }, ints);
            var strings = ("1", "2", "3").ToList();
            CollectionAssert.AreEqual(new[] { "1", "2", "3" }, strings);
        }

        [TestMethod]
        public void ToList_4_Test() {
            var ints = (1, 2, 3, 4).ToList();
            CollectionAssert.AreEqual(new[] { 1, 2, 3, 4 }, ints);
            var strings = ("1", "2", "3", "4").ToList();
            CollectionAssert.AreEqual(new[] { "1", "2", "3", "4" }, strings);
        }

        [TestMethod]
        public void ToList_5_Test() {
            var ints = (1, 2, 3, 4, 5).ToList();
            CollectionAssert.AreEqual(new[] { 1, 2, 3, 4, 5 }, ints);
            var strings = ("1", "2", "3", "4", "5").ToList();
            CollectionAssert.AreEqual(new[] { "1", "2", "3", "4", "5" }, strings);
        }

        [TestMethod]
        public void ToList_6_Test() {
            var ints = (1, 2, 3, 4, 5, 6).ToList();
            CollectionAssert.AreEqual(new[] { 1, 2, 3, 4, 5, 6 }, ints);
            var strings = ("1", "2", "3", "4", "5", "6").ToList();
            CollectionAssert.AreEqual(new[] { "1", "2", "3", "4", "5", "6" }, strings);
        }

        [TestMethod]
        public void ToList_7_Test() {
            var ints = (1, 2, 3, 4, 5, 6, 7).ToList();
            CollectionAssert.AreEqual(new[] { 1, 2, 3, 4, 5, 6, 7 }, ints);
            var strings = ("1", "2", "3", "4", "5", "6", "7").ToList();
            CollectionAssert.AreEqual(new[] { "1", "2", "3", "4", "5", "6", "7" }, strings);
        }

        [TestMethod]
        public void ToSet_2_Test() {
            var ints = (1, 2).ToSet().ToArray();
            CollectionAssert.AreEquivalent(new[] { 1, 2 }, ints);
            var strings = ("1", "2").ToSet().ToArray();
            CollectionAssert.AreEquivalent(new[] { "1", "2" }, strings);
        }

        [TestMethod]
        public void ToSet_3_Test() {
            var ints = (1, 2, 3).ToSet().ToArray();
            CollectionAssert.AreEquivalent(new[] { 1, 2, 3 }, ints);
            var strings = ("1", "2", "3").ToSet().ToArray();
            CollectionAssert.AreEquivalent(new[] { "1", "2", "3" }, strings);
        }

        [TestMethod]
        public void ToSet_4_Test() {
            var ints = (1, 2, 3, 4).ToSet().ToArray();
            CollectionAssert.AreEquivalent(new[] { 1, 2, 3, 4 }, ints);
            var strings = ("1", "2", "3", "4").ToSet().ToArray();
            CollectionAssert.AreEquivalent(new[] { "1", "2", "3", "4" }, strings);
        }

        [TestMethod]
        public void ToSet_5_Test() {
            var ints = (1, 2, 3, 4, 5).ToSet().ToArray();
            CollectionAssert.AreEquivalent(new[] { 1, 2, 3, 4, 5 }, ints);
            var strings = ("1", "2", "3", "4", "5").ToSet().ToArray();
            CollectionAssert.AreEquivalent(new[] { "1", "2", "3", "4", "5" }, strings);
        }

        [TestMethod]
        public void ToSet_6_Test() {
            var ints = (1, 2, 3, 4, 5, 6).ToSet().ToArray();
            CollectionAssert.AreEquivalent(new[] { 1, 2, 3, 4, 5, 6 }, ints);
            var strings = ("1", "2", "3", "4", "5", "6").ToSet().ToArray();
            CollectionAssert.AreEquivalent(new[] { "1", "2", "3", "4", "5", "6" }, strings);
        }

        [TestMethod]
        public void ToSet_7_Test() {
            var ints = (1, 2, 3, 4, 5, 6, 7).ToSet().ToArray();
            CollectionAssert.AreEquivalent(new[] { 1, 2, 3, 4, 5, 6, 7 }, ints);
            var strings = ("1", "2", "3", "4", "5", "6", "7").ToSet().ToArray();
            CollectionAssert.AreEquivalent(new[] { "1", "2", "3", "4", "5", "6", "7" }, strings);
        }

        [TestMethod]
        public void ToDictionary_2_Test() {
            var ints = (
                (1, 11),
                (2, 12)
            ).ToDictionary();
            CollectionAssert.AreEquivalent(new[] {
                new KeyValuePair<int, int>(1, 11),
                new KeyValuePair<int, int>(2, 12)
            }, ints);
            var strings = (
                ("1", "11"),
                ("2", "12")
            ).ToDictionary();
            CollectionAssert.AreEquivalent(new[] {
                new KeyValuePair<string, string>("1", "11"),
                new KeyValuePair<string, string>("2", "12")
            }, strings);
        }

        [TestMethod]
        public void ToDictionary_3_Test() {
            var ints = (
                (1, 11),
                (2, 12),
                (3, 13)
            ).ToDictionary();
            CollectionAssert.AreEquivalent(new[] {
                new KeyValuePair<int, int>(1, 11),
                new KeyValuePair<int, int>(2, 12),
                new KeyValuePair<int, int>(3, 13)
            }, ints);
            var strings = (
                ("1", "11"),
                ("2", "12"),
                ("3", "13")
            ).ToDictionary();
            CollectionAssert.AreEquivalent(new[] {
                new KeyValuePair<string, string>("1", "11"),
                new KeyValuePair<string, string>("2", "12"),
                new KeyValuePair<string, string>("3", "13")
            }, strings);
        }

        [TestMethod]
        public void ToDictionary_4_Test() {
            var ints = (
                (1, 11),
                (2, 12),
                (3, 13),
                (4, 14)
            ).ToDictionary();
            CollectionAssert.AreEquivalent(new[] {
                new KeyValuePair<int, int>(1, 11),
                new KeyValuePair<int, int>(2, 12),
                new KeyValuePair<int, int>(3, 13),
                new KeyValuePair<int, int>(4, 14)
            }, ints);
            var strings = (
                ("1", "11"),
                ("2", "12"),
                ("3", "13"),
                ("4", "14")
            ).ToDictionary();
            CollectionAssert.AreEquivalent(new[] {
                new KeyValuePair<string, string>("1", "11"),
                new KeyValuePair<string, string>("2", "12"),
                new KeyValuePair<string, string>("3", "13"),
                new KeyValuePair<string, string>("4", "14")
            }, strings);
        }

        [TestMethod]
        public void ToDictionary_5_Test() {
            var ints = (
                (1, 11),
                (2, 12),
                (3, 13),
                (4, 14),
                (5, 15)
            ).ToDictionary();
            CollectionAssert.AreEquivalent(new[] {
                new KeyValuePair<int, int>(1, 11),
                new KeyValuePair<int, int>(2, 12),
                new KeyValuePair<int, int>(3, 13),
                new KeyValuePair<int, int>(4, 14),
                new KeyValuePair<int, int>(5, 15)
            }, ints);
            var strings = (
                ("1", "11"),
                ("2", "12"),
                ("3", "13"),
                ("4", "14"),
                ("5", "15")
            ).ToDictionary();
            CollectionAssert.AreEquivalent(new[] {
                new KeyValuePair<string, string>("1", "11"),
                new KeyValuePair<string, string>("2", "12"),
                new KeyValuePair<string, string>("3", "13"),
                new KeyValuePair<string, string>("4", "14"),
                new KeyValuePair<string, string>("5", "15")
            }, strings);
        }

        [TestMethod]
        public void ToDictionary_6_Test() {
            var ints = (
                (1, 11),
                (2, 12),
                (3, 13),
                (4, 14),
                (5, 15),
                (6, 16)
            ).ToDictionary();
            CollectionAssert.AreEquivalent(new[] {
                new KeyValuePair<int, int>(1, 11),
                new KeyValuePair<int, int>(2, 12),
                new KeyValuePair<int, int>(3, 13),
                new KeyValuePair<int, int>(4, 14),
                new KeyValuePair<int, int>(5, 15),
                new KeyValuePair<int, int>(6, 16)
            }, ints);
            var strings = (
                ("1", "11"),
                ("2", "12"),
                ("3", "13"),
                ("4", "14"),
                ("5", "15"),
                ("6", "16")
            ).ToDictionary();
            CollectionAssert.AreEquivalent(new[] {
                new KeyValuePair<string, string>("1", "11"),
                new KeyValuePair<string, string>("2", "12"),
                new KeyValuePair<string, string>("3", "13"),
                new KeyValuePair<string, string>("4", "14"),
                new KeyValuePair<string, string>("5", "15"),
                new KeyValuePair<string, string>("6", "16")
            }, strings);
        }

        [TestMethod]
        public void ToDictionary_7_Test() {
            var ints = (
                (1, 11),
                (2, 12),
                (3, 13),
                (4, 14),
                (5, 15),
                (6, 16),
                (7, 17)
            ).ToDictionary();
            CollectionAssert.AreEquivalent(new[] {
                new KeyValuePair<int, int>(1, 11),
                new KeyValuePair<int, int>(2, 12),
                new KeyValuePair<int, int>(3, 13),
                new KeyValuePair<int, int>(4, 14),
                new KeyValuePair<int, int>(5, 15),
                new KeyValuePair<int, int>(6, 16),
                new KeyValuePair<int, int>(7, 17)
            }, ints);
            var strings = (
                ("1", "11"),
                ("2", "12"),
                ("3", "13"),
                ("4", "14"),
                ("5", "15"),
                ("6", "16"),
                ("7", "17")
            ).ToDictionary();
            CollectionAssert.AreEquivalent(new[] {
                new KeyValuePair<string, string>("1", "11"),
                new KeyValuePair<string, string>("2", "12"),
                new KeyValuePair<string, string>("3", "13"),
                new KeyValuePair<string, string>("4", "14"),
                new KeyValuePair<string, string>("5", "15"),
                new KeyValuePair<string, string>("6", "16"),
                new KeyValuePair<string, string>("7", "17")
            }, strings);
        }

        [TestMethod]
        public void Enumerate_2_Test() {
            var ints = (1, 2).Enumerate().ToArray();
            CollectionAssert.AreEqual(new[] { 1, 2 }, ints);
            var strings = ("1", "2").Enumerate().ToArray();
            CollectionAssert.AreEqual(new[] { "1", "2" }, strings);
        }

        [TestMethod]
        public void Enumerate_3_Test() {
            var ints = (1, 2, 3).Enumerate().ToArray();
            CollectionAssert.AreEqual(new[] { 1, 2, 3 }, ints);
            var strings = ("1", "2", "3").Enumerate().ToArray();
            CollectionAssert.AreEqual(new[] { "1", "2", "3" }, strings);
        }

        [TestMethod]
        public void Enumerate_4_Test() {
            var ints = (1, 2, 3, 4).Enumerate().ToArray();
            CollectionAssert.AreEqual(new[] { 1, 2, 3, 4 }, ints);
            var strings = ("1", "2", "3", "4").Enumerate().ToArray();
            CollectionAssert.AreEqual(new[] { "1", "2", "3", "4" }, strings);
        }

        [TestMethod]
        public void Enumerate_5_Test() {
            var ints = (1, 2, 3, 4, 5).Enumerate().ToArray();
            CollectionAssert.AreEqual(new[] { 1, 2, 3, 4, 5 }, ints);
            var strings = ("1", "2", "3", "4", "5").Enumerate().ToArray();
            CollectionAssert.AreEqual(new[] { "1", "2", "3", "4", "5" }, strings);
        }

        [TestMethod]
        public void Enumerate_6_Test() {
            var ints = (1, 2, 3, 4, 5, 6).Enumerate().ToArray();
            CollectionAssert.AreEqual(new[] { 1, 2, 3, 4, 5, 6 }, ints);
            var strings = ("1", "2", "3", "4", "5", "6").Enumerate().ToArray();
            CollectionAssert.AreEqual(new[] { "1", "2", "3", "4", "5", "6" }, strings);
        }

        [TestMethod]
        public void Enumerate_7_Test() {
            var ints = (1, 2, 3, 4, 5, 6, 7).Enumerate().ToArray();
            CollectionAssert.AreEqual(new[] { 1, 2, 3, 4, 5, 6, 7 }, ints);
            var strings = ("1", "2", "3", "4", "5", "6", "7").Enumerate().ToArray();
            CollectionAssert.AreEqual(new[] { "1", "2", "3", "4", "5", "6", "7" }, strings);
        }
    }
}
