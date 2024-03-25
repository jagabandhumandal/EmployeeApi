using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeApi.Migrations
{
    public partial class initialDbCreation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    empid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    department = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    designation = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.empid);
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "empid", "Name", "department", "designation" },
                values: new object[] { 1, "Action", "HR", "software engineer" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "empid", "Name", "department", "designation" },
                values: new object[] { 2, "SciFi", "IT", " engineer" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "empid", "Name", "department", "designation" },
                values: new object[] { 3, "History", "Devops", "lead software engineer" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
