using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollectorProj.Data.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c22d1561-807f-4506-a18a-d1036b1427bb");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8aacc19a-4e23-4a13-891f-48770e3d45d8", "2e7b1d00-1d81-4daa-8bbe-5ffcbfeb326e", "Employee", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "50e793b5-8a01-450a-9273-4957c086d523", "bd7aaf77-f189-4a8a-aa05-5621ea71e841", "Customer", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "50e793b5-8a01-450a-9273-4957c086d523");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8aacc19a-4e23-4a13-891f-48770e3d45d8");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c22d1561-807f-4506-a18a-d1036b1427bb", "07798675-741f-4f6b-b823-6ffc94f01ca0", "Admin", "ADMIN" });
        }
    }
}
