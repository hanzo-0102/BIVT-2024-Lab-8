using System;

namespace Lab_8
{
    public class Blue_1 : Blue
    {
        private string[] _output;

        public string[] Output
        {
            get
            {
                if (_output == null) return null;
                string[] copy = new string[_output.Length];
                Array.Copy(_output, copy, _output.Length);
                return copy;
            }
        }

        public Blue_1(string input) : base(input) { }

        public override void Review()
        {
            if (string.IsNullOrWhiteSpace(Input))
            {
                _output = null;
                return;
            }

            string[] words = SplitInputIntoWords(Input);
            _output = FormatWordsIntoLines(words);
        }

        private string[] SplitInputIntoWords(string input)
        {
            char[] delimiters = new char[] { ' ' };
            return input.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
        }

        private string[] FormatWordsIntoLines(string[] words)
        {
            string curline = string.Empty;
            string[] lines = new string[words.Length];
            int lineCount = 0;

            foreach (var word in words)
            {
                if (word.Length > 50)
                {
                    if (!string.IsNullOrEmpty(curline))
                    {
                        lines[lineCount++] = curline;
                        curline = string.Empty;
                    }
                    lines[lineCount++] = word;
                }
                else
                {
                    String spacer = String.Empty;
                    if (curline.Length > 0)
                    {
                        spacer = " ";
                    }
                    if (curline.Length + spacer.Length + word.Length <= 50)
                    {
                        curline += spacer + word;
                    }
                    else
                    {
                        if (!string.IsNullOrEmpty(curline))
                        {
                            lines[lineCount++] = curline;
                        }
                        curline = word;
                    }
                }
            }

            if (!string.IsNullOrEmpty(curline))
            {
                lines[lineCount++] = curline;
            }

            Array.Resize(ref lines, lineCount);
            return lines;
        }

        public override string ToString()
        {
            return _output == null ? string.Empty : string.Join(Environment.NewLine, _output);
        }
    }
}
