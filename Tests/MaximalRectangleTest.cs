namespace Tests
{
    using System;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using Solutions;

    [TestClass]
    public class MaximalRectangleTest
    {
        private readonly char[,] inputMatrix1 = { { '1', '0', '1', '0', '0' }, { '1', '0', '1', '1', '1' }, { '1', '1', '1', '1', '1' }, { '1', '0', '0', '1', '0' } };

        [TestMethod]
        public void TestBruteforce()
        {
            var rectangle = new MaximalRectangle();
            Console.WriteLine(this.inputMatrix1.Print());
            var result = rectangle.MaximalBruteForce(this.inputMatrix1);
            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void TestHistogram1()
        {
            var rectangle = new MaximalRectangle();
            var result = rectangle.MaximalHistogram(this.inputMatrix1);
            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void TestHistogram2()
        {
            var rectangle = new MaximalRectangle();
            var result = rectangle.MaximalHistogram(new[,] { { '1' } });
            Assert.AreEqual(1, result);

            result = rectangle.MaximalHistogram(new[,] { { '0', '1' }, { '1', '0' } });
            Assert.AreEqual(1, result);
        }
    }
}