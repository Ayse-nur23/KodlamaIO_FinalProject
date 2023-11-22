using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes.EntityFramework
{
    public class NorthwindContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Northwind;Trusted_Connection=true");
        }

        public DbSet<Product>  Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }


        //custom maping: farklı isimlerle tanımlanmıs classes ilişkili tabloya bağlar
        //public DbSet<Personel> Personels { get; set; } //IEntity bağlı class
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Personel>().ToTable("Employees", "dbo"); //Tabloları ilişkilendirir
        //    modelBuilder.Entity<Personel>().Personel(p => p.Id).HasColumnName("EmployeeID"); //Kolonları ilişkilendirir
        //}
    }
}
