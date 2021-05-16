using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace Lab8q1
{
    class Rtoinfo
    {
        Rto rto = new Rto();
        Hashtable hashtable = new Hashtable();
        public void DeleteRecord(string districtno)
        {
            hashtable.Remove(districtno);
        }
        public void AddRecord(string districtno, string district)
        {
            hashtable.Add(districtno, district);
        }
        public void DisplayAllRecords()
        {
            foreach (DictionaryEntry h in hashtable)
            {
                Console.WriteLine(h.Key);
                Console.WriteLine(h.Value);
            }

        }
        public int DisplayCount()
        {
            return hashtable.Count;
        }
        public void SearchRecord(string districtno)
        {
            if (hashtable.ContainsKey(districtno))
            {
                Console.WriteLine(hashtable[districtno]);
            }
        }
    }
}