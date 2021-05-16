using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace Lab13q4
{
    class Program
    {
        public static void Serialization() //serialize list of employees
        {
            try
            {
                Supplier supplier = new Supplier() { sID = 1, sName = "Raghu", city = "Delhi", phoneNo = 9658742310, email = "rg@gmail.com" };
                Supplier supplier1 = new Supplier() { sID = 2, sName = "Ram", city = "Mumbai", phoneNo = 8796541230, email = "rm@gmail.com" };
                Supplier supplier2 = new Supplier() { sID = 3, sName = "Rohan", city = "Kolkata", phoneNo = 7598463210, email = "rh@gmail.com" };
                List<Supplier> suppliers = new List<Supplier>() { supplier, supplier1, supplier2 };
                XmlSerializer serializer = new XmlSerializer(typeof(List<Supplier>));
                using (FileStream stream = new FileStream("D://sup.xml", FileMode.Create, FileAccess.Write))
                {
                    serializer.Serialize(stream, suppliers);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static List<Supplier> Deserialize()
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Supplier>));
                using (FileStream stream = new FileStream("D://sup.xml", FileMode.Open, FileAccess.Read))
                {
                    List<Supplier> suppliers = serializer.Deserialize(stream) as List<Supplier>;
                    return suppliers;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }
        public static void Main()
        {
            Serialization();
            List<Supplier> suppliers = Deserialize();
            foreach (Supplier supplier in suppliers)
                Console.WriteLine($"{supplier.sID} {supplier.sName} {supplier.city} {supplier.phoneNo} {supplier.email}");
            Console.ReadKey();
        }
    }
}
