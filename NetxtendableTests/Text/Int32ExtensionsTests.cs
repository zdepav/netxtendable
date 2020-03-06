using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Netxtendable.Text.Tests {

    [TestClass]
    public class Int32ExtensionsTests {

        [TestMethod]
        public void ToOrdinal_Test() {
            Assert.AreEqual("1st", 1.ToOrdinal());
            Assert.AreEqual("2nd", 2.ToOrdinal());
            Assert.AreEqual("3rd", 3.ToOrdinal());
            Assert.AreEqual("4th", 4.ToOrdinal());
            Assert.AreEqual("8th", 8.ToOrdinal());
            Assert.AreEqual("13th", 13.ToOrdinal());
            Assert.AreEqual("52nd", 52.ToOrdinal());
            Assert.AreEqual("111th", 111.ToOrdinal());
        }
        
        [TestMethod]
        public void ToWords_Test() {
            Assert.AreEqual("one", 1.ToWords());
            Assert.AreEqual("twenty-two", 22.ToWords());
            Assert.AreEqual("one hundred thirty-five", 135.ToWords());
            Assert.AreEqual("four thousand one", 4001.ToWords());
            Assert.AreEqual("eight million three thousand", 8003000.ToWords());
            Assert.AreEqual("fifty-two", 52.ToWords());
            Assert.AreEqual(
                "two billion one hundred thirty-five million nine " +
                "hundred fourty-six thousand seven hundred twenty-eight",
                2135946728.ToWords());
        }
        
        [TestMethod]
        public void ToWordsOrdinal_Test() {
            Assert.AreEqual("first", 1.ToWordsOrdinal());
            Assert.AreEqual("twenty-second", 22.ToWordsOrdinal());
            Assert.AreEqual("one hundred thirty-fifth", 135.ToWordsOrdinal());
            Assert.AreEqual("four thousand first", 4001.ToWordsOrdinal());
            Assert.AreEqual("eight million three thousandth", 8003000.ToWordsOrdinal());
            Assert.AreEqual("fifty-second", 52.ToWordsOrdinal());
            Assert.AreEqual(
                "two billion one hundred thirty-five million nine " +
                "hundred fourty-six thousand seven hundred twenty-eighth",
                2135946728.ToWordsOrdinal());
        }

    }

}
