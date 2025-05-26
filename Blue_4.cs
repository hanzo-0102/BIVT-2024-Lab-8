using Lab_8;
using System;

namespace Lab_8
{
    public class Blue_4 : Blue
    {
        private int output_;

        public int Output
        {
            get { 
                return output_;
            }
            private set { 
                output_ = value; 
            }
        }

        public Blue_4(string input) : base(input)
        {
            output_ = 0;
        }

        public override void Review()
        {
            if (Input == null)
            {
                output_ = 0;
                return;
            }

            int cur = 0;
            int ans = 0;
            bool isnum = false;
            string numbers = "0123456789";

            for (int i = 0; i != Input.Length; i++)
            {
                char c = Input[i];

                int toadd = -1;

                if (numbers.Contains(c))
                {
                    toadd = (c - '0');
                }

                if (toadd == -1)
                {
                    ans += cur;
                    cur = 0;
                } else
                {
                    cur *= 10;
                    cur += toadd;
                }
            }

            ans += cur != 0 ? cur : 0;
            Output = ans;
        }

        public override string ToString()
        {
            return Output.ToString();
        }
    }

}