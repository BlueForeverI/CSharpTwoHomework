using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _7.EncodeDecodeString
{
    class EncodeDecodeString
    {
        static string EncodeDecode(string input, string key)
        {
            StringBuilder sb = new StringBuilder();

            int keyIndex = 0;
            for(int i = 0; i < input.Length; i ++)
            {
                if(keyIndex == key.Length)
                {
                    keyIndex = 0;
                }

                sb.Append((char)(input[i] ^ key[keyIndex]));
                keyIndex++;
            }

            return sb.ToString();
        }

        static void Main(string[] args)
        {
            string input = "Hello world!";
            string key = "key";

            Console.WriteLine("Input: {0}, key: {1}", input, key);
            string encoded = EncodeDecode(input, key);
            Console.WriteLine("Encoded: {0}", encoded);
            string decoded = EncodeDecode(encoded, key);
            Console.WriteLine("Decoded: {0}", decoded);
        }
    }
}
