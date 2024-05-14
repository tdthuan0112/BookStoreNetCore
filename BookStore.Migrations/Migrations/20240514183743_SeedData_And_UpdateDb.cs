using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookStore.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class SeedData_And_UpdateDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Category");

            migrationBuilder.AlterColumn<int>(
                name: "Gender",
                table: "User",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "Category",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "Rating",
                table: "Book",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "Url",
                table: "Book",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "Author", "CreatedBy", "DateCreated", "DateLastModified", "Description", "DiscountPrice", "ImageUrl", "IsActive", "IsDiscountPercent", "ModifiedBy", "OriginalPrice", "QuantityInStock", "QuantitySold", "Rating", "Title", "Url" },
                values: new object[,]
                {
                    { new Guid("0af62686-4f09-4692-9a50-66d26e6a1c09"), "Barbara O’Neal", new Guid("0f2153fc-bcce-4876-9fcf-383ab9799a70"), new DateTime(2024, 5, 15, 1, 37, 40, 850, DateTimeKind.Local).AddTicks(8432), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 11m, "https://s3-alpha-sig.figma.com/img/ce20/c751/22212be8c4ed077fb6d1a5c029d616f6?Expires=1716163200&Key-Pair-Id=APKAQ4GOSFWCVNEHN3O4&Signature=dSKdBqPysBGOvPZ~Fp3ShPUanqlIuAqdwzmIrw7OQJIM6Z2idPSpcBTeF3mI1OqDi-oof9wO5PDKcCvmON~TjnNI7~9J3wyrxJf4OCbUV9HWW5kd7BrsWzPHr3YS5z9qAoWCwowLZQrlBit3hF8m4qiX1~jaLsyAT5b51yVf-EqH2OGW3WhdX13oCVSeryv1Fq42EnF8gJ5JforvIEEZeReu3VSUtAGUDBPMvc6hv9uPeQ2utEJEtMRJIZ4iuqBq7zXkz2qfxHEh6sHoNbYf9gAIYCIkWfbl-jtU5Dmyn2-jNyeL~3sgaZl09tNd2NZtsXtkM~P99-8SJS6T~Bh4jw__", true, true, new Guid("00000000-0000-0000-0000-000000000000"), 30.99m, 210, 0, 4.2000000000000002, "When We Believed in Mermaids", "/when-we-believed-in-mermaids" },
                    { new Guid("0d2634ff-d823-4745-b9d7-e87d582d6173"), "Lori Gottlieb", new Guid("0f2153fc-bcce-4876-9fcf-383ab9799a70"), new DateTime(2024, 5, 15, 1, 37, 40, 850, DateTimeKind.Local).AddTicks(8418), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 8m, "https://s3-alpha-sig.figma.com/img/d382/ffe7/14d53687669880646de466095672a60c?Expires=1716163200&Key-Pair-Id=APKAQ4GOSFWCVNEHN3O4&Signature=b~QhiYL212syowaBO7x2CJWlsSt~WNcru6m43QizULA8~BvKwYGNHW0vKAXRdFhRG5XUtmSpwDCDFYYWAHGY2gvn7HVhhliGzNa6BgkbUxq1kmMd88I~1OORzpJgmNaMTErorebnQA6EppFQP7MsGCp9Wiu7X1LsXYIwsdZ2ST6oCK3KoZejMIhX9Es93VaCAF0jDZ6IK0NJbf2Exo6F8qqDqeA4otFXAr7aCvBnVnMakq0s0glL8-b6UnMEqD3wkhH7GUeLMxaofy4Zb7vQdpibaKp~KjsMsW5noHyLOqdfn8~14PBY021FzU3~ZDVJ4Q5~eTbnQnZvrHIvDV5l8w__", true, true, new Guid("00000000-0000-0000-0000-000000000000"), 17.59m, 240, 0, 3.6000000000000001, "Maybe You Should Talk to Someone", "/maybe-you-should-talk-to-someone" },
                    { new Guid("3c50e1aa-8b8f-495b-b262-e90c20241433"), "David Crow", new Guid("0f2153fc-bcce-4876-9fcf-383ab9799a70"), new DateTime(2024, 5, 15, 1, 37, 40, 850, DateTimeKind.Local).AddTicks(8446), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 14m, "https://s3-alpha-sig.figma.com/img/5e2c/c494/4bb632fc791ce7b3b0a6677d54ee06fb?Expires=1716163200&Key-Pair-Id=APKAQ4GOSFWCVNEHN3O4&Signature=ER7K9yrHzMgNAQfZZYCpceu46eUoIEF~LntEFVpCH5W9a95w2mu7c-y2A6ZFaIUHrAb4Q9U11pDbR5pEsdbpOX8oC~Kzh0q9cAOqkTVYxyodjkZg6sFYdxK8PmFNyoIfqhjI-TK~CsSdQAvzluaVdJzxWNidVsI6Usx-2rS5XJFEeMWCfVmvAEbKXlWfshKsgYsdAA0z~fTdeHPbcWe32oVGZ9tEZfqlJdsc-pyDtIDINmU35DxxQrGSA2K6Zu6Gxo8b8HdLwM2MBcKsIlrbiGqRAYakCxOtKSCJUdIuvDcnfCTgt7hK9pf-YJMB2cfqNUfdbweh4WgypDhYUvBr9w__", true, true, new Guid("00000000-0000-0000-0000-000000000000"), 14.99m, 110, 0, 3.3999999999999999, "The Pale-Faced Lie", "/the-pale-faced-lie" },
                    { new Guid("52d2ae8a-fa54-4e6c-ac9f-45e2ea8e062e"), "Thomas H. Cormen", new Guid("0f2153fc-bcce-4876-9fcf-383ab9799a70"), new DateTime(2024, 5, 15, 1, 37, 40, 850, DateTimeKind.Local).AddTicks(8402), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 12m, "https://s3-alpha-sig.figma.com/img/8fc2/9edb/ddd8db13bb192848605c5eb55ca236d3?Expires=1716163200&Key-Pair-Id=APKAQ4GOSFWCVNEHN3O4&Signature=nEK2cp1DqH9lWm-t7VnLivuigGkkqrcnw2xWUjH65ggkQKU~lPnqSJsjeL8zAniaBFU196buSycLP5y3yL1mywlDIPXKzPO6QDRJeeiuqyxg5lQmaQvr4wJIMSBIYe9IsALIj5PBJPVc7itX-G7GItpwMhD~61ltU--eLIrPiRNdhlgofhKImYnCNuMluipIWoioJraygFGNXr48SEH3ft5EQ1PwegRVRzjQtWfLUEhR3c4Jmp0azpMTWsSqcRmKxboQefCKZQr-RadHRn9vfQQA6URI3NFDqeDkDoBqbyCBxCWUky74V34nxY5A0wxGK9E5IouecyTn30OKJd5mTQ__", true, true, new Guid("00000000-0000-0000-0000-000000000000"), 23.99m, 150, 0, 4.5, "Introduction to Algorithms", "/introduction-to-algorithms" },
                    { new Guid("951360cd-83cc-4e69-a84c-9fc82f122947"), "Delia Owens", new Guid("0f2153fc-bcce-4876-9fcf-383ab9799a70"), new DateTime(2024, 5, 15, 1, 37, 40, 850, DateTimeKind.Local).AddTicks(8379), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 10m, "https://s3-alpha-sig.figma.com/img/f9e4/42c7/f4808e98ba531d64c0dff57f7d2c3922?Expires=1716163200&Key-Pair-Id=APKAQ4GOSFWCVNEHN3O4&Signature=CBvZnR15JE2wMzQ4ZIMDxV4I2ans6uyeZouIKzwoIpWz8aeVtUuWylTv5a4A7AGJRuTeOHFIuYDGePYyvUhbjbZMgiSIFBSCeCt19AcBoqvXB07f-3rZEvWfkjXVykyRANzm~Lf7nlSdijaxb6GNmcXG8lyntQwxcIx85OkbHA4vAIRCS6AtImoVY8SGITqVTKCL8PUY-d8tfBEEpcoLUrA8AgaYbtU33MYJ8rxz9eV~cvBtMDpEGy8DWCT3ZYdkQ9orjf-B8srJ8NFoeqw76iskyu-bdRmKjuwYjrWcVmX-v77CtHhO4qt~~5s33raqktwkkj-y1H-uOCFSWPsfOg__", true, true, new Guid("00000000-0000-0000-0000-000000000000"), 16.99m, 200, 0, 4.7999999999999998, "Where the Crawdads Sing", "/where-the-crawdads-sing" }
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "CreatedBy", "DateCreated", "DateLastModified", "IsActive", "ModifiedBy", "Name", "Quantity", "Url" },
                values: new object[,]
                {
                    { new Guid("1cd608b5-c9db-48e9-8b03-8e03e738e196"), new Guid("0f2153fc-bcce-4876-9fcf-383ab9799a70"), new DateTime(2024, 5, 15, 1, 37, 40, 850, DateTimeKind.Local).AddTicks(8303), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new Guid("00000000-0000-0000-0000-000000000000"), "Kids", 100, "/kids" },
                    { new Guid("25bb8e35-68e8-432b-981a-796ad4dd8a0a"), new Guid("0f2153fc-bcce-4876-9fcf-383ab9799a70"), new DateTime(2024, 5, 15, 1, 37, 40, 850, DateTimeKind.Local).AddTicks(8277), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new Guid("00000000-0000-0000-0000-000000000000"), "Art & Music", 100, "/art-and-music" },
                    { new Guid("60c25b1f-2ebf-427e-8a8c-896d10cda29d"), new Guid("0f2153fc-bcce-4876-9fcf-383ab9799a70"), new DateTime(2024, 5, 15, 1, 37, 40, 850, DateTimeKind.Local).AddTicks(8161), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new Guid("00000000-0000-0000-0000-000000000000"), "All Books", 100, "/all-books" },
                    { new Guid("654f4c05-9cf0-4be7-ae6e-3d3789efd12c"), new Guid("0f2153fc-bcce-4876-9fcf-383ab9799a70"), new DateTime(2024, 5, 15, 1, 37, 40, 850, DateTimeKind.Local).AddTicks(8316), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new Guid("00000000-0000-0000-0000-000000000000"), "Tech", 100, "/tech" },
                    { new Guid("ba4f371a-2090-4234-aaca-228653e61e6c"), new Guid("0f2153fc-bcce-4876-9fcf-383ab9799a70"), new DateTime(2024, 5, 15, 1, 37, 40, 850, DateTimeKind.Local).AddTicks(8291), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new Guid("00000000-0000-0000-0000-000000000000"), "Biographies", 100, "/biographies" }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "RoleId", "CreatedBy", "DateCreated", "DateLastModified", "IsActive", "ModifiedBy", "RoleName" },
                values: new object[] { new Guid("5ea82ea9-f04f-4718-993e-5eff478d6fd0"), new Guid("0f2153fc-bcce-4876-9fcf-383ab9799a70"), new DateTime(2024, 5, 15, 1, 37, 40, 850, DateTimeKind.Local).AddTicks(8499), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new Guid("00000000-0000-0000-0000-000000000000"), "Administrator" });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "UserId", "Address", "DateCreated", "DateLastModified", "DateOfBirth", "DefaultUserPaymentId", "District", "Email", "FirstName", "Gender", "IsActive", "LastName", "PhoneNumber", "Province", "RoleId", "UserName", "UserPassword", "Ward" },
                values: new object[] { new Guid("0f2153fc-bcce-4876-9fcf-383ab9799a70"), "123 Highway 1k", new DateTime(2024, 5, 15, 1, 37, 40, 850, DateTimeKind.Local).AddTicks(8475), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), "Binh An", "thuanmaildemo@gmail.com", "Thuan", 1, true, "Tran", "0123 456 789", "Binh Duong", new Guid("5ea82ea9-f04f-4718-993e-5eff478d6fd0"), "Administrator", "123456", "Di An" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: new Guid("0af62686-4f09-4692-9a50-66d26e6a1c09"));

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: new Guid("0d2634ff-d823-4745-b9d7-e87d582d6173"));

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: new Guid("3c50e1aa-8b8f-495b-b262-e90c20241433"));

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: new Guid("52d2ae8a-fa54-4e6c-ac9f-45e2ea8e062e"));

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: new Guid("951360cd-83cc-4e69-a84c-9fc82f122947"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: new Guid("1cd608b5-c9db-48e9-8b03-8e03e738e196"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: new Guid("25bb8e35-68e8-432b-981a-796ad4dd8a0a"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: new Guid("60c25b1f-2ebf-427e-8a8c-896d10cda29d"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: new Guid("654f4c05-9cf0-4be7-ae6e-3d3789efd12c"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: new Guid("ba4f371a-2090-4234-aaca-228653e61e6c"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UserId",
                keyValue: new Guid("0f2153fc-bcce-4876-9fcf-383ab9799a70"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "RoleId",
                keyValue: new Guid("5ea82ea9-f04f-4718-993e-5eff478d6fd0"));

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Book");

            migrationBuilder.DropColumn(
                name: "Url",
                table: "Book");

            migrationBuilder.AlterColumn<string>(
                name: "Gender",
                table: "User",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Category",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
