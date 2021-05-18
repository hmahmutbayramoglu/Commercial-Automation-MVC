using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CommercialAutomation.Models.Classes
{
    public class SalesMovement
    {
        [Key]
        public int Id { get; set; }

        public Product Products{ get; set; }

        public Customer Customers { get; set; }

        public Employee Employees { get; set; }

        public DateTime Date { get; set; }

        //Adet
        [Required]
        public int Piece { get; set; }

        [Required]
        public  decimal UnitPrice { get; set; }

        [Required]
        public decimal TotalPrice { get; set; }
    }
}