using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya Elması";

            

            Product elma = new Product();
            elma.ProductsName = "Elma";
            elma.Price = 15;
            elma.Description = "Amasya elması";
            elma.UrunAdeti = 10;

            Product çilek = new Product();
            çilek.ProductsName = "Çilek";
            çilek.Price = 10;
            çilek.Description = "Çilek gibi çilek";
            çilek.UrunAdeti = 15;

            Product karpuz = new Product();
            karpuz.ProductsName = "Karpuz";
            karpuz.Price = 80;
            karpuz.Description = "Diyarbaır karpuzu";
            karpuz.UrunAdeti = 8;

            Product[] products = new Product[] {elma, çilek , karpuz};

            foreach (Product product in products)
            {
                Console.WriteLine("Product Name: "+product.ProductsName+" Price: "+ product.Price +" Description :"+product.Description);
            }


            Console.WriteLine("---------------------Methotds------------------------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(çilek);
            sepetManager.Ekle(karpuz);


            sepetManager.Ekle2(karpuz);
            sepetManager.Ekle2(elma);
           









        }
    }
}



// Dont repeat yourself - Clean Code - Best Practice