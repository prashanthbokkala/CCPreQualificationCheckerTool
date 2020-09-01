using DataAccessControl.DAC;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessControl.BC
{
    public class EligibilityCheckBC
    {
        private readonly AppDbContext _context;

        public EligibilityCheckBC(AppDbContext context)
        {
            _context = context;
        }
        public static CustomerCeditCardDetails SaveEligibilityCheckBC(EligibilityCheck eligibilityCheckModel, AppDbContext _context)
        {
            CreditCardDetails creditCardDetails = CreditCardDetailsDAC.GetCreditCardDetails(eligibilityCheckModel, _context);

            CustomerDetails customerDetails = new CustomerDetails
            {
                FirstName = eligibilityCheckModel.FirstName,
                LastName = eligibilityCheckModel.LastName,
                AnnualIncome = eligibilityCheckModel.AnnualIncome,
                DateOfBirth = eligibilityCheckModel.DateOfBirth,
                CardRefId = creditCardDetails?.CardId,
                CreatedBy = eligibilityCheckModel.FirstName + eligibilityCheckModel.LastName,
                CreatedDate = DateTime.Now
            };
            var result = CustomerDetailsDAC.SaveCustomerDetailsDAC(customerDetails, _context);

            CustomerCeditCardDetails customerCeditCardDetails = new CustomerCeditCardDetails
            {
                //CustomerId = result.CustomerId,
                FirstName = result.FirstName,
                LastName = result.LastName,
                AnnualIncome = result.AnnualIncome,
                DateOfBirth = result.DateOfBirth,
                BankName = creditCardDetails?.BankName,
                CardType = creditCardDetails?.CardType,
                APR = creditCardDetails?.APR,
                Message = creditCardDetails?.Message,
                Image = creditCardDetails?.Image,
                IsEligible = (creditCardDetails != null) ? true : false
            };
            return customerCeditCardDetails;
        }
    }
}
