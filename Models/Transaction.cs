using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankTransaction.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }


        [Column(TypeName = "nvarchar(12)")]
        [DisplayName("Account Number")]
        [Required(ErrorMessage ="This feild id required.")]
        [MaxLength(12,ErrorMessage="Maximum 12 chracters only.")]
        public string AccountNumber { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Beneficary Name")]
        [Required(ErrorMessage ="This feild id required.")]
        public string BeneficaryName { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Bank Name")]
        [Required(ErrorMessage = "This feild id required.")]
        public string BankName { get; set; }
       
        [Column(TypeName = "nvarchar(11)")]
        [DisplayName("SWIFT Code")]
        [Required(ErrorMessage = "This feild id required.")]
        [MaxLength(11, ErrorMessage = "Maximum 12 chracters only.")]
        public string SWIFTCode { get; set; }
        
        [Required(ErrorMessage = "This feild id required.")]
        public int Amount { get; set; }

        [DisplayFormat(DataFormatString = "{0:MMM-dd-yy}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }



    }
}
