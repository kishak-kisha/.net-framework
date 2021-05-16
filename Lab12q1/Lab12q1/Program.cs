using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab12q1
{
    class Program
    {
        public static void Read(string file_path)
        {
            try
            {
                using (StreamReader reader = new StreamReader(file_path))
                {
                    string content = reader.ReadToEnd();
                    Console.WriteLine(content);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        static void Main()
        {
            Console.WriteLine("Enter your file path");
            string file_path = Console.ReadLine();
            Read(file_path);
            Console.ReadLine();
        }
    }
}

          