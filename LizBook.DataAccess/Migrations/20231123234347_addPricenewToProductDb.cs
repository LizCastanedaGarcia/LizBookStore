using Microsoft.EntityFrameworkCore.Migrations;

namespace LizBook.DataAccess.Migrations
{
    public partial class addPricenewToProductDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Products",
                newName: "Pricenew");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Pricenew",
                table: "Products",
                newName: "Price");
        }
    }
}
