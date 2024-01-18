using LOGINWEBAPI.models;
using Microsoft.EntityFrameworkCore;

namespace LOGINWEBAPI.Context{
    
    public class FoodDonateDbContext:DbContext{

       
        public FoodDonateDbContext(DbContextOptions<FoodDonateDbContext> options) : base(options)
        {
        }

        public DbSet<FoodDonate>foodDonates{get;set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder){

            modelBuilder.Entity<FoodDonate>().ToTable("foodDonates");
        }

    }

}