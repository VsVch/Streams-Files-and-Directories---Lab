

namespace _01._Odd_Lines
{
    using System;
    using System.IO;

    public class OddLines
    {
        

        static void Main()
        {
            string inputPath = @"..\..\..\Files\input.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            ExtrctOddLines(inputPath, outputPath);

        }
        public static void ExtrctOddLines(string inputFilePath, string outputFilePath)
        {
            using (StreamWriter writer = new StreamWriter(outputFilePath))
            {
                using (StreamReader reader = new StreamReader(inputFilePath))
                {
                    int index = 0;
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        if (index %2 == 0)
                        {
                            writer.WriteLine($"{line}");
                            
                           
                        }
                        line = reader.ReadLine();
                        index++;
                    }
                }
            }

        }
    }
}
