using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Entity;

namespace CommercialAutomation.Models.Classes
{
    public class Context:DbContext
    {

        public DbSet<Admin> Admins{ get; set; }

        public DbSet<Customer> Customers{ get; set; }

        public DbSet<Employee> Employees{ get; set; }

        public DbSet<Product> Products{ get; set; }

        public DbSet<Category> Categories{ get; set; }

        public DbSet<Department> Departments{ get; set; }

        public DbSet<Invoice> Invoices { get; set; }

        public DbSet<BillItem> BillItems{ get; set; }

        public DbSet<Expense> Expenses{ get; set; }

        public DbSet<SalesMovement> SalesMovements{ get; set; }


    }
}