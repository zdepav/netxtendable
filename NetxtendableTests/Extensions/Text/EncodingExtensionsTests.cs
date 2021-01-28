using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Netxtendable.Extensions.Text.Tests {

    [TestClass]
    public class EncodingExtensionsTests {

        [TestMethod]
        public void TryGetString_Test() {
            var bytes = Encoding.UTF8.GetBytes("Hello World!");
            Assert.IsTrue(Encoding.UTF8.TryGetString(bytes, out var str));
            Assert.AreEqual("Hello World!", str);
            Assert.IsFalse(Encoding.UTF8.TryGetString(null, out _));
            Assert.IsFalse(Encoding.UTF8.TryGetString(bytes, out _, -1));
            Assert.IsFalse(Encoding.UTF8.TryGetString(bytes, out _, 5, 100));
        }

        [TestMethod]
        public void TryGetChars_Test() {
            var bytes = Encoding.UTF8.GetBytes("Hello World!");
            Assert.IsTrue(Encoding.UTF8.TryGetChars(bytes, out var chars));
            CollectionAssert.AreEqual("Hello World!".ToCharArray(), chars);
            Assert.IsFalse(Encoding.UTF8.TryGetChars(null, out _));
            Assert.IsFalse(Encoding.UTF8.TryGetChars(bytes, out _, -1));
            Assert.IsFalse(Encoding.UTF8.TryGetChars(bytes, out _, 5, 100));
        }
    }
}
