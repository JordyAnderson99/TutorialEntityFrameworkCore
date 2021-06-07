using System;
using System.Collections.Generic;
using System.Text;
using TutorialEntityFrameworkCore.Models;
using Microsoft.EntityFrameworkCore;

namespace TutorialEntityFrameworkCore.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=SchoolDB;Trusted_Connection=True;");
        }
    }
}
