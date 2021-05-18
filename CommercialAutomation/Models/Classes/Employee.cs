using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CommercialAutomation.Models.Classes
{
    public class Employee
    {
         
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        [Required]
        public string FirstName { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        [Required]
        public string LastName { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(250)]
        public string Image { get; set; }

        public ICollection<SalesMovement> SalesMovements { get; set; }

        public Department Departments { get; set; }
    }
}