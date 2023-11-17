using appform.Model;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;


namespace appform.Model
{
    public class MyDBcontextcs:DbContext
    {
        public DbSet<details1> detailss { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.Entity<details1>().HasNoKey();
            optionsBuilder.UseSqlServer("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=test;Data Source = Rubhini\\SQLEXPRESS;Encrypt=False");
            
        }

    }
}
