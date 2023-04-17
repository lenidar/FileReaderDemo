using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileReaderDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line = "";
            using (StreamReader sr  = new StreamReader("sample3.sectionA"))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    //Console.WriteLine(line);
                    foreach(char l in line)
                    {
                        Console.Write((int)l + "\t");
                    }
                    Console.WriteLine();
                }
            }
            Console.ReadKey();
        }
    }
}
