using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {

            //array = dizi = string[]
            string[] kurslar = new string[] { "Yazılım Gelişstirme Kampı",
                "2.Kurs","Java","4.Kurs","5.kurs"};
                     
            for (int  i= 0; i <kurslar.Length; i++) 
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For bitti");
            
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa sonu - footer");



        }
    }
}
