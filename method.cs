using System;
using Internal;

class Test
{

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Suma());
            Console.Read();

        }

        public static int Suma()
        {
            Console.WriteLine("Write the first number");
            string input1 = Console.ReadLine();

            Console.WriteLine("Write the second number");
            string input2 = Console.ReadLine();

            int num1 = Int32.Parse(input1);
            int num2 = int.Parse(input2);

            int res = num1 + num2;
            return res;
        }

    }


}
 