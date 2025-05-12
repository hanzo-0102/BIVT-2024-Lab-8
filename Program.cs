using System;

namespace Lab_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing Blue_1:");
            Blue_1 blue1 = new Blue_1("This is a sample text that will be split into lines of no more than fifty characters.");
            Console.WriteLine(blue1.ToString());
            Console.WriteLine();

            Console.WriteLine("Testing Blue_2:");
            Blue_2 blue2 = new Blue_2("This is a test sentence with some test words.", "test");
            Console.WriteLine(blue2.ToString());
            Console.WriteLine();

            Console.WriteLine("Testing Blue_3:");
            Blue_3 blue3 = new Blue_3("Apple banana apricot orange apple apricot.");
            Console.WriteLine(blue3.ToString());
            Console.WriteLine();

            Console.WriteLine("Testing Blue_4:");
            Blue_4 blue4 = new Blue_4("The numbers are 10, 20, and 30. The total is 60.");
            Console.WriteLine(blue4.ToString());
            Console.WriteLine();
        }
    }
}
