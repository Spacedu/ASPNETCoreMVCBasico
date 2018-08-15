using Microsoft.EntityFrameworkCore;
using Site01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site01.Database
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Palavra> Palavras { get; set; }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
            //EF - Garantir que o banco seja criado pelo EF. - Code First
            Database.EnsureCreated();
        }
    }
}
