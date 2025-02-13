using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment.entities;
using Microsoft.EntityFrameworkCore;

namespace Assignment.Context
{
    internal class AppDbContextDept : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>().HasKey(D => D.Id);
        }

    }
}
