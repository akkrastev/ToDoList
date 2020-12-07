using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoListApplication.Models
{
    public class ToDoContext : DbContext
    {
        public virtual DbSet<ToDo> ToDo { get; set; }

        public ToDoContext(DbContextOptions<ToDoContext> options)
            : base(options)
        {
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=DESKTOP-OGU7KB9;Database=ToDoListDB;Trusted_Connection=True;MultipleActiveResultSets=true");
            }
        }

    }
}
