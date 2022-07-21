using Microsoft.EntityFrameworkCore;
using PFMBackend.Models;


namespace PFMBackend.Data

{

    public class PFMDbContex : DbContext
    {

       public DbSet<Transaction> Transactions { get; set; } = null!;
        public DbSet<Category> Categories { get; set; } = null!;

        public string DbPath { get; }

        public PFMDbContex()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "database.db");
        }

        public PFMDbContex(DbContextOptions options) : base(options)
        {

        }



        protected override void OnConfiguring(DbContextOptionsBuilder options)
       => options.UseSqlite(@"Data Source=C:\Users\Robi\source\repos\PFMBackend\PFMBackend\database.db");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Transaction>().HasKey(t => t.Id);
            base.OnModelCreating(modelBuilder);

        }
    }


}