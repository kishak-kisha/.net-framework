using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Lab13q1nd2
{
   
     class Program
    {
        public static void Serialization()
        {
            List<Contact> contact = new List<Contact>();
            
            try
            {
                do
                {

                    Console.WriteLine("Enter ContactNo");
                    int contactNo = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Contact Name");
                    string contactName = Console.ReadLine();
                    Console.WriteLine("Enter CellNo");
                    string cellNo = Console.ReadLine();
                    contact.Add(new Contact() { ContactNo = contactNo, ContactName = contactName, CellNo = cellNo });
                    Console.ReadLine();

                } while (true);

                BinaryFormatter formatter = new BinaryFormatter();
                using (FileStream stream = new FileStream("D://emp.bat", FileMode.Create, FileAccess.Write))
                {
                    formatter.Serialize(stream, contact);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static Contact Deserialize()
        {
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();
                using (FileStream stream = new FileStream("D://emp.bat", FileMode.Open, FileAccess.Read))
                {
                    Contact contact = formatter.Deserialize(stream) as Contact;
                    return contact;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }


        public static void Main(String[] args)
        {
            Serialization();

            Contact contact = Deserialize();
            Console.WriteLine($"{contact.ContactName} {contact.ContactName} {contact.CellNo}");


        }
    }
    }

       

         

