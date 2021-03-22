using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EindCaseBackEnd.Models
{
    public class CursusContext : DbContext
    {
       
        
        public CursusContext(DbContextOptions<CursusContext> options) : base(options)
        { }

        
        DbSet<Cursus> Cursussen {get; set;}
        DbSet<CursusInstantie> CursusInstanties { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Cursus>()
            //    .HasKey(c => c.Id);
            //modelBuilder.Entity<CursusInstantie>()
            //    .HasKey(ci => ci.Id);
        }



    }
}
