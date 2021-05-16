using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3q1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Student Id:");
            int sid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Foundation Marks:");
            int FoundationMarks = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Web Basic Marks:");
            int WebBasicMarks = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Dot Net Marks:");
            int DotnetMarks = Convert.ToInt32(Console.ReadLine());
            Participant p = new Participant(sid, name, FoundationMarks, WebBasicMarks, DotnetMarks);
            p.obtainedMarks();
            p.percentage();
            Console.WriteLine("percentage== " + p.getPercentage());
            Console.ReadLine();
        }
    }
}