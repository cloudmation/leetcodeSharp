using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions
{
    public class NQueens
    {
        public IList<IList<string>> SolveNQueens(int n)
        {
            var res = new List<IList<string>>();
            Helper(n, res, new List<Tuple<int, int>>(), 0, 0);
            return res;
        }

        private void Helper(int n, IList<IList<string>> res, IList<Tuple<int, int>> currentList, int rowIndex, int colIndex)
        {
            if (currentList.Count == n)
            {
                var list = new List<string>();
                for (int i = 0; i < n; i++)
                {
                    var str = new char[n];
                    var currentTuple = currentList[i];
                    for (int j = 0; j < n; j++)
                    {
                        str[j] = currentTuple.Item2 == j ? 'Q' : '.';
                    }
                    list.Add(new string(str));
                }
                res.Add(list);
            }

            for (int i = rowIndex; i < n; i++)
            {
                for (int j = colIndex; j < n; j++)
                {
                    var current = Tuple.Create(i, j);
                    if (IsAttacking(currentList, current)) continue;
                    currentList.Add(current);
                    Helper(n, res, currentList, rowIndex + 1, colIndex);
                    currentList.RemoveAt(currentList.Count - 1);
                }
            }

        }

        private bool IsAttacking(IList<Tuple<int, int>> currentList, Tuple<int, int> current)
        {
            foreach (var tuple in currentList)
            {
                if (tuple.Item1 == current.Item1) return true;
                if (tuple.Item2 == current.Item2) return true;
                if (tuple.Item1 + tuple.Item2 == current.Item1 + current.Item2) return true;
                if (tuple.Item2 - tuple.Item1 == current.Item2 - current.Item1) return true;
            }
            return false;
        }
    }
}
