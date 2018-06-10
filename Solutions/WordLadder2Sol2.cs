namespace Solutions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class WordLadder2Sol2
    {
        public IList<IList<string>> FindLadders(string beginWord, string endWord, IList<string> wordList)
        {
            var result = new List<IList<string>>();
            if (string.IsNullOrEmpty(beginWord) || string.IsNullOrEmpty(endWord) || wordList == null || !wordList.Any())
                return result;
            var neighbours = new Dictionary<string, List<string>>();
            var set = new HashSet<string>(wordList);
            var distance = new Dictionary<string, int>();
            distance[beginWord] = 0;
            set.Add(beginWord);
            Bfs(beginWord, endWord, neighbours, distance, set);
            Dfs(beginWord, endWord, neighbours, distance, result, new List<string>());
            return result;
        }

        private void Bfs(string begin, string end, Dictionary<string, List<string>> neighbours, Dictionary<string, int> distance, HashSet<string> set)
        {
            var queue = new Queue<string>();
            var isEnd = false;
            queue.Enqueue(begin);
            while (queue.Any() && !isEnd)
            {
                var t = new Queue<string>();
                while (queue.Any())
                {
                    var node = queue.Dequeue();
                    var newNeighbours = this.GetNeighbours(node, set);
                    foreach (var newWord in newNeighbours)
                    {
                        if (!neighbours.ContainsKey(node))
                        {
                            neighbours[node] = new List<string>();
                        }

                        neighbours[node].Add(newWord);
                        if (!distance.ContainsKey(newWord))
                        {
                            distance[newWord] = distance[node] + 1;
                            if (newWord == end)
                            {
                                isEnd = true;
                                break;
                            }
                            else
                            {
                                t.Enqueue(newWord);
                            }
                        }
                    }
                }
                queue = t;
            }
        }

        private void Dfs(string start, string end, Dictionary<string, List<string>> neighbours, Dictionary<string, int> distance, IList<IList<string>> result, IList<string> temp)
        {
            temp.Add(start);
            if (start == end)
            {
                result.Add(new List<string>(temp));
            }
            else
            {
                if (neighbours.ContainsKey(start))
                {
                    foreach (var newWord in neighbours[start])
                    {
                        if (distance[newWord] == distance[start] + 1)
                        {
                            Dfs(newWord, end, neighbours, distance, result, temp);
                        }
                    }
                }

            }

            temp.RemoveAt(temp.Count - 1);
        }


        private IList<string> GetNeighbours(string word, HashSet<string> set)
        {
            var result = new List<string>();
            for (int i = 0; i < word.Length; i++)
            {
                var tempWord = word.ToCharArray();
                var cTemp = tempWord[i];
                for (char c = 'a'; c <= 'z'; c++)
                {
                    if (c != cTemp)
                    {
                        tempWord[i] = c;
                        var newString = new string(tempWord);
                        if (set.Contains(newString))
                        {
                            result.Add(newString);
                        }
                        tempWord[i] = cTemp;
                    }

                }
            }
            return result;
        }
    }
}