using System;

namespace MethodExercise
{
  
    internal class Program
    { static int AddSum(int num1, int num2) { return num1 + num2; } 
        static double Multiply(int num1, int num2) { return num1 * num2; }
        static int Divide(int num1, int num2) { return num1 / num2; }
        static int Subtract(int num1, int num2) { return num1 - num2; }
        static int Mod(int num1, int num2) { return num1 % num2; }
        static void Main(string[] args)
        {
           Console.WriteLine($"Our lucky number should always { AddSum(3, 4)}");
           Console.WriteLine($"If you multiply our lucky number which is {AddSum(3, 4)} by itself you get {Multiply(7, 7)}");
            Console.WriteLine($"Lets go back to our lucky number {Divide(49,7)}");
            Console.WriteLine($"Well any number is ok even {Subtract(7, 7)}, they are all important.");
            Console.WriteLine($"7 goes into 49 evenly, when you divide it the remainder is {Mod(49,7)}");
            Console.WriteLine(" Enough about the number 7, lets learn about you!");
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
            // Exercise 2
            

        }
    }
}
