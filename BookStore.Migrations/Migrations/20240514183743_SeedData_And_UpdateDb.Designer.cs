﻿// <auto-generated />
using System;
using BookStore.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BookStore.Migrations.Migrations
{
    [DbContext(typeof(BookStoreContext))]
    [Migration("20240514183743_SeedData_And_UpdateDb")]
    partial class SeedData_And_UpdateDb
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BookCategory", b =>
                {
                    b.Property<Guid>("ListBooksBookId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ListCategoriesCategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ListBooksBookId", "ListCategoriesCategoryId");

                    b.HasIndex("ListCategoriesCategoryId");

                    b.ToTable("BookCategory");
                });

            modelBuilder.Entity("BookStore.DAL.Models.Book", b =>
                {
                    b.Property<Guid>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateLastModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("DiscountPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDiscountPercent")
                        .HasColumnType("bit");

                    b.Property<Guid>("ModifiedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("OriginalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("QuantityInStock")
                        .HasColumnType("int");

                    b.Property<int>("QuantitySold")
                        .HasColumnType("int");

                    b.Property<double>("Rating")
                        .HasColumnType("float");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BookId");

                    b.ToTable("Book");

                    b.HasData(
                        new
                        {
                            BookId = new Guid("951360cd-83cc-4e69-a84c-9fc82f122947"),
                            Author = "Delia Owens",
                            CreatedBy = new Guid("0f2153fc-bcce-4876-9fcf-383ab9799a70"),
                            DateCreated = new DateTime(2024, 5, 15, 1, 37, 40, 850, DateTimeKind.Local).AddTicks(8379),
                            DateLastModified = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                            DiscountPrice = 10m,
                            ImageUrl = "https://s3-alpha-sig.figma.com/img/f9e4/42c7/f4808e98ba531d64c0dff57f7d2c3922?Expires=1716163200&Key-Pair-Id=APKAQ4GOSFWCVNEHN3O4&Signature=CBvZnR15JE2wMzQ4ZIMDxV4I2ans6uyeZouIKzwoIpWz8aeVtUuWylTv5a4A7AGJRuTeOHFIuYDGePYyvUhbjbZMgiSIFBSCeCt19AcBoqvXB07f-3rZEvWfkjXVykyRANzm~Lf7nlSdijaxb6GNmcXG8lyntQwxcIx85OkbHA4vAIRCS6AtImoVY8SGITqVTKCL8PUY-d8tfBEEpcoLUrA8AgaYbtU33MYJ8rxz9eV~cvBtMDpEGy8DWCT3ZYdkQ9orjf-B8srJ8NFoeqw76iskyu-bdRmKjuwYjrWcVmX-v77CtHhO4qt~~5s33raqktwkkj-y1H-uOCFSWPsfOg__",
                            IsActive = true,
                            IsDiscountPercent = true,
                            ModifiedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            OriginalPrice = 16.99m,
                            QuantityInStock = 200,
                            QuantitySold = 0,
                            Rating = 4.7999999999999998,
                            Title = "Where the Crawdads Sing",
                            Url = "/where-the-crawdads-sing"
                        },
                        new
                        {
                            BookId = new Guid("52d2ae8a-fa54-4e6c-ac9f-45e2ea8e062e"),
                            Author = "Thomas H. Cormen",
                            CreatedBy = new Guid("0f2153fc-bcce-4876-9fcf-383ab9799a70"),
                            DateCreated = new DateTime(2024, 5, 15, 1, 37, 40, 850, DateTimeKind.Local).AddTicks(8402),
                            DateLastModified = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                            DiscountPrice = 12m,
                            ImageUrl = "https://s3-alpha-sig.figma.com/img/8fc2/9edb/ddd8db13bb192848605c5eb55ca236d3?Expires=1716163200&Key-Pair-Id=APKAQ4GOSFWCVNEHN3O4&Signature=nEK2cp1DqH9lWm-t7VnLivuigGkkqrcnw2xWUjH65ggkQKU~lPnqSJsjeL8zAniaBFU196buSycLP5y3yL1mywlDIPXKzPO6QDRJeeiuqyxg5lQmaQvr4wJIMSBIYe9IsALIj5PBJPVc7itX-G7GItpwMhD~61ltU--eLIrPiRNdhlgofhKImYnCNuMluipIWoioJraygFGNXr48SEH3ft5EQ1PwegRVRzjQtWfLUEhR3c4Jmp0azpMTWsSqcRmKxboQefCKZQr-RadHRn9vfQQA6URI3NFDqeDkDoBqbyCBxCWUky74V34nxY5A0wxGK9E5IouecyTn30OKJd5mTQ__",
                            IsActive = true,
                            IsDiscountPercent = true,
                            ModifiedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            OriginalPrice = 23.99m,
                            QuantityInStock = 150,
                            QuantitySold = 0,
                            Rating = 4.5,
                            Title = "Introduction to Algorithms",
                            Url = "/introduction-to-algorithms"
                        },
                        new
                        {
                            BookId = new Guid("0d2634ff-d823-4745-b9d7-e87d582d6173"),
                            Author = "Lori Gottlieb",
                            CreatedBy = new Guid("0f2153fc-bcce-4876-9fcf-383ab9799a70"),
                            DateCreated = new DateTime(2024, 5, 15, 1, 37, 40, 850, DateTimeKind.Local).AddTicks(8418),
                            DateLastModified = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                            DiscountPrice = 8m,
                            ImageUrl = "https://s3-alpha-sig.figma.com/img/d382/ffe7/14d53687669880646de466095672a60c?Expires=1716163200&Key-Pair-Id=APKAQ4GOSFWCVNEHN3O4&Signature=b~QhiYL212syowaBO7x2CJWlsSt~WNcru6m43QizULA8~BvKwYGNHW0vKAXRdFhRG5XUtmSpwDCDFYYWAHGY2gvn7HVhhliGzNa6BgkbUxq1kmMd88I~1OORzpJgmNaMTErorebnQA6EppFQP7MsGCp9Wiu7X1LsXYIwsdZ2ST6oCK3KoZejMIhX9Es93VaCAF0jDZ6IK0NJbf2Exo6F8qqDqeA4otFXAr7aCvBnVnMakq0s0glL8-b6UnMEqD3wkhH7GUeLMxaofy4Zb7vQdpibaKp~KjsMsW5noHyLOqdfn8~14PBY021FzU3~ZDVJ4Q5~eTbnQnZvrHIvDV5l8w__",
                            IsActive = true,
                            IsDiscountPercent = true,
                            ModifiedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            OriginalPrice = 17.59m,
                            QuantityInStock = 240,
                            QuantitySold = 0,
                            Rating = 3.6000000000000001,
                            Title = "Maybe You Should Talk to Someone",
                            Url = "/maybe-you-should-talk-to-someone"
                        },
                        new
                        {
                            BookId = new Guid("0af62686-4f09-4692-9a50-66d26e6a1c09"),
                            Author = "Barbara O’Neal",
                            CreatedBy = new Guid("0f2153fc-bcce-4876-9fcf-383ab9799a70"),
                            DateCreated = new DateTime(2024, 5, 15, 1, 37, 40, 850, DateTimeKind.Local).AddTicks(8432),
                            DateLastModified = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                            DiscountPrice = 11m,
                            ImageUrl = "https://s3-alpha-sig.figma.com/img/ce20/c751/22212be8c4ed077fb6d1a5c029d616f6?Expires=1716163200&Key-Pair-Id=APKAQ4GOSFWCVNEHN3O4&Signature=dSKdBqPysBGOvPZ~Fp3ShPUanqlIuAqdwzmIrw7OQJIM6Z2idPSpcBTeF3mI1OqDi-oof9wO5PDKcCvmON~TjnNI7~9J3wyrxJf4OCbUV9HWW5kd7BrsWzPHr3YS5z9qAoWCwowLZQrlBit3hF8m4qiX1~jaLsyAT5b51yVf-EqH2OGW3WhdX13oCVSeryv1Fq42EnF8gJ5JforvIEEZeReu3VSUtAGUDBPMvc6hv9uPeQ2utEJEtMRJIZ4iuqBq7zXkz2qfxHEh6sHoNbYf9gAIYCIkWfbl-jtU5Dmyn2-jNyeL~3sgaZl09tNd2NZtsXtkM~P99-8SJS6T~Bh4jw__",
                            IsActive = true,
                            IsDiscountPercent = true,
                            ModifiedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            OriginalPrice = 30.99m,
                            QuantityInStock = 210,
                            QuantitySold = 0,
                            Rating = 4.2000000000000002,
                            Title = "When We Believed in Mermaids",
                            Url = "/when-we-believed-in-mermaids"
                        },
                        new
                        {
                            BookId = new Guid("3c50e1aa-8b8f-495b-b262-e90c20241433"),
                            Author = "David Crow",
                            CreatedBy = new Guid("0f2153fc-bcce-4876-9fcf-383ab9799a70"),
                            DateCreated = new DateTime(2024, 5, 15, 1, 37, 40, 850, DateTimeKind.Local).AddTicks(8446),
                            DateLastModified = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                            DiscountPrice = 14m,
                            ImageUrl = "https://s3-alpha-sig.figma.com/img/5e2c/c494/4bb632fc791ce7b3b0a6677d54ee06fb?Expires=1716163200&Key-Pair-Id=APKAQ4GOSFWCVNEHN3O4&Signature=ER7K9yrHzMgNAQfZZYCpceu46eUoIEF~LntEFVpCH5W9a95w2mu7c-y2A6ZFaIUHrAb4Q9U11pDbR5pEsdbpOX8oC~Kzh0q9cAOqkTVYxyodjkZg6sFYdxK8PmFNyoIfqhjI-TK~CsSdQAvzluaVdJzxWNidVsI6Usx-2rS5XJFEeMWCfVmvAEbKXlWfshKsgYsdAA0z~fTdeHPbcWe32oVGZ9tEZfqlJdsc-pyDtIDINmU35DxxQrGSA2K6Zu6Gxo8b8HdLwM2MBcKsIlrbiGqRAYakCxOtKSCJUdIuvDcnfCTgt7hK9pf-YJMB2cfqNUfdbweh4WgypDhYUvBr9w__",
                            IsActive = true,
                            IsDiscountPercent = true,
                            ModifiedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            OriginalPrice = 14.99m,
                            QuantityInStock = 110,
                            QuantitySold = 0,
                            Rating = 3.3999999999999999,
                            Title = "The Pale-Faced Lie",
                            Url = "/the-pale-faced-lie"
                        });
                });

            modelBuilder.Entity("BookStore.DAL.Models.CartItem", b =>
                {
                    b.Property<Guid>("CartItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BookId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("CartItemId");

                    b.ToTable("CartItem");
                });

            modelBuilder.Entity("BookStore.DAL.Models.Category", b =>
                {
                    b.Property<Guid>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateLastModified")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<Guid>("ModifiedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            CategoryId = new Guid("60c25b1f-2ebf-427e-8a8c-896d10cda29d"),
                            CreatedBy = new Guid("0f2153fc-bcce-4876-9fcf-383ab9799a70"),
                            DateCreated = new DateTime(2024, 5, 15, 1, 37, 40, 850, DateTimeKind.Local).AddTicks(8161),
                            DateLastModified = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = true,
                            ModifiedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            Name = "All Books",
                            Quantity = 100,
                            Url = "/all-books"
                        },
                        new
                        {
                            CategoryId = new Guid("25bb8e35-68e8-432b-981a-796ad4dd8a0a"),
                            CreatedBy = new Guid("0f2153fc-bcce-4876-9fcf-383ab9799a70"),
                            DateCreated = new DateTime(2024, 5, 15, 1, 37, 40, 850, DateTimeKind.Local).AddTicks(8277),
                            DateLastModified = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = true,
                            ModifiedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            Name = "Art & Music",
                            Quantity = 100,
                            Url = "/art-and-music"
                        },
                        new
                        {
                            CategoryId = new Guid("ba4f371a-2090-4234-aaca-228653e61e6c"),
                            CreatedBy = new Guid("0f2153fc-bcce-4876-9fcf-383ab9799a70"),
                            DateCreated = new DateTime(2024, 5, 15, 1, 37, 40, 850, DateTimeKind.Local).AddTicks(8291),
                            DateLastModified = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = true,
                            ModifiedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            Name = "Biographies",
                            Quantity = 100,
                            Url = "/biographies"
                        },
                        new
                        {
                            CategoryId = new Guid("1cd608b5-c9db-48e9-8b03-8e03e738e196"),
                            CreatedBy = new Guid("0f2153fc-bcce-4876-9fcf-383ab9799a70"),
                            DateCreated = new DateTime(2024, 5, 15, 1, 37, 40, 850, DateTimeKind.Local).AddTicks(8303),
                            DateLastModified = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = true,
                            ModifiedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            Name = "Kids",
                            Quantity = 100,
                            Url = "/kids"
                        },
                        new
                        {
                            CategoryId = new Guid("654f4c05-9cf0-4be7-ae6e-3d3789efd12c"),
                            CreatedBy = new Guid("0f2153fc-bcce-4876-9fcf-383ab9799a70"),
                            DateCreated = new DateTime(2024, 5, 15, 1, 37, 40, 850, DateTimeKind.Local).AddTicks(8316),
                            DateLastModified = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = true,
                            ModifiedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            Name = "Tech",
                            Quantity = 100,
                            Url = "/tech"
                        });
                });

            modelBuilder.Entity("BookStore.DAL.Models.Order", b =>
                {
                    b.Property<Guid>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateLastModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("District")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<Guid>("ModifiedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("OrderNumber")
                        .HasColumnType("int");

                    b.Property<string>("OrderStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("TotalDiscountPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("TotalQuantity")
                        .HasColumnType("int");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UserNote")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ward")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OrderId");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("BookStore.DAL.Models.OrderItem", b =>
                {
                    b.Property<Guid>("OrderItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BookId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateLastModified")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("DiscountPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("IsDiscountPercent")
                        .HasColumnType("bit");

                    b.Property<Guid>("ModifiedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("OrderId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("OriginalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("OrderItemId");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderItem");
                });

            modelBuilder.Entity("BookStore.DAL.Models.OrderPayment", b =>
                {
                    b.Property<Guid>("OrderPaymentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AccountName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AccountNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Expiry")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("OrderId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PaymentTypeId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("OrderPaymentId");

                    b.HasIndex("OrderId")
                        .IsUnique();

                    b.HasIndex("PaymentTypeId");

                    b.ToTable("OrderPayment");
                });

            modelBuilder.Entity("BookStore.DAL.Models.PaymentType", b =>
                {
                    b.Property<Guid>("PaymentTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("BankName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateLastModified")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<Guid>("ModifiedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("PaymentMethod")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PaymentTypeId");

                    b.ToTable("PaymentType");
                });

            modelBuilder.Entity("BookStore.DAL.Models.Review", b =>
                {
                    b.Property<Guid>("ReviewId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BookId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateLastModified")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<Guid>("ModifiedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.HasKey("ReviewId");

                    b.HasIndex("BookId");

                    b.ToTable("Review");
                });

            modelBuilder.Entity("BookStore.DAL.Models.Role", b =>
                {
                    b.Property<Guid>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateLastModified")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<Guid>("ModifiedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoleId");

                    b.ToTable("Role");

                    b.HasData(
                        new
                        {
                            RoleId = new Guid("5ea82ea9-f04f-4718-993e-5eff478d6fd0"),
                            CreatedBy = new Guid("0f2153fc-bcce-4876-9fcf-383ab9799a70"),
                            DateCreated = new DateTime(2024, 5, 15, 1, 37, 40, 850, DateTimeKind.Local).AddTicks(8499),
                            DateLastModified = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = true,
                            ModifiedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            RoleName = "Administrator"
                        });
                });

            modelBuilder.Entity("BookStore.DAL.Models.User", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateLastModified")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("DefaultUserPaymentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("District")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Province")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ward")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.HasIndex("RoleId");

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            UserId = new Guid("0f2153fc-bcce-4876-9fcf-383ab9799a70"),
                            Address = "123 Highway 1k",
                            DateCreated = new DateTime(2024, 5, 15, 1, 37, 40, 850, DateTimeKind.Local).AddTicks(8475),
                            DateLastModified = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfBirth = new DateTime(1999, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DefaultUserPaymentId = new Guid("00000000-0000-0000-0000-000000000000"),
                            District = "Binh An",
                            Email = "thuanmaildemo@gmail.com",
                            FirstName = "Thuan",
                            Gender = 1,
                            IsActive = true,
                            LastName = "Tran",
                            PhoneNumber = "0123 456 789",
                            Province = "Binh Duong",
                            RoleId = new Guid("5ea82ea9-f04f-4718-993e-5eff478d6fd0"),
                            UserName = "Administrator",
                            UserPassword = "123456",
                            Ward = "Di An"
                        });
                });

            modelBuilder.Entity("BookStore.DAL.Models.UserPayment", b =>
                {
                    b.Property<Guid>("UserPaymentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AccountName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("AccountNumber")
                        .HasColumnType("int");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateLastModified")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Expiry")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDefault")
                        .HasColumnType("bit");

                    b.Property<Guid>("ModifiedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("PaymentPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("PaymentTypeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserPaymentId");

                    b.HasIndex("PaymentTypeId");

                    b.HasIndex("UserId");

                    b.ToTable("UserPayment");
                });

            modelBuilder.Entity("BookCategory", b =>
                {
                    b.HasOne("BookStore.DAL.Models.Book", null)
                        .WithMany()
                        .HasForeignKey("ListBooksBookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookStore.DAL.Models.Category", null)
                        .WithMany()
                        .HasForeignKey("ListCategoriesCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BookStore.DAL.Models.OrderItem", b =>
                {
                    b.HasOne("BookStore.DAL.Models.Order", null)
                        .WithMany("ListOrderItems")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BookStore.DAL.Models.OrderPayment", b =>
                {
                    b.HasOne("BookStore.DAL.Models.Order", null)
                        .WithOne("OrderPayment")
                        .HasForeignKey("BookStore.DAL.Models.OrderPayment", "OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookStore.DAL.Models.PaymentType", "PaymentType")
                        .WithMany()
                        .HasForeignKey("PaymentTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PaymentType");
                });

            modelBuilder.Entity("BookStore.DAL.Models.Review", b =>
                {
                    b.HasOne("BookStore.DAL.Models.Book", null)
                        .WithMany("ListReviews")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BookStore.DAL.Models.User", b =>
                {
                    b.HasOne("BookStore.DAL.Models.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("BookStore.DAL.Models.UserPayment", b =>
                {
                    b.HasOne("BookStore.DAL.Models.PaymentType", "PaymentType")
                        .WithMany()
                        .HasForeignKey("PaymentTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookStore.DAL.Models.User", null)
                        .WithMany("ListUserPayments")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PaymentType");
                });

            modelBuilder.Entity("BookStore.DAL.Models.Book", b =>
                {
                    b.Navigation("ListReviews");
                });

            modelBuilder.Entity("BookStore.DAL.Models.Order", b =>
                {
                    b.Navigation("ListOrderItems");

                    b.Navigation("OrderPayment")
                        .IsRequired();
                });

            modelBuilder.Entity("BookStore.DAL.Models.User", b =>
                {
                    b.Navigation("ListUserPayments");
                });
#pragma warning restore 612, 618
        }
    }
}
