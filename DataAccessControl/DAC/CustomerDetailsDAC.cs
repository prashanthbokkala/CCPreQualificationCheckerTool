using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccessControl.DAC
{
    public class CustomerDetailsDAC
    {
        public static List<CustomerDetails> GetCustomerDetailsDAC(AppDbContext _context)
        {
            return _context.Customers.ToList();
        }

        public static CustomerDetails SaveCustomerDetailsDAC(CustomerDetails customerDetails, AppDbContext _context)
        {

            var result = _context.Customers.Add(customerDetails);
            _context.SaveChangesAsync();

            return result.Entity;
        }
    }
}
