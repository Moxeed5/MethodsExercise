namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            //break

            Console.WriteLine("What is your favorite color");
            string color = Console.ReadLine();

            //break

            Console.WriteLine("What is your favorite animal");
            string animal = Console.ReadLine();

            //break

            Console.WriteLine("What is your favorite band");
            string band = Console.ReadLine();

            Console.WriteLine($"{name} dyed his hair {color} because he was going to an {band} show. He took Bob, his {animal} to the show as well");

        }
    }
}
