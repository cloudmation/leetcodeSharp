namespace ConsoleApp
{
    using System;

    using Solutions;

    internal class Program
    {
        private static void Main(string[] args)
        {
            var solution = new MaximalRectangle();
            var result = solution.MaximalBruteForce(new[,] {{'1', '0'},{'1', '0'}});
            Console.Write("results:" + result);
            Console.Read();
        }
    }
}