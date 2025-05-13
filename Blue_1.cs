using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    public class Blue_1 : Blue
    {
        private string[] _output;

        public Blue_1(string input) : base(input)
        {
            Review();
        }

        public override void Review()
        {
            string[] words = Input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string currentLine = string.Empty;
            string[] lines = new string[words.Length];
            int lineCount = 0;

            foreach (string word in words)
            {
                if (currentLine.Length + word.Length + 1 > 50)
                {
                    lines[lineCount++] = currentLine.Trim();
                    currentLine = word + " ";
                }
                else
                {
                    currentLine += word + " ";
                }
            }

            if (!string.IsNullOrEmpty(currentLine))
            {
                lines[lineCount++] = currentLine.Trim();
            }

            Array.Resize(ref lines, lineCount);
            _output = lines;
        }

        public object Output => _output;

        public override string ToString()
        {
            return string.Join("\n", _output);
        }
    }
}
