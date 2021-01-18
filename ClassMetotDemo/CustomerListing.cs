using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerListing
    { 
        public void Listing(Customer customer) 
        {
            Console.WriteLine( "Name and Lastname : " + customer.CustomerName + "  " + customer.CustomerLastName + " No : " + customer.CustomerNo + " Id : " + customer.Id);
        }
        public void Delete(Customer customer) 
        {
            Console.WriteLine("Customer Successfully Deleted: " + "Name and Lastname : " + customer.CustomerName + "  " + customer.CustomerLastName + " No : " + customer.CustomerNo + " Id : " + customer.Id);
        }

        public void AddCustomer(Customer customer) 
        {
            Console.WriteLine("Customer Successfully Added: " + "Name and Lastname : " + customer.CustomerName + "  " + customer.CustomerLastName + " No : " + customer.CustomerNo + " Id : " + customer.Id);
        }
    }
}
