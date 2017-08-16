using System.Collections.Generic;
using VidlyGeoApp.Models;

namespace VidlyGeoApp.Repository
{
    public static class CustomersRepository
    {
        public static IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>()
            {
                new Customer() { Id = 1, Name = "John Smith" },
                new Customer() { Id = 2, Name = "mary Williams" }
            };
        }
    }
}