using System;
using System.IO;
using System.Text.RegularExpressions;

namespace _03._Word_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputFilePath = @"..\..\..\Files\input.txt";
            string otputFilePath = @"..\..\..\Files\output.txt";

            WordCount(inputFilePath, otputFilePath);
        }

        private static void WordCount(string inputFilePath, string ouputFilePath)
        {
            using (StreamWriter writer = new StreamWriter(ouputFilePath))
            {
                using (StreamReader reader = new StreamReader(inputFilePath))

                {
                    

                }
            
            }
        }
    }
}
