using System;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Netxtendable.Extensions.Text.Tests {

    [TestClass]
    public class StringExtensionsTests {

        [TestMethod]
        public void Reverse_Test() {
            Assert.AreEqual("", "".Reverse());
            Assert.AreEqual("9876543210", "0123456789".Reverse());
            Assert.AreEqual("ZyXwVuTsRqPoNmLkJiHgFeDcBa", "aBcDeFgHiJkLmNoPqRsTuVwXyZ".Reverse());
        }

        [TestMethod]
        public void ToBase64_Test() {
            Assert.AreEqual("", "".ToBase64());
            Assert.AreEqual("SGVsbG8gV29ybGQh", "Hello World!".ToBase64());
            Assert.AreEqual(
                "AEgAZQBsAGwAbwAgAFcAbwByAGwAZAAgAG8AZgAgAGIAYQBzAGUANgA0ACE=",
                "Hello World of base64!".ToBase64(Encoding.BigEndianUnicode)
            );
            Assert.AreEqual(
                "dXNpbmcgU3lzdGVtLlRleHQuUmVndWxhckV4cHJlc3Npb25zOw==",
                "using System.Text.RegularExpressions;".ToBase64()
            );
            Assert.ThrowsException<ArgumentNullException>(
                () => (null as string).ToBase64()
            );
        }

        [TestMethod]
        public void FromBase64_Test() {
            Assert.AreEqual("", "".FromBase64());
            Assert.AreEqual("Hello World!", "SGVsbG8gV29ybGQh".FromBase64());
            Assert.AreEqual(
                "Hello World of base64!",
                "AEgAZQBsAGwAbwAgAFcAbwByAGwAZAAgAG8AZgAgAGIAYQBzAGUANgA0ACE="
                    .FromBase64(Encoding.BigEndianUnicode)
            );
            Assert.AreEqual(
                "using System.Text.RegularExpressions;",
                "dXNpbmcgU3lzdGVtLlRleHQuUmVndWxhckV4cHJlc3Npb25zOw==".FromBase64()
            );
            Assert.AreEqual(
                "using System.Text.RegularExpressions;",
                "dXNpbmcgU3lzdGVtLlRleHQuUmVndWxhckV4cHJlc3Npb25zOw".FromBase64()
            );
            Assert.ThrowsException<ArgumentNullException>(
                () => (null as string).FromBase64()
            );
            Assert.ThrowsException<FormatException>(
                () => "dXNpbmcgU3lz!GVtLlRleHQuUm?ndWxhckV4c$Jlc3Npb25zOw==".FromBase64()
            );
        }

        [TestMethod]
        public void ToByteArray_Test() {
            CollectionAssert.AreEqual(
                new byte[] { 72, 101, 108, 108, 111, 32, 87, 111, 114, 108, 100, 33 },
                "Hello World!".ToByteArray()
            );
            CollectionAssert.AreEqual(
                new byte[] {
                    72, 00, 101, 00, 108, 00, 108, 00, 111, 00, 32, 00,
                    87, 00, 111, 00, 114, 00, 108, 00, 100, 00, 33, 00
                },
                "Hello World!".ToByteArray(Encoding.Unicode)
            );
            Assert.ThrowsException<ArgumentNullException>(
                () => (null as string).ToByteArray()
            );
        }

        [TestMethod]
        public void IsAscii_Test() {
            Assert.IsTrue("".IsAscii());
            Assert.IsTrue("\x02Hello World!\n\x03".IsAscii());
            Assert.IsFalse("Unicode is awesome \u2764\ufe0f.".IsAscii());
            Assert.ThrowsException<ArgumentNullException>(
                () => (null as string).IsAscii()
            );
        }

        [TestMethod]
        public void Match_Test1() {
            var regex = new Regex(@"\d{4}");
            Assert.AreEqual("6854", "s68d4gs6854sdd4s68gesd54".Match(regex).Value);
            Assert.IsFalse("s68d4gs68h54sdd4s68gesd54".Match(regex).Success);
        }

        [TestMethod]
        public void Match_Test2() {
            Assert.AreEqual("6854", "s68d4gs6854sdd4s68gesd54".Match(@"\d{4}").Value);
            Assert.IsFalse("s68d4gs68h54sdd4s68gesd54".Match(@"\d{4}").Success);
        }

        [TestMethod]
        public void Matches_Test1() {
            var regex = new Regex(@"\b0x[0-9a-f]+\b", RegexOptions.IgnoreCase);
            CollectionAssert.AreEqual(
                new[] { "0x03", "0xf6", "0xe4", "0x8a" },
                "gsd9 0h84 0x03 OX27 0xf6 6481 0xe4 085o 0x8a"
                    .Matches(regex)
                    .Select(m => m.Value)
                    .ToArray()
            );
        }

        [TestMethod]
        public void Matches_Test2() {
            CollectionAssert.AreEqual(
                new[] { "0x03", "0xf6", "0xe4", "0x8a" },
                "gsd9 0h84 0x03 OX27 0xf6 6481 0xe4 085o 0x8a"
                    .Matches(@"\b0x[0-9a-fA-F]+\b")
                    .Select(m => m.Value)
                    .ToArray()
            );
        }

        [TestMethod]
        public void Replace_Test1() {
            var regex = new Regex(@"\d{2}");
            Assert.AreEqual(
                "s?d?gs??sdd?s?gesd?",
                "s68d84gs6854sdd74s68gesd54".Replace(regex, "?")
            );
        }

        [TestMethod]
        public void Replace_Test2() {
            var regex = new Regex(@"\d{2}");
            Assert.AreEqual(
                "sDdTgsD6sddJsDgesd6",
                "s68d84gs6854sdd74s68gesd54"
                    .Replace(regex, m => ((char)int.Parse(m.Value)).ToString())
            );
        }

        [TestMethod]
        public void Replace_Test3() {
            Assert.AreEqual(
                "Hello\r\nWorld!\r\nThis\r\nis\r\nAwesome!",
                "Hello\nWorld!\nThis\nis\nAwesome!".Replace('\n', "\r\n")
            );
            Assert.AreEqual("", "".Replace('\n', "\r\n"));
            Assert.ThrowsException<ArgumentNullException>(
                () => (null as string).Replace('\n', "\r\n")
            );
        }

        [TestMethod]
        public void Replace_Test4() {
            var chars = new[] { '\n', '\r' };
            Assert.AreEqual(
                "Hello##World!#This#is#Awesome!",
                "Hello\r\nWorld!\nThis\ris\nAwesome!".Replace(chars, "#")
            );
            Assert.AreEqual(
                "HelloWorld!ThisisAwesome!",
                "Hello\r\nWorld!\nThis\ris\nAwesome!".Replace(chars, null as string)
            );
            Assert.AreEqual("", "".Replace(chars, "123"));
            Assert.AreEqual("Hello World!", "Hello World!".Replace(Array.Empty<char>(), "123"));
            Assert.ThrowsException<ArgumentNullException>(
                () => (null as string).Replace(chars, "")
            );
            Assert.ThrowsException<ArgumentNullException>(
                () => "".Replace(null as char[], "")
            );
        }

        [TestMethod]
        public void Replace_Test5() {
            static string Evaluator(char c) => $"\\{c}";
            var chars = new[] { '[', ']', '{', '}', '(', ')', '\\' };
            Assert.AreEqual(
                @"\\b#\(\[0-9a-fA-F\]\{6\}\)\\b",
                @"\b#([0-9a-fA-F]{6})\b".Replace(chars, Evaluator)
            );
            Assert.AreEqual("", "".Replace(chars, Evaluator));
            Assert.AreEqual(
                @"\b#([0-9a-fA-F]{6})\b",
                @"\b#([0-9a-fA-F]{6})\b".Replace(Array.Empty<char>(), Evaluator)
            );
            Assert.AreEqual(
                "b#0-9a-fA-F6b",
                @"\b#([0-9a-fA-F]{6})\b".Replace(chars, _ => null)
            );
            Assert.ThrowsException<ArgumentNullException>(
                () => (null as string).Replace(chars, Evaluator)
            );
            Assert.ThrowsException<ArgumentNullException>(
                () => "".Replace(null as char[], Evaluator)
            );
            Assert.ThrowsException<ArgumentNullException>(
                () => "".Replace(chars, null as Func<char, string>)
            );
        }

        [TestMethod]
        public void RegexReplace_Test1() {
            Assert.AreEqual(
                "s?d?gs??sdd?s?gesd?",
                "s68d84gs6854sdd74s68gesd54".RegexReplace(@"\d{2}", "?")
            );
        }

        [TestMethod]
        public void RegexReplace_Test2() {
            Assert.AreEqual(
                "sDdTgsD6sddJsDgesd6",
                "s68d84gs6854sdd74s68gesd54"
                    .RegexReplace(@"\d{2}", m => ((char)int.Parse(m.Value)).ToString())
            );
        }

        [TestMethod]
        public void Split_Test() {
            var regex = new Regex(@"(?=<)|(?<=>)", RegexOptions.Compiled);
            var output = new[] {
                "&gt; ", "<b>", "Hello", "</b>", " world of ", "<i>",
                "<b>", "regexes", "</b>", "!", "</i>", " :)"
            };
            CollectionAssert.AreEqual(
                output,
                "&gt; <b>Hello</b> world of <i><b>regexes</b>!</i> :)"
                    .Split(regex)
                    .ToArray()
            );
        }

        [TestMethod]
        public void RegexSplit_Test() {
            var pattern = @"(?=<)|(?<=>)";
            var output = new[] {
                "&gt; ", "<b>", "Hello", "</b>", " world of ", "<i>",
                "<b>", "regexes", "</b>", "!", "</i>", " :)"
            };
            CollectionAssert.AreEqual(
                output,
                "&gt; <b>Hello</b> world of <i><b>regexes</b>!</i> :)"
                    .RegexSplit(pattern)
                    .ToArray()
            );
        }

        [TestMethod]
        public void GetMatched_Test1() {
            var regex = new Regex(@"\b0x[0-9a-f]+\b", RegexOptions.IgnoreCase);
            Assert.IsNull("ezan ebz0 06ba re1b z6re".GetMatched(regex));
            Assert.AreEqual("0xba", "ezan ebz0 0xba re1b z6re".GetMatched(regex));
            Assert.AreEqual("0x00", "ezan ebz0 06ba re1b z6re".GetMatched(regex, "0x00"));
        }

        [TestMethod]
        public void GetMatched_Test2() {
            var pattern = @"\b0x[0-9a-fA-F]+\b";
            Assert.IsNull("ezan ebz0 06ba re1b z6re".GetMatched(pattern));
            Assert.AreEqual("0xba", "ezan ebz0 0xba re1b z6re".GetMatched(pattern));
            Assert.AreEqual("0x00", "ezan ebz0 06ba re1b z6re".GetMatched(pattern, "0x00"));
        }

        [TestMethod]
        public void GetMatchedGroup_Test1() {
            var regex = new Regex(@"\b0x([0-9a-f]+)\b", RegexOptions.IgnoreCase);
            Assert.IsNull("ezan ebz0 06ba re1b z6re".GetMatchedGroup(regex, 1));
            Assert.AreEqual("ba", "ezan ebz0 0xba re1b z6re".GetMatchedGroup(regex, 1));
            Assert.AreEqual("00", "ezan ebz0 06ba re1b z6re".GetMatchedGroup(regex, 1, "00"));
        }

        [TestMethod]
        public void GetMatchedGroup_Test2() {
            var pattern = @"\b0x([0-9a-fA-F]+)\b";
            Assert.IsNull("ezan ebz0 06ba re1b z6re".GetMatchedGroup(pattern, 1));
            Assert.AreEqual("ba", "ezan ebz0 0xba re1b z6re".GetMatchedGroup(pattern, 1));
            Assert.AreEqual("00", "ezan ebz0 06ba re1b z6re".GetMatchedGroup(pattern, 1, "00"));
        }

        [TestMethod]
        public void GetMatchedGroup_Test3() {
            var regex = new Regex(@"\b0x(?'value'[0-9a-f]+)\b", RegexOptions.IgnoreCase);
            Assert.IsNull("ezan ebz0 06ba re1b z6re".GetMatchedGroup(regex, "value"));
            Assert.AreEqual("ba", "ezan ebz0 0xba re1b z6re".GetMatchedGroup(regex, "value"));
            Assert.AreEqual(
                "00",
                "ezan ebz0 06ba re1b z6re".GetMatchedGroup(regex, "value", "00")
            );
        }

        [TestMethod]
        public void GetMatchedGroup_Test4() {
            var pattern = @"\b0x(?'value'[0-9a-fA-F]+)\b";
            Assert.IsNull("ezan ebz0 06ba re1b z6re".GetMatchedGroup(pattern, "value"));
            Assert.AreEqual("ba", "ezan ebz0 0xba re1b z6re".GetMatchedGroup(pattern, "value"));
            Assert.AreEqual(
                "00",
                "ezan ebz0 06ba re1b z6re".GetMatchedGroup(pattern, "value", "00")
            );
        }

        [TestMethod]
        public void IsMatch_Test1() {
            var regex = new Regex(@"\b0x[0-9a-f]+\b", RegexOptions.IgnoreCase);
            Assert.IsFalse("ezan ebz0 06ba re1b z6re".IsMatch(regex));
            Assert.IsTrue("ezan ebz0 0xba re1b z6re".IsMatch(regex));
        }

        [TestMethod]
        public void IsMatch_Test2() {
            var pattern = @"\b0x[0-9a-fA-F]+\b";
            Assert.IsFalse("ezan ebz0 06ba re1b z6re".IsMatch(pattern));
            Assert.IsTrue("ezan ebz0 0xba re1b z6re".IsMatch(pattern));
        }

        [TestMethod]
        public void RegexEscape_Test() {
            Assert.AreEqual(
                @"0x\(\?'value'\[0-9a-fA-F]\+\)",
                "0x(?'value'[0-9a-fA-F]+)".RegexEscape()
            );
        }

        [TestMethod]
        public void XmlEscape_Test() {
            Assert.AreEqual("", "".XmlEscape());
            Assert.AreEqual(
                "&lt;a href=&quot;test&quot;&gt;it&apos;s great &amp; easy&lt;/a&gt;",
                "<a href=\"test\">it's great & easy</a>".XmlEscape()
            );
        }

        [TestMethod]
        public void UnifyLineEndingsToCr_Test() {
            Assert.AreEqual("", "".UnifyLineEndingsToCr());
            Assert.AreEqual(
                " Hello\r\rworld\r of lines\r\r\r!\r",
                " Hello\u2028\r\nworld\r of lines\r\u2028\n!\n".UnifyLineEndingsToCr()
            );
        }

        [TestMethod]
        public void UnifyLineEndingsToLf_Test() {
            Assert.AreEqual("", "".UnifyLineEndingsToLf());
            Assert.AreEqual(
                " Hello\n\nworld\n of lines\n\n\n!\n",
                " Hello\u2028\r\nworld\r of lines\r\u2028\n!\n".UnifyLineEndingsToLf()
            );
        }

        [TestMethod]
        public void UnifyLineEndingsToCrLf_Test() {
            Assert.AreEqual("", "".UnifyLineEndingsToCrLf());
            Assert.AreEqual(
                " Hello\r\n\r\nworld\r\n of lines\r\n\r\n\r\n!\r\n",
                " Hello\u2028\r\nworld\r of lines\r\u2028\n!\n".UnifyLineEndingsToCrLf()
            );
        }

        [TestMethod]
        public void UnifyLineEndingsToLs_Test() {
            Assert.AreEqual("", "".UnifyLineEndingsToLs());
            Assert.AreEqual(
                " Hello\u2028\u2028world\u2028 of lines\u2028\u2028\u2028!\u2028",
                " Hello\u2028\r\nworld\r of lines\r\u2028\n!\n".UnifyLineEndingsToLs()
            );
        }

        [TestMethod]
        public void LazySplit_Test1() {
            var input = "field1, field1;  field2.;;FiElD4;";
            CollectionAssert.AreEqual(
                new[] { "field1, field1", "  field2.", "", "FiElD4", "" },
                input.LazySplit(';').ToArray()
            );
            CollectionAssert.AreEqual(
                new[] { "field1, field1", "  field2.", "FiElD4" },
                input.LazySplit(';', false).ToArray()
            );
            input = "field1, field1;  field2.;;FiElD4";
            CollectionAssert.AreEqual(
                new[] { "field1, field1", "  field2.", "", "FiElD4" },
                input.LazySplit(';').ToArray()
            );
            Assert.ThrowsException<ArgumentNullException>(
                () => (null as string).LazySplit(';', false)
                                      .GetEnumerator()
                                      .MoveNext()
            );
        }

        [TestMethod]
        public void LazySplit_Test2() {
            var input = "field1, field1;  field2.:;FiElD4:";
            var delimiters = new[] { ':', ';' };
            CollectionAssert.AreEqual(
                new[] { "field1, field1", "  field2.", "", "FiElD4", "" },
                input.LazySplit(delimiters).ToArray()
            );
            CollectionAssert.AreEqual(
                new[] { "field1, field1", "  field2.", "FiElD4" },
                input.LazySplit(delimiters, false).ToArray()
            );
            input = "field1, field1;  field2.:;FiElD4";
            CollectionAssert.AreEqual(
                new[] { "field1, field1", "  field2.", "", "FiElD4" },
                input.LazySplit(delimiters).ToArray()
            );
            Assert.ThrowsException<ArgumentNullException>(
                () => (null as string).LazySplit(delimiters, false)
                                      .GetEnumerator()
                                      .MoveNext()
            );
            Assert.ThrowsException<ArgumentNullException>(
                () => "".LazySplit(null as char[], false)
                        .GetEnumerator()
                        .MoveNext()
            );
        }

        [TestMethod]
        public void LazySplit_Test3() {
            var input = "field1, field1;   field2.; ; FiElD4; ";
            CollectionAssert.AreEqual(
                new[] { "field1, field1", "  field2.", "", "FiElD4", "" },
                input.LazySplit("; ").ToArray()
            );
            CollectionAssert.AreEqual(
                new[] { "field1, field1", "  field2.", "FiElD4" },
                input.LazySplit("; ", false).ToArray()
            );
            input = "field1, field1;   field2.; ; FiElD4";
            CollectionAssert.AreEqual(
                new[] { "field1, field1", "  field2.", "", "FiElD4" },
                input.LazySplit("; ").ToArray()
            );
            Assert.ThrowsException<ArgumentNullException>(
                () => (null as string).LazySplit("; ", false)
                                      .GetEnumerator()
                                      .MoveNext()
            );
            Assert.ThrowsException<ArgumentNullException>(
                () => "".LazySplit(null as string, false)
                        .GetEnumerator()
                        .MoveNext()
            );
            Assert.ThrowsException<ArgumentException>(
                () => "".LazySplit("", false)
                        .GetEnumerator()
                        .MoveNext()
            );
        }

        [TestMethod]
        public void EnumerateLines_Test() {
            var input1 = " Hello\u2028\r\nworld\r of lines\n\n!\n";
            CollectionAssert.AreEqual(
                new[] { " Hello", "", "world", " of lines", "", "!" },
                input1.EnumerateLines().ToArray()
            );
            CollectionAssert.AreEqual(
                new[] { " Hello", "world", " of lines", "!" },
                input1.EnumerateLines(false).ToArray()
            );
            CollectionAssert.AreEqual(
                new[] { "", "1", "2" },
                "\n1\n2".EnumerateLines().ToArray()
            );
            Assert.ThrowsException<ArgumentNullException>(
                () => (null as string).EnumerateLines()
                                      .GetEnumerator()
                                      .MoveNext()
            );
        }

        [TestMethod]
        public void SplitLines_Test() {
            var input1 = " Hello\u2028\r\nworld\r of lines\n\n!\n";
            CollectionAssert.AreEqual(
                new[] { " Hello", "", "world", " of lines", "", "!" },
                input1.SplitLines()
            );
            CollectionAssert.AreEqual(
                new[] { " Hello", "world", " of lines", "!" },
                input1.SplitLines(false)
            );
            CollectionAssert.AreEqual(
                new[] { "", "1", "2" },
                "\n1\n2".SplitLines()
            );
            Assert.ThrowsException<ArgumentNullException>(
                () => (null as string).SplitLines()
            );
        }

        [TestMethod]
        public void ExpandHtmlEntities_Test() {
            Assert.AreEqual(
                "<a href=\"test\">it's great & easy</a>",
                "&lt;a href=&quot;test&quot;&gt;it&apos;s great &amp; easy&lt;/a&gt;"
                    .ExpandHtmlEntities()
            );
        }

        [TestMethod]
        public void CollapseWhitespace_Test() {
            Assert.AreEqual(
                "Hello World of whitespace !",
                "   Hello   \n World \r\t of\nwhitespace \r\n!\t".CollapseWhitespace()
            );
            Assert.AreEqual(null, (null as string).CollapseWhitespace());
        }

        [TestMethod]
        public void Repeat_Test() {
            Assert.AreEqual("", "Hello".Repeat(0));
            Assert.AreEqual("Hello", "Hello".Repeat(1));
            Assert.AreEqual("HelloHelloHello", "Hello".Repeat(3));
            Assert.AreEqual("AAAAAAAAAAAAAAAAAAAA", "A".Repeat(20));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => "Hello".Repeat(-3));
            Assert.ThrowsException<ArgumentNullException>(() => (null as string).Repeat(2));
        }

        [TestMethod]
        public void ParseSByte_Test() {
            Assert.AreEqual((sbyte)15, "15".ParseSByte());
            Assert.AreEqual((sbyte)-3, "-3".ParseSByte());
            Assert.ThrowsException<FormatException>(() => "Z5".ParseSByte());
        }

        [TestMethod]
        public void ParseByte_Test() {
            Assert.AreEqual((byte)15, "15".ParseByte());
            Assert.ThrowsException<OverflowException>(() => "-3".ParseByte());
            Assert.ThrowsException<FormatException>(() => "Z5".ParseByte());
        }

        [TestMethod]
        public void ParseInt16_Test() {
            Assert.AreEqual((short)15, "15".ParseInt16());
            Assert.AreEqual((short)-3, "-3".ParseInt16());
            Assert.ThrowsException<FormatException>(() => "Z5".ParseInt16());
        }

        [TestMethod]
        public void ParseUInt16_Test() {
            Assert.AreEqual((ushort)15, "15".ParseUInt16());
            Assert.ThrowsException<OverflowException>(() => "-3".ParseUInt16());
            Assert.ThrowsException<FormatException>(() => "Z5".ParseUInt16());
        }

        [TestMethod]
        public void ParseInt_Test() {
            Assert.AreEqual(15, "15".ParseInt());
            Assert.AreEqual(-3, "-3".ParseInt());
            Assert.ThrowsException<FormatException>(() => "Z5".ParseInt());
        }

        [TestMethod]
        public void ParseUInt32_Test() {
            Assert.AreEqual(15U, "15".ParseUInt32());
            Assert.ThrowsException<OverflowException>(() => "-3".ParseUInt32());
            Assert.ThrowsException<FormatException>(() => "Z5".ParseUInt32());
        }

        [TestMethod]
        public void ParseInt64_Test() {
            Assert.AreEqual(15L, "15".ParseInt64());
            Assert.AreEqual(-3L, "-3".ParseInt64());
            Assert.ThrowsException<FormatException>(() => "Z5".ParseInt64());
        }

        [TestMethod]
        public void ParseUInt64_Test() {
            Assert.AreEqual(15UL, "15".ParseUInt64());
            Assert.ThrowsException<OverflowException>(() => "-3".ParseUInt64());
            Assert.ThrowsException<FormatException>(() => "Z5".ParseUInt64());
        }

        [TestMethod]
        public void ParseSingle_Test() {
            Assert.AreEqual(15f, "15".ParseSingle());
            Assert.AreEqual(-25f, "-0.25e2".ParseSingle());
            Assert.ThrowsException<FormatException>(() => "Z5".ParseSingle());
        }

        [TestMethod]
        public void ParseDouble_Test() {
            Assert.AreEqual(15d, "15".ParseDouble());
            Assert.AreEqual(-25d, "-0.25e2".ParseDouble());
            Assert.ThrowsException<FormatException>(() => "Z5".ParseDouble());
        }

        [TestMethod]
        public void ParseDecimal_Test() {
            Assert.AreEqual(15m, "15".ParseDecimal());
            Assert.AreEqual(-25m, "-0.25e2".ParseDecimal());
            Assert.ThrowsException<FormatException>(() => "Z5".ParseDecimal());
        }

        [TestMethod]
        public void ParseSByteOrDefault_Test() {
            Assert.AreEqual((sbyte)15, "15".ParseSByteOrDefault());
            Assert.AreEqual((sbyte)-3, "-3".ParseSByteOrDefault());
            Assert.AreEqual((sbyte)15, "Z5".ParseSByteOrDefault(15));
        }

        [TestMethod]
        public void ParseByteOrDefault_Test() {
            Assert.AreEqual((byte)15, "15".ParseByteOrDefault());
            Assert.AreEqual((byte)15, "-3".ParseByteOrDefault(15));
            Assert.AreEqual((byte)15, "Z5".ParseByteOrDefault(15));
        }

        [TestMethod]
        public void ParseInt16OrDefault_Test() {
            Assert.AreEqual((short)15, "15".ParseInt16OrDefault());
            Assert.AreEqual((short)-3, "-3".ParseInt16OrDefault());
            Assert.AreEqual((short)15, "Z5".ParseInt16OrDefault(15));
        }

        [TestMethod]
        public void ParseUInt16OrDefault_Test() {
            Assert.AreEqual((ushort)15, "15".ParseUInt16OrDefault());
            Assert.AreEqual((ushort)15, "-3".ParseUInt16OrDefault(15));
            Assert.AreEqual((ushort)15, "Z5".ParseUInt16OrDefault(15));
        }

        [TestMethod]
        public void ParseIntOrDefault_Test() {
            Assert.AreEqual(15, "15".ParseIntOrDefault());
            Assert.AreEqual(-3, "-3".ParseIntOrDefault());
            Assert.AreEqual(15, "Z5".ParseIntOrDefault(15));
        }

        [TestMethod]
        public void ParseUInt32OrDefault_Test() {
            Assert.AreEqual(15U, "15".ParseUInt32OrDefault());
            Assert.AreEqual(15U, "-3".ParseUInt32OrDefault(15U));
            Assert.AreEqual(15U, "Z5".ParseUInt32OrDefault(15U));
        }

        [TestMethod]
        public void ParseInt64OrDefault_Test() {
            Assert.AreEqual(15L, "15".ParseInt64OrDefault());
            Assert.AreEqual(-3L, "-3".ParseInt64OrDefault());
            Assert.AreEqual(15L, "Z5".ParseInt64OrDefault(15L));
        }

        [TestMethod]
        public void ParseUInt64OrDefault_Test() {
            Assert.AreEqual(15UL, "15".ParseUInt64OrDefault());
            Assert.AreEqual(15UL, "-3".ParseUInt64OrDefault(15UL));
            Assert.AreEqual(15UL, "Z5".ParseUInt64OrDefault(15UL));
        }

        [TestMethod]
        public void ParseSingleOrDefault_Test() {
            Assert.AreEqual(15f, "15".ParseSingleOrDefault());
            Assert.AreEqual(-25f, "-0.25e2".ParseSingleOrDefault());
            Assert.AreEqual(15f, "Z5".ParseSingleOrDefault(15f));
            var defaultCulture = NetxtendableConfig.DefaultCulture;
            NetxtendableConfig.DefaultCulture = CultureInfo.GetCultureInfo("cs-CZ");
            Assert.AreEqual(4f, "15.3".ParseSingleOrDefault(4f));
            Assert.AreEqual(15.3f, "15,3".ParseSingleOrDefault());
            NetxtendableConfig.DefaultCulture = defaultCulture;
        }

        [TestMethod]
        public void ParseDoubleOrDefault_Test() {
            Assert.AreEqual(15d, "15".ParseDoubleOrDefault());
            Assert.AreEqual(-25d, "-0.25e2".ParseDoubleOrDefault());
            Assert.AreEqual(15d, "Z5".ParseDoubleOrDefault(15.0));
            var defaultCulture = NetxtendableConfig.DefaultCulture;
            NetxtendableConfig.DefaultCulture = CultureInfo.GetCultureInfo("cs-CZ");
            Assert.AreEqual(4d, "15.3".ParseDoubleOrDefault(4d));
            Assert.AreEqual(15.3d, "15,3".ParseDoubleOrDefault());
            NetxtendableConfig.DefaultCulture = defaultCulture;
        }

        [TestMethod]
        public void ParseDecimalOrDefault_Test() {
            Assert.AreEqual(15m, "15".ParseDecimalOrDefault());
            Assert.AreEqual(-25m, "-0.25e2".ParseDecimalOrDefault());
            Assert.AreEqual(15m, "Z5".ParseDecimalOrDefault(15m));
            var defaultCulture = NetxtendableConfig.DefaultCulture;
            NetxtendableConfig.DefaultCulture = CultureInfo.GetCultureInfo("cs-CZ");
            Assert.AreEqual(4m, "15.3".ParseDecimalOrDefault(4m));
            Assert.AreEqual(15.3m, "15,3".ParseDecimalOrDefault());
            NetxtendableConfig.DefaultCulture = defaultCulture;
        }
    }
}
