namespace Solutions
{
    using System;
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
            var root = new TreeNode(beginWord, wordSet, null, 0);
            this.BuildTree(root, wordSet, endWord, res);
            for (int i = res.Count - 1; i >= 0; i--)
            {
                if (res[i].Count > this.minLevel + 1)
                {
                    res.RemoveAt(i);
                }
            }
            return res;
        }


        private void BuildTree(TreeNode node, HashSet<string> wordSet, string endWord, IList<IList<string>> res)
        {
            if (wordSet.Count == 0) return;
            if (node.Word.Equals(endWord) && node.Level <= this.minLevel)
            {
                var list = new List<string>();
                res.Add(list);
                list.Add(endWord);
                this.minLevel = node.Level;
                var parent = node.Parent;
                while (parent != null)
                {
                    list.Insert(0, parent.Word);
                    parent = parent.Parent;
                }
           

            return;
            }

            foreach (var w in wordSet)
            {
                if (!this.CanTransform(node.Word, w)) continue;
                var nextSet = new HashSet<string>(wordSet);
                nextSet.Remove(w);
                var childNode = new TreeNode(w, nextSet, node, node.Level + 1);
                node.Childern.Add(childNode);
                this.BuildTree(childNode, nextSet, endWord, res);
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

            return change == 1 ? true : false;
        }

        private class TreeNode
        {
            public TreeNode(string word, HashSet<string> wordSet, TreeNode parent, int level)
            {
                this.Level = level;
                this.Word = word;
                this.WordSet = wordSet;
                this.Parent = parent;
                this.Childern = new List<TreeNode>();
            }

            public int Level { get; set; }

            public IList<TreeNode> Childern { get; set; }

            public TreeNode Parent { get; set; }

            public string Word { get; set; }

            public HashSet<string> WordSet { get; set; }
        }
    }
}