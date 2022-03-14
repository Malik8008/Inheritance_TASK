using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Task
{
    internal class NewsPaper : Product
    {
        public string Advertisement;
        public string Article;


        public NewsPaper(string advertisement, string article, int price, string releasedate, int count):base(price,releasedate,count)
        {
            Advertisement = advertisement;
            Article = article;
           
        }
    }
}
