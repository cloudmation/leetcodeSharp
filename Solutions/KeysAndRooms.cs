namespace Solutions
{
    using System.Collections.Generic;
    using System.Linq;

    // 841. Keys and Rooms - DSF
    public class KeysAndRooms
    {
        public bool CanVisitAllRooms(IList<IList<int>> rooms)
        {
            var visited = new bool[rooms.Count()];
            var nodesToVisit = new Stack<int>();
            nodesToVisit.Push(0);
            visited[0] = true;
            while (nodesToVisit.Count() != 0)
            {
                int roomNumber = nodesToVisit.Pop();
                foreach (var room in rooms[roomNumber])
                {
                    if (!visited[room])
                    {
                        visited[room] = true;
                        nodesToVisit.Push(room);
                    }
                }
            }

            foreach (var v in visited)
            {
                if (!v)
                {
                    return false;
                }
            }

            return true;
        }
    }
}