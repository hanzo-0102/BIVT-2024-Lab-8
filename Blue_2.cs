using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    public class Blue_2 : Blue
    {
        private readonly string _sequence;
        private readonly string _allowed_characters;
        private string _output;

        public Blue_2(string input, string sequence) : base(input)
        {
            _sequence = sequence;
            _allowed_characters = ".!?,:\\\";–()[]{}/";
            Review();
        }

        public override void Review()
        {
            string[] words = Input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string result = string.Empty;

            foreach (string word in words)
            {
                if (!word.Contains(_sequence, StringComparison.OrdinalIgnoreCase))
                {
                    result += word + " ";
                } else if (_allowed_characters.Contains(word[word.Length - 1]))
                {
                    result += word[word.Length - 1] + " ";
                }
            }

            _output = result.Trim();
        }

        public string Output => _output;

        public override string ToString() {
            if (Output != null)
            {
                return Output;
            } else
            {
                return string.Empty;
            }
        }
    }
}
