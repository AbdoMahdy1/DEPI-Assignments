using Microsoft.EntityFrameworkCore.Migrations;

namespace EFDay01.Migrations
{
    public partial class AddProjectAndEmpFluent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Emps",
                table: "Emps");

            migrationBuilder.RenameTable(
                name: "Emps",
                newName: "Employees");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Employees",
                newName: "EmpName");

            migrationBuilder.RenameColumn(
                name: "EmpId",
                table: "Employees",
                newName: "Id");

            migrationBuilder.AlterColumn<string>(
                name: "EmpName",
                table: "Employees",
                type: "varchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employees",
                table: "Employees",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "10, 10"),
                    ProjectName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, defaultValue: "OurProject"),
                    ProjectCost = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Id);
                    table.CheckConstraint("CK_Project_Cost", "[ProjectCost] >= 500000 AND [ProjectCost] <= 3500000");
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employees",
                table: "Employees");

            migrationBuilder.RenameTable(
                name: "Employees",
                newName: "Emps");

            migrationBuilder.RenameColumn(
                name: "EmpName",
                table: "Emps",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Emps",
                newName: "EmpId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Emps",
                type: "varchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Emps",
                table: "Emps",
                column: "EmpId");
        }
    }
}
