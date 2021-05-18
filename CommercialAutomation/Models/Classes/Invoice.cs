using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CommercialAutomation.Models.Classes
{
    //Fatura
    public class Invoice
    { 

        [Key]
        public int Id { get; set; }

        //Seri no
        [Column(TypeName = "Varchar")]
        [StringLength(20)]
        [Required]
        public string SerialNumber { get; set; }

        //Sıra no
        [Column(TypeName = "Varchar")]
        [StringLength(15)]
        [Required]
        public string RowNumber{ get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public DateTime Hour { get; set; }

        //Vergi dairesi
        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        [Required]
        public string TaxAdministration { get; set; }

        //Teslim eden kişi (Dağıtıcı)
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string Distributor { get; set; }

        //Teslim alan kişi (Alıcı)
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string Receiver { get; set; }


        public ICollection<BillItem> BillItems { get; set; }

    }
}