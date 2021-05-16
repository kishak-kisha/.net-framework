using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7q2
{
    class Product
    {
        private int productNo;
        private string name;
        private int rate;
        private int stock;

        public int ProductNo { get => productNo; set => productNo = value; }
        public string Name { get => name; set => name = value; }
        public int Rate { get => rate; set => rate = value; }
        public int Stock { get => stock; set => stock = value; }
    }
}

