using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    public class Blue_3 : Blue
    {
        private (char, double)[] _output;

        public Blue_3(string input) : base(input)
        {
            Review();
        }

        public override void Review()
        {
            string[] words = Input.Split(new[] { ' ', '.', '!', '?', ',', ':', '\"', ';', '–', '(', ')', '[', ']', '{', '}', '/' }, StringSplitOptions.RemoveEmptyEntries);
            int totalWords = words.Length;
            int[] letterCounts = new int[26];

            foreach (string word in words)
            {
                if (word.Length > 0)
                {
                    char firstChar = char.ToLower(word[0]);
                    if (firstChar >= 'a' && firstChar <= 'z')
                    {
                        letterCounts[firstChar - 'a']++;
                    }
                }
            }

            _output = new (char, double)[26];
            for (int i = 0; i < 26; i++)
            {
                if (totalWords > 0)
                {
                    double percentage = (double)letterCounts[i] / totalWords * 100;
                    _output[i] = ((char)(i + 'a'), Math.Round(percentage, 4));
                }
            }

            Array.Sort(_output, (x, y) => y.Item2.CompareTo(x.Item2));
        }

        public (char, double)[] Output => _output;

        public override string ToString()
        {
            string result = string.Empty;
            foreach (var item in _output)
            {
                if (item.Item2 > 0)
                {
                    result += $"{item.Item1}-{item.Item2}\n";
                }
            }
            return result.TrimEnd('\n');
        }
    }
}
