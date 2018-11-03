using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppCuaToi.Models
{
    public class MyDataContext : DbContext
    {
        public MyDataContext(DbContextOptions<MyDataContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    id = 1,
                    name = "Quần"
                },
                new Category()
                {
                    id = 2,
                    name = "Áo"
                }
            );
            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    id = 1,
                    name = "Quần đùi",
                    categoryId = 1
                },
                new Product()
                {
                    id = 2,
                    name = "Áo khoác",
                    categoryId = 2
                }
            );
        }


        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
