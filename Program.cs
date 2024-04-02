using System;
using System.Linq;
using week11.Models.Entities;

namespace Week10.Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var dbContext = new MMABooksContext())
            {
                var customers = dbContext.Customers.ToList();

                foreach (var customer in customers)
                {
                    Console.WriteLine($"{customer.Name}");
                }
            }
        }
    }
}
