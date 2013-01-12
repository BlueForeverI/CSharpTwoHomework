using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _7.CalculateExpression
{
    class CalculateExpression
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an expression: ");
            string expression = Console.ReadLine();

            try
            {
                ReversePolishNotation rpn = new ReversePolishNotation();
                rpn.Parse(expression);
                Console.WriteLine("Result: {0}", rpn.Evaluate());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
