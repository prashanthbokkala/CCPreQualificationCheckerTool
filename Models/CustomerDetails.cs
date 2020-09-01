using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    public class CustomerDetails
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        [Column("CustomerId")]
        public int CustomerId { get; set; }

        [Required]
        [StringLength(15, ErrorMessage = "{0} length must be between {2} and {1}.", MinimumLength = 2)]
        [Column("FirstName")]
        public string FirstName { get; set; }
        
        [Required]
        [StringLength(15, ErrorMessage = "{0} length must be between {2} and {1}.", MinimumLength = 2)]
        [Column("LastName")]
        public string LastName { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Column("DateOfBirth")]
        public DateTime DateOfBirth { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        [Column("AnnualIncome", TypeName = "money")]
        public decimal AnnualIncome { get; set; }

        [ForeignKey("CreditCardDetails")]
        public int? CardRefId { get; set; }
        public CreditCardDetails CreditCardDetails { get; set; }

        [Column("CreatedDate")]
        [DataType(DataType.DateTime)]
        public DateTime? CreatedDate { get; set; }
        [Column("CreatedBy")]
        public string CreatedBy { get; set; }
        [Column("UpdatedDate")]
        [DataType(DataType.DateTime)]
        public DateTime? UpdatedDate { get; set; }
        [Column("UpdatedBy")]
        public string UpdatedBy { get; set; }
    }
}
