using LibraryApp.Models;
using LibraryApp.SupportClasses.PasswordHasher;
using Microsoft.EntityFrameworkCore;

namespace LibraryApp.Data
{
    public class LibraryContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<RentedBook> RentedBooks { get; set; }
        public LibraryContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region DUMMY USERS
            PasswordHasher passwordHasher = new PasswordHasher();
            byte[] salt;
            modelBuilder.Entity<User>().HasQueryFilter(user => !user.IsDeleted);
            modelBuilder.Entity<User>(user =>
            {
                user.HasData(
                    new
                    {
                        Id = 1L,
                        FirstName = "Dane",
                        LastName = "Milisic",
                        Email = "dane.m.12@gmail.com",
                        Password = passwordHasher.HashPassword("123", out salt),
                        Role = "USER",
                        CreatedDate = DateTime.Now,
                        ModifiedDate = DateTime.Now,
                        Salt = salt,
                        IsDeleted = false
                    });
                user.HasData(
                    new
                    {
                        Id = 2L,
                        FirstName = "Nikola",
                        LastName = "Vukic",
                        Email = "woox.gg@gmail.com",
                        Password = passwordHasher.HashPassword("123", out salt),
                        Role = "LIBRARIAN",
                        CreatedDate = DateTime.Now,
                        ModifiedDate = DateTime.Now,
                        Salt = salt,
                        IsDeleted = false
                    });
                user.HasData(
                    new
                    {
                        Id = 3L,
                        FirstName = "Djordje",
                        LastName = "Rasic",
                        Email = "djokeen@gmail.com",
                        Password = passwordHasher.HashPassword("123", out salt),
                        Role = "ADMIN",
                        CreatedDate = DateTime.Now,
                        ModifiedDate = DateTime.Now,
                        Salt = salt,
                        IsDeleted = false
                    });
                user.HasData(
                    new
                    {
                        Id = 4L,
                        FirstName = "Kristijan",
                        LastName = "Trnjanac",
                        Email = "kikimaher@gmail.com",
                        Password = passwordHasher.HashPassword("123", out salt),
                        Role = "USER",
                        CreatedDate = DateTime.Now,
                        ModifiedDate = DateTime.Now,
                        Salt = salt,
                        IsDeleted = true
                    });
            });
            #endregion
            #region DUMMY BOOKS
            modelBuilder.Entity<Book>().HasQueryFilter(book => !book.IsDeleted);
            modelBuilder.Entity<Book>(book =>
            {
                book.HasData(
                    new
                    {
                        Id = 1L,
                        Name = "Algebra Testovi",
                        CreatedDate = DateTime.Now,
                        ModifiedDate = DateTime.Now,
                        IsDeleted = false,
                        Quantity = 2
                    });
                book.HasData(
                    new
                    {
                        Id = 2L,
                        Name = "Algebra",
                        CreatedDate = DateTime.Now,
                        ModifiedDate = DateTime.Now,
                        IsDeleted = false,
                        Quantity = 1
                    });
                book.HasData(
                    new
                    {
                        Id = 3L,
                        Name = "Mehanika",
                        CreatedDate = DateTime.Now,
                        ModifiedDate = DateTime.Now,
                        IsDeleted = false,
                        Quantity = 2
                    });
                book.HasData(
                    new
                    {
                        Id = 4L,
                        Name = "Zbirka zadataka iz Mehanike",
                        CreatedDate = DateTime.Now,
                        ModifiedDate = DateTime.Now,
                        IsDeleted = false,
                        Quantity = 1
                    });

            });
            #endregion
            #region DUMMY AUTHORS
            modelBuilder.Entity<Author>().HasQueryFilter(author => !author.IsDeleted);
            modelBuilder.Entity<Author>(author =>
            {
                author.HasData(
                    new
                    {
                        Id = 1L,
                        FirstName = "Ljubo",
                        LastName = "Nedovic",
                        CreatedDate = DateTime.Now,
                        ModifiedDate = DateTime.Now,
                        IsDeleted = false
                    });
                author.HasData(
                    new
                    {
                        Id = 2L,
                        FirstName = "Rade",
                        LastName = "Doroslovacki",
                        CreatedDate = DateTime.Now,
                        ModifiedDate = DateTime.Now,
                        IsDeleted = false
                    });
                author.HasData(
                    new
                    {
                        Id = 3L,
                        FirstName = "Damir",
                        LastName = "Madjarevic",
                        CreatedDate = DateTime.Now,
                        ModifiedDate = DateTime.Now,
                        IsDeleted = false
                    });
            });
            #endregion
        }

    }
}
