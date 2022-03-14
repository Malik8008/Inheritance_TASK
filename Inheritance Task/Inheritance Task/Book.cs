using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Task
{
    internal class Book:Product
    {
        public string Author;
        public string Genre;

        public Book(string author, string genre, int price, string releasedate, int count):base(price, releasedate, count)
        {
            Author = author;
            Genre = genre;                  
        }
    }
}
