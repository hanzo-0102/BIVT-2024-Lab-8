using Lab_8;
using System;

namespace Lab_8
{
    public class Blue_1 : Blue
    {
        private string[] output_;
        public string[] Output
        {
            get
            {
                if (output_ == null) return null;
                string[] answer = new string[output_.Length];
                for (int i = 0; i != output_.Length; i++)
                {
                    answer[i] = output_[i];
                }
                return answer;
            }
        }


        public Blue_1(string input) : base(input)
        {
            output_ = null;
        }


        public override void Review()
        {
            if (string.IsNullOrEmpty(Input))
            {
                output_ = null;
                return;
            }

            string[] Splited = Input.Split(' ');
            string[] result = new string[0];
            string strings = "";
            
            int i = 0;

            while (i < Splited.Length)
            {
                string cur = string.Empty;
                if (strings.Length > 0)
                {
                    cur = strings + " " + Splited[i];
                }
                else
                {
                    cur = Splited[i];
                }
                if (cur.Length > 50)
                {

                    string[] newresult = new string[result.Length + 1];
                    for (int j = 0; j != result.Length; j++)
                    {
                        newresult[j] = result[j];
                    }
                    newresult[result.Length] = strings;
                    result = newresult;
                    strings = "";
                }
                else
                {
                    strings = cur;
                    i++;
                }

            }
            if (strings.Length > 0)
            {
                string[] newresult = new string[result.Length + 1];
                for (int j = 0; j != result.Length; j++)
                {
                    newresult[j] = result[j];
                }
                newresult[result.Length] = strings;
                result = newresult;
                strings = "";
            }
            output_ = result;
        }
        public override string ToString()
        {
            if (String.IsNullOrEmpty(this.Input) || output_ == null)
            {
                return null;
            }
            else
            {
                return string.Join(Environment.NewLine, output_);
            }
        }
    }
}