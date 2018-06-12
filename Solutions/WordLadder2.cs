namespace Solutions
{
    using System.Collections.Generic;
    using System.Linq;

    public class WordLadder2
    {
        private int minLevel = int.MaxValue;

        public IList<IList<string>> FindLadders(string beginWord, string endWord, IList<string> wordList)
        {
            var res = new List<IList<string>>();
            var wordSet = new HashSet<string>(wordList);
            if (!wordSet.Contains(endWord)) return res;
            if (wordSet.Contains(beginWord))
            {
                wordSet.Remove(beginWord);
            }

            var root = new TreeNode(beginWord, wordSet, null, 0);
            this.BuildTreeBfs2(beginWord, endWord, wordSet, res);
            // for (int i = res.Count - 1; i >= 0; i--)
            // {
            //     if (res[i].Count > this.minLevel + 1)
            //     {
            //         res.RemoveAt(i);
            //     }
            // }

            return res;
        }

        public void BuildTreeBfs2(string beginWord, string endWord, HashSet<string> wordSet, IList<IList<string>> res)
        {
            if (wordSet.Contains(beginWord))
            {
                wordSet.Remove(beginWord);
            }

            var queue = new Queue<string>();
            queue.Enqueue(beginWord);
            var levelMap = new Dictionary<string, int> { { beginWord, 1 } };
            var ans = new List<string>();
            res.Add(ans);
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
                                return;
                            }

                            levelMap.Add(temp, curLevel + 1);
                            queue.Enqueue(temp);
                            wordSet.Remove(temp);
                            ans.Add(temp);
                        }
                    }
                }
            }
        }

        private void BuildTreeBfs(TreeNode root, HashSet<string> wordSet, string endWord, IList<IList<string>> res)
        {
            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Any())
            {
                var currentNode = queue.Dequeue();
                if (currentNode.Level > this.minLevel) return;
                if (currentNode.Word.Equals(endWord) && currentNode.Level <= this.minLevel)
                {
                    var list = new List<string>();
                    res.Add(list);
                    list.Add(endWord);
                    this.minLevel = currentNode.Level;
                    var parent = currentNode.Parent;
                    while (parent != null)
                    {
                        list.Insert(0, parent.Word);
                        parent = parent.Parent;
                    }
                }

                foreach (var w in currentNode.WordSet)
                {
                    if (!this.CanTransform(currentNode.Word, w)) continue;
                    var nextSet = new HashSet<string>(currentNode.WordSet);
                    nextSet.Remove(w);
                    var childNode = new TreeNode(w, nextSet, currentNode, currentNode.Level + 1);
                    queue.Enqueue(childNode);
                }
            }
        }

        private bool CanTransform(string beginWord, string endword)
        {
            int change = 0;
            for (int i = 0; i < beginWord.Length; i++)
            {
                if (!beginWord[i].Equals(endword[i]))
                {
                    change++;
                }
            }

            return change == 1;
        }

        private class TreeNode
        {
            public TreeNode(string word, HashSet<string> wordSet, TreeNode parent, int level)
            {
                this.Level = level;
                this.Word = word;
                this.WordSet = wordSet;
                this.Parent = parent;
            }

            public int Level { get; set; }

            public TreeNode Parent { get; set; }

            public string Word { get; set; }

            public HashSet<string> WordSet { get; set; }
        }
    }
}