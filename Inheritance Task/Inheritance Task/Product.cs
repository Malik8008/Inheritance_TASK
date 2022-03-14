using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Task
{
    internal class Product
    {
        public int Price;
        public string ReleasteDate;
        public int Count;

        public Product(int price, string releasedate, int count)
        {
            Price = price;
            ReleasteDate = releasedate;
            Count = count;
        }

        public void Sell()
        {
            if (Count >= 1)
            {                
                    Count--;
                    Console.WriteLine(Count);                                                   
            }
            else
            {
                Console.WriteLine("Satis prosesi heyata kecmedi!");                
            }
        }
    }
}
