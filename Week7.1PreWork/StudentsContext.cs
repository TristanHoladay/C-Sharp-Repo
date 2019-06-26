using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Week7._1PreWork
{
    class StudentsContext : DbContext
    {
        public DbSet<Student> students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=students.db");
        }
    }
}
