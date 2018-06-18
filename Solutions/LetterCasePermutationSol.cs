namespace Solutions
{
    using System.Collections.Generic;
    using System.Text;

    public class LetterCasePermutationSol
    {
        public IList<string> LetterCasePermutation(string S)
        {
            if (S == null) return null;
            var res = new List<string>();
            this.Permute(S, 0, res);
            return res;
        }

        private void Permute(string S, int index, List<string> res)
        {
            if (index == S.Length)
            {
                res.Add(S);
                return;
            }

            Permute(S, index + 1, res);
            var original = S[index];
            if (char.IsDigit(original)) return;
            var sb = new StringBuilder(S);
            var toggledChar = char.IsLower(S[index]) ? char.ToUpper(S[index]) : char.ToLower(S[index]);
            sb[index] = toggledChar;
            Permute(sb.ToString(), index + 1, res);
        }
    }
}