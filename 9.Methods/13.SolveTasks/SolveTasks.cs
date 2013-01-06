using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _13.SolveTasks
{
    class SolveTasks
    {
        static string ReverseDigits(int number)
        {
            return new string(number.ToString().Reverse().ToArray());
        }

        static double CalculateAverage(int[] sequence)
        {
            return (double)sequence.Sum()/sequence.Length;
        }

        static double SolveEquation(int a, int b)
        {
            return (double) (-b)/a;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("You have the following chouces:");
            Console.WriteLine("1) Reverse the digits of a number;");
            Console.WriteLine("2) Calculate the average of a sequence of integers;");
            Console.WriteLine("3) Solve a linear equation a*x + b = 0;");
            Console.Write("Enter your choice: ");

            int choice = 0;
            if(!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid input format!");
            }

            switch (choice)
            {
                case 1:
                    Console.Write("Enter a number: ");
                    int n = int.Parse(Console.ReadLine());
                    if(n < 0)
                    {
                        Console.WriteLine("The number should be non-negative!");
                        break;
                    }

                    Console.WriteLine("Reversed digits: {0}", ReverseDigits(n));
                    break;

                case 2:
                    Console.Write("Enter the sequence size: ");
                    int size = int.Parse(Console.ReadLine());

                    if(size <= 0)
                    {
                        Console.WriteLine("The sequence should not be empty!");
                        break;
                    }

                    int[] sequence = new int[size];

                    for(int i = 0; i < size; i ++)
                    {
                        Console.Write("enter element {0}: ", i);
                        sequence[i] = int.Parse(Console.ReadLine());
                    }

                    Console.WriteLine("The average is {0}", CalculateAverage(sequence));
                    break;

                case 3:
                    Console.Write("Enter a: ");
                    int a = int.Parse(Console.ReadLine());
                    if(a == 0)
                    {
                        Console.WriteLine("a should not be 0!");
                        break;
                    }

                    Console.Write("Enter b: ");
                    int b = int.Parse(Console.ReadLine());
                    Console.WriteLine("x = {0}", SolveEquation(a, b));
                    break;
            }
        }
    }
}
