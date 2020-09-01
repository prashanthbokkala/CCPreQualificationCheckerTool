using DataAccessControl.DAC;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessControl.BC
{
    public class CustomerDetailsBC
    {
        //public static CustomerCeditCardDetails GetCustomerDetailsBC(AppDbContext _context)
        //{
        //    List<CustomerDetails> result = CustomerDetailsDAC.GetCustomerDetailsDAC(_context);
        //    CreditCardDetails creditCardDetails = CreditCardDetailsDAC.GetCreditCardDetails(result, _context);



        //    CustomerCeditCardDetails customerCeditCardDetails = new CustomerCeditCardDetails
        //    {
        //        //CustomerId = result.CustomerId,
        //        FirstName = result.FirstName,
        //        LastName = result.LastName,
        //        AnnualIncome = result.AnnualIncome,
        //        DateOfBirth = result.DateOfBirth,
        //        BankName = creditCardDetails?.BankName,
        //        CardType = creditCardDetails?.CardType,
        //        APR = creditCardDetails?.APR,
        //        Message = creditCardDetails?.Message,
        //        Image = creditCardDetails?.Image,
        //        IsEligible = (creditCardDetails != null) ? true : false
        //    };
        //    return customerCeditCardDetails;
        //}
    }
}
