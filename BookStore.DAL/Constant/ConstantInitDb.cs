using BookStore.DAL.Enum;
using BookStore.DAL.Models;

namespace BookStore.DAL.Constant
{
    public static class ConstantInitDb
    {
        public static readonly Guid AdministratorId = Guid.NewGuid();
        public static readonly Guid RoleAdminId = Guid.NewGuid();
        public static readonly Guid RoleUserId = Guid.NewGuid();
        public static readonly Category[] DUMMY_CATEGORIES = [
            new Category {
                CategoryId = Guid.NewGuid(),
                Name = "All Books",
                Url = "all-books",
                CreatedBy = AdministratorId,
                Quantity = 5,
                IsActive = true
            },
            new Category {
                CategoryId = Guid.NewGuid(),
                Name = "Art & Music",
                Url = "art-and-music",
                CreatedBy = AdministratorId,
                Quantity = 3,
                IsActive = true
            },
            new Category {
                CategoryId = Guid.NewGuid(),
                Name = "Biographies",
                Url = "biographies",
                CreatedBy = AdministratorId,
                Quantity = 2,
                IsActive = true
            },
            new Category {
                CategoryId = Guid.NewGuid(),
                Name = "Kids",
                Url = "kids",
                CreatedBy = AdministratorId,
                Quantity = 1,
                IsActive = true
            },
            new Category {
                CategoryId = Guid.NewGuid(),
                Name = "Tech",
                Url = "tech",
                CreatedBy = AdministratorId,
                Quantity = 1,
                IsActive = true
            }
        ];

        public static readonly Book[] DUMMY_BOOKS = [
            new Book {
                BookId = Guid.NewGuid(),
                Title = "Where the Crawdads Sing",
                Author = "Delia Owens",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                Url = "where-the-crawdads-sing",
                ImageUrl = "https://m.media-amazon.com/images/I/81IKIMU4U+L._SY522_.jpg",
                QuantityInStock = 200,
                QuantitySold = 24,
                OriginalPrice = (decimal)16.99,
                DiscountPrice = 10,
                IsDiscountPercent = true,
                CreatedBy = AdministratorId,
                DateCreated = DateTime.Now,
                IsActive = true,
                Rating = 4.8,
            },
            new Book {
                BookId = Guid.NewGuid(),
                Title = "Introduction to Algorithms",
                Author = "Thomas H. Cormen",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                Url = "introduction-to-algorithms",
                ImageUrl = "https://m.media-amazon.com/images/I/616c+ys7RBL._SY522_.jpg",
                QuantityInStock = 150,
                QuantitySold = 16,
                OriginalPrice = (decimal)23.99,
                DiscountPrice = 12,
                IsDiscountPercent = true,
                CreatedBy = AdministratorId,
                DateCreated = DateTime.Now,
                IsActive = true,
                Rating = 4.5,
            },
            new Book {
                BookId = Guid.NewGuid(),
                Title = "Maybe You Should Talk to Someone",
                Author = "Lori Gottlieb",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                Url = "maybe-you-should-talk-to-someone",
                ImageUrl = "https://m.media-amazon.com/images/I/816Gj-UmcVL._SY522_.jpg",
                QuantityInStock = 240,
                QuantitySold = 7,
                OriginalPrice = (decimal)17.59,
                DiscountPrice = 8,
                IsDiscountPercent = true,
                CreatedBy = AdministratorId,
                DateCreated = DateTime.Now,
                IsActive = true,
                Rating = 3.6,
                ListCategories = new List<Category>()
            },
            new Book {
                BookId = Guid.NewGuid(),
                Title = "When We Believed in Mermaids",
                Author = "Barbara O’Neal",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                Url = "when-we-believed-in-mermaids",
                ImageUrl = "https://m.media-amazon.com/images/I/81FJvwYyqgL._SY522_.jpg",
                QuantityInStock = 210,
                QuantitySold = 42,
                OriginalPrice = (decimal)30.99,
                DiscountPrice = 11,
                IsDiscountPercent = true,
                CreatedBy = AdministratorId,
                DateCreated = DateTime.Now,
                IsActive = true,
                Rating = 4.2,
            },
            new Book {
                BookId = Guid.NewGuid(),
                Title = "The Pale-Faced Lie",
                Author = "David Crow",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                Url = "the-pale-faced-lie",
                ImageUrl = "https://m.media-amazon.com/images/I/81DyB6c3EqL._SY522_.jpg",
                QuantityInStock = 110,
                QuantitySold = 6,
                OriginalPrice = (decimal)14.99,
                DiscountPrice = 14,
                IsDiscountPercent = true,
                CreatedBy = AdministratorId,
                DateCreated = DateTime.Now,
                IsActive = true,
                Rating = 3.4,
            }
        ];

        public static readonly BookCategory[] DUMMY_BOOK_CATEGORY = [
            #region ALl BOOKS
            new BookCategory {
                CategoryId = DUMMY_CATEGORIES[0].CategoryId,
                BookId = DUMMY_BOOKS[0].BookId,
            },
            new BookCategory {
                CategoryId = DUMMY_CATEGORIES[0].CategoryId,
                BookId = DUMMY_BOOKS[1].BookId,
            },
            new BookCategory {
                CategoryId = DUMMY_CATEGORIES[0].CategoryId,
                BookId = DUMMY_BOOKS[2].BookId,
            },
            new BookCategory {
                CategoryId = DUMMY_CATEGORIES[0].CategoryId,
                BookId = DUMMY_BOOKS[3].BookId,
            },
            new BookCategory {
                CategoryId = DUMMY_CATEGORIES[0].CategoryId,
                BookId = DUMMY_BOOKS[4].BookId,
            },
            #endregion ALL BOOKS
            new BookCategory {
                CategoryId = DUMMY_CATEGORIES[1].CategoryId,
                BookId = DUMMY_BOOKS[0].BookId,
            },
            new BookCategory {
                CategoryId = DUMMY_CATEGORIES[1].CategoryId,
                BookId = DUMMY_BOOKS[2].BookId,
            },
            new BookCategory {
                CategoryId = DUMMY_CATEGORIES[1].CategoryId,
                BookId = DUMMY_BOOKS[4].BookId,
            },
            new BookCategory {
                CategoryId = DUMMY_CATEGORIES[2].CategoryId,
                BookId = DUMMY_BOOKS[1].BookId,
            },
            new BookCategory {
                CategoryId = DUMMY_CATEGORIES[2].CategoryId,
                BookId = DUMMY_BOOKS[3].BookId,
            },
            new BookCategory {
                CategoryId = DUMMY_CATEGORIES[3].CategoryId,
                BookId = DUMMY_BOOKS[3].BookId,
            },
            new BookCategory {
                CategoryId = DUMMY_CATEGORIES[4].CategoryId,
                BookId = DUMMY_BOOKS[4].BookId,
            },
        ];

        public static readonly User USER_ADMIN = new()
        {
            UserId = AdministratorId,
            UserName = "admin",
            UserPassword = "txPzQDMu4jM=", // 123456
            FirstName = "Thuan",
            LastName = "Tran",
            Email = "thuanmaildemo@gmail.com",
            Gender = (int)Sexes.Male,
            PhoneNumber = "0123 456 789",
            Address = "123 Highway 1k",
            ProvinceId = 74,
            ProvinceName = "Binh Duong",
            DistrictId = 724,
            DistrictName = "Di An",
            WardId = 25951,
            WardName = "Binh An",
            DateOfBirth = new DateTime(1999, 12, 1),
            DateCreated = DateTime.Now,
            IsActive = true,
            RoleId = RoleAdminId
        };

        public static readonly User USER_NORMAL = new()
        {
            UserId = Guid.NewGuid(),
            UserName = "user",
            UserPassword = "txPzQDMu4jM=", // 123456
            FirstName = "Lam",
            LastName = "Nguyen",
            Email = "lammaildemo@gmail.com",
            Gender = (int)Sexes.Male,
            PhoneNumber = "0123 456 789",
            Address = "123 Highway 1k",
            ProvinceId = 74,
            ProvinceName = "Binh Duong",
            DistrictId = 724,
            DistrictName = "Di An",
            WardId = 25951,
            WardName = "Binh An",
            DateOfBirth = new DateTime(2000, 1, 1),
            DateCreated = DateTime.Now,
            IsActive = true,
            RoleId = RoleUserId
        };

        public static readonly User[] USERS = [
            USER_ADMIN,
            USER_NORMAL
        ];

        public static readonly Role ROLE_ADMIN = new()
        {
            RoleId = RoleAdminId,
            RoleName = "Administrator",
            CreatedBy = AdministratorId,
            DateCreated = DateTime.Now,
            IsActive = true
        };

        public static readonly Role ROLE_BUYER = new()
        {
            RoleId = RoleUserId,
            RoleName = "Buyer",
            CreatedBy = AdministratorId,
            DateCreated = DateTime.Now,
            IsActive = true
        };

        public static readonly Role[] ROLES = [
            ROLE_ADMIN,
            ROLE_BUYER
        ];
    }
}
