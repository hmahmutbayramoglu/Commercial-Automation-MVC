using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CommercialAutomation.Models.Classes
{
    //Fatura Kalemi
    public class BillItem
    {
        [Key] 
        public int Id { get; set; }

        //Açıklama
        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public string Explanation { get; set; }

        //Miktar
        [Required]
        public int Quantity { get; set; }

        //Birim Fiyat
        [Required]
        public decimal UnitPrice { get; set; }

        //Tutar
        [Required]
        public decimal Amount { get; set; }

        public Invoice  Invoices{ get; set; }

        //Toplam Fiyat
        //  public decimal TotalPrice { get; set; }
    }
}