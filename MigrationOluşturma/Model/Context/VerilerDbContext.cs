using MigrationOluşturma.Model.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigrationOluşturma.Model.Context
{
    public class VerilerDbContext:DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet <Ders> Dersler { get; set;}
        public DbSet<Ogretmen> Ogretmenler{ get; set; }
    }
}
