namespace Solutions
{
    using System;
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

        public static void AssertAreEqual<T>(IList<IList<T>> expected, IList<IList<T>> actual)
        {
            if (expected.Count != actual.Count)
            {
                Assert.Fail($"Different number of lists. expected:{expected.Count} actual:{actual.Count}");
            }

            for (int i = 0; i < expected.Count; i++)
            {
                CollectionAssert.AreEqual(expected[i].ToArray(), actual[i].ToArray());
            }
        }
    }
}