using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Netxtendable.Extensions.Utils.Tests {

    [TestClass]
    public class RandomExtensionsTests {

        private static readonly Random random = new(729431685);

        private const int TRIES = 1024, INFINITE_SEQUENCE_TRIES = 10_000;

        [TestMethod]
        public void NextSingle_Test() {
            for (var i = 0; i < TRIES; ++i) {
                var value = random.NextSingle();
                Assert.IsTrue(value >= 0f && value < 1f);
            }
            Assert.ThrowsException<ArgumentNullException>(
                () => (null as Random).NextSingle()
            );
        }

        [TestMethod]
        public void NextSingle_Test_f() {
            const float MAX = 150f;
            for (var i = 0; i < TRIES; ++i) {
                var value = random.NextSingle(MAX);
                Assert.IsTrue(value >= 0f && value < MAX);
            }
            Assert.ThrowsException<ArgumentOutOfRangeException>(
                () => random.NextSingle(-MAX)
            );
            Assert.ThrowsException<ArgumentNullException>(
                () => (null as Random).NextSingle(MAX)
            );
        }

        [TestMethod]
        public void NextSingle_Test_f_f() {
            const float MIN = -200f, MAX = 150f;
            for (var i = 0; i < TRIES; ++i) {
                var value = random.NextSingle(MIN, MAX);
                Assert.IsTrue(value >= MIN && value < MAX);
            }
            Assert.ThrowsException<ArgumentOutOfRangeException>(
                () => random.NextSingle(MAX, MIN)
            );
            Assert.ThrowsException<ArgumentNullException>(
                () => (null as Random).NextSingle(MIN, MAX)
            );
        }

        [TestMethod]
        public void NextDouble_Test_d() {
            const double MAX = 150d;
            for (var i = 0; i < TRIES; ++i) {
                var value = random.NextDouble(MAX);
                Assert.IsTrue(value >= 0f && value < MAX);
            }
            Assert.ThrowsException<ArgumentOutOfRangeException>(
                () => random.NextDouble(-MAX)
            );
            Assert.ThrowsException<ArgumentNullException>(
                () => (null as Random).NextDouble(MAX)
            );
        }

        [TestMethod]
        public void NextDouble_Test_d_d() {
            const double MIN = -200d, MAX = 150d;
            for (var i = 0; i < TRIES; ++i) {
                var value = random.NextDouble(MIN, MAX);
                Assert.IsTrue(value >= MIN && value < MAX);
            }
            Assert.ThrowsException<ArgumentOutOfRangeException>(
                () => random.NextDouble(MAX, MIN)
            );
            Assert.ThrowsException<ArgumentNullException>(
                () => (null as Random).NextDouble(MIN, MAX)
            );
        }

        [TestMethod]
        public void NextDecimal_Test() {
            for (var i = 0; i < TRIES; ++i) {
                var value = random.NextDecimal();
                Assert.IsTrue(value >= 0m && value < 1m);
            }
            Assert.ThrowsException<ArgumentNullException>(
                () => (null as Random).NextDecimal()
            );
        }

        [TestMethod]
        public void NextDecimal_Test_m() {
            const decimal MAX = 150m;
            for (var i = 0; i < TRIES; ++i) {
                var value = random.NextDecimal(MAX);
                Assert.IsTrue(value >= 0m && value < MAX);
            }
            Assert.ThrowsException<ArgumentOutOfRangeException>(
                () => random.NextDecimal(-MAX)
            );
            Assert.ThrowsException<ArgumentNullException>(
                () => (null as Random).NextDecimal(MAX)
            );
        }

        [TestMethod]
        public void NextDecimal_Test_m_m() {
            const decimal MIN = -200m, MAX = 150m;
            for (var i = 0; i < TRIES; ++i) {
                var value = random.NextDecimal(MIN, MAX);
                Assert.IsTrue(value >= MIN && value < MAX);
            }
            Assert.ThrowsException<ArgumentOutOfRangeException>(
                () => random.NextDecimal(MAX, MIN)
            );
            Assert.ThrowsException<ArgumentNullException>(
                () => (null as Random).NextDecimal(MIN, MAX)
            );
        }

        [TestMethod]
        public void NextByte_Test() {
            random.NextByte();
            Assert.ThrowsException<ArgumentNullException>(
                () => (null as Random).NextByte()
            );
        }

        [TestMethod]
        public void NextBoolean_Test() {
            random.NextBoolean();
            Assert.ThrowsException<ArgumentNullException>(
                () => (null as Random).NextByte()
            );
        }

        [TestMethod]
        public void Next_Test() {
            var range1 = 15..327;
            var range2 = ^5..0;
            for (var i = 0; i < TRIES; ++i) {
                var value = random.Next(range1);
                Assert.IsTrue(value >= 15 && value < 327);
                value = random.Next(range2);
                Assert.IsTrue(value >= -5 && value < 0);
            }
            Assert.AreEqual(5, random.Next(5..6));
            random.Next(^3..0);
            Assert.ThrowsException<ArgumentOutOfRangeException>(
                () => random.Next(15..3)
            );
            Assert.ThrowsException<ArgumentOutOfRangeException>(
                () => random.Next(..^3)
            );
            Assert.ThrowsException<ArgumentNullException>(
                () => (null as Random).Next(range1)
            );
        }

        [TestMethod]
        public void NextInt32s_Test_ia() {
            var buffer = new int[TRIES];
            Array.Fill(buffer, -1);
            random.NextInt32s(buffer);
            foreach (var value in buffer) {
                Assert.IsTrue(value >= 0);
            }
            Assert.ThrowsException<ArgumentNullException>(
                () => random.NextInt32s(null)
            );
            Assert.ThrowsException<ArgumentNullException>(
                () => (null as Random).NextInt32s(buffer)
            );
        }

        [TestMethod]
        public void NextInt32s_Test_ia_i() {
            const int MAX = 30;
            var buffer = new int[TRIES];
            Array.Fill(buffer, -1);
            random.NextInt32s(buffer, MAX);
            foreach (var value in buffer) {
                Assert.IsTrue(value >= 0 && value < MAX);
            }
            Array.Fill(buffer, -1);
            random.NextInt32s(buffer, 1);
            foreach (var value in buffer) {
                Assert.AreEqual(0, value);
            }
            Assert.ThrowsException<ArgumentOutOfRangeException>(
                () => random.NextInt32s(buffer, -150)
            );
            Assert.ThrowsException<ArgumentOutOfRangeException>(
                () => random.NextInt32s(buffer, 0)
            );
            Assert.ThrowsException<ArgumentNullException>(
                () => random.NextInt32s(null, MAX)
            );
            Assert.ThrowsException<ArgumentNullException>(
                () => (null as Random).NextInt32s(buffer, MAX)
            );
        }

        [TestMethod]
        public void NextInt32s_Test_ia_i_i() {
            const int MIN = -15, MAX = 30;
            var buffer = new int[TRIES];
            Array.Fill(buffer, -1);
            random.NextInt32s(buffer, MIN, MAX);
            foreach (var value in buffer) {
                Assert.IsTrue(value >= MIN && value < MAX);
            }
            Array.Fill(buffer, -1);
            random.NextInt32s(buffer, 5, 6);
            foreach (var value in buffer) {
                Assert.AreEqual(5, value);
            }
            Assert.ThrowsException<ArgumentOutOfRangeException>(
                () => random.NextInt32s(buffer, MIN, MIN - 150)
            );
            Assert.ThrowsException<ArgumentOutOfRangeException>(
                () => random.NextInt32s(buffer, 0, 0)
            );
            Assert.ThrowsException<ArgumentNullException>(
                () => random.NextInt32s(null, MIN, MAX)
            );
            Assert.ThrowsException<ArgumentNullException>(
                () => (null as Random).NextInt32s(buffer, MIN, MAX)
            );
        }

        [TestMethod]
        public void NextInt32s_Test_ia_r() {
            const int MIN = 15, MAX = 30;
            var range = MIN..MAX;
            var buffer = new int[TRIES];
            Array.Fill(buffer, -1);
            random.NextInt32s(buffer, range);
            foreach (var value in buffer) {
                Assert.IsTrue(value >= MIN && value < MAX);
            }
            Array.Fill(buffer, -1);
            random.NextInt32s(buffer, ^5..0);
            foreach (var value in buffer) {
                Assert.IsTrue(value >= -5 && value < 0);
            }
            Array.Fill(buffer, -1);
            random.NextInt32s(buffer, 5..6);
            foreach (var value in buffer) {
                Assert.AreEqual(5, value);
            }
            Assert.ThrowsException<ArgumentOutOfRangeException>(
                () => random.NextInt32s(buffer, MAX..MIN)
            );
            Assert.ThrowsException<ArgumentOutOfRangeException>(
                () => random.NextInt32s(buffer, 15..15)
            );
            Assert.ThrowsException<ArgumentNullException>(
                () => random.NextInt32s(null, range)
            );
            Assert.ThrowsException<ArgumentNullException>(
                () => (null as Random).NextInt32s(buffer, range)
            );
        }

        [TestMethod]
        public void NextSingles_Test_fa() {
            var buffer = new float[TRIES];
            Array.Fill(buffer, -1);
            random.NextSingles(buffer);
            foreach (var value in buffer) {
                Assert.IsTrue(value >= 0f && value < 1f);
            }
            Assert.ThrowsException<ArgumentNullException>(
                () => random.NextSingles(null)
            );
            Assert.ThrowsException<ArgumentNullException>(
                () => (null as Random).NextSingles(buffer)
            );
        }

        [TestMethod]
        public void NextDoubles_Test_da() {
            var buffer = new double[TRIES];
            Array.Fill(buffer, -1);
            random.NextDoubles(buffer);
            foreach (var value in buffer) {
                Assert.IsTrue(value >= 0d && value < 1d);
            }
            Assert.ThrowsException<ArgumentNullException>(
                () => random.NextDoubles(null)
            );
            Assert.ThrowsException<ArgumentNullException>(
                () => (null as Random).NextDoubles(buffer)
            );
        }

        [TestMethod]
        public void NextDecimals_Test_ma() {
            var buffer = new decimal[TRIES];
            Array.Fill(buffer, -1);
            random.NextDecimals(buffer);
            foreach (var value in buffer) {
                Assert.IsTrue(value >= 0m && value < 1m);
            }
            Assert.ThrowsException<ArgumentNullException>(
                () => random.NextDecimals(null)
            );
            Assert.ThrowsException<ArgumentNullException>(
                () => (null as Random).NextDecimals(buffer)
            );
        }

        [TestMethod]
        public void NextBytes_Test_i() {
            var buffer = random.NextBytes(0);
            Assert.IsNotNull(buffer);
            Assert.AreEqual(0, buffer.Length);
            buffer = random.NextBytes(TRIES);
            Assert.IsNotNull(buffer);
            Assert.AreEqual(TRIES, buffer.Length);
            Assert.ThrowsException<ArgumentOutOfRangeException>(
                () => random.NextBytes(-5)
            );
            Assert.ThrowsException<ArgumentNullException>(
                () => (null as Random).NextBytes(TRIES)
            );
        }

        [TestMethod]
        public void NextInt32s_Test_i() {
            var buffer = random.NextInt32s(0);
            Assert.IsNotNull(buffer);
            Assert.AreEqual(0, buffer.Length);
            buffer = random.NextInt32s(TRIES);
            Assert.IsNotNull(buffer);
            Assert.AreEqual(TRIES, buffer.Length);
            foreach (var value in buffer) {
                Assert.IsTrue(value >= 0);
            }
            Assert.ThrowsException<ArgumentOutOfRangeException>(
                () => random.NextInt32s(-5)
            );
            Assert.ThrowsException<ArgumentNullException>(
                () => (null as Random).NextInt32s(TRIES)
            );
        }

        [TestMethod]
        public void NextInt32s_Test5_i_i() {
            const int MAX = 30;
            var buffer = random.NextInt32s(0, MAX);
            Assert.IsNotNull(buffer);
            Assert.AreEqual(0, buffer.Length);
            buffer = random.NextInt32s(TRIES, MAX);
            Assert.IsNotNull(buffer);
            Assert.AreEqual(TRIES, buffer.Length);
            foreach (var value in buffer) {
                Assert.IsTrue(value >= 0 && value < MAX);
            }
            buffer = random.NextInt32s(TRIES, 1);
            Assert.IsNotNull(buffer);
            Assert.AreEqual(TRIES, buffer.Length);
            foreach (var value in buffer) {
                Assert.AreEqual(0, value);
            }
            Assert.ThrowsException<ArgumentOutOfRangeException>(
                () => random.NextInt32s(-5, MAX)
            );
            Assert.ThrowsException<ArgumentOutOfRangeException>(
                () => random.NextInt32s(TRIES, -15)
            );
            Assert.ThrowsException<ArgumentNullException>(
                () => (null as Random).NextInt32s(TRIES, MAX)
            );
        }

        [TestMethod]
        public void NextInt32s_Test6_i_i_i() {
            const int MIN = -15, MAX = 30;
            var buffer = random.NextInt32s(0, MIN, MAX);
            Assert.IsNotNull(buffer);
            Assert.AreEqual(0, buffer.Length);
            buffer = random.NextInt32s(TRIES, MIN, MAX);
            Assert.IsNotNull(buffer);
            Assert.AreEqual(TRIES, buffer.Length);
            foreach (var value in buffer) {
                Assert.IsTrue(value >= MIN && value < MAX);
            }
            buffer = random.NextInt32s(TRIES, 5, 6);
            Assert.IsNotNull(buffer);
            Assert.AreEqual(TRIES, buffer.Length);
            foreach (var value in buffer) {
                Assert.AreEqual(5, value);
            }
            Assert.ThrowsException<ArgumentOutOfRangeException>(
                () => random.NextInt32s(-5, MIN, MAX)
            );
            Assert.ThrowsException<ArgumentOutOfRangeException>(
                () => random.NextInt32s(TRIES, MIN, MIN - 15)
            );
            Assert.ThrowsException<ArgumentNullException>(
                () => (null as Random).NextInt32s(TRIES, MIN, MAX)
            );
        }

        [TestMethod]
        public void NextInt32s_Test7_i_r() {
            const int MIN = 15, MAX = 30;
            var range = MIN..MAX;
            var buffer = random.NextInt32s(0, range);
            Assert.IsNotNull(buffer);
            Assert.AreEqual(0, buffer.Length);
            buffer = random.NextInt32s(TRIES, range);
            Assert.IsNotNull(buffer);
            Assert.AreEqual(TRIES, buffer.Length);
            foreach (var value in buffer) {
                Assert.IsTrue(value >= MIN && value < MAX);
            }
            buffer = random.NextInt32s(TRIES, ^5..0);
            Assert.IsNotNull(buffer);
            Assert.AreEqual(TRIES, buffer.Length);
            foreach (var value in buffer) {
                Assert.IsTrue(value >= -5 && value < 0);
            }
            buffer = random.NextInt32s(TRIES, 5..6);
            Assert.IsNotNull(buffer);
            Assert.AreEqual(TRIES, buffer.Length);
            foreach (var value in buffer) {
                Assert.AreEqual(5, value);
            }
            Assert.ThrowsException<ArgumentOutOfRangeException>(
                () => random.NextInt32s(-5, range)
            );
            Assert.ThrowsException<ArgumentOutOfRangeException>(
                () => random.NextInt32s(TRIES, MAX..MIN)
            );
            Assert.ThrowsException<ArgumentNullException>(
                () => (null as Random).NextInt32s(TRIES, range)
            );
        }

        [TestMethod]
        public void NextSingles_Test_i() {
            var buffer = random.NextSingles(0);
            Assert.IsNotNull(buffer);
            Assert.AreEqual(0, buffer.Length);
            buffer = random.NextSingles(TRIES);
            Assert.IsNotNull(buffer);
            Assert.AreEqual(TRIES, buffer.Length);
            foreach (var value in buffer) {
                Assert.IsTrue(value >= 0f && value < 1f);
            }
            Assert.ThrowsException<ArgumentOutOfRangeException>(
                () => random.NextSingles(-5)
            );
            Assert.ThrowsException<ArgumentNullException>(
                () => (null as Random).NextSingles(TRIES)
            );
        }

        [TestMethod]
        public void NextDoubles_Test_i() {
            var buffer = random.NextDoubles(0);
            Assert.IsNotNull(buffer);
            Assert.AreEqual(0, buffer.Length);
            buffer = random.NextDoubles(TRIES);
            Assert.IsNotNull(buffer);
            Assert.AreEqual(TRIES, buffer.Length);
            foreach (var value in buffer) {
                Assert.IsTrue(value >= 0d && value < 1d);
            }
            Assert.ThrowsException<ArgumentOutOfRangeException>(
                () => random.NextDoubles(-5)
            );
            Assert.ThrowsException<ArgumentNullException>(
                () => (null as Random).NextDoubles(TRIES)
            );
        }

        [TestMethod]
        public void NextDecimals_Test_i() {
            var buffer = random.NextDecimals(0);
            Assert.IsNotNull(buffer);
            Assert.AreEqual(0, buffer.Length);
            buffer = random.NextDecimals(TRIES);
            Assert.IsNotNull(buffer);
            Assert.AreEqual(TRIES, buffer.Length);
            foreach (var value in buffer) {
                Assert.IsTrue(value >= 0m && value < 1m);
            }
            Assert.ThrowsException<ArgumentOutOfRangeException>(
                () => random.NextDecimals(-5)
            );
            Assert.ThrowsException<ArgumentNullException>(
                () => (null as Random).NextDecimals(TRIES)
            );
        }

        private static void CheckStream<T>(IEnumerable<T> enumerable, Func<T, bool> test) {
            using var enumerator = enumerable.GetEnumerator();
            for (var i = 0; i < INFINITE_SEQUENCE_TRIES; ++i) {
                Assert.IsTrue(enumerator.MoveNext());
                Assert.IsTrue(test(enumerator.Current));
            }
        }

        [TestMethod]
        public void Int32Stream_Test() {
            CheckStream(random.Int32Stream(), i => i >= 0);
            Assert.ThrowsException<ArgumentNullException>(
                () => (null as Random).Int32Stream()
                                      .GetEnumerator()
                                      .MoveNext()
            );
        }

        [TestMethod]
        public void Int32Stream_Test_i() {
            const int MAX = 800;
            CheckStream(random.Int32Stream(MAX), i => i >= 0 && i < MAX);
            CheckStream(random.Int32Stream(1), i => i == 0);
            Assert.ThrowsException<ArgumentNullException>(
                () => (null as Random).Int32Stream(MAX)
                                      .GetEnumerator()
                                      .MoveNext()
            );
            Assert.ThrowsException<ArgumentOutOfRangeException>(
                () => random.Int32Stream(-15)
                            .GetEnumerator()
                            .MoveNext()
            );
        }

        [TestMethod]
        public void Int32Stream_Test_i_i() {
            const int MIN = -720, MAX = 650;
            CheckStream(random.Int32Stream(MIN, MAX), i => i >= MIN && i < MAX);
            CheckStream(random.Int32Stream(5, 6), i => i == 5);
            Assert.ThrowsException<ArgumentNullException>(
                () => (null as Random).Int32Stream(MIN, MAX)
                                      .GetEnumerator()
                                      .MoveNext()
            );
            Assert.ThrowsException<ArgumentOutOfRangeException>(
                () => random.Int32Stream(MAX, MIN)
                            .GetEnumerator()
                            .MoveNext()
            );
        }

        [TestMethod]
        public void Int32Stream_Test_r() {
            const int MIN = 12, MAX = 150;
            CheckStream(random.Int32Stream(MIN..MAX), i => i >= MIN && i < MAX);
            CheckStream(random.Int32Stream(^5..0), i => i >= -5 && i < 0);
            CheckStream(random.Int32Stream(5..6), i => i == 5);
            Assert.ThrowsException<ArgumentNullException>(
                () => (null as Random).Int32Stream(MIN..MAX)
                                      .GetEnumerator()
                                      .MoveNext()
            );
            Assert.ThrowsException<ArgumentOutOfRangeException>(
                () => random.Int32Stream(MAX..MIN)
                            .GetEnumerator()
                            .MoveNext()
            );
        }

        [TestMethod]
        public void SingleStream_Test() {
            CheckStream(random.SingleStream(), f => f >= 0f && f < 1f);
            Assert.ThrowsException<ArgumentNullException>(
                () => (null as Random).SingleStream()
                                      .GetEnumerator()
                                      .MoveNext()
            );
        }

        [TestMethod]
        public void DoubleStream_Test() {
            CheckStream(random.DoubleStream(), d => d >= 0d && d < 1d);
            Assert.ThrowsException<ArgumentNullException>(
                () => (null as Random).DoubleStream()
                                      .GetEnumerator()
                                      .MoveNext()
            );
        }

        [TestMethod]
        public void DecimalStream_Test() {
            CheckStream(random.DecimalStream(), m => m >= 0m && m < 1m);
            Assert.ThrowsException<ArgumentNullException>(
                () => (null as Random).DecimalStream()
                                      .GetEnumerator()
                                      .MoveNext()
            );
        }

        [TestMethod]
        public void Choice_Test_c() {
            var collection1 = new HashSet<char> { 'A', 'B', 'c', 'd', '5', '6', '.', '?' };
            var collection2 = new HashSet<string> { "", "asd", "QWE", "123", "84569", "    " };
            for (var i = 0; i < TRIES; ++i) {
                Assert.IsTrue(collection1.Contains(random.Choice(collection1)));
                Assert.IsTrue(collection2.Contains(random.Choice(collection2)));
            }
            Assert.ThrowsException<ArgumentNullException>(
                () => (null as Random).Choice(collection1)
            );
            Assert.ThrowsException<ArgumentNullException>(
                () => random.Choice(null as HashSet<int>)
            );
            Assert.ThrowsException<ArgumentException>(
                () => random.Choice(new HashSet<int>())
            );
        }

        [TestMethod]
        public void Choice_Test_l() {
            var list = new List<char> { 'A', 'B', 'c', 'd', '5', '6', '.', '?' };
            var listSet = list.ToHashSet();
            var array = new[] { "", "asd", "QWE", "123", "84569", "    " };
            var arraySet = array.ToHashSet();
            for (var i = 0; i < TRIES; ++i) {
                Assert.IsTrue(listSet.Contains(random.Choice(list)));
                Assert.IsTrue(arraySet.Contains(random.Choice(array)));
            }
            Assert.ThrowsException<ArgumentNullException>(
                () => (null as Random).Choice(list)
            );
            Assert.ThrowsException<ArgumentNullException>(
                () => random.Choice(null as int[])
            );
            Assert.ThrowsException<ArgumentException>(
                () => random.Choice(Array.Empty<int>())
            );
        }

        [TestMethod]
        public void Choices_Test_l() {
            var list = new List<char> { 'A', 'B', 'c', 'd', '5', '6', '.', '?' };
            var listSet = list.ToHashSet();
            var array = new[] { "", "asd", "QWE", "123", "84569", "    " };
            var arraySet = array.ToHashSet();
            var listChoices = random.Choices(list, TRIES);
            Assert.IsNotNull(listChoices);
            Assert.AreEqual(TRIES, listChoices.Length);
            for (var i = 0; i < TRIES; ++i) {
                Assert.IsTrue(listSet.Contains(listChoices[i]));
            }
            listChoices = random.Choices(list, 0);
            Assert.IsNotNull(listChoices);
            Assert.AreEqual(0, listChoices.Length);
            var arrayChoices = random.Choices(array, TRIES);
            Assert.IsNotNull(arrayChoices);
            Assert.AreEqual(TRIES, arrayChoices.Length);
            for (var i = 0; i < TRIES; ++i) {
                Assert.IsTrue(arraySet.Contains(arrayChoices[i]));
            }
            arrayChoices = random.Choices(new[] { "S" }, TRIES);
            Assert.IsNotNull(arrayChoices);
            Assert.AreEqual(TRIES, arrayChoices.Length);
            for (var i = 0; i < TRIES; ++i) {
                Assert.AreEqual("S", arrayChoices[i]);
            }
            Assert.ThrowsException<ArgumentOutOfRangeException>(
                () => random.Choices(list, -5)
            );
            Assert.ThrowsException<ArgumentNullException>(
                () => (null as Random).Choices(list, TRIES)
            );
            Assert.ThrowsException<ArgumentNullException>(
                () => random.Choices(null as int[], TRIES)
            );
            Assert.ThrowsException<ArgumentException>(
                () => random.Choices(Array.Empty<int>(), TRIES)
            );
        }

        [TestMethod]
        public void ChoiceStream_Test_l() {
            var list = new List<char> { 'A', 'B', 'c', 'd', '5', '6', '.', '?' };
            var listSet = list.ToHashSet();
            var array = new[] { "", "asd", "QWE", "123", "84569", "    " };
            var arraySet = array.ToHashSet();
            CheckStream(random.ChoiceStream(list), c => listSet.Contains(c));
            CheckStream(random.ChoiceStream(array), c => arraySet.Contains(c));
            CheckStream(random.ChoiceStream(new[]{ 19 }), i => i == 19);
            Assert.ThrowsException<ArgumentNullException>(
                () => (null as Random).ChoiceStream(list)
                                      .GetEnumerator()
                                      .MoveNext()
            );
            Assert.ThrowsException<ArgumentNullException>(
                () => random.ChoiceStream(null as int[])
                            .GetEnumerator()
                            .MoveNext()
            );
            Assert.ThrowsException<ArgumentException>(
                () => random.ChoiceStream(Array.Empty<double>())
                            .GetEnumerator()
                            .MoveNext()
            );
        }

        [TestMethod]
        public void Sample_Test_l() {
            const int COUNT = 5;
            var list = new List<char> { 'A', 'B', 'c', 'd', '5', '6', '.', '?' };
            var array = new[] { "", "asd", "QWE", "123", "84569", "    ", "+--+-+", "Hello" };
            var sample1 = random.Sample(list, COUNT);
            Assert.IsNotNull(sample1);
            Assert.AreEqual(COUNT, sample1.Length);
            CollectionAssert.IsSubsetOf(sample1, list);
            var sample2 = random.Sample(array, COUNT);
            Assert.IsNotNull(sample2);
            Assert.AreEqual(COUNT, sample2.Length);
            CollectionAssert.IsSubsetOf(sample2, array);
            sample1 = random.Sample(list, list.Count);
            Assert.IsNotNull(sample1);
            CollectionAssert.AreEquivalent(sample1, list);
            sample2 = random.Sample(new List<string>{ "List" }, 1);
            Assert.IsNotNull(sample2);
            Assert.AreEqual(1, sample2.Length);
            Assert.AreEqual("List", sample2[0]);
            sample1 = random.Sample(Array.Empty<char>(), 0);
            Assert.IsNotNull(sample1);
            Assert.AreEqual(0, sample1.Length);
            Assert.ThrowsException<ArgumentOutOfRangeException>(
                () => random.Sample(list, -COUNT)
            );
            Assert.ThrowsException<ArgumentNullException>(
                () => (null as Random).Sample(list, COUNT)
            );
            Assert.ThrowsException<ArgumentNullException>(
                () => random.Sample(null as int[], COUNT)
            );
            Assert.ThrowsException<ArgumentOutOfRangeException>(
                () => random.Sample(list, 1000)
            );
        }

        [TestMethod]
        public void Choice_Test_s() {
            const string STR = "aBcDeF1234.?:;ghijKLMN/*-+=";
            var set = STR.ToHashSet();
            for (var i = 0; i < TRIES; ++i) {
                Assert.IsTrue(set.Contains(random.Choice(STR)));
            }
            Assert.ThrowsException<ArgumentNullException>(
                () => (null as Random).Choice(STR)
            );
            Assert.ThrowsException<ArgumentNullException>(
                () => random.Choice(null as string)
            );
            Assert.ThrowsException<ArgumentException>(
                () => random.Choice("")
            );
        }

        [TestMethod]
        public void Choices_Test_s() {
            const string STR = "aBcDeF1234.?:;ghijKLMN/*-+=";
            var set = STR.ToHashSet();
            var choices = random.Choices(STR, TRIES);
            Assert.IsNotNull(choices);
            Assert.AreEqual(TRIES, choices.Length);
            for (var i = 0; i < TRIES; ++i) {
                Assert.IsTrue(set.Contains(choices[i]));
            }
            choices = random.Choices("U", TRIES);
            Assert.IsNotNull(choices);
            Assert.AreEqual(TRIES, choices.Length);
            for (var i = 0; i < TRIES; ++i) {
                Assert.AreEqual('U', choices[i]);
            }
            choices = random.Choices(STR, 0);
            Assert.IsNotNull(choices);
            Assert.AreEqual(0, choices.Length);
            Assert.ThrowsException<ArgumentOutOfRangeException>(
                () => random.Choices(STR, -5)
            );
            Assert.ThrowsException<ArgumentNullException>(
                () => (null as Random).Choices(STR, TRIES)
            );
            Assert.ThrowsException<ArgumentNullException>(
                () => random.Choices(null as string, TRIES)
            );
            Assert.ThrowsException<ArgumentException>(
                () => random.Choices("", TRIES)
            );
        }

        [TestMethod]
        public void ChoiceStream_Test_s() {
            const string STR = "aBcDeF1234.?:;ghijKLMN/*-+=";
            var set = STR.ToHashSet();
            CheckStream(random.ChoiceStream(STR), c => set.Contains(c));
            CheckStream(random.ChoiceStream("X"), c => c == 'X');
            Assert.ThrowsException<ArgumentNullException>(
                () => (null as Random).ChoiceStream(STR)
                                      .GetEnumerator()
                                      .MoveNext()
            );
            Assert.ThrowsException<ArgumentNullException>(
                () => random.ChoiceStream(null as string)
                            .GetEnumerator()
                            .MoveNext()
            );
            Assert.ThrowsException<ArgumentException>(
                () => random.ChoiceStream("")
                            .GetEnumerator()
                            .MoveNext()
            );
        }

        [TestMethod]
        public void Sample_Test_s() {
            const int COUNT = 10;
            const string STR = "aBcDeF1234.?:;ghijKLMN/*-+=";
            var chars = STR.ToCharArray();
            var sample = random.Sample(STR, COUNT);
            Assert.IsNotNull(sample);
            Assert.AreEqual(COUNT, sample.Length);
            CollectionAssert.IsSubsetOf(sample, chars);
            sample = random.Sample("U", 1);
            Assert.IsNotNull(sample);
            Assert.AreEqual(1, sample.Length);
            Assert.AreEqual('U', sample[0]);
            sample = random.Sample(STR, 0);
            Assert.IsNotNull(sample);
            Assert.AreEqual(0, sample.Length);
            sample = random.Sample(STR, STR.Length);
            Assert.IsNotNull(sample);
            CollectionAssert.AreEquivalent(sample, chars);
            Assert.ThrowsException<ArgumentOutOfRangeException>(
                () => random.Sample(STR, -COUNT)
            );
            Assert.ThrowsException<ArgumentNullException>(
                () => (null as Random).Sample(STR, COUNT)
            );
            Assert.ThrowsException<ArgumentNullException>(
                () => random.Sample(null as string, COUNT)
            );
            Assert.ThrowsException<ArgumentOutOfRangeException>(
                () => random.Sample(STR, 1000)
            );
        }

        [TestMethod]
        public void Shuffle_Test() {
            var originalArray = new[] { 0, 1, 1, 2, 3, 4, 5, 5, 6, 7, 8, 8, 9 };
            var shuffledArray = new int[originalArray.Length];
            Array.Copy(originalArray, shuffledArray, originalArray.Length);
            shuffledArray = new[] { int.MinValue, int.MaxValue };
            for (var i = 0; i < TRIES; ++i) {
                random.Shuffle(shuffledArray);
                Assert.IsTrue(
                    (shuffledArray[0] == int.MinValue && shuffledArray[1] == int.MaxValue) ||
                    (shuffledArray[0] == int.MaxValue && shuffledArray[1] == int.MinValue)
                );
            }
            var originalList = new List<string> { "A", null, "BCD", "", "eF", null, "ghiJkl", "M" };
            var shuffledList = new List<string>(originalList);
            for (var i = 0; i < TRIES; ++i) {
                random.Shuffle(shuffledList);
                CollectionAssert.AreEquivalent(originalList, shuffledList);
            }
            random.Shuffle(Array.Empty<char>());
            var one = new[] { 'L' };
            random.Shuffle(one);
            Assert.AreEqual('L', one[0]);
            Assert.ThrowsException<ArgumentNullException>(
                () => (null as Random).Shuffle(shuffledList)
            );
            Assert.ThrowsException<ArgumentNullException>(
                () => random.Shuffle(null as char[])
            );
        }

        [TestMethod]
        public void ShuffleCopy_Test() {
            var originalArray = new[] { 0, 1, 1, 2, 3, 4, 5, 5, 6, 7, 8, 8, 9 };
            var shuffledArray = random.ShuffleCopy(originalArray);
            Assert.IsNotNull(shuffledArray);
            CollectionAssert.AreEquivalent(originalArray, shuffledArray);
            var originalList = new List<string> { "A", null, "BCD", "", "eF", null, "ghiJkl", "M" };
            var shuffledList = random.ShuffleCopy(originalList);
            Assert.IsNotNull(shuffledList);
            CollectionAssert.AreEquivalent(originalList, shuffledList);
            var shuffled = random.ShuffleCopy(Array.Empty<char>());
            Assert.IsNotNull(shuffled);
            Assert.AreEqual(0, shuffled.Length);
            shuffled = random.ShuffleCopy(new[] { 'L' });
            Assert.IsNotNull(shuffled);
            Assert.AreEqual(1, shuffled.Length);
            Assert.AreEqual('L', shuffled[0]);
            Assert.ThrowsException<ArgumentNullException>(
                () => (null as Random).ShuffleCopy(shuffledList)
            );
            Assert.ThrowsException<ArgumentNullException>(
                () => random.ShuffleCopy(null as char[])
            );
        }
    }
}
