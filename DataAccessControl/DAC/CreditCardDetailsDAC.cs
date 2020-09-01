using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Utilities;

namespace DataAccessControl.DAC
{
    public class CreditCardDetailsDAC
    {
        public static CreditCardDetails GetCreditCardDetails(int cardId, AppDbContext _context)
        {
            CreditCardDetails creditCardDetails = _context.CreditCards.Where(x => x.CardId == cardId).FirstOrDefault();
            return creditCardDetails;
        }
        public static CreditCardDetails GetCreditCardDetails(EligibilityCheck eligibilityCheckModel, AppDbContext _context)
        {

            int age = Common.GetAge(eligibilityCheckModel.DateOfBirth);
            CreditCardDetails creditCardDetails = _context.CreditCards.Where(x => x.AgeLimit <= age
                                   && x.MinAnnualIncome <= eligibilityCheckModel.AnnualIncome).OrderByDescending(o => o.MinAnnualIncome).FirstOrDefault();
            return creditCardDetails;
        }

        //public static List<CreditCardDetails> GetCreditCardDetails(CustomerDetails customerDetailsModel, AppDbContext _context)
        //{

        //    int age = Common.GetAge(customerDetailsModel.DateOfBirth);
        //    List<CreditCardDetails> creditCardDetails = _context.CreditCards.Where(x => x.AgeLimit <= age
        //                           && x.MinAnnualIncome <= customerDetailsModel.AnnualIncome).OrderByDescending(o => o.MinAnnualIncome).ToList();
        //    return creditCardDetails;
        //}

    }
}
