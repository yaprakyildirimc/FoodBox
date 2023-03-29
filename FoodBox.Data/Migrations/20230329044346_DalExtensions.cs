using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodBox.Data.Migrations
{
    public partial class DalExtensions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("71ffa444-c1c0-45d1-859c-2767d4a75b35"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7ffe2660-14ff-48df-9804-098e5bb3071c"));

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
    }
}
