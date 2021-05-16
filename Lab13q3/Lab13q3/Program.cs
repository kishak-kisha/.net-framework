using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Soap;
using System.IO;
using System.Collections;

namespace Lab13q3
{
    class Program
    {
        static ArrayList contacts = new ArrayList();
        public static void Serialization()
        {
            try
            {

                SoapFormatter formatter = new SoapFormatter();
                using (FileStream stream = new FileStream(@"E:/lab13.xml", FileMode.Create, FileAccess.Write))
                {
                    formatter.Serialize(stream, contacts);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static ArrayList Deserialize()
        {
            try
            {
                SoapFormatter formatter = new SoapFormatter();
                using (FileStream stream = new FileStream("D:/lab13.xml", FileMode.Open, FileAccess.Read))
                {
                    ArrayList contactdesserializable = formatter.Deserialize(stream) as ArrayList;
                    return contactdesserializable;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;

            }
        }

        static void Main(string[] args)
        {
            //List<Contact> contacts = new List<Contact>();
            Console.WriteLine("Enter no of contacts to add");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= n - 1; i++)
            {
                Contact c = GetDetails();
                contacts.Add(c);

            }
            Serialization();
            ArrayList cont = Deserialize();
            foreach (Contact c in cont)
            {
                Console.WriteLine(c.ContactNo + "\t" + c.ContactName + "\t" + c.CellNo);
            }
            Console.ReadLine();

        }
        private static Contact GetDetails()
        {
            Contact contact = new Contact();
            Console.WriteLine("Enter Contact Details");
            Console.WriteLine("Enter ContactNo");
            contact.ContactNo = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Contact Name");
            contact.ContactName = Console.ReadLine();
            Console.WriteLine("Enter CellNo");
            contact.CellNo = Console.ReadLine();

            return contact;

        }
    }
}


