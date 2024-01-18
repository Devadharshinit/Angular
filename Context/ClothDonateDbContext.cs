using LOGINWEBAPI.models;
using Microsoft.EntityFrameworkCore;

namespace LOGINWEBAPI.Context{
    
    public class ClothDonateDbContext:DbContext{

       
        public ClothDonateDbContext(DbContextOptions<ClothDonateDbContext> options) : base(options)
        {
        }

        public DbSet<ClothDonate>clothDonates{get;set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder){

            modelBuilder.Entity<ClothDonate>().ToTable("ClothDonates");
        }

    }

}
