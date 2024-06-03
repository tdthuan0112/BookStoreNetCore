using BookStore.DAL.Constant;
using BookStore.DAL.Models;
using Microsoft.EntityFrameworkCore;

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
        public virtual DbSet<BookCategory> BookCategory { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>()
                .HasMany(e => e.ListCategories)
                .WithMany(e => e.ListBooks)
                .UsingEntity<BookCategory>(
                    l => l.HasOne<Category>().WithMany().HasForeignKey(e => e.CategoryId),
                    r => r.HasOne<Book>().WithMany().HasForeignKey(e => e.BookId)
                );
            modelBuilder.Entity<CartItem>()
                .HasKey(l => new { l.UserId, l.BookId });

            SeedData_Category(modelBuilder);
            SeedData_Book(modelBuilder);
            SeedData_BookCategory(modelBuilder);
            SeedData_User(modelBuilder);
            SeedData_Role(modelBuilder);
        }

        private void SeedData_Category(ModelBuilder modelBuilder)
        {
            foreach (var category in ConstantInitDb.DUMMY_CATEGORIES) { modelBuilder.Entity<Category>().HasData(category); };
        }

        private void SeedData_Book(ModelBuilder modelBuilder)
        {
            foreach (var item in ConstantInitDb.DUMMY_BOOKS) { modelBuilder.Entity<Book>().HasData(item); };
        }

        private void SeedData_User(ModelBuilder modelBuilder)
        {
            foreach (var item in ConstantInitDb.USERS) { modelBuilder.Entity<User>().HasData(item); };
        }

        private void SeedData_Role(ModelBuilder modelBuilder)
        {
            foreach (var item in ConstantInitDb.ROLES) { modelBuilder.Entity<Role>().HasData(item); };
        }

        private void SeedData_BookCategory(ModelBuilder modelBuilder)
        {
            foreach (var item in ConstantInitDb.DUMMY_BOOK_CATEGORY) { modelBuilder.Entity<BookCategory>().HasData(item); };
        }
    }
}
