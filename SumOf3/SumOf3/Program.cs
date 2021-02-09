using System;
/** Michael Brickey**/
namespace SumOf3 
{
    class Program
    {
        static void Main(string[] args)                     //Michael Brickey
        {
          
           const double MAGIC_NUMBER = 7.777; //local constant variable

            Console.WriteLine("Please enter the first number >>");
            string answer = Console.ReadLine();
            double number1 = Convert.ToDouble(answer);

            Console.WriteLine("Please enter the second number >>");
            answer = Console.ReadLine();
            double number2 = Convert.ToDouble(answer);

            Console.WriteLine("Please enter the third number >>");
            answer = Console.ReadLine();
            double number3 = Convert.ToDouble(answer);

            double sum = number1 + number2 + number3;

           Console.WriteLine($"{number1} + {number2} + {number3} = {sum.ToString("N3")}");

            double magicnumbertimessum = sum * MAGIC_NUMBER;

            Console.WriteLine($"Your sum multiplied by our magic number is {magicnumbertimessum.ToString("N3")}");


        }
    }
}
