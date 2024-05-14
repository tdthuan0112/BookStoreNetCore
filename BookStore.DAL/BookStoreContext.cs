using BookStore.DAL.Constant;
using BookStore.DAL.Models;
using Microsoft.EntityFrameworkCore;
using BookStore.DAL.Enum;
using System;

namespace BookStore.DAL
{
    public class BookStoreContext : DbContext
    {
        public BookStoreContext(DbContextOptions<BookStoreContext> options) : base(options) { }

        public virtual DbSet<Book> Book { get; set; }
        public virtual DbSet<CartItem> CartItem { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<OrderItem> OrderItem { get; set; }
        public virtual DbSet<OrderPayment> OrderPayment { get; set; }
        public virtual DbSet<PaymentType> PaymentType { get; set; }
        public virtual DbSet<Review> Review { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserPayment> UserPayment { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            SeedData_Category(modelBuilder);
            SeedData_Book(modelBuilder);
            SeedData_User(modelBuilder);
            SeedData_Role(modelBuilder);
        }

        private void SeedData_Category(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    CategoryId = Guid.NewGuid(),
                    Name = "All Books",
                    Url = "/all-books",
                    CreatedBy = new Guid(ConstantInitDb.AdministratorId),
                    Quantity = 100,
                    IsActive = true
                }
            );
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    CategoryId = Guid.NewGuid(),
                    Name = "Art & Music",
                    Url = "/art-and-music",
                    CreatedBy = new Guid(ConstantInitDb.AdministratorId),
                    Quantity = 100,
                    IsActive = true
                }
            );
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    CategoryId = Guid.NewGuid(),
                    Name = "Biographies",
                    Url = "/biographies",
                    CreatedBy = new Guid(ConstantInitDb.AdministratorId),
                    Quantity = 100,
                    IsActive = true
                }
            );
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    CategoryId = Guid.NewGuid(),
                    Name = "Kids",
                    Url = "/kids",
                    CreatedBy = new Guid(ConstantInitDb.AdministratorId),
                    Quantity = 100,
                    IsActive = true
                }
            );
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    CategoryId = Guid.NewGuid(),
                    Name = "Tech",
                    Url = "/tech",
                    CreatedBy = new Guid(ConstantInitDb.AdministratorId),
                    Quantity = 100,
                    IsActive = true
                }
            );
        }

        private void SeedData_Book(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasData(
                new Book
                {
                    BookId = Guid.NewGuid(),
                    Title = "Where the Crawdads Sing",
                    Author = "Delia Owens",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                    Url = "/where-the-crawdads-sing",
                    ImageUrl = "https://s3-alpha-sig.figma.com/img/f9e4/42c7/f4808e98ba531d64c0dff57f7d2c3922?Expires=1716163200&Key-Pair-Id=APKAQ4GOSFWCVNEHN3O4&Signature=CBvZnR15JE2wMzQ4ZIMDxV4I2ans6uyeZouIKzwoIpWz8aeVtUuWylTv5a4A7AGJRuTeOHFIuYDGePYyvUhbjbZMgiSIFBSCeCt19AcBoqvXB07f-3rZEvWfkjXVykyRANzm~Lf7nlSdijaxb6GNmcXG8lyntQwxcIx85OkbHA4vAIRCS6AtImoVY8SGITqVTKCL8PUY-d8tfBEEpcoLUrA8AgaYbtU33MYJ8rxz9eV~cvBtMDpEGy8DWCT3ZYdkQ9orjf-B8srJ8NFoeqw76iskyu-bdRmKjuwYjrWcVmX-v77CtHhO4qt~~5s33raqktwkkj-y1H-uOCFSWPsfOg__",
                    QuantityInStock = 200,
                    QuantitySold = 0,
                    OriginalPrice = (decimal)16.99,
                    DiscountPrice = 10,
                    IsDiscountPercent = true,
                    CreatedBy = new Guid(ConstantInitDb.AdministratorId),
                    DateCreated = DateTime.Now,
                    IsActive = true,
                    Rating = 4.8,
                }
            );
            modelBuilder.Entity<Book>().HasData(
                new Book
                {
                    BookId = Guid.NewGuid(),
                    Title = "Introduction to Algorithms",
                    Author = "Thomas H. Cormen",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                    Url = "/introduction-to-algorithms",
                    ImageUrl = "https://s3-alpha-sig.figma.com/img/8fc2/9edb/ddd8db13bb192848605c5eb55ca236d3?Expires=1716163200&Key-Pair-Id=APKAQ4GOSFWCVNEHN3O4&Signature=nEK2cp1DqH9lWm-t7VnLivuigGkkqrcnw2xWUjH65ggkQKU~lPnqSJsjeL8zAniaBFU196buSycLP5y3yL1mywlDIPXKzPO6QDRJeeiuqyxg5lQmaQvr4wJIMSBIYe9IsALIj5PBJPVc7itX-G7GItpwMhD~61ltU--eLIrPiRNdhlgofhKImYnCNuMluipIWoioJraygFGNXr48SEH3ft5EQ1PwegRVRzjQtWfLUEhR3c4Jmp0azpMTWsSqcRmKxboQefCKZQr-RadHRn9vfQQA6URI3NFDqeDkDoBqbyCBxCWUky74V34nxY5A0wxGK9E5IouecyTn30OKJd5mTQ__",
                    QuantityInStock = 150,
                    QuantitySold = 0,
                    OriginalPrice = (decimal)23.99,
                    DiscountPrice = 12,
                    IsDiscountPercent = true,
                    CreatedBy = new Guid(ConstantInitDb.AdministratorId),
                    DateCreated = DateTime.Now,
                    IsActive = true,
                    Rating = 4.5,
                }
            );
            modelBuilder.Entity<Book>().HasData(
                new Book
                {
                    BookId = Guid.NewGuid(),
                    Title = "Maybe You Should Talk to Someone",
                    Author = "Lori Gottlieb",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                    Url = "/maybe-you-should-talk-to-someone",
                    ImageUrl = "https://s3-alpha-sig.figma.com/img/d382/ffe7/14d53687669880646de466095672a60c?Expires=1716163200&Key-Pair-Id=APKAQ4GOSFWCVNEHN3O4&Signature=b~QhiYL212syowaBO7x2CJWlsSt~WNcru6m43QizULA8~BvKwYGNHW0vKAXRdFhRG5XUtmSpwDCDFYYWAHGY2gvn7HVhhliGzNa6BgkbUxq1kmMd88I~1OORzpJgmNaMTErorebnQA6EppFQP7MsGCp9Wiu7X1LsXYIwsdZ2ST6oCK3KoZejMIhX9Es93VaCAF0jDZ6IK0NJbf2Exo6F8qqDqeA4otFXAr7aCvBnVnMakq0s0glL8-b6UnMEqD3wkhH7GUeLMxaofy4Zb7vQdpibaKp~KjsMsW5noHyLOqdfn8~14PBY021FzU3~ZDVJ4Q5~eTbnQnZvrHIvDV5l8w__",
                    QuantityInStock = 240,
                    QuantitySold = 0,
                    OriginalPrice = (decimal)17.59,
                    DiscountPrice = 8,
                    IsDiscountPercent = true,
                    CreatedBy = new Guid(ConstantInitDb.AdministratorId),
                    DateCreated = DateTime.Now,
                    IsActive = true,
                    Rating = 3.6,
                }
            );
            modelBuilder.Entity<Book>().HasData(
                new Book
                {
                    BookId = Guid.NewGuid(),
                    Title = "When We Believed in Mermaids",
                    Author = "Barbara O’Neal",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                    Url = "/when-we-believed-in-mermaids",
                    ImageUrl = "https://s3-alpha-sig.figma.com/img/ce20/c751/22212be8c4ed077fb6d1a5c029d616f6?Expires=1716163200&Key-Pair-Id=APKAQ4GOSFWCVNEHN3O4&Signature=dSKdBqPysBGOvPZ~Fp3ShPUanqlIuAqdwzmIrw7OQJIM6Z2idPSpcBTeF3mI1OqDi-oof9wO5PDKcCvmON~TjnNI7~9J3wyrxJf4OCbUV9HWW5kd7BrsWzPHr3YS5z9qAoWCwowLZQrlBit3hF8m4qiX1~jaLsyAT5b51yVf-EqH2OGW3WhdX13oCVSeryv1Fq42EnF8gJ5JforvIEEZeReu3VSUtAGUDBPMvc6hv9uPeQ2utEJEtMRJIZ4iuqBq7zXkz2qfxHEh6sHoNbYf9gAIYCIkWfbl-jtU5Dmyn2-jNyeL~3sgaZl09tNd2NZtsXtkM~P99-8SJS6T~Bh4jw__",
                    QuantityInStock = 210,
                    QuantitySold = 0,
                    OriginalPrice = (decimal)30.99,
                    DiscountPrice = 11,
                    IsDiscountPercent = true,
                    CreatedBy = new Guid(ConstantInitDb.AdministratorId),
                    DateCreated = DateTime.Now,
                    IsActive = true,
                    Rating = 4.2,
                }
            );
            modelBuilder.Entity<Book>().HasData(
                new Book
                {
                    BookId = Guid.NewGuid(),
                    Title = "The Pale-Faced Lie",
                    Author = "David Crow",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                    Url = "/the-pale-faced-lie",
                    ImageUrl = "https://s3-alpha-sig.figma.com/img/5e2c/c494/4bb632fc791ce7b3b0a6677d54ee06fb?Expires=1716163200&Key-Pair-Id=APKAQ4GOSFWCVNEHN3O4&Signature=ER7K9yrHzMgNAQfZZYCpceu46eUoIEF~LntEFVpCH5W9a95w2mu7c-y2A6ZFaIUHrAb4Q9U11pDbR5pEsdbpOX8oC~Kzh0q9cAOqkTVYxyodjkZg6sFYdxK8PmFNyoIfqhjI-TK~CsSdQAvzluaVdJzxWNidVsI6Usx-2rS5XJFEeMWCfVmvAEbKXlWfshKsgYsdAA0z~fTdeHPbcWe32oVGZ9tEZfqlJdsc-pyDtIDINmU35DxxQrGSA2K6Zu6Gxo8b8HdLwM2MBcKsIlrbiGqRAYakCxOtKSCJUdIuvDcnfCTgt7hK9pf-YJMB2cfqNUfdbweh4WgypDhYUvBr9w__",
                    QuantityInStock = 110,
                    QuantitySold = 0,
                    OriginalPrice = (decimal)14.99,
                    DiscountPrice = 14,
                    IsDiscountPercent = true,
                    CreatedBy = new Guid(ConstantInitDb.AdministratorId),
                    DateCreated = DateTime.Now,
                    IsActive = true,
                    Rating = 3.4,
                }
            );
        }

        private void SeedData_User(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    UserId = new Guid(ConstantInitDb.AdministratorId),
                    UserName = "Administrator",
                    UserPassword = "123456",
                    FirstName = "Thuan",
                    LastName = "Tran",
                    Email = "thuanmaildemo@gmail.com",
                    Gender = (int)Sexes.Male,
                    PhoneNumber = "0123 456 789",
                    Address = "123 Highway 1k",
                    District = "Binh An",
                    Ward = "Di An",
                    Province = "Binh Duong",
                    DateOfBirth = new DateTime(1999, 12, 1),
                    DateCreated = DateTime.Now,
                    IsActive = true,
                    RoleId = new Guid(ConstantInitDb.RoleId)
                });
        }

        private void SeedData_Role(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>().HasData(
                new Role
                {
                    RoleId = new Guid(ConstantInitDb.RoleId),
                    RoleName = "Administrator",
                    CreatedBy = new Guid(ConstantInitDb.AdministratorId),
                    DateCreated = DateTime.Now,
                    IsActive = true
                }
            );
        }
    }
}
