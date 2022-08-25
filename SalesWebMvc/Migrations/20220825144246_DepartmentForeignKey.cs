using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SalesWebMvc.Migrations
{
    public partial class DepartmentForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SELLER_DEPARTMENT_DepartmentId",
                table: "SELLER");

            migrationBuilder.AlterColumn<int>(
                name: "DepartmentId",
                table: "SELLER",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_SELLER_DEPARTMENT_DepartmentId",
                table: "SELLER",
                column: "DepartmentId",
                principalTable: "DEPARTMENT",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SELLER_DEPARTMENT_DepartmentId",
                table: "SELLER");

            migrationBuilder.AlterColumn<int>(
                name: "DepartmentId",
                table: "SELLER",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_SELLER_DEPARTMENT_DepartmentId",
                table: "SELLER",
                column: "DepartmentId",
                principalTable: "DEPARTMENT",
                principalColumn: "ID");
        }
    }
}
