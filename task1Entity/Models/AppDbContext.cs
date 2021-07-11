using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace task1Entity.Models
{
    public class AppDbContext :DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ClientProduct> ClientProducts { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.;Initial Catalog=clients;Integrated Security=True");


        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            modelBuilder.Entity<ClientProduct>().HasKey(t => new { t.ClientId, t.ProductId });

            modelBuilder.Entity<ClientProduct>()
                        .HasOne(t => t.Client)
                        .WithMany(t => t.ClientProduct)
                        .HasForeignKey(t => t.ClientId)
                        .OnDelete(DeleteBehavior.ClientCascade);




            modelBuilder.Entity<ClientProduct>()
                        .HasOne(t => t.Product)
                        .WithMany(t => t.ClientProduct)
                        .HasForeignKey(t => t.ProductId);
        }
    }
}
