using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    public class Blue_4 : Blue
    {
        private int _output;

        public Blue_4(string input) : base(input)
        {
            Review();
        }

        public override void Review()
        {
            string[] tokens = Input.Split(new[] { ' ', '.', '!', '?', ',', ':', '\"', ';', '–', '(', ')', '[', ']', '{', '}', '/' }, StringSplitOptions.RemoveEmptyEntries);
            _output = 0;

            foreach (string token in tokens)
            {
                if (int.TryParse(token, out int number))
                {
                    _output += number;
                }
            }
        }

        public object Output => _output;

        public override string ToString() => _output.ToString();
    }
}
