using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Student\Desktop\number.txt";
            WriteNumbersToFile(path);

            Console.ReadKey(true);
        }

        public static void WriteNumbersToFile(string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                using (StreamWriter sw = new StreamWriter(fs, Encoding.Default))
                {
                    for (int i = 1; i <= 500; i++)
                        sw.Write($"{i}, ");
                }
            }
        }
    }
}
