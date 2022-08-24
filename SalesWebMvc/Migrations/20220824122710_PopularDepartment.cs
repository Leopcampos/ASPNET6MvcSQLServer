using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SalesWebMvc.Migrations
{
    public partial class PopularDepartment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO DEPARTMENT(NAME) " +
                "VALUES('Computers')");
            migrationBuilder.Sql("INSERT INTO DEPARTMENT(NAME) " +
                "VALUES('Electronics')");
            migrationBuilder.Sql("INSERT INTO DEPARTMENT(NAME) " +
                "VALUES('Fashion')");
            migrationBuilder.Sql("INSERT INTO DEPARTMENT(NAME) " +
                "VALUES('Books')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM DEPARTMENT");
        }
    }
}
