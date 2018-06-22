using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Solutions
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.InteropServices;
    using System.Text;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    public static class Utlilitiy
    {
        public static string Print<T>(this T[,] array)
        {
            var builder = new StringBuilder();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    builder.Append($"({i}, {j})={array[i, j]}");
                    builder.Append("\t");
                }

                builder.AppendLine();
            }

            return builder.ToString();
        }

        public static string Print<T>(this T[] array)
        {
            var builder = new StringBuilder();
            foreach (var t in array)
            {
                builder.Append($"[{t}]");
            }

            builder.Append(Environment.NewLine);
            return builder.ToString();
        }

        public static void AssertAreEqual<T>(IList<IList<T>> expected, IList<IList<T>> actual)
        {
            if (expected.Count != actual.Count)
            {
                Assert.Fail($"Different number of lists. expected:{expected.Count} actual:{actual.Count}");
            }

            for (int i = 0; i < expected.Count; i++)
            {
                CollectionAssert.AreEquivalent(expected[i].ToArray(), actual[i].ToArray());
            }
        }

        public static void AssertAreEqualIgnoreOrder<T>(IList<IList<T>> expected, IList<IList<T>> actual)
        {
            if (expected.Count != actual.Count)
            {
                Assert.Fail($"Different number of lists. expected:{expected.Count} actual:{actual.Count}");
            }

            var actualSet = new HashSet<IEnumerable<T>>();
            foreach (var a in actual)
            {
                actualSet.Add(a.ToArray());
            }

            var actualSetCount = actualSet.Count;
            for (int i = 0; i < expected.Count; i++)
            {
                var cur = expected[i].ToArray();
                if (actualSet.Contains(cur, new ArrayComparer<T>()))
                {
                    actualSetCount--;
                }
            }

            Assert.AreEqual(0, actualSetCount);
        }
    }
}

public class ArrayComparer<T> : IEqualityComparer<IEnumerable<T>>
{
    public bool Equals(IEnumerable<T> x, IEnumerable<T> y)
    {
        return x.SequenceEqual(y);
    }

    public int GetHashCode(IEnumerable<T> obj)
    {
        throw new NotImplementedException();
    }
}