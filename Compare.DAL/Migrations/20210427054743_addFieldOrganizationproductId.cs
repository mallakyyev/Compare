using Microsoft.EntityFrameworkCore.Migrations;

namespace Compare.DAL.Migrations
{
    public partial class addFieldOrganizationproductId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrganizationProductId",
                table: "OrganizationProducts",
                type: "integer",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OrganizationProductId",
                table: "OrganizationProducts");
        }
    }
}
