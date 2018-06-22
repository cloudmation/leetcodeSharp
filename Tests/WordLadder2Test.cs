namespace Tests
{
    using System.Collections.Generic;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using Solutions;

    [TestClass]
    public class WordLadder2Test
    {
        [TestMethod]
        public void Test1()
        {
            var ladder = new WordLadder2Sol2();
            var res = ladder.FindLadders("hit", "cog", new List<string>() { "hot", "dot", "dog", "lot", "log", "cog" });
            IList<IList<string>> expected = new List<IList<string>>();
            expected.Add(new List<string>() { "hit", "hot", "dot", "dog", "cog" });
            expected.Add(new List<string>() { "hit", "hot", "lot", "log", "cog" });
            Utlilitiy.AssertAreEqual(expected, res);
        }

        [TestMethod]
        public void Test2()
        {
            var ladder = new WordLadder2Sol2();
            var res = ladder.FindLadders(
                "hot",
                "dog",
                new List<string>() { "hot", "cog", "dog", "tot", "hog", "hop", "pot", "dot" });
            IList<IList<string>> expected = new List<IList<string>>();
            expected.Add(new List<string>() { "hot", "dot", "dog" });
            expected.Add(new List<string>() { "hot", "hog", "dog" });
            Utlilitiy.AssertAreEqual(expected, res);
        }

        [TestMethod]
        public void Test3()
        {
            var ladder = new WordLadder2Sol2();
            var res = ladder.FindLadders(
                "lost",
                "miss",
                new List<string>() { "most", "mist", "miss", "lost", "fist", "fish" });
            IList<IList<string>> expected = new List<IList<string>>();
            expected.Add(new List<string>() { "lost", "most", "mist", "miss" });
            Utlilitiy.AssertAreEqual(expected, res);
        }


        [TestMethod]
        public void Test4()
        {
            var ladder = new WordLadder2Sol2();
            var res = ladder.FindLadders(
                "qa",
                "sq",
                new List<string>() { "si", "go", "se", "cm", "so", "ph", "mt", "db", "mb", "sb", "kr", "ln", "tm", "le", "av", "sm", "ar", "ci", "ca", "br", "ti", "ba", "to", "ra", "fa", "yo", "ow", "sn", "ya", "cr", "po", "fe", "ho", "ma", "re", "or", "rn", "au", "ur", "rh", "sr", "tc", "lt", "lo", "as", "fr", "nb", "yb", "if", "pb", "ge", "th", "pm", "rb", "sh", "co", "ga", "li", "ha", "hz", "no", "bi", "di", "hi", "qa", "pi", "os", "uh", "wm", "an", "me", "mo", "na", "la", "st", "er", "sc", "ne", "mn", "mi", "am", "ex", "pt", "io", "be", "fm", "ta", "tb", "ni", "mr", "pa", "he", "lr", "sq", "ye" });
            IList<IList<string>> expected = new List<IList<string>>();
            expected.Add(new List<string>() { "qa", "ba", "be", "se", "sq" });
            expected.Add(new List<string>() { "qa", "ba", "bi", "si", "sq" });
            expected.Add(new List<string>() { "qa", "ba", "br", "sr", "sq" });
            expected.Add(new List<string>() { "qa", "ca", "cm", "sm", "sq" });
            expected.Add(new List<string>() { "qa", "ca", "co", "so", "sq" });
            expected.Add(new List<string>() { "qa", "la", "ln", "sn", "sq" });
            expected.Add(new List<string>() { "qa", "la", "lt", "st", "sq" });
            expected.Add(new List<string>() { "qa", "ma", "mb", "sb", "sq" });
            expected.Add(new List<string>() { "qa", "pa", "ph", "sh", "sq" });
            expected.Add(new List<string>() { "qa", "ta", "tc", "sc", "sq" });
            expected.Add(new List<string>() { "qa", "fa", "fe", "se", "sq" });
            expected.Add(new List<string>() { "qa", "ga", "ge", "se", "sq" });
            expected.Add(new List<string>() { "qa", "ha", "he", "se", "sq" });
            expected.Add(new List<string>() { "qa", "la", "le", "se", "sq" });
            expected.Add(new List<string>() { "qa", "ma", "me", "se", "sq" });
            expected.Add(new List<string>() { "qa", "na", "ne", "se", "sq" });
            expected.Add(new List<string>() { "qa", "ra", "re", "se", "sq" });
            expected.Add(new List<string>() { "qa", "ya", "ye", "se", "sq" });
            expected.Add(new List<string>() { "qa", "ca", "ci", "si", "sq" });
            expected.Add(new List<string>() { "qa", "ha", "hi", "si", "sq" });
            expected.Add(new List<string>() { "qa", "la", "li", "si", "sq" });
            expected.Add(new List<string>() { "qa", "ma", "mi", "si", "sq" });
            expected.Add(new List<string>() { "qa", "na", "ni", "si", "sq" });
            expected.Add(new List<string>() { "qa", "pa", "pi", "si", "sq" });
            expected.Add(new List<string>() { "qa", "ta", "ti", "si", "sq" });
            expected.Add(new List<string>() { "qa", "ca", "cr", "sr", "sq" });
            expected.Add(new List<string>() { "qa", "fa", "fr", "sr", "sq" });
            expected.Add(new List<string>() { "qa", "la", "lr", "sr", "sq" });
            expected.Add(new List<string>() { "qa", "ma", "mr", "sr", "sq" });
            expected.Add(new List<string>() { "qa", "fa", "fm", "sm", "sq" });
            expected.Add(new List<string>() { "qa", "pa", "pm", "sm", "sq" });
            expected.Add(new List<string>() { "qa", "ta", "tm", "sm", "sq" });
            expected.Add(new List<string>() { "qa", "ga", "go", "so", "sq" });
            expected.Add(new List<string>() { "qa", "ha", "ho", "so", "sq" });
            expected.Add(new List<string>() { "qa", "la", "lo", "so", "sq" });
            expected.Add(new List<string>() { "qa", "ma", "mo", "so", "sq" });
            expected.Add(new List<string>() { "qa", "na", "no", "so", "sq" });
            expected.Add(new List<string>() { "qa", "pa", "po", "so", "sq" });
            expected.Add(new List<string>() { "qa", "ta", "to", "so", "sq" });
            expected.Add(new List<string>() { "qa", "ya", "yo", "so", "sq" });
            expected.Add(new List<string>() { "qa", "ma", "mn", "sn", "sq" });
            expected.Add(new List<string>() { "qa", "ra", "rn", "sn", "sq" });
            expected.Add(new List<string>() { "qa", "ma", "mt", "st", "sq" });
            expected.Add(new List<string>() { "qa", "pa", "pt", "st", "sq" });
            expected.Add(new List<string>() { "qa", "na", "nb", "sb", "sq" });
            expected.Add(new List<string>() { "qa", "pa", "pb", "sb", "sq" });
            expected.Add(new List<string>() { "qa", "ra", "rb", "sb", "sq" });
            expected.Add(new List<string>() { "qa", "ta", "tb", "sb", "sq" });
            expected.Add(new List<string>() { "qa", "ya", "yb", "sb", "sq" });
            expected.Add(new List<string>() { "qa", "ra", "rh", "sh", "sq" });
            expected.Add(new List<string>() { "qa", "ta", "th", "sh", "sq" });
            Utlilitiy.AssertAreEqualIgnoreOrder(expected, res);
        }
    }
}