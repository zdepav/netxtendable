using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

// GENERATED CODE - DO NOT MODIFY

namespace Netxtendable.Collections.Tests {

    [TestClass]
    public class TupleExtensionsTests {

        [TestMethod]
        public void Deconstruct_2_Test() {
            var (i1, i2) = new Tuple<
                int, int
            >(1, 2);
            Assert.AreEqual(1, i1);
            Assert.AreEqual(2, i2);
            var (s1, s2) = new Tuple<
                string, string
            >("1", "2");
            Assert.AreEqual("1", s1);
            Assert.AreEqual("2", s2);
            Assert.ThrowsException<ArgumentNullException>(() => {
                var (a1, a2) = (Tuple<int, int>)null;
            });
        }

        [TestMethod]
        public void Deconstruct_3_Test() {
            var (i1, i2, i3) = new Tuple<
                int, int, int
            >(1, 2, 3);
            Assert.AreEqual(1, i1);
            Assert.AreEqual(2, i2);
            Assert.AreEqual(3, i3);
            var (s1, s2, s3) = new Tuple<
                string, string, string
            >("1", "2", "3");
            Assert.AreEqual("1", s1);
            Assert.AreEqual("2", s2);
            Assert.AreEqual("3", s3);
            Assert.ThrowsException<ArgumentNullException>(() => {
                var (a1, a2, a3) = (Tuple<int, int, int>)null;
            });
        }

        [TestMethod]
        public void Deconstruct_4_Test() {
            var (i1, i2, i3, i4) = new Tuple<
                int, int, int, int
            >(1, 2, 3, 4);
            Assert.AreEqual(1, i1);
            Assert.AreEqual(2, i2);
            Assert.AreEqual(3, i3);
            Assert.AreEqual(4, i4);
            var (s1, s2, s3, s4) = new Tuple<
                string, string, string, string
            >("1", "2", "3", "4");
            Assert.AreEqual("1", s1);
            Assert.AreEqual("2", s2);
            Assert.AreEqual("3", s3);
            Assert.AreEqual("4", s4);
            Assert.ThrowsException<ArgumentNullException>(() => {
                var (a1, a2, a3, a4) = (Tuple<int, int, int, int>)null;
            });
        }

        [TestMethod]
        public void Deconstruct_5_Test() {
            var (i1, i2, i3, i4, i5) = new Tuple<
                int, int, int, int, int
            >(1, 2, 3, 4, 5);
            Assert.AreEqual(1, i1);
            Assert.AreEqual(2, i2);
            Assert.AreEqual(3, i3);
            Assert.AreEqual(4, i4);
            Assert.AreEqual(5, i5);
            var (s1, s2, s3, s4, s5) = new Tuple<
                string, string, string, string, string
            >("1", "2", "3", "4", "5");
            Assert.AreEqual("1", s1);
            Assert.AreEqual("2", s2);
            Assert.AreEqual("3", s3);
            Assert.AreEqual("4", s4);
            Assert.AreEqual("5", s5);
            Assert.ThrowsException<ArgumentNullException>(() => {
                var (a1, a2, a3, a4, a5) = (Tuple<int, int, int, int, int>)null;
            });
        }

        [TestMethod]
        public void Deconstruct_6_Test() {
            var (i1, i2, i3, i4, i5, i6) = new Tuple<
                int, int, int, int, int, int
            >(1, 2, 3, 4, 5, 6);
            Assert.AreEqual(1, i1);
            Assert.AreEqual(2, i2);
            Assert.AreEqual(3, i3);
            Assert.AreEqual(4, i4);
            Assert.AreEqual(5, i5);
            Assert.AreEqual(6, i6);
            var (s1, s2, s3, s4, s5, s6) = new Tuple<
                string, string, string, string, string, string
            >("1", "2", "3", "4", "5", "6");
            Assert.AreEqual("1", s1);
            Assert.AreEqual("2", s2);
            Assert.AreEqual("3", s3);
            Assert.AreEqual("4", s4);
            Assert.AreEqual("5", s5);
            Assert.AreEqual("6", s6);
            Assert.ThrowsException<ArgumentNullException>(() => {
                var (a1, a2, a3, a4, a5, a6) = (Tuple<int, int, int, int, int, int>)null;
            });
        }

        [TestMethod]
        public void Deconstruct_7_Test() {
            var (i1, i2, i3, i4, i5, i6, i7) = new Tuple<
                int, int, int, int, int, int, int
            >(1, 2, 3, 4, 5, 6, 7);
            Assert.AreEqual(1, i1);
            Assert.AreEqual(2, i2);
            Assert.AreEqual(3, i3);
            Assert.AreEqual(4, i4);
            Assert.AreEqual(5, i5);
            Assert.AreEqual(6, i6);
            Assert.AreEqual(7, i7);
            var (s1, s2, s3, s4, s5, s6, s7) = new Tuple<
                string, string, string, string, string, string, string
            >("1", "2", "3", "4", "5", "6", "7");
            Assert.AreEqual("1", s1);
            Assert.AreEqual("2", s2);
            Assert.AreEqual("3", s3);
            Assert.AreEqual("4", s4);
            Assert.AreEqual("5", s5);
            Assert.AreEqual("6", s6);
            Assert.AreEqual("7", s7);
            Assert.ThrowsException<ArgumentNullException>(() => {
                var (a1, a2, a3, a4, a5, a6, a7) = (Tuple<int, int, int, int, int, int, int>)null;
            });
        }

        [TestMethod]
        public void ToArray_2_Test() {
            var ints = new Tuple<int, int>(1, 2).ToArray();
            CollectionAssert.AreEqual(new[] { 1, 2 }, ints);
            var strings = new Tuple<
                string, string
            >("1", "2").ToArray();
            CollectionAssert.AreEqual(new[] { "1", "2" }, strings);
            Assert.ThrowsException<ArgumentNullException>(() => {
                ((Tuple<int, int>)null).ToArray();
            });
        }

        [TestMethod]
        public void ToArray_3_Test() {
            var ints = new Tuple<int, int, int>(1, 2, 3).ToArray();
            CollectionAssert.AreEqual(new[] { 1, 2, 3 }, ints);
            var strings = new Tuple<
                string, string, string
            >("1", "2", "3").ToArray();
            CollectionAssert.AreEqual(new[] { "1", "2", "3" }, strings);
            Assert.ThrowsException<ArgumentNullException>(() => {
                ((Tuple<int, int, int>)null).ToArray();
            });
        }

        [TestMethod]
        public void ToArray_4_Test() {
            var ints = new Tuple<int, int, int, int>(1, 2, 3, 4).ToArray();
            CollectionAssert.AreEqual(new[] { 1, 2, 3, 4 }, ints);
            var strings = new Tuple<
                string, string, string, string
            >("1", "2", "3", "4").ToArray();
            CollectionAssert.AreEqual(new[] { "1", "2", "3", "4" }, strings);
            Assert.ThrowsException<ArgumentNullException>(() => {
                ((Tuple<int, int, int, int>)null).ToArray();
            });
        }

        [TestMethod]
        public void ToArray_5_Test() {
            var ints = new Tuple<int, int, int, int, int>(1, 2, 3, 4, 5).ToArray();
            CollectionAssert.AreEqual(new[] { 1, 2, 3, 4, 5 }, ints);
            var strings = new Tuple<
                string, string, string, string, string
            >("1", "2", "3", "4", "5").ToArray();
            CollectionAssert.AreEqual(new[] { "1", "2", "3", "4", "5" }, strings);
            Assert.ThrowsException<ArgumentNullException>(() => {
                ((Tuple<int, int, int, int, int>)null).ToArray();
            });
        }

        [TestMethod]
        public void ToArray_6_Test() {
            var ints = new Tuple<int, int, int, int, int, int>(1, 2, 3, 4, 5, 6).ToArray();
            CollectionAssert.AreEqual(new[] { 1, 2, 3, 4, 5, 6 }, ints);
            var strings = new Tuple<
                string, string, string, string, string, string
            >("1", "2", "3", "4", "5", "6").ToArray();
            CollectionAssert.AreEqual(new[] { "1", "2", "3", "4", "5", "6" }, strings);
            Assert.ThrowsException<ArgumentNullException>(() => {
                ((Tuple<int, int, int, int, int, int>)null).ToArray();
            });
        }

        [TestMethod]
        public void ToArray_7_Test() {
            var ints = new Tuple<int, int, int, int, int, int, int>(1, 2, 3, 4, 5, 6, 7).ToArray();
            CollectionAssert.AreEqual(new[] { 1, 2, 3, 4, 5, 6, 7 }, ints);
            var strings = new Tuple<
                string, string, string, string, string, string, string
            >("1", "2", "3", "4", "5", "6", "7").ToArray();
            CollectionAssert.AreEqual(new[] { "1", "2", "3", "4", "5", "6", "7" }, strings);
            Assert.ThrowsException<ArgumentNullException>(() => {
                ((Tuple<int, int, int, int, int, int, int>)null).ToArray();
            });
        }

        [TestMethod]
        public void ToList_2_Test() {
            var ints = new Tuple<int, int>(1, 2).ToList();
            CollectionAssert.AreEqual(new[] { 1, 2 }, ints);
            var strings = new Tuple<
                string, string
            >("1", "2").ToList();
            CollectionAssert.AreEqual(new[] { "1", "2" }, strings);
            Assert.ThrowsException<ArgumentNullException>(() => {
                ((Tuple<int, int>)null).ToList();
            });
        }

        [TestMethod]
        public void ToList_3_Test() {
            var ints = new Tuple<int, int, int>(1, 2, 3).ToList();
            CollectionAssert.AreEqual(new[] { 1, 2, 3 }, ints);
            var strings = new Tuple<
                string, string, string
            >("1", "2", "3").ToList();
            CollectionAssert.AreEqual(new[] { "1", "2", "3" }, strings);
            Assert.ThrowsException<ArgumentNullException>(() => {
                ((Tuple<int, int, int>)null).ToList();
            });
        }

        [TestMethod]
        public void ToList_4_Test() {
            var ints = new Tuple<int, int, int, int>(1, 2, 3, 4).ToList();
            CollectionAssert.AreEqual(new[] { 1, 2, 3, 4 }, ints);
            var strings = new Tuple<
                string, string, string, string
            >("1", "2", "3", "4").ToList();
            CollectionAssert.AreEqual(new[] { "1", "2", "3", "4" }, strings);
            Assert.ThrowsException<ArgumentNullException>(() => {
                ((Tuple<int, int, int, int>)null).ToList();
            });
        }

        [TestMethod]
        public void ToList_5_Test() {
            var ints = new Tuple<int, int, int, int, int>(1, 2, 3, 4, 5).ToList();
            CollectionAssert.AreEqual(new[] { 1, 2, 3, 4, 5 }, ints);
            var strings = new Tuple<
                string, string, string, string, string
            >("1", "2", "3", "4", "5").ToList();
            CollectionAssert.AreEqual(new[] { "1", "2", "3", "4", "5" }, strings);
            Assert.ThrowsException<ArgumentNullException>(() => {
                ((Tuple<int, int, int, int, int>)null).ToList();
            });
        }

        [TestMethod]
        public void ToList_6_Test() {
            var ints = new Tuple<int, int, int, int, int, int>(1, 2, 3, 4, 5, 6).ToList();
            CollectionAssert.AreEqual(new[] { 1, 2, 3, 4, 5, 6 }, ints);
            var strings = new Tuple<
                string, string, string, string, string, string
            >("1", "2", "3", "4", "5", "6").ToList();
            CollectionAssert.AreEqual(new[] { "1", "2", "3", "4", "5", "6" }, strings);
            Assert.ThrowsException<ArgumentNullException>(() => {
                ((Tuple<int, int, int, int, int, int>)null).ToList();
            });
        }

        [TestMethod]
        public void ToList_7_Test() {
            var ints = new Tuple<int, int, int, int, int, int, int>(1, 2, 3, 4, 5, 6, 7).ToList();
            CollectionAssert.AreEqual(new[] { 1, 2, 3, 4, 5, 6, 7 }, ints);
            var strings = new Tuple<
                string, string, string, string, string, string, string
            >("1", "2", "3", "4", "5", "6", "7").ToList();
            CollectionAssert.AreEqual(new[] { "1", "2", "3", "4", "5", "6", "7" }, strings);
            Assert.ThrowsException<ArgumentNullException>(() => {
                ((Tuple<int, int, int, int, int, int, int>)null).ToList();
            });
        }

        [TestMethod]
        public void ToSet_2_Test() {
            var ints = new Tuple<
                int, int
            >(1, 2).ToSet().ToArray();
            CollectionAssert.AreEquivalent(new[] { 1, 2 }, ints);
            var strings = new Tuple<
                string, string
            >("1", "2").ToSet().ToArray();
            CollectionAssert.AreEquivalent(new[] { "1", "2" }, strings);
            Assert.ThrowsException<ArgumentNullException>(() => {
                ((Tuple<int, int>)null).ToSet();
            });
        }

        [TestMethod]
        public void ToSet_3_Test() {
            var ints = new Tuple<
                int, int, int
            >(1, 2, 3).ToSet().ToArray();
            CollectionAssert.AreEquivalent(new[] { 1, 2, 3 }, ints);
            var strings = new Tuple<
                string, string, string
            >("1", "2", "3").ToSet().ToArray();
            CollectionAssert.AreEquivalent(new[] { "1", "2", "3" }, strings);
            Assert.ThrowsException<ArgumentNullException>(() => {
                ((Tuple<int, int, int>)null).ToSet();
            });
        }

        [TestMethod]
        public void ToSet_4_Test() {
            var ints = new Tuple<
                int, int, int, int
            >(1, 2, 3, 4).ToSet().ToArray();
            CollectionAssert.AreEquivalent(new[] { 1, 2, 3, 4 }, ints);
            var strings = new Tuple<
                string, string, string, string
            >("1", "2", "3", "4").ToSet().ToArray();
            CollectionAssert.AreEquivalent(new[] { "1", "2", "3", "4" }, strings);
            Assert.ThrowsException<ArgumentNullException>(() => {
                ((Tuple<int, int, int, int>)null).ToSet();
            });
        }

        [TestMethod]
        public void ToSet_5_Test() {
            var ints = new Tuple<
                int, int, int, int, int
            >(1, 2, 3, 4, 5).ToSet().ToArray();
            CollectionAssert.AreEquivalent(new[] { 1, 2, 3, 4, 5 }, ints);
            var strings = new Tuple<
                string, string, string, string, string
            >("1", "2", "3", "4", "5").ToSet().ToArray();
            CollectionAssert.AreEquivalent(new[] { "1", "2", "3", "4", "5" }, strings);
            Assert.ThrowsException<ArgumentNullException>(() => {
                ((Tuple<int, int, int, int, int>)null).ToSet();
            });
        }

        [TestMethod]
        public void ToSet_6_Test() {
            var ints = new Tuple<
                int, int, int, int, int, int
            >(1, 2, 3, 4, 5, 6).ToSet().ToArray();
            CollectionAssert.AreEquivalent(new[] { 1, 2, 3, 4, 5, 6 }, ints);
            var strings = new Tuple<
                string, string, string, string, string, string
            >("1", "2", "3", "4", "5", "6").ToSet().ToArray();
            CollectionAssert.AreEquivalent(new[] { "1", "2", "3", "4", "5", "6" }, strings);
            Assert.ThrowsException<ArgumentNullException>(() => {
                ((Tuple<int, int, int, int, int, int>)null).ToSet();
            });
        }

        [TestMethod]
        public void ToSet_7_Test() {
            var ints = new Tuple<
                int, int, int, int, int, int, int
            >(1, 2, 3, 4, 5, 6, 7).ToSet().ToArray();
            CollectionAssert.AreEquivalent(new[] { 1, 2, 3, 4, 5, 6, 7 }, ints);
            var strings = new Tuple<
                string, string, string, string, string, string, string
            >("1", "2", "3", "4", "5", "6", "7").ToSet().ToArray();
            CollectionAssert.AreEquivalent(new[] { "1", "2", "3", "4", "5", "6", "7" }, strings);
            Assert.ThrowsException<ArgumentNullException>(() => {
                ((Tuple<int, int, int, int, int, int, int>)null).ToSet();
            });
        }

        [TestMethod]
        public void ToDictionary_2_Test() {
            var ints = new Tuple<
                (int, int), (int, int)
            >(
                (1, 11),
                (2, 12)
            ).ToDictionary();
            CollectionAssert.AreEquivalent(new[] {
                new KeyValuePair<int, int>(1, 11),
                new KeyValuePair<int, int>(2, 12)
            }, ints);
            var strings = new Tuple<
                (string, string),
                (string, string)
            >(
                ("1", "11"),
                ("2", "12")
            ).ToDictionary();
            CollectionAssert.AreEquivalent(new[] {
                new KeyValuePair<string, string>("1", "11"),
                new KeyValuePair<string, string>("2", "12")
            }, strings);
            Assert.ThrowsException<ArgumentNullException>(() => {
                ((Tuple<
                    (int, int),
                    (int, int)
                >)null).ToDictionary();
            });
        }

        [TestMethod]
        public void ToDictionary_3_Test() {
            var ints = new Tuple<
                (int, int), (int, int), (int, int)
            >(
                (1, 11),
                (2, 12),
                (3, 13)
            ).ToDictionary();
            CollectionAssert.AreEquivalent(new[] {
                new KeyValuePair<int, int>(1, 11),
                new KeyValuePair<int, int>(2, 12),
                new KeyValuePair<int, int>(3, 13)
            }, ints);
            var strings = new Tuple<
                (string, string),
                (string, string),
                (string, string)
            >(
                ("1", "11"),
                ("2", "12"),
                ("3", "13")
            ).ToDictionary();
            CollectionAssert.AreEquivalent(new[] {
                new KeyValuePair<string, string>("1", "11"),
                new KeyValuePair<string, string>("2", "12"),
                new KeyValuePair<string, string>("3", "13")
            }, strings);
            Assert.ThrowsException<ArgumentNullException>(() => {
                ((Tuple<
                    (int, int),
                    (int, int),
                    (int, int)
                >)null).ToDictionary();
            });
        }

        [TestMethod]
        public void ToDictionary_4_Test() {
            var ints = new Tuple<
                (int, int), (int, int), (int, int), (int, int)
            >(
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
            var strings = new Tuple<
                (string, string),
                (string, string),
                (string, string),
                (string, string)
            >(
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
            Assert.ThrowsException<ArgumentNullException>(() => {
                ((Tuple<
                    (int, int),
                    (int, int),
                    (int, int),
                    (int, int)
                >)null).ToDictionary();
            });
        }

        [TestMethod]
        public void ToDictionary_5_Test() {
            var ints = new Tuple<
                (int, int), (int, int), (int, int), (int, int), (int, int)
            >(
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
            var strings = new Tuple<
                (string, string),
                (string, string),
                (string, string),
                (string, string),
                (string, string)
            >(
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
            Assert.ThrowsException<ArgumentNullException>(() => {
                ((Tuple<
                    (int, int),
                    (int, int),
                    (int, int),
                    (int, int),
                    (int, int)
                >)null).ToDictionary();
            });
        }

        [TestMethod]
        public void ToDictionary_6_Test() {
            var ints = new Tuple<
                (int, int), (int, int), (int, int), (int, int), (int, int), (int, int)
            >(
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
            var strings = new Tuple<
                (string, string),
                (string, string),
                (string, string),
                (string, string),
                (string, string),
                (string, string)
            >(
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
            Assert.ThrowsException<ArgumentNullException>(() => {
                ((Tuple<
                    (int, int),
                    (int, int),
                    (int, int),
                    (int, int),
                    (int, int),
                    (int, int)
                >)null).ToDictionary();
            });
        }

        [TestMethod]
        public void ToDictionary_7_Test() {
            var ints = new Tuple<
                (int, int), (int, int), (int, int), (int, int), (int, int), (int, int), (int, int)
            >(
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
            var strings = new Tuple<
                (string, string),
                (string, string),
                (string, string),
                (string, string),
                (string, string),
                (string, string),
                (string, string)
            >(
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
            Assert.ThrowsException<ArgumentNullException>(() => {
                ((Tuple<
                    (int, int),
                    (int, int),
                    (int, int),
                    (int, int),
                    (int, int),
                    (int, int),
                    (int, int)
                >)null).ToDictionary();
            });
        }

        [TestMethod]
        public void Enumerate_2_Test() {
            var ints = new Tuple<
                int, int
            >(1, 2).Enumerate().ToArray();
            CollectionAssert.AreEqual(new[] { 1, 2 }, ints);
            var strings = new Tuple<
                string, string
            >("1", "2").Enumerate().ToArray();
            CollectionAssert.AreEqual(new[] { "1", "2" }, strings);
            Assert.ThrowsException<ArgumentNullException>(() => {
                foreach (var v in ((Tuple<int, int>)null).Enumerate()) { }
            });
        }

        [TestMethod]
        public void Enumerate_3_Test() {
            var ints = new Tuple<
                int, int, int
            >(1, 2, 3).Enumerate().ToArray();
            CollectionAssert.AreEqual(new[] { 1, 2, 3 }, ints);
            var strings = new Tuple<
                string, string, string
            >("1", "2", "3").Enumerate().ToArray();
            CollectionAssert.AreEqual(new[] { "1", "2", "3" }, strings);
            Assert.ThrowsException<ArgumentNullException>(() => {
                foreach (var v in ((Tuple<int, int, int>)null).Enumerate()) { }
            });
        }

        [TestMethod]
        public void Enumerate_4_Test() {
            var ints = new Tuple<
                int, int, int, int
            >(1, 2, 3, 4).Enumerate().ToArray();
            CollectionAssert.AreEqual(new[] { 1, 2, 3, 4 }, ints);
            var strings = new Tuple<
                string, string, string, string
            >("1", "2", "3", "4").Enumerate().ToArray();
            CollectionAssert.AreEqual(new[] { "1", "2", "3", "4" }, strings);
            Assert.ThrowsException<ArgumentNullException>(() => {
                foreach (var v in ((Tuple<int, int, int, int>)null).Enumerate()) { }
            });
        }

        [TestMethod]
        public void Enumerate_5_Test() {
            var ints = new Tuple<
                int, int, int, int, int
            >(1, 2, 3, 4, 5).Enumerate().ToArray();
            CollectionAssert.AreEqual(new[] { 1, 2, 3, 4, 5 }, ints);
            var strings = new Tuple<
                string, string, string, string, string
            >("1", "2", "3", "4", "5").Enumerate().ToArray();
            CollectionAssert.AreEqual(new[] { "1", "2", "3", "4", "5" }, strings);
            Assert.ThrowsException<ArgumentNullException>(() => {
                foreach (var v in ((Tuple<int, int, int, int, int>)null).Enumerate()) { }
            });
        }

        [TestMethod]
        public void Enumerate_6_Test() {
            var ints = new Tuple<
                int, int, int, int, int, int
            >(1, 2, 3, 4, 5, 6).Enumerate().ToArray();
            CollectionAssert.AreEqual(new[] { 1, 2, 3, 4, 5, 6 }, ints);
            var strings = new Tuple<
                string, string, string, string, string, string
            >("1", "2", "3", "4", "5", "6").Enumerate().ToArray();
            CollectionAssert.AreEqual(new[] { "1", "2", "3", "4", "5", "6" }, strings);
            Assert.ThrowsException<ArgumentNullException>(() => {
                foreach (var v in ((Tuple<int, int, int, int, int, int>)null).Enumerate()) { }
            });
        }

        [TestMethod]
        public void Enumerate_7_Test() {
            var ints = new Tuple<
                int, int, int, int, int, int, int
            >(1, 2, 3, 4, 5, 6, 7).Enumerate().ToArray();
            CollectionAssert.AreEqual(new[] { 1, 2, 3, 4, 5, 6, 7 }, ints);
            var strings = new Tuple<
                string, string, string, string, string, string, string
            >("1", "2", "3", "4", "5", "6", "7").Enumerate().ToArray();
            CollectionAssert.AreEqual(new[] { "1", "2", "3", "4", "5", "6", "7" }, strings);
            Assert.ThrowsException<ArgumentNullException>(() => {
                foreach (var v in ((Tuple<int, int, int, int, int, int, int>)null).Enumerate()) { }
            });
        }
    }
}
