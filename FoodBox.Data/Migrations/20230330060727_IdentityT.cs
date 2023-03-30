using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodBox.Data.Migrations
{
    public partial class IdentityT : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("71ffa444-c1c0-45d1-859c-2767d4a75b35"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7ffe2660-14ff-48df-9804-098e5bb3071c"));

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("855b21a0-2a28-4c07-a6f4-6fc5392b30a6"), "be92c055-edef-4c62-9d1c-61a5c63b6643", "User", "USER" },
                    { new Guid("a780b1c8-6d4b-452d-9bc4-40f184964380"), "fc3ed9da-16e1-4d6f-a0cc-e0455b2a60ee", "Superadmin", "SUPERADMIN" },
                    { new Guid("c457729b-87e5-4d96-9965-eefb8e36a203"), "2710fe03-e58d-431d-a881-7d9294146771", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("4f3d95f2-ad3e-4172-9b35-3d80ecfd0624"), 0, "f7bf8df4-bd64-41af-a79f-bc464ff26877", "admin@gmail.com", false, "Admin", "User", false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEBDP2CnHBAMq1BN2XNZ31ygcL3B8+UTIaXPcxd7wMYDzOiwoduA6E1sQKeIi2oCOJQ==", "+905423891212", false, "7f43761c-943d-48b1-9e19-1549a78effe1", false, "admin@gmail.com" },
                    { new Guid("e6c8d1cd-1b18-473a-b68a-7b3cb247307d"), 0, "7c00324b-39cc-4bf6-b587-2d8e66edf770", "superadmin@gmail.com", true, "Yaprak", "Yildirim", false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAECxO/x/TQZmTiDxC/wxcWaUGV6vWCAuk8Tr7oitfCG5FyQ8YnBjChaeB5vwZE1/h+Q==", "+905423897485", true, "56c83fb4-9512-4d62-ad61-4c4cbd86bfa7", false, "superadmin@gmail.com" }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("19aa3e6c-b4aa-4e53-998b-dbf0a5750512"),
                column: "CreatedDate",
                value: new DateTime(2023, 3, 30, 9, 7, 26, 856, DateTimeKind.Local).AddTicks(6563));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("cf794b4b-ddf3-4dc4-9905-5ad6adfb9cd5"),
                column: "CreatedDate",
                value: new DateTime(2023, 3, 30, 9, 7, 26, 856, DateTimeKind.Local).AddTicks(6555));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "CategoryId", "CreatedBy", "CreatedDate", "DeleteBy", "DeletedDate", "IsDeleted", "ModifiedBy", "ModifiedDate", "ProductCode", "ProductName", "Stock", "StoreId" },
                values: new object[,]
                {
                    { new Guid("92b4d394-d337-4490-a991-1be18c55c569"), "Ülker", new Guid("cf794b4b-ddf3-4dc4-9905-5ad6adfb9cd5"), "Admin Test", new DateTime(2023, 3, 30, 9, 7, 26, 856, DateTimeKind.Local).AddTicks(6928), null, null, false, null, null, 1, "Coko", 90, new Guid("c9cc4f4e-39ee-46c9-b5a6-fcb2674c71c8") },
                    { new Guid("9f33e0fe-db83-4552-827f-8d3489281cc7"), "Torku", new Guid("19aa3e6c-b4aa-4e53-998b-dbf0a5750512"), "Admin Test", new DateTime(2023, 3, 30, 9, 7, 26, 856, DateTimeKind.Local).AddTicks(6955), null, null, false, null, null, 2, "Puskevit", 80, new Guid("40888f2b-9891-4fa4-abb2-993e4682fd0b") }
                });

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: new Guid("40888f2b-9891-4fa4-abb2-993e4682fd0b"),
                column: "CreatedDate",
                value: new DateTime(2023, 3, 30, 9, 7, 26, 857, DateTimeKind.Local).AddTicks(7839));

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: new Guid("c9cc4f4e-39ee-46c9-b5a6-fcb2674c71c8"),
                column: "CreatedDate",
                value: new DateTime(2023, 3, 30, 9, 7, 26, 857, DateTimeKind.Local).AddTicks(7832));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("c457729b-87e5-4d96-9965-eefb8e36a203"), new Guid("4f3d95f2-ad3e-4172-9b35-3d80ecfd0624") });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("a780b1c8-6d4b-452d-9bc4-40f184964380"), new Guid("e6c8d1cd-1b18-473a-b68a-7b3cb247307d") });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("92b4d394-d337-4490-a991-1be18c55c569"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9f33e0fe-db83-4552-827f-8d3489281cc7"));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("19aa3e6c-b4aa-4e53-998b-dbf0a5750512"),
                column: "CreatedDate",
                value: new DateTime(2023, 3, 29, 7, 43, 45, 641, DateTimeKind.Local).AddTicks(7918));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("cf794b4b-ddf3-4dc4-9905-5ad6adfb9cd5"),
                column: "CreatedDate",
                value: new DateTime(2023, 3, 29, 7, 43, 45, 641, DateTimeKind.Local).AddTicks(7915));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "CategoryId", "CreatedBy", "CreatedDate", "DeleteBy", "DeletedDate", "IsDeleted", "ModifiedBy", "ModifiedDate", "ProductCode", "ProductName", "Stock", "StoreId" },
                values: new object[,]
                {
                    { new Guid("71ffa444-c1c0-45d1-859c-2767d4a75b35"), "Ülker", new Guid("cf794b4b-ddf3-4dc4-9905-5ad6adfb9cd5"), "Admin Test", new DateTime(2023, 3, 29, 7, 43, 45, 641, DateTimeKind.Local).AddTicks(8064), null, null, false, null, null, 1, "Coko", 90, new Guid("c9cc4f4e-39ee-46c9-b5a6-fcb2674c71c8") },
                    { new Guid("7ffe2660-14ff-48df-9804-098e5bb3071c"), "Torku", new Guid("19aa3e6c-b4aa-4e53-998b-dbf0a5750512"), "Admin Test", new DateTime(2023, 3, 29, 7, 43, 45, 641, DateTimeKind.Local).AddTicks(8068), null, null, false, null, null, 2, "Puskevit", 80, new Guid("40888f2b-9891-4fa4-abb2-993e4682fd0b") }
                });

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: new Guid("40888f2b-9891-4fa4-abb2-993e4682fd0b"),
                column: "CreatedDate",
                value: new DateTime(2023, 3, 29, 7, 43, 45, 641, DateTimeKind.Local).AddTicks(8138));

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: new Guid("c9cc4f4e-39ee-46c9-b5a6-fcb2674c71c8"),
                column: "CreatedDate",
                value: new DateTime(2023, 3, 29, 7, 43, 45, 641, DateTimeKind.Local).AddTicks(8136));
        }
    }
}
