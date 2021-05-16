using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Lab7q2
{
   public class ProductDetails
    {
        ArrayList products = new ArrayList();
        public void AddProduct(Product product)
        {
            products.Add(product);
        }
        public void SortedOrder()
        {
            var prod = (from Product j in products orderby j.ProductNo select j).ToList();
            products = new ArrayList(prod);
        }
    
        public Product GetProduct(string name)
        {
            Product product = null;
            foreach (Product p in products)
            {
                if (p.Name.Equals(name))
                {
                    product = p;
                }
            }
            return product;
        }
       

        public bool DeleteProduct(int pid)
        {
            Product product = null;
            foreach (Product p in products)
            {
                if (p.ProductNo == pid)
                {
                    product = p;
                    break;
                }
            }
            if (product != null)
            {
                products.Remove(product);
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}




