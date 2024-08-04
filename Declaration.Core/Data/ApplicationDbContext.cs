using Declaration.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Declaration.Core.Data
{
    public class ApplicationDbContext: DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<DDT> DDTs {  get; set; }

        public DbSet<LIQ> LIQs { get; set; }
        public DbSet<ART> ARTs { get; set; }
        public DbSet<LQA> LQAs { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DDT>()
                .HasOne(d => d.LIQ)
                .WithOne(l => l.DDT)
                .HasForeignKey<LIQ>(l => l.Iliq);

            modelBuilder.Entity<DDT>()
                .HasMany(d => d.ARTS)
                .WithOne()
                .HasForeignKey(a => a.Iddt)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<LQA>()
            .HasKey(l => new { l.Iliq, l.Nart, l.Clqatax, l.Clqatyp });

            modelBuilder.Entity<ART>()
                .HasKey(a => new { a.Iddt, a.Nart });
        }
    }
}
