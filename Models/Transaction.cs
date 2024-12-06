﻿using System.ComponentModel;
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
        public string AccountNumber { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Beneficary Name")]
        public string BeneficaryName { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Bank Name")]
        public string BankName { get; set; }
       
        [Column(TypeName = "nvarchar(11)")]
        [DisplayName("SWIFT Code")]
        public string SWIFTCode { get; set; }
       
        public int Amount { get; set; }
        
        public DateTime Date { get; set; }



    }
}
