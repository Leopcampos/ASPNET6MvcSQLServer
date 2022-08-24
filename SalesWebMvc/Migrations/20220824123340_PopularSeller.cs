using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SalesWebMvc.Migrations
{
    public partial class PopularSeller : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO SELLER(NAME, EMAIL, BirthDate, BaseSalary, DepartmentId) " + "VALUES('Bob Brown', 'bob@gmail.com', '21/04/1998', 1000.0, '1')");
            migrationBuilder.Sql("INSERT INTO SELLER(NAME, EMAIL, BirthDate, BaseSalary, DepartmentId) " + "VALUES('Maria Green', 'maria@gmail.com', '31/12/1979', 3500.0, 2)");
            migrationBuilder.Sql("INSERT INTO SELLER(NAME, EMAIL, BirthDate, BaseSalary, DepartmentId) " + "VALUES('Alex Grey', 'alex@gmail.com', '15/01/1988', 2200.0, 1)");
            migrationBuilder.Sql("INSERT INTO SELLER(NAME, EMAIL, BirthDate, BaseSalary, DepartmentId) " + "VALUES('Martha Red', 'martha@gmail.com', '30/11/1993', 3000.0, 4)");
            migrationBuilder.Sql("INSERT INTO SELLER(NAME, EMAIL, BirthDate, BaseSalary, DepartmentId) " + "VALUES('Donald Blue', 'donald@gmail.com', '09/01/2000', 4000.0, 3)");
            migrationBuilder.Sql("INSERT INTO SELLER(NAME, EMAIL, BirthDate, BaseSalary, DepartmentId) " + "VALUES('Alex Pink', 'bob@gmail.com', '04/03/1997', 3000.0, 2)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM SELLER");
        }
    }
}
