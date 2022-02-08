using System;

namespace User_Input
{
    class Program
    {
        static void Main(string[] args)
        {
            //string input = Console.ReadLine();
            //Console.WriteLine(input);
            //Console.Read();

            Console.WriteLine("Welcome to the basic calculator!");
            Console.WriteLine("Please enter the first number you would like to add: ");
            string input1= Console.ReadLine();
            Console.WriteLine("Please enter the second number you would like added to the first: ");
            string input2 = Console.ReadLine();

            int result = Calculate(input1, input2);
            Console.WriteLine($"{input1} + {input2} = {result}");
            Console.Read();
        }

        public static int Calculate(string input1, string input2)
        {
            int addition = int.Parse(input1) + int.Parse(input2);
            return addition;
        }
    }
}
