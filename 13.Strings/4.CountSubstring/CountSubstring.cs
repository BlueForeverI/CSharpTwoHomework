using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4.CountSubstring
{
    class CountSubstring
    {
        static void Main(string[] args)
        {
            string text =
                "We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight."
                + " So we are drinking all the day. We will move out of it in 5 days.";

            text = text.ToLower();
            string target = "in";
            int count = 0;

            for(int i = 0; i < text.Length - target.Length; i ++)
            {
                if(text.Substring(i, target.Length) == target)
                {
                    count++;
                }
            }

            Console.WriteLine("The string {0} is contained {1} times", target, count);
        }
    }
}
