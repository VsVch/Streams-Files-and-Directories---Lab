using System;
using System.IO;

namespace _02._Line_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputFilePath = @"..\..\..\Files\input.txt";
            string outputFilePath = @"..\..\..\Files\output.txt";

            RewriwriteFileWithNumbers(inputFilePath, outputFilePath);
        }

        private static void RewriwriteFileWithNumbers(string inputFilePath, string outputFilePath)
        {
            using (StreamWriter writer = new StreamWriter(outputFilePath))
            {
                using (StreamReader reader = new StreamReader(inputFilePath))
                {
                    int index = 0;
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        
                         writer.WriteLine($"{index + 1}. {line}");
                        line = reader.ReadLine();
                        index++;
                    }
                }
            }
        }
    }
}
