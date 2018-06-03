namespace Solutions
{
    using System;
    using System.Runtime.InteropServices;
    using System.Text;

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
    }
}