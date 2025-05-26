using Lab_8;
using System;
using System.Diagnostics.CodeAnalysis;

namespace Lab_8
{

    public class Blue_2 : Blue
    {
        private string _erase;
        private string output_;
        public string Output => output_;

        public Blue_2(string input, string to_delete) : base(input)
        {
            _erase = to_delete;
            output_ = null;
        }

        public override void Review()
        {
            if (string.IsNullOrEmpty(Input) || string.IsNullOrEmpty(_erase))
            {
                output_ = null;
                return;
            }
            string ans = "";
            string[] splited = Input.Split(' ');
            string temp = Input;
            foreach (string word in splited)
            {
                if (word.Contains(_erase))
                {
                    if (word.Any(sym => (sym == '.' || sym == ',' || sym == ';')))
                    {
                        char[] charki = word.ToCharArray();
                        ans = word.Contains("\"") ? temp.Replace(word + " ", "\"\"" + charki[charki.Length - 1] + " ") : temp.Replace(" " + word, "" + charki[charki.Length - 1]);
                        temp = ans;
                    }
                    else
                    {
                        ans = temp.Replace(word + " ", "");
                        temp = ans;
                    }
                }
            }
            temp = temp.Replace("  ", "");
            output_ = temp.Trim();
        }

        public override string ToString() => string.IsNullOrEmpty(output_) ? string.Empty : output_;
    }
}
