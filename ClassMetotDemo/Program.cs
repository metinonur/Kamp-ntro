using System;

namespace ClassMetotDemo
{
    class Program
    {
       

        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            
            customer1.CustomerName = "Metin Onur";
            customer1.CustomerNo =10;
            customer1.Id = 999999;
            


            Customer customer2 = new Customer();
            customer2.CustomerName = "Engin";
            customer2.CustomerLastName = "Demiroğ";
            customer2.CustomerNo = 1;
            customer2.Id =135468;

            Customer customer3 = new Customer();
            customer3.CustomerName = "Recep Ali";
            customer3.CustomerLastName = "Tüzün";
            customer3.CustomerNo = 11;
            customer3.Id = 123654;

            Customer customer4 = new Customer();
            customer4.CustomerName = "Mehmet Ali";
            customer4.CustomerLastName = "Gökmen";
            customer4.CustomerNo = 12;
            customer4.Id = 987456;

            Customer[] customers = new Customer[] {customer1,customer2,customer3,customer4 };

            CustomerListing customerListing = new CustomerListing();

            customerListing.AddCustomer(customer4);
            customerListing.Delete(customer1 );
            Console.WriteLine("------------------------ALLCUSTOMERS-------------------------");
            // foreach (Customer customer in customers)
            // {
            //  Console.WriteLine("Name and Lastname : " + customer.CustomerName + "  " + customer.CustomerLastName + " No : " + customer.CustomerNo + " Id : " + customer.Id );
            // }
            customerListing.Listing(customers);
               

           

        }
    }
}
