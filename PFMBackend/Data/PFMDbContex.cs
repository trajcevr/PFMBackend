using Microsoft.EntityFrameworkCore;
using PFMBackend.Models;


namespace PFMBackend.Data

{

    public class PFMDbContex : DbContext
    {
        
        DbSet<Transaction> Transactions { get; set; } = null!;
        DbSet<Category> Categories { get; set; } = null!;

        public string DbPath { get; }

        public PFMDbContex()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "database.db");
        }



        protected override void OnConfiguring(DbContextOptionsBuilder options)
       => options.UseSqlite($"Data Source={DbPath}");
    }


}
