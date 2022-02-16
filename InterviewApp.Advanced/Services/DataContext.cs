using System;
using Microsoft.EntityFrameworkCore;
using InterviewApp.Models;

namespace InterviewApp.Services
{
    public class DataContext : DbContext
    {
        public readonly string _file;

        public DbSet<Item> Items => Set<Item>();

        public DataContext(string file)
        {
            if (string.IsNullOrWhiteSpace(file))
                throw new ArgumentNullException(nameof(file));

            _file = file;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Filename={_file}");
        }
    }
}
