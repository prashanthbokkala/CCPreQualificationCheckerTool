using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    public class CustomerCeditCardDetails
    {
        //public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public decimal AnnualIncome { get; set; }
        //public int CardId { get; set; }
        public string CardType { get; set; }
        public string BankName { get; set; }
        public decimal? APR { get; set; }
        public string Message { get; set; }
        public string Image { get; set; }
        public bool IsEligible { get; set; }
    }
}
