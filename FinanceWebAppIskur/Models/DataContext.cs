using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using FinanceWebAppIskur.Models;


namespace FinanceWebAppIskur.Models
{
    public class DataContext : DbContext
    {
        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        //}
        public DataContext() : base("financeBase") {        
            
        }

        public DbSet<User> User { get; set; }

        public DbSet<Job> Job { get; set; }
        public DbSet<Credit> Credit { get; set; } 
        public DbSet<SocialAccount> SocialAccount { get; set; }
        public DbSet<Permission> Permission { get; set; }
        public DbSet<Customer> Customer { get; set; }

        //public DbSet<Package> Package { get; set; }

    }
}