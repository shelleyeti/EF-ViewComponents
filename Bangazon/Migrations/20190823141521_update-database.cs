using Microsoft.EntityFrameworkCore.Migrations;

namespace Bangazon.Migrations
{
    public partial class updatedatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "31fd8d96-964a-414c-9df5-7ba7b5268f35", "AQAAAAEAACcQAAAAECL31Ak9XuVigYZYs6ujri//cRSsTNgBE9fBGe+ei8a4XYEopyj6oPsxnndk5v/G1w==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e9b8b50d-023c-4aee-a71f-58a3de88e038", "AQAAAAEAACcQAAAAEF6xFBqJnrP0RsWyisTUL22FkuJDoeHsOlojKYHClpAShlq6uJhB6ERZawSUs1hyVg==" });
        }
    }
}
