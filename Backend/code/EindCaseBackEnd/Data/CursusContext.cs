using EindCaseBackEnd.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EindCaseBackEnd.Data
{
    public class CursusContext : DbContext
    {
       
        
        public CursusContext(DbContextOptions<CursusContext> options) : base(options)
        { }


        public List<Cursus> getCursus()
        {
            return Cursussen.ToList();
        }

        
        DbSet<Cursus> Cursussen {get; set;}
        DbSet<CursusInstantie> CursusInstanties { get; set; }







        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cursus>()
                .Property(c => c.Titel)
                .HasMaxLength(300);
            modelBuilder.Entity<Cursus>()
                .Property(c => c.Code)
                .HasMaxLength(10);
            
            modelBuilder.Entity<CursusInstantie>()
                .Property(ci => ci.StartDatum)
                .HasColumnType("date");
        }



    }
}
