using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerListing
    { 
        public void Listing(Customer[] customers) 
        {
            foreach (var Customer in customers)
            {
                Console.WriteLine(Customer.CustomerName + " " + Customer.CustomerLastName);
            }
        }
        public void Delete(Customer customer) 
        {
            Console.WriteLine("Customer Successfully Deleted: " + "Name and Lastname : " + customer.CustomerName + "  " + customer.CustomerLastName + "\n No : " + customer.CustomerNo + " Customer Id : " + customer.Id);
        }

        public void AddCustomer(Customer customer) 
        {
            Console.WriteLine("Customer Successfully Added: " + "Name and Lastname : " + customer.CustomerName + "  " + customer.CustomerLastName + "\n No : " + customer.CustomerNo + " Customer Id : " + customer.Id);
        }
    }
}
