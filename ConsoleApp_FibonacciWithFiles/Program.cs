using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using static ConsoleApp_FibonacciWithFiles.Fibanacci;

namespace ConsoleApp_FibonacciWithFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> reversedLines = new List<string>();
            Console.WriteLine("Вместо слеша пишите \\");
            Console.WriteLine("Напишите путь исходного файла");
            string inputPath = Console.ReadLine();
            Console.WriteLine("Напишите путь выходной файла");
            string outputPath = Console.ReadLine();

            try
            {
                using (var inputFile = new StreamReader(inputPath))
                {
                    while (!inputFile.EndOfStream)
                    {
                        string lineFile = inputFile.ReadLine();
                        if (IsFibanacci(NumberFromString(lineFile)))
                        {
                            reversedLines.Add(ReverseString(lineFile));
                        }
                    }
                }
                using (var outputFile = new StreamWriter(outputPath, true))
                {
                    foreach (var line in reversedLines)
                    {
                        outputFile.WriteLine(line);
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Неправильный путь к файлу");
                Environment.Exit(0);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Неправильный путь к файлу");
                Environment.Exit(0);
            }
            catch (UnauthorizedAccessException) 
            {
                Console.WriteLine("Неправильный путь к файлу");
                Environment.Exit(0);
            }
            ViewInputFile(inputPath);
            ViewInputFile(outputPath);
            Console.WriteLine("Done!");
            Console.ReadLine();
        }
    }
}
