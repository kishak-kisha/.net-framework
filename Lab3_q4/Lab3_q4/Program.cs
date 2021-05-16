using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_q4
{
    class Program
    {
   static void Main(string[] args)
        {
            Student s = new Student();
            SetDetails(s);
            GetDetails(s);
            Console.ReadLine();

        }
        static void SetDetails(Student s1)
        {
            Console.Write("Enter Roll Number Of Student : ");
            s1.RollNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Name Of Student : ");
            s1.StudentName = Console.ReadLine();
            Console.Write("Enter Age Of Student : ");
            s1.Age = Convert.ToByte(Console.ReadLine());
            Console.Write("Enter Gender Of Student : ");
            s1.Gender = Convert.ToChar(Console.ReadLine());
            Console.Write("Enter Date Of Birth Of Student : ");
            s1.DateOfBirth = DateTime.Parse(Console.ReadLine());
            Console.Write("Enter Address Of Student : ");
            s1.Address = Console.ReadLine();
            Console.Write("Enter Percentage Of Student : ");
            s1.Percentage = float.Parse(Console.ReadLine());
        }
        static void GetDetails(Student s1)
        {
            Console.WriteLine("******************Student Details***********************");
            Console.WriteLine("Roll Number :- " + s1.RollNumber);
            Console.WriteLine("Name  :- " + s1.StudentName);
            Console.WriteLine("Age :- " + s1.Age);
            Console.WriteLine("Gender :- " + s1.Gender);
            Console.WriteLine("Date Of Birth :- " + s1.DateOfBirth);
            Console.WriteLine("Address :- " + s1.Address);
            Console.WriteLine("Percentage :- " + s1.Percentage);
        }
    }
}
