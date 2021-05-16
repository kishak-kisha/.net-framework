using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3q1
{
   public class Participant
    {
        private int StudentId;
        private string Name;
        private static string CompanyName;
        private int FoundationMarks;
        private int WebBasicMarks;
        private int DotNetMarks;
        private double TotalMarks=300;
        private int ObtainedMarks;
        private float Percentage;

        public Participant()
        {
            Console.WriteLine(CompanyName);
        }
        static Participant()
        {
            CompanyName = "corporate university";
        }
        public Participant(int sId, string Name, int FMarks, int WBMarks, int DNMarks)
        {
            this.StudentId = sId;
            this.Name = Name;
            this.FoundationMarks = FMarks;
            this.WebBasicMarks = WBMarks;
            this.DotNetMarks = DNMarks;
        }


        public void obtainedMarks()
        {
            if ((FoundationMarks >= 0 && FoundationMarks <= 100) && (WebBasicMarks >= 0 && WebBasicMarks <= 100) && ((DotNetMarks >= 0 && DotNetMarks <= 100)))
            {
                ObtainedMarks = FoundationMarks + WebBasicMarks + DotNetMarks;
            }
            else
            {
                Console.WriteLine("Enter Marks Between 0 to 100");
                Console.ReadLine();
                Environment.Exit(0);

            }
        }
        public void percentage()
        {
            Percentage = (float)(ObtainedMarks / TotalMarks) * 100;
        }
        public float getPercentage()
        {
            return this.Percentage;
        }
    }
}
