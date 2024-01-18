using LOGINWEBAPI.models;
using Microsoft.EntityFrameworkCore;

namespace LOGINWEBAPI.Context{
    
    public class ContactDbContext:DbContext{

       
        public ContactDbContext(DbContextOptions<ContactDbContext> options) : base(options)
        {
        }

        public DbSet<ContactModel>contactModels{get;set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder){

            modelBuilder.Entity<ContactModel>().ToTable("contactModels");
        }

    }

}