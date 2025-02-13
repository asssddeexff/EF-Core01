using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment.entities;
using Microsoft.EntityFrameworkCore;

namespace Assignment.Context
{
    internal class AppDbContext : DbContext
    {

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().HasKey(C => C.Id);
            modelBuilder.Entity<Course>().Property(C => C.Name).HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Department>().HasKey(D=>D.Id);
            modelBuilder.Entity<Department>().Property(D=>D.Name).HasMaxLength(50).IsRequired();

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server =.;Database = AppG03;Trusted_Connection = True;TrustServerCertificate=True");
        }

        

        public DbSet<Course> Courses { get; set; }

        public DbSet<Student> Students { get; set; }

        public DbSet<Constructor> Constructors { get; set; }

        public DbSet<Department> Departments { get; set; }


    }
}
