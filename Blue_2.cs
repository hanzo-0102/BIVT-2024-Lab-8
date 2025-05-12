using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    public class Blue_2 : Blue
    {
        private readonly string _sequence;
        private string _output;

        public Blue_2(string input, string sequence) : base(input)
        {
            _sequence = sequence;
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
                }
            }

            _output = result.Trim();
        }

        public override object Output => _output;

        public override string ToString() => _output;
    }
}
