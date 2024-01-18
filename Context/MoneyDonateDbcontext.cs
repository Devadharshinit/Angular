using LOGINWEBAPI.models;
using Microsoft.EntityFrameworkCore;

namespace LOGINWEBAPI.Context{
    
    public class MoneyDonateDbContext:DbContext{

       
        public MoneyDonateDbContext(DbContextOptions<MoneyDonateDbContext> options) : base(options)
        {
        }

        public DbSet<MoneyDonate>MoneyDonates{get;set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder){

            modelBuilder.Entity<MoneyDonate>().ToTable("MoneyDonates");
        }

    }

}