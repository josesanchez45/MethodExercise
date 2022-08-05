using System;

namespace MethodExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //exercise 1
            Console.WriteLine("What is your name?");
            string name= Console.ReadLine();
            Console.WriteLine($"Hello, {name}.");
            Console.WriteLine("What is your favorite color?");
            string color= Console.ReadLine();
            Console.WriteLine($"Got it! Your favorite color is {color}!");
            Console.WriteLine("What is your favorite animal?");
            string animal= Console.ReadLine();
            Console.WriteLine("What is your favorite band?");
            string band= Console.ReadLine();
            Console.WriteLine($"What if {band} was actually a bunch of {animal}'s playing music? Funny!");

        }
    }
}
