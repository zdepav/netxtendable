using System;
using System.IO;
using System.Linq;

namespace NetxtendableCodeGen {

    internal static class Program {

        private static readonly string
            targetDirectory = "../../../../Netxtendable",
            targetTestsDirectory = "../../../../NetxtendableTests";

        private static string Nth(int i) =>
            i switch {
                0 => "0",
                1 => "1st",
                2 => "2nd",
                3 => "3rd",
                _ => $"{i}th"
            };

        private static readonly string[] longNth = { "zeroth", "first", "second", "third", "fourth", "fifth", "sixth", "seventh", "eighth", "ninth" };
        
        private static readonly string[] longNthCapitalized = { "Zeroth", "First", "Second", "Third", "Fourth", "Fifth", "Sixth", "Seventh", "Eighth", "Ninth" };

        private static string NthLong(int i) =>
            Math.Abs(i) >= 10
                ? Nth(i)
                : i < 0 ? "-" + longNth[-i] : longNth[i];

        private static string NthLongCapitalized(int i) =>
            Math.Abs(i) >= 10
                ? Nth(i)
                : i < 0 ? "-" + longNthCapitalized[-i] : longNthCapitalized[i];

        private static void GenereateTupleToCollectionMethods(StreamWriter sw, bool valueTuple) {
            var type = valueTuple ? "ValueTuple" : "Tuple";
            for (var n = 2; n < 8; ++n) {
                sw.WriteLine("        /// <summary>Creates an array using items from <paramref name=\"t\"/>.</summary>");
                sw.WriteLine("        /// <typeparam name=\"T\">Type of items in <paramref name=\"t\"/>.</typeparam>");
                sw.WriteLine("        /// <param name=\"t\">Tuple whose items will be inserted into the array.</param>");
                sw.WriteLine("        /// <returns>");
                sw.WriteLine($"        /// Array of size {n} whose elements are items of <paramref name=\"t\"/>.");
                sw.WriteLine("        /// </returns>");
                if (!valueTuple) {
                    sw.WriteLine("        /// <exception cref=\"ArgumentNullException\">");
                    sw.WriteLine("        /// Thrown when <paramref name=\"t\"/> is null.");
                    sw.WriteLine("        /// </exception>");
                }
                sw.WriteLine($"        public static T[] ToArray<T>(this {type}<{string.Join(", ", Enumerable.Repeat('T', n))}> t) =>");
                if (!valueTuple) {
                    sw.WriteLine("            t is null");
                    sw.WriteLine("                ? throw new ArgumentNullException(nameof(t))");
                    sw.WriteLine($"                : new[] {{ {string.Join(", ", Enumerable.Range(1, n).Select(i => $"t.Item{i}"))} }};");
                } else {
                    sw.WriteLine($"            new[] {{ {string.Join(", ", Enumerable.Range(1, n).Select(i => $"t.Item{i}"))} }};");
                }
                sw.WriteLine();
            }
            for (var n = 2; n < 8; ++n) {
                sw.WriteLine("        /// <summary>Creates a list using items from <paramref name=\"t\"/>.</summary>");
                sw.WriteLine("        /// <typeparam name=\"T\">Type of items in <paramref name=\"t\"/>.</typeparam>");
                sw.WriteLine("        /// <param name=\"t\">Tuple whose items will be inserted into the list.</param>");
                sw.WriteLine("        /// <returns>");
                sw.WriteLine($"        /// <see cref=\"List{{T}}\"/> of size {n} whose elements are items of <paramref name=\"t\"/>.");
                sw.WriteLine("        /// </returns>");
                if (!valueTuple) {
                    sw.WriteLine("        /// <exception cref=\"ArgumentNullException\">");
                    sw.WriteLine("        /// Thrown when <paramref name=\"t\"/> is null.");
                    sw.WriteLine("        /// </exception>");
                }
                sw.WriteLine($"        public static List<T> ToList<T>(this {type}<{string.Join(", ", Enumerable.Repeat('T', n))}> t) =>");
                if (!valueTuple) {
                    sw.WriteLine("            t is null");
                    sw.WriteLine("                ? throw new ArgumentNullException(nameof(t))");
                    sw.WriteLine($"                : new List<T>({n}) {{ {string.Join(", ", Enumerable.Range(1, n).Select(i => $"t.Item{i}"))} }};");
                } else {
                    sw.WriteLine($"            new List<T>({n}) {{ {string.Join(", ", Enumerable.Range(1, n).Select(i => $"t.Item{i}"))} }};");
                }
                sw.WriteLine();
            }
            for (var n = 2; n < 8; ++n) {
                sw.WriteLine("        /// <summary>Creates a set using items from <paramref name=\"t\"/>.</summary>");
                sw.WriteLine("        /// <typeparam name=\"T\">Type of items in <paramref name=\"t\"/>.</typeparam>");
                sw.WriteLine("        /// <param name=\"t\">Tuple whose items will be inserted into the set.</param>");
                sw.WriteLine("        /// <returns>");
                sw.WriteLine($"        /// <see cref=\"HashSet{{T}}\"/> of size {n} whose elements are items of <paramref name=\"t\"/>.");
                sw.WriteLine("        /// </returns>");
                if (!valueTuple) {
                    sw.WriteLine("        /// <exception cref=\"ArgumentNullException\">");
                    sw.WriteLine("        /// Thrown when <paramref name=\"t\"/> is null.");
                    sw.WriteLine("        /// </exception>");
                }
                sw.WriteLine($"        public static HashSet<T> ToSet<T>(this {type}<{string.Join(", ", Enumerable.Repeat('T', n))}> t) =>");
                if (!valueTuple) {
                    sw.WriteLine("            t is null");
                    sw.WriteLine("                ? throw new ArgumentNullException(nameof(t))");
                    sw.WriteLine($"                : new HashSet<T>({n}) {{ {string.Join(", ", Enumerable.Range(1, n).Select(i => $"t.Item{i}"))} }};");
                } else {
                    sw.WriteLine($"            new HashSet<T>({n}) {{ {string.Join(", ", Enumerable.Range(1, n).Select(i => $"t.Item{i}"))} }};");
                }
                sw.WriteLine();
            }
            for (var n = 2; n < 8; ++n) {
                sw.WriteLine("        /// <summary>Creates a dictionary using items from <paramref name=\"t\"/>.</summary>");
                sw.WriteLine("        /// <typeparam name=\"K\">Type of keys in key-value pairs in <paramref name=\"t\"/>.</typeparam>");
                sw.WriteLine("        /// <typeparam name=\"V\">");
                sw.WriteLine("        /// Type of values in key-value pairs in <paramref name=\"t\"/>.");
                sw.WriteLine("        /// </typeparam>");
                sw.WriteLine("        /// <param name=\"t\">");
                sw.WriteLine("        /// Tuple with key-value pairs that will be inserted into the dictionary.");
                sw.WriteLine("        /// </param>");
                sw.WriteLine("        /// <returns>");
                sw.WriteLine($"        /// <see cref=\"Dictionary{{K,V}}\"/> of size {n} whose elements are items of <paramref name=\"t\"/>.");
                sw.WriteLine("        /// </returns>");
                if (!valueTuple) {
                    sw.WriteLine("        /// <exception cref=\"ArgumentNullException\">");
                    sw.WriteLine("        /// Thrown when <paramref name=\"t\"/> is null.");
                    sw.WriteLine("        /// </exception>");
                }
                sw.WriteLine("        public static Dictionary<K, V> ToDictionary<K, V>(");
                sw.WriteLine($"            this {type}<{string.Join(", ", Enumerable.Repeat("(K, V)", n))}> t");
                sw.WriteLine("        ) where K : notnull {");
                if (!valueTuple) {
                    sw.WriteLine("            if (t is null) {");
                    sw.WriteLine("                throw new ArgumentNullException(nameof(t));");
                    sw.WriteLine("            }");
                }
                sw.WriteLine($"            return new Dictionary<K, V>({n}) {{");
                for (var i = 1; i <= n; ++i) {
                    sw.WriteLine($"                {{ t.Item{i}.Item1, t.Item{i}.Item2 }}{(i < n ? "," : "")}");
                }
                sw.WriteLine("            };");
                sw.WriteLine("        }");
                sw.WriteLine();
            }
            for (var n = 2; n < 8; ++n) {
                sw.WriteLine("        /// <summary>Enumerates items in <paramref name=\"t\"/>.</summary>");
                sw.WriteLine("        /// <typeparam name=\"T\">Type of items in <paramref name=\"t\"/>.</typeparam>");
                sw.WriteLine("        /// <param name=\"t\">Tuple whose items will be enumerated.</param>");
                sw.WriteLine("        /// <returns>");
                sw.WriteLine("        /// <see cref=\"IEnumerable{T}\"/> with items of <paramref name=\"t\"/>.");
                sw.WriteLine("        /// </returns>");
                if (!valueTuple) {
                    sw.WriteLine("        /// <exception cref=\"ArgumentNullException\">");
                    sw.WriteLine("        /// Thrown when <paramref name=\"t\"/> is null.");
                    sw.WriteLine("        /// </exception>");
                }
                sw.WriteLine($"        public static IEnumerable<T> Enumerate<T>(this {type}<{string.Join(", ", Enumerable.Repeat('T', n))}> t) {{");
                if (!valueTuple) {
                    sw.WriteLine("            if (t is null) {");
                    sw.WriteLine("                throw new ArgumentNullException(nameof(t));");
                    sw.WriteLine("            }");
                }
                for (var i = 1; i <= n; ++i) {
                    sw.WriteLine($"            yield return t.Item{i};");
                }
                sw.WriteLine("        }");
                sw.WriteLine();
            }
        }
        
        private static void GenereateIListExtensionsClass() {
            using var sw = new StreamWriter(Path.Combine(targetDirectory, "Collections", "IListExtensions.cs"));
            sw.WriteLine("using System;");
            sw.WriteLine("using System.Collections.Generic;");
            sw.WriteLine();
            sw.WriteLine("// GENERATED CODE - DO NOT MODIFY");
            sw.WriteLine();
            sw.WriteLine("namespace Netxtendable.Collections {");
            sw.WriteLine();
            sw.WriteLine("    /// <summary>Class with extension methods for <see cref=\"IList{T}\"/></summary>");
            sw.WriteLine("    public static class IListExtensions {");
            sw.WriteLine();
            for (var n = 2; n < 8; ++n) {
                sw.WriteLine($"        /// <summary>Extracts first {n} values from <paramref name=\"list\"/>.</summary>");
                sw.WriteLine("        /// <typeparam name=\"T\">Type of items in <paramref name=\"list\"/>.</typeparam>");
                sw.WriteLine("        /// <param name=\"list\">List to deconstruct.</param>");
                for (var i = 1; i <= n; ++i) {
                    sw.WriteLine($"        /// <param name=\"item{i}\">{NthLongCapitalized(i)} output item.</param>");
                }
                sw.WriteLine("        /// <exception cref=\"ArgumentNullException\">");
                sw.WriteLine("        /// Thrown when <paramref name=\"list\"/> is null.");
                sw.WriteLine("        /// </exception>");
                sw.WriteLine("        /// <exception cref=\"InvalidOperationException\">");
                sw.WriteLine("        /// Thrown when <paramref name=\"list\"/> does not have enought items.");
                sw.WriteLine("        /// </exception>");
                sw.WriteLine("        public static void Deconstruct<T>(");
                sw.WriteLine("            this IList<T> list,");
                for (var i = 1; i <= n; ++i) {
                    sw.WriteLine($"            out T item{i}{(i < n ? "," : "")}");
                }
                sw.WriteLine("        ) {");
                sw.WriteLine("            if (list is null) {");
                sw.WriteLine("                throw new ArgumentNullException(nameof(list));");
                sw.WriteLine($"            }} else if (list.Count < {n}) {{");
                sw.WriteLine("                throw new InvalidOperationException(");
                sw.WriteLine($"                    $\"At least {n} items were expected, {{list.Count}} were found.\");");
                sw.WriteLine("            }");
                for (var i = 1; i <= n; ++i) {
                    sw.WriteLine($"            item{i} = list[{i - 1}];");
                }
                sw.WriteLine("        }");
                sw.WriteLine();
            }
            sw.WriteLine("    }");
            sw.WriteLine();
            sw.WriteLine("}");
        }
        
        private static void GenereateIEnumerableExtensionsClass() {
            using var sw = new StreamWriter(Path.Combine(targetDirectory, "Collections", "IEnumerableExtensions.Deconstruct.cs"));
            sw.WriteLine("using System;");
            sw.WriteLine("using System.Collections.Generic;");
            sw.WriteLine();
            sw.WriteLine("// GENERATED CODE - DO NOT MODIFY");
            sw.WriteLine();
            sw.WriteLine("namespace Netxtendable.Collections {");
            sw.WriteLine();
            sw.WriteLine("    /// <summary>Class with extension methods for <see cref=\"IEnumerable{T}\"/></summary>");
            sw.WriteLine("    public static partial class IEnumerableExtensions {");
            sw.WriteLine();
            for (var n = 2; n < 8; ++n) {
                sw.WriteLine($"        /// <summary>Extracts first {n} values from <paramref name=\"enumerable\"/>.</summary>");
                sw.WriteLine("        /// <typeparam name=\"T\">Type of items in <paramref name=\"enumerable\"/>.</typeparam>");
                sw.WriteLine("        /// <param name=\"enumerable\"><see cref=\"IEnumerable{T}\"/> to deconstruct.</param>");
                for (var i = 1; i <= n; ++i) {
                    sw.WriteLine($"        /// <param name=\"item{i}\">{NthLongCapitalized(i)} output item.</param>");
                }
                sw.WriteLine("        /// <exception cref=\"ArgumentNullException\">");
                sw.WriteLine("        /// Thrown when <paramref name=\"enumerable\"/> is null.");
                sw.WriteLine("        /// </exception>");
                sw.WriteLine("        /// <exception cref=\"InvalidOperationException\">");
                sw.WriteLine("        /// Thrown when <paramref name=\"enumerable\"/> does not have enought items.");
                sw.WriteLine("        /// </exception>");
                sw.WriteLine("        public static void Deconstruct<T>(");
                sw.WriteLine("            this IEnumerable<T> enumerable,");
                for (var i = 1; i <= n; ++i) {
                    sw.WriteLine($"            out T item{i}{(i < n ? "," : "")}");
                }
                sw.WriteLine("        ) {");
                sw.WriteLine("            if (enumerable is null) {");
                sw.WriteLine("                throw new ArgumentNullException(nameof(enumerable));");
                sw.WriteLine("            }");
                sw.WriteLine("            using var enumerator = enumerable.GetEnumerator();");
                for (var i = 1; i <= n; ++i) {
                    sw.WriteLine($"            item{i} = enumerator.MoveNext()");
                    sw.WriteLine("                ? enumerator.Current");
                    sw.WriteLine("                : throw new InvalidOperationException(");
                    sw.WriteLine($"                    \"At least {n} items were expected, {i - 1} were found.\");");
                }
                sw.WriteLine("        }");
                sw.WriteLine();
            }
            sw.WriteLine("    }");
            sw.WriteLine();
            sw.WriteLine("}");
        }
        
        private static void GenereateTupleExtensionsClass() {
            using var sw = new StreamWriter(Path.Combine(targetDirectory, "Collections", "TupleExtensions.cs"));
            sw.WriteLine("using System;");
            sw.WriteLine("using System.Collections.Generic;");
            sw.WriteLine();
            sw.WriteLine("// GENERATED CODE - DO NOT MODIFY");
            sw.WriteLine();
            sw.WriteLine("namespace Netxtendable.Collections {");
            sw.WriteLine();
            sw.WriteLine("    /// <summary>Class with extension methods for <see cref=\"Tuple\"/></summary>");
            sw.WriteLine("    public static class TupleExtensions {");
            sw.WriteLine();
            for (var n = 2; n < 8; ++n) {
                sw.WriteLine("        /// <summary>Deconstructs <paramref name=\"t\"/>.</summary>");
                for (var i = 1; i <= n; ++i) {
                    sw.WriteLine($"        /// <typeparam name=\"T{i}\">Type of {NthLong(i)} item in <paramref name=\"t\"/>.</typeparam>");
                }
                sw.WriteLine("        /// <param name=\"t\">Tuple to deconstruct.</param>");
                for (var i = 1; i <= n; ++i) {
                    sw.WriteLine($"        /// <param name=\"item{i}\">{NthLongCapitalized(i)} output item.</param>");
                }
                sw.WriteLine("        /// <exception cref=\"ArgumentNullException\">");
                sw.WriteLine("        /// Thrown when <paramref name=\"t\"/> is null.");
                sw.WriteLine("        /// </exception>");
                sw.WriteLine($"        public static void Deconstruct<{string.Join(", ", Enumerable.Range(1, n).Select(i => $"T{i}"))}>(");
                sw.WriteLine($"            this Tuple<{string.Join(", ", Enumerable.Range(1, n).Select(i => $"T{i}"))}> t,");
                for (var i = 1; i <= n; ++i) {
                    sw.WriteLine($"            out T{i} item{i}{(i < n ? "," : "")}");
                }
                sw.WriteLine("        ) {");
                sw.WriteLine("            if (t is null) {");
                sw.WriteLine("                throw new ArgumentNullException(nameof(t));");
                sw.WriteLine("            }");
                for (var i = 1; i <= n; ++i) {
                    sw.WriteLine($"            item{i} = t.Item{i};");
                }
                sw.WriteLine("        }");
                sw.WriteLine();
            }
            GenereateTupleToCollectionMethods(sw, false);
            sw.WriteLine("    }");
            sw.WriteLine();
            sw.WriteLine("}");
        }

        private static void GenereateValueTupleExtensionsClass() {
            using var sw = new StreamWriter(Path.Combine(targetDirectory, "Collections", "ValueTupleExtensions.cs"));
            sw.WriteLine("using System;");
            sw.WriteLine("using System.Collections.Generic;");
            sw.WriteLine();
            sw.WriteLine("// GENERATED CODE - DO NOT MODIFY");
            sw.WriteLine();
            sw.WriteLine("namespace Netxtendable.Collections {");
            sw.WriteLine();
            sw.WriteLine("    /// <summary>Class with extension methods for <see cref=\"Tuple\"/></summary>");
            sw.WriteLine("    public static class ValueTupleExtensions {");
            sw.WriteLine();
            GenereateTupleToCollectionMethods(sw, true);
            sw.WriteLine("    }");
            sw.WriteLine();
            sw.WriteLine("}");
        }
        
        private static void GenereateTupleToCollectionMethodsTests(StreamWriter sw, bool valueTuple) {
            for (var n = 2; n < 8; ++n) {
                sw.WriteLine("        [TestMethod]");
                sw.WriteLine($"        public void ToArray_{n}_Test() {{");
                var items = string.Join(", ", Enumerable.Range(1, n));
                sw.WriteLine(valueTuple
                                 ? $"            var ints = ({items}).ToArray();"
                                 : $"            var ints = new Tuple<{string.Join(", ", Enumerable.Repeat("int", n))}>({items}).ToArray();");
                sw.WriteLine($"            CollectionAssert.AreEqual(new[] {{ {string.Join(", ", Enumerable.Range(1, n))} }}, ints);");
                items = string.Join(", ", Enumerable.Range(1, n).Select(i => $"\"{i}\""));
                sw.WriteLine(valueTuple
                                 ? $"            var strings = ({items}).ToArray();"
                                 : $"            var strings = new Tuple<{string.Join(", ", Enumerable.Repeat("string", n))}>({items}).ToArray();");
                sw.WriteLine($"            CollectionAssert.AreEqual(new[] {{ {string.Join(", ", Enumerable.Range(1, n).Select(i => $"\"{i}\""))} }}, strings);");
                if (!valueTuple) {
                    sw.WriteLine("            Assert.ThrowsException<ArgumentNullException>(() => {");
                    sw.Write("                ((Tuple<");
                    sw.Write(string.Join(", ", Enumerable.Repeat("int", n)));
                    sw.WriteLine(">)null).ToArray();");
                    sw.WriteLine("            });");
                }
                sw.WriteLine("        }");
                sw.WriteLine();
            }
            for (var n = 2; n < 8; ++n) {
                sw.WriteLine("        [TestMethod]");
                sw.WriteLine($"        public void ToList_{n}_Test() {{");
                var items = string.Join(", ", Enumerable.Range(1, n));
                if (valueTuple) {
                    sw.WriteLine($"            var ints = ({items}).ToList();");
                } else {
                    sw.WriteLine($"            var ints = new Tuple<{string.Join(", ", Enumerable.Repeat("int", n))}>({items}).ToList();");
                }
                sw.WriteLine($"            CollectionAssert.AreEqual(new[] {{ {string.Join(", ", Enumerable.Range(1, n))} }}, ints);");
                items = string.Join(", ", Enumerable.Range(1, n).Select(i => $"\"{i}\""));
                if (valueTuple) {
                    sw.WriteLine($"            var strings = ({items}).ToList();");
                } else {
                    sw.WriteLine($"            var strings = new Tuple<{string.Join(", ", Enumerable.Repeat("string", n))}>({items}).ToList();");
                }
                sw.WriteLine($"            CollectionAssert.AreEqual(new[] {{ {string.Join(", ", Enumerable.Range(1, n).Select(i => $"\"{i}\""))} }}, strings);");
                if (!valueTuple) {
                    sw.WriteLine("            Assert.ThrowsException<ArgumentNullException>(() => {");
                    sw.Write("                ((Tuple<");
                    sw.Write(string.Join(", ", Enumerable.Repeat("int", n)));
                    sw.WriteLine(">)null).ToList();");
                    sw.WriteLine("            });");
                }
                sw.WriteLine("        }");
                sw.WriteLine();
            }
            for (var n = 2; n < 8; ++n) {
                sw.WriteLine("        [TestMethod]");
                sw.WriteLine($"        public void ToSet_{n}_Test() {{");
                var items = string.Join(", ", Enumerable.Range(1, n));
                if (valueTuple) {
                    sw.WriteLine($"            var ints = ({items}).ToSet().ToArray();");
                } else {
                    sw.WriteLine($"            var ints = new Tuple<{string.Join(", ", Enumerable.Repeat("int", n))}>({items}).ToSet().ToArray();");
                }
                sw.WriteLine($"            CollectionAssert.AreEquivalent(new[] {{ {string.Join(", ", Enumerable.Range(1, n))} }}, ints);");
                items = string.Join(", ", Enumerable.Range(1, n).Select(i => $"\"{i}\""));
                if (valueTuple) {
                    sw.WriteLine($"            var strings = ({items}).ToSet().ToArray();");
                } else {
                    sw.WriteLine($"            var strings = new Tuple<{string.Join(", ", Enumerable.Repeat("string", n))}>({items}).ToSet().ToArray();");
                }
                sw.WriteLine($"            CollectionAssert.AreEquivalent(new[] {{ {string.Join(", ", Enumerable.Range(1, n).Select(i => $"\"{i}\""))} }}, strings);");
                if (!valueTuple) {
                    sw.WriteLine("            Assert.ThrowsException<ArgumentNullException>(() => {");
                    sw.Write("                ((Tuple<");
                    sw.Write(string.Join(", ", Enumerable.Repeat("int", n)));
                    sw.WriteLine(">)null).ToSet();");
                    sw.WriteLine("            });");
                }
                sw.WriteLine("        }");
                sw.WriteLine();
            }
            for (var n = 2; n < 8; ++n) {
                sw.WriteLine("        [TestMethod]");
                sw.WriteLine($"        public void ToDictionary_{n}_Test() {{");
                var items = string.Join(", ", Enumerable.Range(1, n).Select(i => $"({i}, 1{i})"));
                if (valueTuple) {
                    sw.WriteLine($"            var ints = ({items}).ToDictionary();");
                } else {
                    sw.WriteLine($"            var ints = new Tuple<{string.Join(", ", Enumerable.Repeat("(int, int)", n))}>({items}).ToDictionary();");
                }
                sw.WriteLine("            CollectionAssert.AreEquivalent(new[] {");
                for (var i = 1; i <= n; ++i) {
                    sw.WriteLine($"                new KeyValuePair<int, int>({i}, 1{i}){(i < n ? "," : "")}");
                }
                sw.WriteLine("            }, ints);");
                items = string.Join(", ", Enumerable.Range(1, n).Select(i => $"(\"{i}\", \"1{i}\")"));
                if (valueTuple) {
                    sw.WriteLine($"            var strings = ({items}).ToDictionary();");
                } else {
                    sw.WriteLine($"            var strings = new Tuple<{string.Join(", ", Enumerable.Repeat("(string, string)", n))}>({items}).ToDictionary();");
                }
                sw.WriteLine("            CollectionAssert.AreEquivalent(new[] {");
                for (var i = 1; i <= n; ++i) {
                    sw.WriteLine($"                new KeyValuePair<string, string>(\"{i}\", \"1{i}\"){(i < n ? "," : "")}");
                }
                sw.WriteLine("            }, strings);");
                if (!valueTuple) {
                    sw.WriteLine("            Assert.ThrowsException<ArgumentNullException>(() => {");
                    sw.Write("                ((Tuple<");
                    sw.Write(string.Join(", ", Enumerable.Repeat("(int, int)", n)));
                    sw.WriteLine(">)null).ToDictionary();");
                    sw.WriteLine("            });");
                }
                sw.WriteLine("        }");
                sw.WriteLine();
            }
            for (var n = 2; n < 8; ++n) {
                sw.WriteLine("        [TestMethod]");
                sw.WriteLine($"        public void Enumerate_{n}_Test() {{");
                var items = string.Join(", ", Enumerable.Range(1, n));
                if (valueTuple) {
                    sw.WriteLine($"            var ints = ({items}).Enumerate().ToArray();");
                } else {
                    sw.WriteLine($"            var ints = new Tuple<{string.Join(", ", Enumerable.Repeat("int", n))}>({items}).Enumerate().ToArray();");
                }
                sw.WriteLine($"            CollectionAssert.AreEqual(new[] {{ {string.Join(", ", Enumerable.Range(1, n))} }}, ints);");
                items = string.Join(", ", Enumerable.Range(1, n).Select(i => $"\"{i}\""));
                if (valueTuple) {
                    sw.WriteLine($"            var strings = ({items}).Enumerate().ToArray();");
                } else {
                    sw.WriteLine($"            var strings = new Tuple<{string.Join(", ", Enumerable.Repeat("string", n))}>({items}).Enumerate().ToArray();");
                }
                sw.WriteLine($"            CollectionAssert.AreEqual(new[] {{ {string.Join(", ", Enumerable.Range(1, n).Select(i => $"\"{i}\""))} }}, strings);");
                if (!valueTuple) {
                    sw.WriteLine("            Assert.ThrowsException<ArgumentNullException>(() => {");
                    sw.Write("                foreach (var v in ((Tuple<");
                    sw.Write(string.Join(", ", Enumerable.Repeat("int", n)));
                    sw.WriteLine(">)null).Enumerate()) { }");
                    sw.WriteLine("            });");
                }
                sw.WriteLine("        }");
                sw.WriteLine();
            }
        }
        
        private static void GenereateIListExtensionsClassTests() {
            using var sw = new StreamWriter(Path.Combine(targetTestsDirectory, "Collections", "IListExtensionsTests.cs"));
            sw.WriteLine("using Microsoft.VisualStudio.TestTools.UnitTesting;");
            sw.WriteLine("using System;");
            sw.WriteLine("using System.Collections.Generic;");
            sw.WriteLine();
            sw.WriteLine("// GENERATED CODE - DO NOT MODIFY");
            sw.WriteLine();
            sw.WriteLine("namespace Netxtendable.Collections.Tests {");
            sw.WriteLine();
            sw.WriteLine("    [TestClass]");
            sw.WriteLine("    public class IListExtensionsTests {");
            sw.WriteLine();
            for (var n = 2; n < 8; ++n) {
                sw.WriteLine("        [TestMethod]");
                sw.WriteLine($"        public void Deconstruct_{n}_Test() {{");
                sw.WriteLine($"            var ({string.Join(", ", Enumerable.Range(1, n).Select(i => $"i{i}"))}) =");
                sw.WriteLine("                new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };");
                for (var i = 1; i <= n; ++i) {
                    sw.WriteLine($"            Assert.AreEqual({i}, i{i});");
                }
                sw.WriteLine($"            var ({string.Join(", ", Enumerable.Range(1, n).Select(i => $"s{i}"))}) =");
                sw.WriteLine("                new List<string> { \"1\", \"2\", \"3\", \"4\", \"5\", \"6\", \"7\", \"8\" };");
                for (var i = 1; i <= n; ++i) {
                    sw.WriteLine($"            Assert.AreEqual(\"{i}\", s{i});");
                }
                var avars = string.Join(", ", Enumerable.Range(1, n).Select(i => $"a{i}"));
                sw.WriteLine("            Assert.ThrowsException<ArgumentNullException>(() => {");
                sw.WriteLine($"                var ({avars}) = (List<int>)null;");
                sw.WriteLine("            });");
                sw.WriteLine("            Assert.ThrowsException<InvalidOperationException>(() => {");
                sw.WriteLine($"                var ({avars}) = new List<int>();");
                sw.WriteLine("            });");
                sw.WriteLine("        }");
                sw.WriteLine();
            }
            sw.WriteLine("    }");
            sw.WriteLine();
            sw.WriteLine("}");
        }
        
        private static void GenereateIEnumerableExtensionsClassTests() {
            using var sw = new StreamWriter(Path.Combine(targetTestsDirectory, "Collections", "IEnumerableExtensionsTests.Deconstruct.cs"));
            sw.WriteLine("using Microsoft.VisualStudio.TestTools.UnitTesting;");
            sw.WriteLine("using System;");
            sw.WriteLine("using System.Collections.Generic;");
            sw.WriteLine("using System.Linq;");
            sw.WriteLine();
            sw.WriteLine("// GENERATED CODE - DO NOT MODIFY");
            sw.WriteLine();
            sw.WriteLine("namespace Netxtendable.Collections.Tests {");
            sw.WriteLine();
            sw.WriteLine("    public partial class IEnumerableExtensionsTests {");
            sw.WriteLine();
            for (var n = 2; n < 8; ++n) {
                sw.WriteLine("        [TestMethod]");
                sw.WriteLine($"        public void Deconstruct_{n}_Test() {{");
                sw.WriteLine($"            var ({string.Join(", ", Enumerable.Range(1, n).Select(i => $"i{i}"))}) = Enumerable.Range(1, 8);");
                for (var i = 1; i <= n; ++i) {
                    sw.WriteLine($"            Assert.AreEqual({i}, i{i});");
                }
                sw.WriteLine($"            var ({string.Join(", ", Enumerable.Range(1, n).Select(i => $"s{i}"))}) = Enumerable.Range(1, 8).Select(i => i.ToString());");
                for (var i = 1; i <= n; ++i) {
                    sw.WriteLine($"            Assert.AreEqual(\"{i}\", s{i});");
                }
                var avars = string.Join(", ", Enumerable.Range(1, n).Select(i => $"a{i}"));
                sw.WriteLine("            Assert.ThrowsException<ArgumentNullException>(() => {");
                sw.WriteLine($"                var ({avars}) = (IEnumerable<int>)null;");
                sw.WriteLine("            });");
                sw.WriteLine("            Assert.ThrowsException<InvalidOperationException>(() => {");
                sw.WriteLine($"                var ({avars}) = Enumerable.Empty<int>();");
                sw.WriteLine("            });");
                sw.WriteLine("        }");
                sw.WriteLine();
            }
            sw.WriteLine("    }");
            sw.WriteLine();
            sw.WriteLine("}");
        }

        private static void GenereateTupleExtensionsClassTests() {
            using var sw = new StreamWriter(Path.Combine(targetTestsDirectory, "Collections", "TupleExtensionsTests.cs"));
            sw.WriteLine("using Microsoft.VisualStudio.TestTools.UnitTesting;");
            sw.WriteLine("using System;");
            sw.WriteLine("using System.Collections.Generic;");
            sw.WriteLine("using System.Linq;");
            sw.WriteLine();
            sw.WriteLine("// GENERATED CODE - DO NOT MODIFY");
            sw.WriteLine();
            sw.WriteLine("namespace Netxtendable.Collections.Tests {");
            sw.WriteLine();
            sw.WriteLine("    [TestClass]");
            sw.WriteLine("    public class TupleExtensionsTests {");
            sw.WriteLine();
            for (var n = 2; n < 8; ++n) {
                sw.WriteLine("        [TestMethod]");
                sw.WriteLine($"        public void Deconstruct_{n}_Test() {{");
                sw.Write("            var (");
                sw.Write(string.Join(", ", Enumerable.Range(1, n).Select(i => $"i{i}")));
                sw.Write(") = new Tuple<");
                sw.Write(string.Join(", ", Enumerable.Repeat("int", n)));
                sw.Write(">(");
                sw.Write(string.Join(", ", Enumerable.Range(1, n)));
                sw.WriteLine(");");
                for (var i = 1; i <= n; ++i) {
                    sw.WriteLine($"            Assert.AreEqual({i}, i{i});");
                }
                sw.Write("            var (");
                sw.Write(string.Join(", ", Enumerable.Range(1, n).Select(i => $"s{i}")));
                sw.Write(") = new Tuple<");
                sw.Write(string.Join(", ", Enumerable.Repeat("string", n)));
                sw.Write(">(");
                sw.Write(string.Join(", ", Enumerable.Range(1, n).Select(i => $"\"{i}\"")));
                sw.WriteLine(");");
                for (var i = 1; i <= n; ++i) {
                    sw.WriteLine($"            Assert.AreEqual(\"{i}\", s{i});");
                }
                sw.WriteLine("            Assert.ThrowsException<ArgumentNullException>(() => {");
                sw.Write("                var (");
                sw.Write(string.Join(", ", Enumerable.Range(1, n).Select(i => $"a{i}")));
                sw.Write(") = (Tuple<");
                sw.Write(string.Join(", ", Enumerable.Repeat("int", n)));
                sw.WriteLine(">)null;");
                sw.WriteLine("            });");
                sw.WriteLine("        }");
                sw.WriteLine();
            }
            GenereateTupleToCollectionMethodsTests(sw, false);
            sw.WriteLine("    }");
            sw.WriteLine();
            sw.WriteLine("}");
        }
        
        private static void GenereateValueTupleExtensionsClassTests() {
            using var sw = new StreamWriter(Path.Combine(targetTestsDirectory, "Collections", "ValueTupleExtensionsTests.cs"));
            sw.WriteLine("using Microsoft.VisualStudio.TestTools.UnitTesting;");
            sw.WriteLine("using System;");
            sw.WriteLine("using System.Collections.Generic;");
            sw.WriteLine("using System.Linq;");
            sw.WriteLine();
            sw.WriteLine("// GENERATED CODE - DO NOT MODIFY");
            sw.WriteLine();
            sw.WriteLine("namespace Netxtendable.Collections.Tests {");
            sw.WriteLine();
            sw.WriteLine("    [TestClass]");
            sw.WriteLine("    public class ValueTupleExtensionsTests {");
            sw.WriteLine();
            GenereateTupleToCollectionMethodsTests(sw, true);
            sw.WriteLine("    }");
            sw.WriteLine();
            sw.WriteLine("}");
        }
        
        private static void Main() {
            GenereateIListExtensionsClass();
            GenereateIEnumerableExtensionsClass();
            GenereateTupleExtensionsClass();
            GenereateValueTupleExtensionsClass();
            // tests
            GenereateIListExtensionsClassTests();
            GenereateIEnumerableExtensionsClassTests();
            GenereateTupleExtensionsClassTests();
            GenereateValueTupleExtensionsClassTests();
        }

    }

}
