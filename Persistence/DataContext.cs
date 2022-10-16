using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Persistence;
using Domain;

namespace Persistence
{
    public class DataContext : DbContext
    {
        public DbSet<Value> Values { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Value>().HasData(
                new Value { Id = 3, Name = "Tim", Species = "Cat", Age =20},
                new Value { Id = 5, Name = "Tom", Species= "Dog", Age =12},
                new Value { Id = 9, Name = "Kerby", Species = "Lion", Age = 15}
            
            );
        }
        public DataContext(DbContextOptions options) : base(options)
        {
        }
    }
}