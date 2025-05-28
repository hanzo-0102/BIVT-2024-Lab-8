using Lab_8;
using System;

namespace Lab_8
{
    public class Blue_3 : Blue
    {
        private (char, double)[] output_;

        char nothing = '\0';

        private char[] spliters = { ' ', '.', '!', '?', ',', ':', '\"', ';', '–', '(', ')', '[', ']', '{', '}', '/' };
        public (char, double)[] Output => output_;
        public Blue_3(string input) : base(input)
        {
            output_ = null;
        }

        public override void Review()
        {
            if (string.IsNullOrEmpty(Input)) return;

            string[] splited = Input.Split(spliters);
            string ans = "";
            int schet = 0;

            if (splited.Length == 0) return;

            foreach (string word in splited)
            {
                if (!string.IsNullOrEmpty(word) && char.IsLetter(word[0])) ans += char.ToLower(word[0]);
            }

            (char, double)[] chastota = new (char, double)[ans.Length];

            for (int i = 0; i != chastota.Length; i++) chastota[i] = (nothing, 0);

            foreach (char symbol in ans)
            {
                bool isin = false;
                for (int i = 0; i != chastota.Count(); i++)
                {
                    if (chastota[i].Item1 == symbol)
                    {
                        chastota[i] = (symbol, chastota[i].Item2 + 1);
                        isin = true;
                        break;
                    }
                }
                if (!isin)
                {
                    for (int j = 0; j != chastota.Length; j++)
                    {
                        if (chastota[j].Item1 == nothing)
                        {
                            chastota[j] = (symbol, 1);
                            schet++;
                            break;
                        }
                    }
                }
            }

            (char, double)[] result = new (char, double)[schet];
            double total = ans.Count() / 100.0;
            int cur = 0;

            foreach (var item in chastota)
            {
                if (item.Item1 != nothing) result[cur++] = (item.Item1, item.Item2 / total);
            }

            result = result.OrderByDescending(i => i.Item2).ThenBy(j => j.Item1).ToArray();
            output_ = result;
        }

        public override string ToString()
        {
            return output_ == null ? null : string.Join(Environment.NewLine, output_.Select(cortege => $"{cortege.Item1} - {cortege.Item2:F4}"));
        }
    }
}