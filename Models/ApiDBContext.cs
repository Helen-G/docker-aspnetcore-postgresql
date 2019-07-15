using dockerapi.Maps;
using Microsoft.EntityFrameworkCore;
using dockerapi.Models;
using System;

namespace dockerapi.Models{
#pragma warning disable CS1591
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext> options)
       : base(options)
        {

        }
        public DbSet<ToDo> ToDos { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            new ToDoMap(modelBuilder.Entity<ToDo>());
        }
    }
    #pragma warning restore CS1591
}