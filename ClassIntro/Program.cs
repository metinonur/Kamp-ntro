using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Metin";
            int yas = 18;

            Kurs Kurs1 = new Kurs();
            Kurs1.KursAdi = "C#";
            Kurs1.Egitmen = "Metin ONUR";
            Kurs1.IzlenmeOrani = 1000;

            Kurs Kurs2 = new Kurs();
            Kurs2.KursAdi = "Java";
            Kurs2.Egitmen = "Engin DEMİROĞ";
            Kurs2.IzlenmeOrani = 900;

            Kurs Kurs3 = new Kurs();
            Kurs3.KursAdi = "css";
            Kurs3.Egitmen = "Öykü YETER";
            Kurs3.IzlenmeOrani = 19500;

            // Console.WriteLine(Kurs1.KursAdi + " : " + Kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[] { Kurs1, Kurs2, Kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen + " : " + kurs.IzlenmeOrani);
            }

        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
