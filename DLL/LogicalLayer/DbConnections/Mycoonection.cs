using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.EntityClient;
using System.Data.Entity;
using BusinessModels.CGC;

namespace LogicalLayer.DataBaseLogic
{
  public  class Mycoonection : DbContext
    {

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>().ToTable("Country");
            modelBuilder.Entity<MasterTable>().ToTable("MasterTable");


        }
        public DbSet<Country> Country { get; set; }
        public DbSet<MasterTable> MasterTable { get; set; }

    }
}
