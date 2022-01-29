using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAppCrudeMVCCore.Migrations
{
    public partial class InnitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                    nvarchar250 = table.Column<string>(name: "nvarchar(250)", type: "nvarchar(max)", nullable: false),
                    varchar10 = table.Column<string>(name: "varchar(10)", type: "nvarchar(max)", nullable: true),
                    varchar100 = table.Column<string>(name: "varchar(100)", type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
