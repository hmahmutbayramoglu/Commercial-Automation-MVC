using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CommercialAutomation.Models.Classes
{
    //Gider
    public class Expense
    {
        [Key]
        public int Id { get; set; }

        //Açıklama
        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public string Explanation { get; set; }

        [Required]
        public DateTime Date { get; set; }

        //Tutar
        [Required]
        public decimal Amount { get; set; }


    }
}