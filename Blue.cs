using System;

namespace Lab_8
{
    public abstract class Blue
    {
        private readonly string _input;

        protected Blue(string input)
        {
            _input = input;
        }

        public string Input => _input;

        public abstract void Review();
        public abstract object Output { get; }

        public override string ToString()
        {
            return Output.ToString();
        }
    }
}
