using System.Diagnostics;

namespace MethodsExercise
{
    internal static class Program
    {
        static void Main(string[] args)
        {

            //Exercise 1

            //Console.WriteLine("What is your name?");
            //string name = Console.ReadLine();

            //break

            //Console.WriteLine("What is your favorite color");
            //string color = Console.ReadLine();

            //break

            //Console.WriteLine("What is your favorite animal");
           // string animal = Console.ReadLine();

            //break

            //Console.WriteLine("What is your favorite band");
            //string band = Console.ReadLine();

            //break

            //Console.WriteLine($"{name} dyed his hair {color} because he was going to an {band} show. He took Bob, his {animal} to the show as well");


            Console.WriteLine("Input a number to add");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Input a number to add to the first one");
            int num2 = int.Parse(Console.ReadLine());
                
            int sum = Sum(num1, num2);

            Console.WriteLine($"The sum is {sum}");
            //break


            Console.WriteLine("Input a number to multiply");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Input another number to multiply");
            int y = int.Parse(Console.ReadLine());

            int total = Multiply(x, y);

            Console.WriteLine($"The total is {total}");

            //call methods here

            Sum(num1, num2);

            Multiply(x, y);
    


        }

        public static int Sum(int num1, int num2)
        {
            int sum = num1 + num2;

            return sum; 
        }

        public static int Multiply(int x, int y)
        {
            int total = x * y;
            return total;
        }
    }

}
