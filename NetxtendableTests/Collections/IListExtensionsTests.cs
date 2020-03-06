using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

// GENERATED CODE - DO NOT MODIFY

namespace Netxtendable.Collections.Tests {

    [TestClass]
    public class IListExtensionsTests {

        [TestMethod]
        public void Deconstruct_2_Test() {
            var (i1, i2) =
                new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
            Assert.AreEqual(1, i1);
            Assert.AreEqual(2, i2);
            var (s1, s2) =
                new List<string> { "1", "2", "3", "4", "5", "6", "7", "8" };
            Assert.AreEqual("1", s1);
            Assert.AreEqual("2", s2);
            Assert.ThrowsException<ArgumentNullException>(() => {
                var (a1, a2) = (List<int>)null;
            });
            Assert.ThrowsException<InvalidOperationException>(() => {
                var (a1, a2) = new List<int>();
            });
        }

        [TestMethod]
        public void Deconstruct_3_Test() {
            var (i1, i2, i3) =
                new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
            Assert.AreEqual(1, i1);
            Assert.AreEqual(2, i2);
            Assert.AreEqual(3, i3);
            var (s1, s2, s3) =
                new List<string> { "1", "2", "3", "4", "5", "6", "7", "8" };
            Assert.AreEqual("1", s1);
            Assert.AreEqual("2", s2);
            Assert.AreEqual("3", s3);
            Assert.ThrowsException<ArgumentNullException>(() => {
                var (a1, a2, a3) = (List<int>)null;
            });
            Assert.ThrowsException<InvalidOperationException>(() => {
                var (a1, a2, a3) = new List<int>();
            });
        }

        [TestMethod]
        public void Deconstruct_4_Test() {
            var (i1, i2, i3, i4) =
                new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
            Assert.AreEqual(1, i1);
            Assert.AreEqual(2, i2);
            Assert.AreEqual(3, i3);
            Assert.AreEqual(4, i4);
            var (s1, s2, s3, s4) =
                new List<string> { "1", "2", "3", "4", "5", "6", "7", "8" };
            Assert.AreEqual("1", s1);
            Assert.AreEqual("2", s2);
            Assert.AreEqual("3", s3);
            Assert.AreEqual("4", s4);
            Assert.ThrowsException<ArgumentNullException>(() => {
                var (a1, a2, a3, a4) = (List<int>)null;
            });
            Assert.ThrowsException<InvalidOperationException>(() => {
                var (a1, a2, a3, a4) = new List<int>();
            });
        }

        [TestMethod]
        public void Deconstruct_5_Test() {
            var (i1, i2, i3, i4, i5) =
                new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
            Assert.AreEqual(1, i1);
            Assert.AreEqual(2, i2);
            Assert.AreEqual(3, i3);
            Assert.AreEqual(4, i4);
            Assert.AreEqual(5, i5);
            var (s1, s2, s3, s4, s5) =
                new List<string> { "1", "2", "3", "4", "5", "6", "7", "8" };
            Assert.AreEqual("1", s1);
            Assert.AreEqual("2", s2);
            Assert.AreEqual("3", s3);
            Assert.AreEqual("4", s4);
            Assert.AreEqual("5", s5);
            Assert.ThrowsException<ArgumentNullException>(() => {
                var (a1, a2, a3, a4, a5) = (List<int>)null;
            });
            Assert.ThrowsException<InvalidOperationException>(() => {
                var (a1, a2, a3, a4, a5) = new List<int>();
            });
        }

        [TestMethod]
        public void Deconstruct_6_Test() {
            var (i1, i2, i3, i4, i5, i6) =
                new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
            Assert.AreEqual(1, i1);
            Assert.AreEqual(2, i2);
            Assert.AreEqual(3, i3);
            Assert.AreEqual(4, i4);
            Assert.AreEqual(5, i5);
            Assert.AreEqual(6, i6);
            var (s1, s2, s3, s4, s5, s6) =
                new List<string> { "1", "2", "3", "4", "5", "6", "7", "8" };
            Assert.AreEqual("1", s1);
            Assert.AreEqual("2", s2);
            Assert.AreEqual("3", s3);
            Assert.AreEqual("4", s4);
            Assert.AreEqual("5", s5);
            Assert.AreEqual("6", s6);
            Assert.ThrowsException<ArgumentNullException>(() => {
                var (a1, a2, a3, a4, a5, a6) = (List<int>)null;
            });
            Assert.ThrowsException<InvalidOperationException>(() => {
                var (a1, a2, a3, a4, a5, a6) = new List<int>();
            });
        }

        [TestMethod]
        public void Deconstruct_7_Test() {
            var (i1, i2, i3, i4, i5, i6, i7) =
                new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
            Assert.AreEqual(1, i1);
            Assert.AreEqual(2, i2);
            Assert.AreEqual(3, i3);
            Assert.AreEqual(4, i4);
            Assert.AreEqual(5, i5);
            Assert.AreEqual(6, i6);
            Assert.AreEqual(7, i7);
            var (s1, s2, s3, s4, s5, s6, s7) =
                new List<string> { "1", "2", "3", "4", "5", "6", "7", "8" };
            Assert.AreEqual("1", s1);
            Assert.AreEqual("2", s2);
            Assert.AreEqual("3", s3);
            Assert.AreEqual("4", s4);
            Assert.AreEqual("5", s5);
            Assert.AreEqual("6", s6);
            Assert.AreEqual("7", s7);
            Assert.ThrowsException<ArgumentNullException>(() => {
                var (a1, a2, a3, a4, a5, a6, a7) = (List<int>)null;
            });
            Assert.ThrowsException<InvalidOperationException>(() => {
                var (a1, a2, a3, a4, a5, a6, a7) = new List<int>();
            });
        }

    }

}
