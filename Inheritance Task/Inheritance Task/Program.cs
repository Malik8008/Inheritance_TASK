using System;

namespace Inheritance_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product(24, "12.05.1995" ,5);            
            product.Sell();

            Book book = new Book("F.M Dostoyevski","Psychological Fiction",120,"15.02.1866",0);
            //Console.WriteLine(book.Genre);
            book.Sell();


            NewsPaper newspaper = new NewsPaper("Big Mac","Food",250000,"1967",500);
            Console.WriteLine(newspaper.Advertisement);
            //newspaper.Sell();
        }
    }
}
