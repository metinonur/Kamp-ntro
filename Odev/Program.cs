using System;

namespace Odev
{
    class Program
    {  // \n = bu kodu "" içinde alt satıra geçmek için kullan
        static void Main(string[] args) 
        
        
        {
            Product Apple = new Product();
            Apple.Name = "Apple";
            Apple.Id = 1324;
            Apple.Price = 10;
            Apple.Stock = 10000;


            Product Melon = new Product();
            Melon.Name = "Melon";
            Melon.Id = 1122;
            Melon.Price = 5;
            Melon.Stock = 665;


            Product Pear = new Product();
            Pear.Name = "Pear";
            Pear.Id = 6645;
            Pear.Price = 4;
            Pear.Stock = 4567;

            Product[] products = new Product[] {Melon,Apple,Pear };

            foreach (Product product in products)
            {
                Console.WriteLine("Add product:" + product.Name);
            }



        }      
        
    }
}
