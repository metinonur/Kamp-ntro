using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class SepetManager
    {
        public void Ekle(Product product)
        {
            Console.WriteLine("Tebrikler, Sepete eklendi : " + product.ProductsName);
        }

        public void Ekle2(Product product)

        {
            Console.WriteLine("Tebrikler, Sepete eklendi : " + product.UrunAdeti);

        }
    }
}
