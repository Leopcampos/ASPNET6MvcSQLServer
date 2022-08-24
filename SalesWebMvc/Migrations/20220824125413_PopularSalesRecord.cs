using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SalesWebMvc.Migrations
{
    public partial class PopularSalesRecord : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO SALES_RECORD(Date, Amount, Status, SellerId) " + "VALUES('25/09/2018', 11000.0, '1', 1)");
            migrationBuilder.Sql("INSERT INTO SALES_RECORD(Date, Amount, Status, SellerId) " + "VALUES('04/09/2018', 7000.0, '1', 5)");
            migrationBuilder.Sql("INSERT INTO SALES_RECORD(Date, Amount, Status, SellerId) " + "VALUES('13/09/2018', 4000.0, '2', 4)");
            migrationBuilder.Sql("INSERT INTO SALES_RECORD(Date, Amount, Status, SellerId) " + "VALUES('01/09/2018', 8000.0, '1', 1)");
            migrationBuilder.Sql("INSERT INTO SALES_RECORD(Date, Amount, Status, SellerId) " + "VALUES('21/09/2018', 3000.0, '1', 3)");
            migrationBuilder.Sql("INSERT INTO SALES_RECORD(Date, Amount, Status, SellerId) " + "VALUES('15/09/2018', 2000.0, '1', 1)");
            migrationBuilder.Sql("INSERT INTO SALES_RECORD(Date, Amount, Status, SellerId) " + "VALUES('28/09/2018', 13000.0, '1', 2)");
            migrationBuilder.Sql("INSERT INTO SALES_RECORD(Date, Amount, Status, SellerId) " + "VALUES('11/09/2018', 4000.0, '1', 4)");
            migrationBuilder.Sql("INSERT INTO SALES_RECORD(Date, Amount, Status, SellerId) " + "VALUES('14/09/2018', 11000.0, '0', 6)");
            migrationBuilder.Sql("INSERT INTO SALES_RECORD(Date, Amount, Status, SellerId) " + "VALUES('07/09/2018', 9000.0, '1', 6)");
            migrationBuilder.Sql("INSERT INTO SALES_RECORD(Date, Amount, Status, SellerId) " + "VALUES('13/09/2018', 6000.0, '1', 2)");
            migrationBuilder.Sql("INSERT INTO SALES_RECORD(Date, Amount, Status, SellerId) " + "VALUES('25/09/2018', 7000.0, '0', 3)");
            migrationBuilder.Sql("INSERT INTO SALES_RECORD(Date, Amount, Status, SellerId) " + "VALUES('29/09/2018', 10000.0, '1', 4)");
            migrationBuilder.Sql("INSERT INTO SALES_RECORD(Date, Amount, Status, SellerId) " + "VALUES('04/09/2018', 3000.0, '1', 5)");
            migrationBuilder.Sql("INSERT INTO SALES_RECORD(Date, Amount, Status, SellerId) " + "VALUES('12/09/2018', 4000.0, '1', 1)");
            migrationBuilder.Sql("INSERT INTO SALES_RECORD(Date, Amount, Status, SellerId) " + "VALUES('05/10/2018', 2000.0, '1', 4)");
            migrationBuilder.Sql("INSERT INTO SALES_RECORD(Date, Amount, Status, SellerId) " + "VALUES('01/10/2018', 12000.0, '1', 1)");
            migrationBuilder.Sql("INSERT INTO SALES_RECORD(Date, Amount, Status, SellerId) " + "VALUES('24/10/2018', 6000.0, '1', 3)");
            migrationBuilder.Sql("INSERT INTO SALES_RECORD(Date, Amount, Status, SellerId) " + "VALUES('22/10/2018', 8000.0, '1', 5)");
            migrationBuilder.Sql("INSERT INTO SALES_RECORD(Date, Amount, Status, SellerId) " + "VALUES('15/10/2018', 8000.0, '1', 6)");
            migrationBuilder.Sql("INSERT INTO SALES_RECORD(Date, Amount, Status, SellerId) " + "VALUES('17/10/2018', 9000.0, '1', 2)");
            migrationBuilder.Sql("INSERT INTO SALES_RECORD(Date, Amount, Status, SellerId) " + "VALUES('24/10/2018', 4000.0, '1', 4)");
            migrationBuilder.Sql("INSERT INTO SALES_RECORD(Date, Amount, Status, SellerId) " + "VALUES('19/10/2018', 11000.0, '2', 2)");
            migrationBuilder.Sql("INSERT INTO SALES_RECORD(Date, Amount, Status, SellerId) " + "VALUES('12/10/2018', 8000.0, '1', 5)");
            migrationBuilder.Sql("INSERT INTO SALES_RECORD(Date, Amount, Status, SellerId) " + "VALUES('31/10/2018', 7000.0, '1', 3)");
            migrationBuilder.Sql("INSERT INTO SALES_RECORD(Date, Amount, Status, SellerId) " + "VALUES('06/10/2018', 5000.0, '1', 4)");
            migrationBuilder.Sql("INSERT INTO SALES_RECORD(Date, Amount, Status, SellerId) " + "VALUES('13/10/2018', 9000.0, '0', 1)");
            migrationBuilder.Sql("INSERT INTO SALES_RECORD(Date, Amount, Status, SellerId) " + "VALUES('07/10/2018', 4000.0, '1', 3)");
            migrationBuilder.Sql("INSERT INTO SALES_RECORD(Date, Amount, Status, SellerId) " + "VALUES('23/10/2018', 12000.0, '1', 5)");
            migrationBuilder.Sql("INSERT INTO SALES_RECORD(Date, Amount, Status, SellerId) " + "VALUES('12/10/2018', 5000.0, '1', 2)");
        }
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM SALES_RECORD");
        }
    }
}
