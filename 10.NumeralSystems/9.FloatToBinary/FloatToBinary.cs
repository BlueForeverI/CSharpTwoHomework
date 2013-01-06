using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _9.FloatToBinary
{
    class FloatToBinary
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a floating-point number: ");
            float num = float.Parse(Console.ReadLine());

            byte[] raw = BitConverter.GetBytes(num);
            StringBuilder sb = new StringBuilder();
            foreach (var b in raw)
            {
                string bin = Convert.ToString(b, 2);
                bin = new string('0', 8 - bin.Length) + bin;
                sb.Append(bin);
            }

            string binary = sb.ToString();
            string mantissa = new string(binary.Substring(0, 23).Reverse().ToArray());
            string exponent = new string(binary.Substring(24, 8).Reverse().ToArray());
            char sign = binary[31];

            Console.WriteLine("sign = {0}, exponent = {1}, mantissa = {2}",
                sign, exponent, mantissa);
        }
    }
}
