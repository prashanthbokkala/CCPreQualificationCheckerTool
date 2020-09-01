using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions
<AppDbContext> options) : base(options)
        {
        }
        public DbSet<CustomerDetails> Customers { get; set; }
        public DbSet<CreditCardDetails> CreditCards { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CreditCardDetails>().HasData(
                new CreditCardDetails { CardId = new Random().Next(), BankName = "Barclay", CardType = "Visa", AgeLimit = 18, MinAnnualIncome = 30000.00M, APR = 19.99M, Image = ".\\CCPreQualificationCheckerTool\\ClientApp\\images\\Barclays-credit-card.png", Message= "When you spend with our Purchase card, you can buy today, and spread the repayments over time. Or you might prefer our Rewards card, which could give you cashback on your everyday spending. The choice is yours.", CreatedBy = "SYSTEM", CreatedDate = DateTime.Now, UpdatedBy = null, UpdatedDate=null },
                new CreditCardDetails { CardId = new Random().Next(), BankName = "Vanquis", CardType = "Visa", AgeLimit = 18, MinAnnualIncome = 0.00M, APR = 39.90M, Image = "..\\CCPreQualificationCheckerTool\\ClientApp\\images\vanquis-credit-card.png", Message = "A Vanquis credit card can help you improve your rating by helping you prove to lenders that you can handle credit responsibly. Our credit cards are designed for people who find themselves with a poor credit score, maybe because they’ve had financial problems in the past, or no credit history as they’ve never taken out credit before.", CreatedBy = "SYSTEM", CreatedDate = DateTime.Now, UpdatedBy = null, UpdatedDate = null }
            );
        }
    }
}
