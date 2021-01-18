using System;

namespace Odev
{
    class Program
    {  // \n = bu kodu "" içinde alt satıra geçmek için kullan
        static void Main(string[] args) 
        
        
        {
            Person Metin = new Person();
            Metin.Name = "Metin";
            Metin.LastName = "ONUR";
            Metin.Age = 18;
            Metin.Weight = 71;

            Person Recep = new Person();
            Recep.Name = "Recep Ali";
            Recep.LastName = "GÖKMEN";
            Recep.Age = 20;
            Recep.Weight = 78;


            Person Mali = new Person();
            Mali.Name = "Mali";
            Mali.LastName = "TÜZÜN";
            Mali.Age = 19;
            Mali.Weight = 75;

            Person Alp = new Person();
            Alp.Name = "Alp";
            Alp.LastName = "AKIŞ";
            Alp.Age = 19;
            Alp.Weight = 70;


            Person[] Persons = new Person[] { Metin, Mali, Recep, Alp};

            foreach (var Person in Persons)
            {
                Console.WriteLine($"Name: {Person.Name }\n------------------- \nLast Name: {Person.LastName}\n------------------- \nAge: {Person.Age}\n------------------- \nWeight: {Person.Weight}\n-------------------");
            }

            Console.WriteLine("------------------------Definition is over------------------------");


            Console.WriteLine("--_--" +
                "\n--_--");





        }
        






            class Person
               {
            public string Name { get; set; }
            public string  LastName { get; set; }
            public int Age { get; set; }
            public int Weight { get; set; }
             }
        
    }
}
