using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Data.Entity;

namespace Data
{
    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            var connString = "Server=localhost;Database=consoleapp;Uid=root;Pwd=;";
            optionsBuilder.UseMySql(connString, ServerVersion.AutoDetect(connString));
        }
        public DbSet<Cliente>? Clientes { get; set; }
    }
}