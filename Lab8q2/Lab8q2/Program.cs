using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Lab8q2
{
    class Program
    {
        static void Main()
        {

            Hashtable hs = GetHashtable();
            bool task1 = hs.Contains("Perimeter");
            if (task1)
            {
                Console.WriteLine("Found Perimeter");
            }
            object n = hs["Area"];
            Console.WriteLine("Indexer of Area is" + (int)n);
            hs.Remove("Mortgage");
            foreach (DictionaryEntry h in hs)
            {
                Console.WriteLine($"{h.Key}{h.Value}");
            }
            Console.ReadLine();
        }
        static Hashtable GetHashtable()
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add("Area", 1000);
            hashtable.Add("Perimeter", 55);
            hashtable.Add("Mortgage", 540);
            return hashtable;
        }
    }

        }
  
