using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9
{
    class Dict
    {
        public static Dictionary<string, string> Extension = new Dictionary<string, string>();

        public string this[string fe]
        {
            get { return Extension[fe]; }
            set
            {
                Extension[fe] = value;
            }

        }
        public static void AddDetails(string k, string v)
        {
            Extension.Add(k, v);

        }
        public static void Remove(string k)
        {
            Extension.Remove(k);
        }
        public static void DisplayAll()
        {
            foreach (var kv in Extension)
            {

                Console.WriteLine("Key=" + kv.Key + " value =" + kv.Value);
            }
        }
        static void Main()
        {
            Dict obj = new Dict();
            string ans;

            do
            {
                Console.WriteLine("1.Add");
                Console.WriteLine("2.update Value");
                Console.WriteLine("3.Display All");
                Console.WriteLine("4.Remove key value pair");
                Console.WriteLine("5.Display");
                Console.Write("enter num:");
                int ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        Console.Write("Enter Key:");
                        string k = Console.ReadLine();
                        Console.Write("Enter Value:");
                        string val = Console.ReadLine();
                        AddDetails(k, val);
                        break;
                    case 2:
                        {
                            Console.Write("Enter Key:");
                            k = Console.ReadLine();
                            if (Extension.ContainsKey(k))
                            {
                                Console.Write("Key Existed Enter value to update:");
                                val = Console.ReadLine();
                                obj[k] = val;
                                Console.WriteLine("key={0}\tnew value={1} ", k, Extension[k]);
                            }
                            else
                            {
                                Console.Write("Key Not Existed and enterd key taking as key and now Enter value to update:");
                                val = Console.ReadLine();
                                obj[k] = val;
                            }
                            //UpdateDetails(k);

                        }
                        break;
                    case 3:
                        {

                            DisplayAll();
                        }
                        break;
                    case 4:
                        {
                            Console.Write("Enter Key:");
                            k = Console.ReadLine();
                            Remove(k);

                        }
                        break;
                    case 5:
                        {
                            Console.Write("Enter Key:");
                            k = Console.ReadLine();
                            try
                            {


                                Console.WriteLine("For key = {0}, value = {1}.", k, obj[k]);
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("key Not FOund" + e);
                            }

                        }
                        break;
                }
                Console.WriteLine("Enter y/n to continue");
                ans = Console.ReadLine();
            } while (ans == "y");
        }

    }
}
