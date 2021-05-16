using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8q1
{
    class Program
    {
        static void Main(string[] args)
        { 
        Rtoinfo rtoinfo = new Rtoinfo();

            do
            {
                Console.WriteLine("RTO Districts Application");
                Console.WriteLine("1.Add Record in Hashtable");
                Console.WriteLine("2.Search Record");
                Console.WriteLine("3.Display All Records");
                Console.WriteLine("4.Total Count");
                Console.WriteLine("5.Remove any particular Record");
                Console.Write("Enter your choice:");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                        {
                            Console.WriteLine("Enter District Number");
                            string districtno = Console.ReadLine();
                            Console.WriteLine("Enter District Name");
                            string district = Console.ReadLine();
                            rtoinfo.AddRecord(districtno, district);
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Enter DIstrict Number");
                            string d = Console.ReadLine();
                            rtoinfo.SearchRecord(d);

                            break;
                        }
                    case 3:
                        {
                            rtoinfo.DisplayAllRecords();
                            break;
                        }
                    case 4:
                        {
                            int noOfRecords = rtoinfo.DisplayCount();
                            Console.WriteLine("Total Records:" + noOfRecords);
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("enter DistrictNO");
                            string districtn = Console.ReadLine();
                            rtoinfo.DeleteRecord(districtn);
                            break;
                        }
                  
                }

}
        while (true) ;
        }
    }
}
