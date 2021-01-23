using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {//Metin Onur
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.Id = 1;
            customer1.CustomerNo = "12345";
            customer1.Name = "Metin";
            customer1.LastName = "Onur";
            customer1.TcNo = "12345678922";


            CooporateCustomer customer2 = new CooporateCustomer();
            customer2.Id = 1;
            customer2.CustomerNo = "123455";
            customer2.CompanyName = "KodlamaİO";
            customer2.VergiNo = "12345678910";

            //Gerçek Müşteri - Tüzel Müşteri
            //SOLID L harfi bu işi söylüyo

            Customer customer3 = new IndividualCustomer();
            Customer customer4 = new CooporateCustomer();

            CustomerMenager customerMenager = new CustomerMenager();
            customerMenager.Add(customer1);
            customerMenager.Add(customer2);


        }
    }
}
