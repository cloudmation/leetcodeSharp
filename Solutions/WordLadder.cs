namespace Solutions
{
    using System.Collections.Generic;
    using System.Linq;

    public class WordLadder
    {
        public int LadderLength(string beginWord, string endWord, IList<string> wordList)
        {
            var wordSet = new HashSet<string>(wordList);
            if (wordSet.Contains(beginWord))
            {
                wordSet.Remove(beginWord);
            }

            var queue = new Queue<string>();
            queue.Enqueue(beginWord);
            var levelMap = new Dictionary<string, int> { { beginWord, 1 } };
            var ans = new List<string>();
            ans.Add(beginWord);
            while (queue.Any())
            {
                var word = queue.Dequeue();
                int curLevel = levelMap[word];
                for (int i = 0; i < word.Length; i++)
                {
                    var wordChar = word.ToCharArray();
                    for (char j = 'a'; j <= 'z'; j++)
                    {
                        wordChar[i] = j;
                        var temp = new string(wordChar);
                        if (wordSet.Contains(temp))
                        {
                            if (temp.Equals(endWord))
                            {
                                ans.Add(endWord);
                                return curLevel + 1;
                            }

                            levelMap.Add(temp, curLevel + 1);
                            queue.Enqueue(temp);
                            wordSet.Remove(temp);
                            ans.Add(temp);
                        }
                    }
                }
            }

            return 0;
        }
    }
}