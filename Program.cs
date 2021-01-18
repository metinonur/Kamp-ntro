using System;

namespace Kampİntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip güvenliği
            // Do not repeat yourself - Kendini tekrarlama!!!
            //değer tutucu
            // double = ondalıklı sayılar için
            //int yazarken sayının büyüklüğü çok artarsa hata verir
            //bool = ?

            string kategoriEtiketi = "Kategori";
            int ogrenciSayısı = 32000;
            double faizOranı = 1.45;
            bool sistemeGirişYapmışMı = true;
            double dolarDun = 7.45;
            double dolarBugun = 7.45;


            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış butonu göster");
            }
            else if(dolarDun<dolarBugun)
            {
                 Console.WriteLine("Artış butonu göster");
            }
           

            else
            {
                Console.WriteLine("Değişmedi butonu göster");
            }


            if (sistemeGirişYapmışMı == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap");
            }

            Console.WriteLine(kategoriEtiketi);



        }
    }
}
