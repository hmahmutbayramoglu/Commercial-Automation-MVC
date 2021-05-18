using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CommercialAutomation.Models.Classes
{
    public class Product
    {

        [Key]
        public int Id { get; set; }

     // public int CategoryId { get; set; }

        [Column(TypeName ="Varchar")]
        [StringLength(30)]
        [Required]
        public string Name { get; set; }

        //marka
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        [Required]
        public string Brand { get; set; }

        public short UnitInStock { get; set; }

        //Alış fiyatı
        [Required]
        public decimal PurchasePrice { get; set; }

        //Satış Fiyatı
        [Required]
        public decimal SalePrice { get; set; }

        //Durum (Geçerlilik)
        [Required]
        public bool  Validity { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(250)]
        public string Image { get; set; }

        public Category Categories { get; set; }

        public ICollection<SalesMovement> SalesMovements { get; set; }

    }
}