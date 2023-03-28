using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodBox.Data.Migrations
{
    public partial class Initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1b274fcd-c7f8-4902-af98-9f289db134e8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8081f0ee-7868-410b-92f3-6e6c1028bb99"));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("19aa3e6c-b4aa-4e53-998b-dbf0a5750512"),
                column: "CreatedDate",
                value: new DateTime(2023, 3, 28, 16, 4, 33, 580, DateTimeKind.Local).AddTicks(1646));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("cf794b4b-ddf3-4dc4-9905-5ad6adfb9cd5"),
                column: "CreatedDate",
                value: new DateTime(2023, 3, 28, 16, 4, 33, 580, DateTimeKind.Local).AddTicks(1626));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "CategoryId", "CreatedBy", "CreatedDate", "DeleteBy", "DeletedDate", "IsDeleted", "ModifiedBy", "ModifiedDate", "ProductCode", "ProductName", "Stock", "StoreId" },
                values: new object[,]
                {
                    { new Guid("664603ef-b0c6-416d-ad3b-574ad8ed1dfd"), "Torku", new Guid("19aa3e6c-b4aa-4e53-998b-dbf0a5750512"), "Admin Test", new DateTime(2023, 3, 28, 16, 4, 33, 580, DateTimeKind.Local).AddTicks(1783), null, null, false, null, null, 2, "Puskevit", 80, new Guid("40888f2b-9891-4fa4-abb2-993e4682fd0b") },
                    { new Guid("fac6cede-2edb-4405-9f3d-7800e9da55cb"), "Ülker", new Guid("cf794b4b-ddf3-4dc4-9905-5ad6adfb9cd5"), "Admin Test", new DateTime(2023, 3, 28, 16, 4, 33, 580, DateTimeKind.Local).AddTicks(1780), null, null, false, null, null, 1, "Coko", 90, new Guid("c9cc4f4e-39ee-46c9-b5a6-fcb2674c71c8") }
                });

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: new Guid("40888f2b-9891-4fa4-abb2-993e4682fd0b"),
                column: "CreatedDate",
                value: new DateTime(2023, 3, 28, 16, 4, 33, 580, DateTimeKind.Local).AddTicks(1872));

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: new Guid("c9cc4f4e-39ee-46c9-b5a6-fcb2674c71c8"),
                column: "CreatedDate",
                value: new DateTime(2023, 3, 28, 16, 4, 33, 580, DateTimeKind.Local).AddTicks(1869));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("664603ef-b0c6-416d-ad3b-574ad8ed1dfd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fac6cede-2edb-4405-9f3d-7800e9da55cb"));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("19aa3e6c-b4aa-4e53-998b-dbf0a5750512"),
                column: "CreatedDate",
                value: new DateTime(2023, 3, 28, 16, 0, 3, 179, DateTimeKind.Local).AddTicks(6098));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("cf794b4b-ddf3-4dc4-9905-5ad6adfb9cd5"),
                column: "CreatedDate",
                value: new DateTime(2023, 3, 28, 16, 0, 3, 179, DateTimeKind.Local).AddTicks(6094));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "CategoryId", "CreatedBy", "CreatedDate", "DeleteBy", "DeletedDate", "IsDeleted", "ModifiedBy", "ModifiedDate", "ProductCode", "ProductName", "Stock", "StoreId" },
                values: new object[,]
                {
                    { new Guid("1b274fcd-c7f8-4902-af98-9f289db134e8"), "Torku", new Guid("19aa3e6c-b4aa-4e53-998b-dbf0a5750512"), "Admin Test", new DateTime(2023, 3, 28, 16, 0, 3, 179, DateTimeKind.Local).AddTicks(6249), null, null, false, null, null, 2, "Puskevit", 80, null },
                    { new Guid("8081f0ee-7868-410b-92f3-6e6c1028bb99"), "Ülker", new Guid("cf794b4b-ddf3-4dc4-9905-5ad6adfb9cd5"), "Admin Test", new DateTime(2023, 3, 28, 16, 0, 3, 179, DateTimeKind.Local).AddTicks(6246), null, null, false, null, null, 1, "Coko", 90, null }
                });

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: new Guid("40888f2b-9891-4fa4-abb2-993e4682fd0b"),
                column: "CreatedDate",
                value: new DateTime(2023, 3, 28, 16, 0, 3, 179, DateTimeKind.Local).AddTicks(6364));

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "Id",
                keyValue: new Guid("c9cc4f4e-39ee-46c9-b5a6-fcb2674c71c8"),
                column: "CreatedDate",
                value: new DateTime(2023, 3, 28, 16, 0, 3, 179, DateTimeKind.Local).AddTicks(6362));
        }
    }
}
