using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Numerics;

namespace Netxtendable.Extensions.Numerics.Tests {

    [TestClass]
    public class NumberExtensionsTests {

        [TestMethod]
        public void Clamp_SByte_Test() {
            Assert.AreEqual((sbyte)-20, ((sbyte)-100).Clamp(-20, 80));
            Assert.AreEqual((sbyte)40, ((sbyte)40).Clamp(-20, 80));
            Assert.AreEqual((sbyte)80, ((sbyte)90).Clamp(-20, 80));
            ((sbyte)50).Clamp(80, -20); // No exception
        }

        [TestMethod]
        public void Clamp_Byte_Test() {
            Assert.AreEqual((byte)20, ((byte)10).Clamp(20, 80));
            Assert.AreEqual((byte)40, ((byte)40).Clamp(20, 80));
            Assert.AreEqual((byte)80, ((byte)90).Clamp(20, 80));
            ((byte)50).Clamp(80, 20); // No exception
        }

        [TestMethod]
        public void Clamp_Int16_Test() {
            Assert.AreEqual((short)-200, ((short)-1000).Clamp(-200, 800));
            Assert.AreEqual((short)400, ((short)400).Clamp(-200, 800));
            Assert.AreEqual((short)800, ((short)900).Clamp(-200, 800));
            ((short)500).Clamp(800, -200); // No exception
        }

        [TestMethod]
        public void Clamp_UInt16_Test() {
            Assert.AreEqual((ushort)200, ((ushort)100).Clamp(200, 800));
            Assert.AreEqual((ushort)400, ((ushort)400).Clamp(200, 800));
            Assert.AreEqual((ushort)800, ((ushort)900).Clamp(200, 800));
            ((ushort)500).Clamp(800, 200); // No exception
        }

        [TestMethod]
        public void Clamp_Int32_Test() {
            Assert.AreEqual(-200, (-1000).Clamp(-200, 800));
            Assert.AreEqual(400, 400.Clamp(-200, 800));
            Assert.AreEqual(800, 900.Clamp(-200, 800));
            500.Clamp(800, -200); // No exception
        }

        [TestMethod]
        public void Clamp_UInt32_Test() {
            Assert.AreEqual(200U, 100U.Clamp(200U, 800U));
            Assert.AreEqual(400U, 400U.Clamp(200U, 800U));
            Assert.AreEqual(800U, 900U.Clamp(200U, 800U));
            500U.Clamp(800U, 200U); // No exception
        }

        [TestMethod]
        public void Clamp_Int64_Test() {
            Assert.AreEqual(-200L, (-1000L).Clamp(-200L, 800L));
            Assert.AreEqual(400L, 400L.Clamp(-200L, 800L));
            Assert.AreEqual(800L, 900L.Clamp(-200L, 800L));
            500L.Clamp(800L, -200L); // No exception
        }

        [TestMethod]
        public void Clamp_UInt64_Test() {
            Assert.AreEqual(200UL, 100UL.Clamp(200UL, 800UL));
            Assert.AreEqual(400UL, 400UL.Clamp(200UL, 800UL));
            Assert.AreEqual(800UL, 900UL.Clamp(200UL, 800UL));
            500UL.Clamp(800UL, 200UL); // No exception
        }

        [TestMethod]
        public void Clamp_BigInteger_Test() {
            Assert.AreEqual(new(-200), new BigInteger(-1000).Clamp(-200, 800));
            Assert.AreEqual(new(400), new BigInteger(400).Clamp(-200, 800));
            Assert.AreEqual(new(800), new BigInteger(900).Clamp(-200, 800));
            new BigInteger(500).Clamp(800, -200); // No exception
        }

        [TestMethod]
        public void Clamp_Single_Test() {
            Assert.AreEqual(-200f, (-1000f).Clamp(-200f, 800f));
            Assert.AreEqual(400f, 400f.Clamp(-200f, 800f));
            Assert.AreEqual(800f, 900f.Clamp(-200f, 800f));
            Assert.AreEqual(float.NaN, float.NaN.Clamp(-200f, 800f));
            500f.Clamp(800f, -200f); // No exception
        }

        [TestMethod]
        public void Clamp_Double_Test() {
            Assert.AreEqual(-200d, (-1000d).Clamp(-200d, 800d));
            Assert.AreEqual(400d, 400d.Clamp(-200d, 800d));
            Assert.AreEqual(800d, 900d.Clamp(-200d, 800d));
            Assert.AreEqual(double.NaN, double.NaN.Clamp(-200d, 800d));
            500d.Clamp(800d, -200d); // No exception
        }

        [TestMethod]
        public void Clamp_Decimal_Test() {
            Assert.AreEqual(-200m, (-1000m).Clamp(-200m, 800m));
            Assert.AreEqual(400m, 400m.Clamp(-200m, 800m));
            Assert.AreEqual(800m, 900m.Clamp(-200m, 800m));
            500m.Clamp(800m, -200m); // No exception
        }
    }
}
