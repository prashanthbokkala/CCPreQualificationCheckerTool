using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    public class CreditCardDetails : BaseEntity
    {
        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        [Column("CardId")]
        public int CardId { get; set; }

        [Required]
        [StringLength(15)]
        [Column("CardType")]
        public string CardType { get; set; }

        [Required]
        [StringLength(100)]
        [Column("BankName")]
        public string BankName { get; set; }

        [Required]
        [Column("AgeLimit")]
        public int AgeLimit { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        [Column("MinAnnualIncome")]
        public decimal MinAnnualIncome { get; set; }

        [Required]
        [DataType(DataType.Custom)]
        [Column("APR")]
        public decimal APR { get; set; }

        [Required]
        [StringLength(1000)]
        [Column("Message")]
        public string Message { get; set; }

        [Required]
        [Column("Image")]
        public string Image { get; set; }
    }
}
