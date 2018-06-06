namespace Tests
{
    using System.Collections.Generic;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using Solutions;

    [TestClass]
    public class KeysAndRoomsTest
    {
        [TestMethod]
        public void TestFalse()
        {
            var solution = new KeysAndRooms();
            IList<IList<int>> input = new List<IList<int>>();
            input.Add(new List<int>() { 1, 3 });
            input.Add(new List<int>() { 3, 0, 1 });
            input.Add(new List<int>() { 2 });
            input.Add(new List<int>() { 0 });

            var visited = solution.CanVisitAllRooms(input);
            Assert.AreEqual(false, visited);
        }

        [TestMethod]
        public void TestTrue()
        {
            var solution = new KeysAndRooms();
            IList<IList<int>> input = new List<IList<int>>();
            input.Add(new List<int>() { 1 });
            input.Add(new List<int>() { 2 });
            input.Add(new List<int>() { 3 });
            input.Add(new List<int>());

            var visited = solution.CanVisitAllRooms(input);
            Assert.AreEqual(true, visited);
        }
    }
}