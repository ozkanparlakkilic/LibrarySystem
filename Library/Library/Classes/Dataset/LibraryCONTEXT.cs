using Library.Classes.TableClasses;
using System.Data.Entity;

namespace Library.Classes.Dataset
{
    class LibraryCONTEXT : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AUTHOR>().ToTable("AUTHOR");
            modelBuilder.Entity<BOOK>().ToTable("BOOK");
            modelBuilder.Entity<PUBLISHER>().ToTable("PUBLISHER");
            modelBuilder.Entity<PERSONEL>().ToTable("PERSONEL");
            modelBuilder.Entity<LOGIN>().ToTable("LOGIN");
            modelBuilder.Entity<MEMBER>().ToTable("MEMBER");
            modelBuilder.Entity<LOAN>().ToTable("LOAN");
            modelBuilder.Entity<PUNISHMENT>().ToTable("PUNISHMENT");
            modelBuilder.Entity<BOOK_INFORMATION>().ToTable("BOOK_INFORMATION");
            modelBuilder.Entity<MEMBER_INFORMATION>().ToTable("MEMBER_INFORMATION");
            modelBuilder.Entity<STOCK_RAPOR>().ToTable("STOCK_RAPOR");
        }
        public DbSet<AUTHOR> AUTHOR { get; set; }
        public DbSet<BOOK> BOOK { get; set; }
        public DbSet<PUBLISHER> PUBLISHER { get; set; }
        public DbSet<PERSONEL> PERSONEL { get; set; }
        public DbSet<LOGIN> LOGIN { get; set; }
        public DbSet<MEMBER> MEMBER { get; set; }
        public DbSet<LOAN> LOAN { get; set; }
        public DbSet<PUNISHMENT> PUNISHMENT { get; set; }
        public DbSet<BOOK_INFORMATION> BOOK_INFORMATION { get; set; }
        public DbSet<MEMBER_INFORMATION> MEMBER_INFORMATION { get; set; }
        public DbSet<STOCK_RAPOR> STOCK_RAPOR { get; set; }
    }
}
