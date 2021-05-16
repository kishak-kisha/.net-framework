using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab12
{
    [Serializable]
    public class Contact
    {
        public int ContactNo { get ; set ; }
        public string ContactName { get ; set ; }
        public string CellNo { get ; set ; }
    }
}