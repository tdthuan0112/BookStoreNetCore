using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookStore.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class UpdateUrl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BookCategory",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { new Guid("2eecb227-a05e-4def-89ef-ff4b8b7e1843"), new Guid("15dadf90-183e-4ffb-b8a8-87f847488e58") });

            migrationBuilder.DeleteData(
                table: "BookCategory",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { new Guid("2eecb227-a05e-4def-89ef-ff4b8b7e1843"), new Guid("1b154465-0947-4d09-8988-7c1ffb4cc1ac") });

            migrationBuilder.DeleteData(
                table: "BookCategory",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { new Guid("7e8f7dbe-3d72-4bf1-b512-55c901641ea4"), new Guid("15dadf90-183e-4ffb-b8a8-87f847488e58") });

            migrationBuilder.DeleteData(
                table: "BookCategory",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { new Guid("7e8f7dbe-3d72-4bf1-b512-55c901641ea4"), new Guid("1b154465-0947-4d09-8988-7c1ffb4cc1ac") });

            migrationBuilder.DeleteData(
                table: "BookCategory",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { new Guid("7e8f7dbe-3d72-4bf1-b512-55c901641ea4"), new Guid("74096c18-d9a9-44a3-af91-12e55ae22d91") });

            migrationBuilder.DeleteData(
                table: "BookCategory",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { new Guid("a42e7b4c-cf11-40da-81ee-6a9cd401815c"), new Guid("15dadf90-183e-4ffb-b8a8-87f847488e58") });

            migrationBuilder.DeleteData(
                table: "BookCategory",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { new Guid("a42e7b4c-cf11-40da-81ee-6a9cd401815c"), new Guid("1b154465-0947-4d09-8988-7c1ffb4cc1ac") });

            migrationBuilder.DeleteData(
                table: "BookCategory",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { new Guid("c47636df-5572-4834-af21-7207ce87ed87"), new Guid("15dadf90-183e-4ffb-b8a8-87f847488e58") });

            migrationBuilder.DeleteData(
                table: "BookCategory",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { new Guid("c47636df-5572-4834-af21-7207ce87ed87"), new Guid("3f17c3b3-02ea-480d-8e73-da9b65f11de1") });

            migrationBuilder.DeleteData(
                table: "BookCategory",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { new Guid("e576a03f-6247-4b57-af16-d8df4bb12c2a"), new Guid("15dadf90-183e-4ffb-b8a8-87f847488e58") });

            migrationBuilder.DeleteData(
                table: "BookCategory",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { new Guid("e576a03f-6247-4b57-af16-d8df4bb12c2a"), new Guid("3f17c3b3-02ea-480d-8e73-da9b65f11de1") });

            migrationBuilder.DeleteData(
                table: "BookCategory",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { new Guid("e576a03f-6247-4b57-af16-d8df4bb12c2a"), new Guid("e455903a-7908-49e7-9a39-66a4453d9fb8") });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UserId",
                keyValue: new Guid("36beea9d-4c24-4163-8dbe-0179de943759"));

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: new Guid("2eecb227-a05e-4def-89ef-ff4b8b7e1843"));

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: new Guid("7e8f7dbe-3d72-4bf1-b512-55c901641ea4"));

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: new Guid("a42e7b4c-cf11-40da-81ee-6a9cd401815c"));

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: new Guid("c47636df-5572-4834-af21-7207ce87ed87"));

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: new Guid("e576a03f-6247-4b57-af16-d8df4bb12c2a"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: new Guid("15dadf90-183e-4ffb-b8a8-87f847488e58"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: new Guid("1b154465-0947-4d09-8988-7c1ffb4cc1ac"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: new Guid("3f17c3b3-02ea-480d-8e73-da9b65f11de1"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: new Guid("74096c18-d9a9-44a3-af91-12e55ae22d91"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: new Guid("e455903a-7908-49e7-9a39-66a4453d9fb8"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "RoleId",
                keyValue: new Guid("3bd50e45-f68f-41b8-bbce-6a66d4c35fe0"));

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "Author", "CreatedBy", "DateCreated", "DateLastModified", "Description", "DiscountPrice", "ImageUrl", "IsActive", "IsDiscountPercent", "ModifiedBy", "OriginalPrice", "QuantityInStock", "QuantitySold", "Rating", "Title", "Url" },
                values: new object[,]
                {
                    { new Guid("122dd70c-046d-4e28-b3c5-73f125d42062"), "Barbara O’Neal", new Guid("57630d03-6fb1-434a-81ed-8f55343b69fd"), new DateTime(2024, 5, 15, 19, 26, 27, 833, DateTimeKind.Local).AddTicks(6000), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 11m, "https://s3-alpha-sig.figma.com/img/ce20/c751/22212be8c4ed077fb6d1a5c029d616f6?Expires=1716163200&Key-Pair-Id=APKAQ4GOSFWCVNEHN3O4&Signature=dSKdBqPysBGOvPZ~Fp3ShPUanqlIuAqdwzmIrw7OQJIM6Z2idPSpcBTeF3mI1OqDi-oof9wO5PDKcCvmON~TjnNI7~9J3wyrxJf4OCbUV9HWW5kd7BrsWzPHr3YS5z9qAoWCwowLZQrlBit3hF8m4qiX1~jaLsyAT5b51yVf-EqH2OGW3WhdX13oCVSeryv1Fq42EnF8gJ5JforvIEEZeReu3VSUtAGUDBPMvc6hv9uPeQ2utEJEtMRJIZ4iuqBq7zXkz2qfxHEh6sHoNbYf9gAIYCIkWfbl-jtU5Dmyn2-jNyeL~3sgaZl09tNd2NZtsXtkM~P99-8SJS6T~Bh4jw__", true, true, new Guid("00000000-0000-0000-0000-000000000000"), 30.99m, 210, 42, 4.2000000000000002, "When We Believed in Mermaids", "when-we-believed-in-mermaids" },
                    { new Guid("19f00202-69df-4159-b4fb-2641d8553c41"), "Delia Owens", new Guid("57630d03-6fb1-434a-81ed-8f55343b69fd"), new DateTime(2024, 5, 15, 19, 26, 27, 833, DateTimeKind.Local).AddTicks(5644), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 10m, "https://s3-alpha-sig.figma.com/img/f9e4/42c7/f4808e98ba531d64c0dff57f7d2c3922?Expires=1716163200&Key-Pair-Id=APKAQ4GOSFWCVNEHN3O4&Signature=CBvZnR15JE2wMzQ4ZIMDxV4I2ans6uyeZouIKzwoIpWz8aeVtUuWylTv5a4A7AGJRuTeOHFIuYDGePYyvUhbjbZMgiSIFBSCeCt19AcBoqvXB07f-3rZEvWfkjXVykyRANzm~Lf7nlSdijaxb6GNmcXG8lyntQwxcIx85OkbHA4vAIRCS6AtImoVY8SGITqVTKCL8PUY-d8tfBEEpcoLUrA8AgaYbtU33MYJ8rxz9eV~cvBtMDpEGy8DWCT3ZYdkQ9orjf-B8srJ8NFoeqw76iskyu-bdRmKjuwYjrWcVmX-v77CtHhO4qt~~5s33raqktwkkj-y1H-uOCFSWPsfOg__", true, true, new Guid("00000000-0000-0000-0000-000000000000"), 16.99m, 200, 24, 4.7999999999999998, "Where the Crawdads Sing", "where-the-crawdads-sing" },
                    { new Guid("23120f05-2b7b-4a05-8533-c2a60a6e5253"), "Lori Gottlieb", new Guid("57630d03-6fb1-434a-81ed-8f55343b69fd"), new DateTime(2024, 5, 15, 19, 26, 27, 833, DateTimeKind.Local).AddTicks(5883), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 8m, "https://s3-alpha-sig.figma.com/img/d382/ffe7/14d53687669880646de466095672a60c?Expires=1716163200&Key-Pair-Id=APKAQ4GOSFWCVNEHN3O4&Signature=b~QhiYL212syowaBO7x2CJWlsSt~WNcru6m43QizULA8~BvKwYGNHW0vKAXRdFhRG5XUtmSpwDCDFYYWAHGY2gvn7HVhhliGzNa6BgkbUxq1kmMd88I~1OORzpJgmNaMTErorebnQA6EppFQP7MsGCp9Wiu7X1LsXYIwsdZ2ST6oCK3KoZejMIhX9Es93VaCAF0jDZ6IK0NJbf2Exo6F8qqDqeA4otFXAr7aCvBnVnMakq0s0glL8-b6UnMEqD3wkhH7GUeLMxaofy4Zb7vQdpibaKp~KjsMsW5noHyLOqdfn8~14PBY021FzU3~ZDVJ4Q5~eTbnQnZvrHIvDV5l8w__", true, true, new Guid("00000000-0000-0000-0000-000000000000"), 17.59m, 240, 7, 3.6000000000000001, "Maybe You Should Talk to Someone", "maybe-you-should-talk-to-someone" },
                    { new Guid("3b6e70ca-dcd8-44b9-af64-24aa0d057cfb"), "David Crow", new Guid("57630d03-6fb1-434a-81ed-8f55343b69fd"), new DateTime(2024, 5, 15, 19, 26, 27, 833, DateTimeKind.Local).AddTicks(6006), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 14m, "https://s3-alpha-sig.figma.com/img/5e2c/c494/4bb632fc791ce7b3b0a6677d54ee06fb?Expires=1716163200&Key-Pair-Id=APKAQ4GOSFWCVNEHN3O4&Signature=ER7K9yrHzMgNAQfZZYCpceu46eUoIEF~LntEFVpCH5W9a95w2mu7c-y2A6ZFaIUHrAb4Q9U11pDbR5pEsdbpOX8oC~Kzh0q9cAOqkTVYxyodjkZg6sFYdxK8PmFNyoIfqhjI-TK~CsSdQAvzluaVdJzxWNidVsI6Usx-2rS5XJFEeMWCfVmvAEbKXlWfshKsgYsdAA0z~fTdeHPbcWe32oVGZ9tEZfqlJdsc-pyDtIDINmU35DxxQrGSA2K6Zu6Gxo8b8HdLwM2MBcKsIlrbiGqRAYakCxOtKSCJUdIuvDcnfCTgt7hK9pf-YJMB2cfqNUfdbweh4WgypDhYUvBr9w__", true, true, new Guid("00000000-0000-0000-0000-000000000000"), 14.99m, 110, 6, 3.3999999999999999, "The Pale-Faced Lie", "the-pale-faced-lie" },
                    { new Guid("43d39e45-6232-476d-9e50-82e611afb474"), "Thomas H. Cormen", new Guid("57630d03-6fb1-434a-81ed-8f55343b69fd"), new DateTime(2024, 5, 15, 19, 26, 27, 833, DateTimeKind.Local).AddTicks(5879), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 12m, "https://s3-alpha-sig.figma.com/img/8fc2/9edb/ddd8db13bb192848605c5eb55ca236d3?Expires=1716163200&Key-Pair-Id=APKAQ4GOSFWCVNEHN3O4&Signature=nEK2cp1DqH9lWm-t7VnLivuigGkkqrcnw2xWUjH65ggkQKU~lPnqSJsjeL8zAniaBFU196buSycLP5y3yL1mywlDIPXKzPO6QDRJeeiuqyxg5lQmaQvr4wJIMSBIYe9IsALIj5PBJPVc7itX-G7GItpwMhD~61ltU--eLIrPiRNdhlgofhKImYnCNuMluipIWoioJraygFGNXr48SEH3ft5EQ1PwegRVRzjQtWfLUEhR3c4Jmp0azpMTWsSqcRmKxboQefCKZQr-RadHRn9vfQQA6URI3NFDqeDkDoBqbyCBxCWUky74V34nxY5A0wxGK9E5IouecyTn30OKJd5mTQ__", true, true, new Guid("00000000-0000-0000-0000-000000000000"), 23.99m, 150, 16, 4.5, "Introduction to Algorithms", "introduction-to-algorithms" }
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "CreatedBy", "DateCreated", "DateLastModified", "IsActive", "ModifiedBy", "Name", "Quantity", "Url" },
                values: new object[,]
                {
                    { new Guid("31c89000-c8fe-46b7-a353-aac5c8db1809"), new Guid("57630d03-6fb1-434a-81ed-8f55343b69fd"), new DateTime(2024, 5, 15, 19, 26, 27, 833, DateTimeKind.Local).AddTicks(4497), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new Guid("00000000-0000-0000-0000-000000000000"), "Art & Music", 100, "art-and-music" },
                    { new Guid("5fb3467d-784f-4fdb-8520-b8fc29c7ed80"), new Guid("57630d03-6fb1-434a-81ed-8f55343b69fd"), new DateTime(2024, 5, 15, 19, 26, 27, 832, DateTimeKind.Local).AddTicks(7504), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new Guid("00000000-0000-0000-0000-000000000000"), "All Books", 100, "all-books" },
                    { new Guid("7d87a5b3-a7ef-4235-802a-f2a0d6e0c2f5"), new Guid("57630d03-6fb1-434a-81ed-8f55343b69fd"), new DateTime(2024, 5, 15, 19, 26, 27, 833, DateTimeKind.Local).AddTicks(4514), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new Guid("00000000-0000-0000-0000-000000000000"), "Tech", 100, "tech" },
                    { new Guid("81d05496-72b1-4cbd-acc9-7ec15318af33"), new Guid("57630d03-6fb1-434a-81ed-8f55343b69fd"), new DateTime(2024, 5, 15, 19, 26, 27, 833, DateTimeKind.Local).AddTicks(4510), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new Guid("00000000-0000-0000-0000-000000000000"), "Biographies", 100, "biographies" },
                    { new Guid("cec19f04-245b-477a-9f8d-ac90d91e9000"), new Guid("57630d03-6fb1-434a-81ed-8f55343b69fd"), new DateTime(2024, 5, 15, 19, 26, 27, 833, DateTimeKind.Local).AddTicks(4512), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new Guid("00000000-0000-0000-0000-000000000000"), "Kids", 100, "kids" }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "RoleId", "CreatedBy", "DateCreated", "DateLastModified", "IsActive", "ModifiedBy", "RoleName" },
                values: new object[] { new Guid("b7e33288-6773-491a-8866-ae399456bed1"), new Guid("57630d03-6fb1-434a-81ed-8f55343b69fd"), new DateTime(2024, 5, 15, 19, 26, 27, 833, DateTimeKind.Local).AddTicks(8613), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new Guid("00000000-0000-0000-0000-000000000000"), "Administrator" });

            migrationBuilder.InsertData(
                table: "BookCategory",
                columns: new[] { "BookId", "CategoryId" },
                values: new object[,]
                {
                    { new Guid("122dd70c-046d-4e28-b3c5-73f125d42062"), new Guid("5fb3467d-784f-4fdb-8520-b8fc29c7ed80") },
                    { new Guid("122dd70c-046d-4e28-b3c5-73f125d42062"), new Guid("81d05496-72b1-4cbd-acc9-7ec15318af33") },
                    { new Guid("122dd70c-046d-4e28-b3c5-73f125d42062"), new Guid("cec19f04-245b-477a-9f8d-ac90d91e9000") },
                    { new Guid("19f00202-69df-4159-b4fb-2641d8553c41"), new Guid("31c89000-c8fe-46b7-a353-aac5c8db1809") },
                    { new Guid("19f00202-69df-4159-b4fb-2641d8553c41"), new Guid("5fb3467d-784f-4fdb-8520-b8fc29c7ed80") },
                    { new Guid("23120f05-2b7b-4a05-8533-c2a60a6e5253"), new Guid("31c89000-c8fe-46b7-a353-aac5c8db1809") },
                    { new Guid("23120f05-2b7b-4a05-8533-c2a60a6e5253"), new Guid("5fb3467d-784f-4fdb-8520-b8fc29c7ed80") },
                    { new Guid("3b6e70ca-dcd8-44b9-af64-24aa0d057cfb"), new Guid("31c89000-c8fe-46b7-a353-aac5c8db1809") },
                    { new Guid("3b6e70ca-dcd8-44b9-af64-24aa0d057cfb"), new Guid("5fb3467d-784f-4fdb-8520-b8fc29c7ed80") },
                    { new Guid("3b6e70ca-dcd8-44b9-af64-24aa0d057cfb"), new Guid("7d87a5b3-a7ef-4235-802a-f2a0d6e0c2f5") },
                    { new Guid("43d39e45-6232-476d-9e50-82e611afb474"), new Guid("5fb3467d-784f-4fdb-8520-b8fc29c7ed80") },
                    { new Guid("43d39e45-6232-476d-9e50-82e611afb474"), new Guid("81d05496-72b1-4cbd-acc9-7ec15318af33") }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "UserId", "Address", "DateCreated", "DateLastModified", "DateOfBirth", "DefaultUserPaymentId", "District", "Email", "FirstName", "Gender", "IsActive", "LastName", "PhoneNumber", "Province", "RoleId", "UserName", "UserPassword", "Ward" },
                values: new object[] { new Guid("57630d03-6fb1-434a-81ed-8f55343b69fd"), "123 Highway 1k", new DateTime(2024, 5, 15, 19, 26, 27, 833, DateTimeKind.Local).AddTicks(7968), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), "Binh An", "thuanmaildemo@gmail.com", "Thuan", 1, true, "Tran", "0123 456 789", "Binh Duong", new Guid("b7e33288-6773-491a-8866-ae399456bed1"), "Administrator", "123456", "Di An" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BookCategory",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { new Guid("122dd70c-046d-4e28-b3c5-73f125d42062"), new Guid("5fb3467d-784f-4fdb-8520-b8fc29c7ed80") });

            migrationBuilder.DeleteData(
                table: "BookCategory",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { new Guid("122dd70c-046d-4e28-b3c5-73f125d42062"), new Guid("81d05496-72b1-4cbd-acc9-7ec15318af33") });

            migrationBuilder.DeleteData(
                table: "BookCategory",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { new Guid("122dd70c-046d-4e28-b3c5-73f125d42062"), new Guid("cec19f04-245b-477a-9f8d-ac90d91e9000") });

            migrationBuilder.DeleteData(
                table: "BookCategory",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { new Guid("19f00202-69df-4159-b4fb-2641d8553c41"), new Guid("31c89000-c8fe-46b7-a353-aac5c8db1809") });

            migrationBuilder.DeleteData(
                table: "BookCategory",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { new Guid("19f00202-69df-4159-b4fb-2641d8553c41"), new Guid("5fb3467d-784f-4fdb-8520-b8fc29c7ed80") });

            migrationBuilder.DeleteData(
                table: "BookCategory",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { new Guid("23120f05-2b7b-4a05-8533-c2a60a6e5253"), new Guid("31c89000-c8fe-46b7-a353-aac5c8db1809") });

            migrationBuilder.DeleteData(
                table: "BookCategory",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { new Guid("23120f05-2b7b-4a05-8533-c2a60a6e5253"), new Guid("5fb3467d-784f-4fdb-8520-b8fc29c7ed80") });

            migrationBuilder.DeleteData(
                table: "BookCategory",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { new Guid("3b6e70ca-dcd8-44b9-af64-24aa0d057cfb"), new Guid("31c89000-c8fe-46b7-a353-aac5c8db1809") });

            migrationBuilder.DeleteData(
                table: "BookCategory",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { new Guid("3b6e70ca-dcd8-44b9-af64-24aa0d057cfb"), new Guid("5fb3467d-784f-4fdb-8520-b8fc29c7ed80") });

            migrationBuilder.DeleteData(
                table: "BookCategory",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { new Guid("3b6e70ca-dcd8-44b9-af64-24aa0d057cfb"), new Guid("7d87a5b3-a7ef-4235-802a-f2a0d6e0c2f5") });

            migrationBuilder.DeleteData(
                table: "BookCategory",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { new Guid("43d39e45-6232-476d-9e50-82e611afb474"), new Guid("5fb3467d-784f-4fdb-8520-b8fc29c7ed80") });

            migrationBuilder.DeleteData(
                table: "BookCategory",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { new Guid("43d39e45-6232-476d-9e50-82e611afb474"), new Guid("81d05496-72b1-4cbd-acc9-7ec15318af33") });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UserId",
                keyValue: new Guid("57630d03-6fb1-434a-81ed-8f55343b69fd"));

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: new Guid("122dd70c-046d-4e28-b3c5-73f125d42062"));

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: new Guid("19f00202-69df-4159-b4fb-2641d8553c41"));

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: new Guid("23120f05-2b7b-4a05-8533-c2a60a6e5253"));

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: new Guid("3b6e70ca-dcd8-44b9-af64-24aa0d057cfb"));

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: new Guid("43d39e45-6232-476d-9e50-82e611afb474"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: new Guid("31c89000-c8fe-46b7-a353-aac5c8db1809"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: new Guid("5fb3467d-784f-4fdb-8520-b8fc29c7ed80"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: new Guid("7d87a5b3-a7ef-4235-802a-f2a0d6e0c2f5"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: new Guid("81d05496-72b1-4cbd-acc9-7ec15318af33"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: new Guid("cec19f04-245b-477a-9f8d-ac90d91e9000"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "RoleId",
                keyValue: new Guid("b7e33288-6773-491a-8866-ae399456bed1"));

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "Author", "CreatedBy", "DateCreated", "DateLastModified", "Description", "DiscountPrice", "ImageUrl", "IsActive", "IsDiscountPercent", "ModifiedBy", "OriginalPrice", "QuantityInStock", "QuantitySold", "Rating", "Title", "Url" },
                values: new object[,]
                {
                    { new Guid("2eecb227-a05e-4def-89ef-ff4b8b7e1843"), "Delia Owens", new Guid("36beea9d-4c24-4163-8dbe-0179de943759"), new DateTime(2024, 5, 15, 12, 27, 44, 383, DateTimeKind.Local).AddTicks(6499), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 10m, "https://s3-alpha-sig.figma.com/img/f9e4/42c7/f4808e98ba531d64c0dff57f7d2c3922?Expires=1716163200&Key-Pair-Id=APKAQ4GOSFWCVNEHN3O4&Signature=CBvZnR15JE2wMzQ4ZIMDxV4I2ans6uyeZouIKzwoIpWz8aeVtUuWylTv5a4A7AGJRuTeOHFIuYDGePYyvUhbjbZMgiSIFBSCeCt19AcBoqvXB07f-3rZEvWfkjXVykyRANzm~Lf7nlSdijaxb6GNmcXG8lyntQwxcIx85OkbHA4vAIRCS6AtImoVY8SGITqVTKCL8PUY-d8tfBEEpcoLUrA8AgaYbtU33MYJ8rxz9eV~cvBtMDpEGy8DWCT3ZYdkQ9orjf-B8srJ8NFoeqw76iskyu-bdRmKjuwYjrWcVmX-v77CtHhO4qt~~5s33raqktwkkj-y1H-uOCFSWPsfOg__", true, true, new Guid("00000000-0000-0000-0000-000000000000"), 16.99m, 200, 24, 4.7999999999999998, "Where the Crawdads Sing", "/where-the-crawdads-sing" },
                    { new Guid("7e8f7dbe-3d72-4bf1-b512-55c901641ea4"), "David Crow", new Guid("36beea9d-4c24-4163-8dbe-0179de943759"), new DateTime(2024, 5, 15, 12, 27, 44, 383, DateTimeKind.Local).AddTicks(6853), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 14m, "https://s3-alpha-sig.figma.com/img/5e2c/c494/4bb632fc791ce7b3b0a6677d54ee06fb?Expires=1716163200&Key-Pair-Id=APKAQ4GOSFWCVNEHN3O4&Signature=ER7K9yrHzMgNAQfZZYCpceu46eUoIEF~LntEFVpCH5W9a95w2mu7c-y2A6ZFaIUHrAb4Q9U11pDbR5pEsdbpOX8oC~Kzh0q9cAOqkTVYxyodjkZg6sFYdxK8PmFNyoIfqhjI-TK~CsSdQAvzluaVdJzxWNidVsI6Usx-2rS5XJFEeMWCfVmvAEbKXlWfshKsgYsdAA0z~fTdeHPbcWe32oVGZ9tEZfqlJdsc-pyDtIDINmU35DxxQrGSA2K6Zu6Gxo8b8HdLwM2MBcKsIlrbiGqRAYakCxOtKSCJUdIuvDcnfCTgt7hK9pf-YJMB2cfqNUfdbweh4WgypDhYUvBr9w__", true, true, new Guid("00000000-0000-0000-0000-000000000000"), 14.99m, 110, 6, 3.3999999999999999, "The Pale-Faced Lie", "/the-pale-faced-lie" },
                    { new Guid("a42e7b4c-cf11-40da-81ee-6a9cd401815c"), "Lori Gottlieb", new Guid("36beea9d-4c24-4163-8dbe-0179de943759"), new DateTime(2024, 5, 15, 12, 27, 44, 383, DateTimeKind.Local).AddTicks(6722), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 8m, "https://s3-alpha-sig.figma.com/img/d382/ffe7/14d53687669880646de466095672a60c?Expires=1716163200&Key-Pair-Id=APKAQ4GOSFWCVNEHN3O4&Signature=b~QhiYL212syowaBO7x2CJWlsSt~WNcru6m43QizULA8~BvKwYGNHW0vKAXRdFhRG5XUtmSpwDCDFYYWAHGY2gvn7HVhhliGzNa6BgkbUxq1kmMd88I~1OORzpJgmNaMTErorebnQA6EppFQP7MsGCp9Wiu7X1LsXYIwsdZ2ST6oCK3KoZejMIhX9Es93VaCAF0jDZ6IK0NJbf2Exo6F8qqDqeA4otFXAr7aCvBnVnMakq0s0glL8-b6UnMEqD3wkhH7GUeLMxaofy4Zb7vQdpibaKp~KjsMsW5noHyLOqdfn8~14PBY021FzU3~ZDVJ4Q5~eTbnQnZvrHIvDV5l8w__", true, true, new Guid("00000000-0000-0000-0000-000000000000"), 17.59m, 240, 7, 3.6000000000000001, "Maybe You Should Talk to Someone", "/maybe-you-should-talk-to-someone" },
                    { new Guid("c47636df-5572-4834-af21-7207ce87ed87"), "Thomas H. Cormen", new Guid("36beea9d-4c24-4163-8dbe-0179de943759"), new DateTime(2024, 5, 15, 12, 27, 44, 383, DateTimeKind.Local).AddTicks(6719), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 12m, "https://s3-alpha-sig.figma.com/img/8fc2/9edb/ddd8db13bb192848605c5eb55ca236d3?Expires=1716163200&Key-Pair-Id=APKAQ4GOSFWCVNEHN3O4&Signature=nEK2cp1DqH9lWm-t7VnLivuigGkkqrcnw2xWUjH65ggkQKU~lPnqSJsjeL8zAniaBFU196buSycLP5y3yL1mywlDIPXKzPO6QDRJeeiuqyxg5lQmaQvr4wJIMSBIYe9IsALIj5PBJPVc7itX-G7GItpwMhD~61ltU--eLIrPiRNdhlgofhKImYnCNuMluipIWoioJraygFGNXr48SEH3ft5EQ1PwegRVRzjQtWfLUEhR3c4Jmp0azpMTWsSqcRmKxboQefCKZQr-RadHRn9vfQQA6URI3NFDqeDkDoBqbyCBxCWUky74V34nxY5A0wxGK9E5IouecyTn30OKJd5mTQ__", true, true, new Guid("00000000-0000-0000-0000-000000000000"), 23.99m, 150, 16, 4.5, "Introduction to Algorithms", "/introduction-to-algorithms" },
                    { new Guid("e576a03f-6247-4b57-af16-d8df4bb12c2a"), "Barbara O’Neal", new Guid("36beea9d-4c24-4163-8dbe-0179de943759"), new DateTime(2024, 5, 15, 12, 27, 44, 383, DateTimeKind.Local).AddTicks(6839), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 11m, "https://s3-alpha-sig.figma.com/img/ce20/c751/22212be8c4ed077fb6d1a5c029d616f6?Expires=1716163200&Key-Pair-Id=APKAQ4GOSFWCVNEHN3O4&Signature=dSKdBqPysBGOvPZ~Fp3ShPUanqlIuAqdwzmIrw7OQJIM6Z2idPSpcBTeF3mI1OqDi-oof9wO5PDKcCvmON~TjnNI7~9J3wyrxJf4OCbUV9HWW5kd7BrsWzPHr3YS5z9qAoWCwowLZQrlBit3hF8m4qiX1~jaLsyAT5b51yVf-EqH2OGW3WhdX13oCVSeryv1Fq42EnF8gJ5JforvIEEZeReu3VSUtAGUDBPMvc6hv9uPeQ2utEJEtMRJIZ4iuqBq7zXkz2qfxHEh6sHoNbYf9gAIYCIkWfbl-jtU5Dmyn2-jNyeL~3sgaZl09tNd2NZtsXtkM~P99-8SJS6T~Bh4jw__", true, true, new Guid("00000000-0000-0000-0000-000000000000"), 30.99m, 210, 42, 4.2000000000000002, "When We Believed in Mermaids", "/when-we-believed-in-mermaids" }
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "CreatedBy", "DateCreated", "DateLastModified", "IsActive", "ModifiedBy", "Name", "Quantity", "Url" },
                values: new object[,]
                {
                    { new Guid("15dadf90-183e-4ffb-b8a8-87f847488e58"), new Guid("36beea9d-4c24-4163-8dbe-0179de943759"), new DateTime(2024, 5, 15, 12, 27, 44, 382, DateTimeKind.Local).AddTicks(8805), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new Guid("00000000-0000-0000-0000-000000000000"), "All Books", 100, "/all-books" },
                    { new Guid("1b154465-0947-4d09-8988-7c1ffb4cc1ac"), new Guid("36beea9d-4c24-4163-8dbe-0179de943759"), new DateTime(2024, 5, 15, 12, 27, 44, 383, DateTimeKind.Local).AddTicks(5360), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new Guid("00000000-0000-0000-0000-000000000000"), "Art & Music", 100, "/art-and-music" },
                    { new Guid("3f17c3b3-02ea-480d-8e73-da9b65f11de1"), new Guid("36beea9d-4c24-4163-8dbe-0179de943759"), new DateTime(2024, 5, 15, 12, 27, 44, 383, DateTimeKind.Local).AddTicks(5372), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new Guid("00000000-0000-0000-0000-000000000000"), "Biographies", 100, "/biographies" },
                    { new Guid("74096c18-d9a9-44a3-af91-12e55ae22d91"), new Guid("36beea9d-4c24-4163-8dbe-0179de943759"), new DateTime(2024, 5, 15, 12, 27, 44, 383, DateTimeKind.Local).AddTicks(5376), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new Guid("00000000-0000-0000-0000-000000000000"), "Tech", 100, "/tech" },
                    { new Guid("e455903a-7908-49e7-9a39-66a4453d9fb8"), new Guid("36beea9d-4c24-4163-8dbe-0179de943759"), new DateTime(2024, 5, 15, 12, 27, 44, 383, DateTimeKind.Local).AddTicks(5375), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new Guid("00000000-0000-0000-0000-000000000000"), "Kids", 100, "/kids" }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "RoleId", "CreatedBy", "DateCreated", "DateLastModified", "IsActive", "ModifiedBy", "RoleName" },
                values: new object[] { new Guid("3bd50e45-f68f-41b8-bbce-6a66d4c35fe0"), new Guid("36beea9d-4c24-4163-8dbe-0179de943759"), new DateTime(2024, 5, 15, 12, 27, 44, 383, DateTimeKind.Local).AddTicks(9534), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new Guid("00000000-0000-0000-0000-000000000000"), "Administrator" });

            migrationBuilder.InsertData(
                table: "BookCategory",
                columns: new[] { "BookId", "CategoryId" },
                values: new object[,]
                {
                    { new Guid("2eecb227-a05e-4def-89ef-ff4b8b7e1843"), new Guid("15dadf90-183e-4ffb-b8a8-87f847488e58") },
                    { new Guid("2eecb227-a05e-4def-89ef-ff4b8b7e1843"), new Guid("1b154465-0947-4d09-8988-7c1ffb4cc1ac") },
                    { new Guid("7e8f7dbe-3d72-4bf1-b512-55c901641ea4"), new Guid("15dadf90-183e-4ffb-b8a8-87f847488e58") },
                    { new Guid("7e8f7dbe-3d72-4bf1-b512-55c901641ea4"), new Guid("1b154465-0947-4d09-8988-7c1ffb4cc1ac") },
                    { new Guid("7e8f7dbe-3d72-4bf1-b512-55c901641ea4"), new Guid("74096c18-d9a9-44a3-af91-12e55ae22d91") },
                    { new Guid("a42e7b4c-cf11-40da-81ee-6a9cd401815c"), new Guid("15dadf90-183e-4ffb-b8a8-87f847488e58") },
                    { new Guid("a42e7b4c-cf11-40da-81ee-6a9cd401815c"), new Guid("1b154465-0947-4d09-8988-7c1ffb4cc1ac") },
                    { new Guid("c47636df-5572-4834-af21-7207ce87ed87"), new Guid("15dadf90-183e-4ffb-b8a8-87f847488e58") },
                    { new Guid("c47636df-5572-4834-af21-7207ce87ed87"), new Guid("3f17c3b3-02ea-480d-8e73-da9b65f11de1") },
                    { new Guid("e576a03f-6247-4b57-af16-d8df4bb12c2a"), new Guid("15dadf90-183e-4ffb-b8a8-87f847488e58") },
                    { new Guid("e576a03f-6247-4b57-af16-d8df4bb12c2a"), new Guid("3f17c3b3-02ea-480d-8e73-da9b65f11de1") },
                    { new Guid("e576a03f-6247-4b57-af16-d8df4bb12c2a"), new Guid("e455903a-7908-49e7-9a39-66a4453d9fb8") }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "UserId", "Address", "DateCreated", "DateLastModified", "DateOfBirth", "DefaultUserPaymentId", "District", "Email", "FirstName", "Gender", "IsActive", "LastName", "PhoneNumber", "Province", "RoleId", "UserName", "UserPassword", "Ward" },
                values: new object[] { new Guid("36beea9d-4c24-4163-8dbe-0179de943759"), "123 Highway 1k", new DateTime(2024, 5, 15, 12, 27, 44, 383, DateTimeKind.Local).AddTicks(8851), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), "Binh An", "thuanmaildemo@gmail.com", "Thuan", 1, true, "Tran", "0123 456 789", "Binh Duong", new Guid("3bd50e45-f68f-41b8-bbce-6a66d4c35fe0"), "Administrator", "123456", "Di An" });
        }
    }
}
