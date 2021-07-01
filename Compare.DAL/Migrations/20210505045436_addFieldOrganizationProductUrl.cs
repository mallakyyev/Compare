using Microsoft.EntityFrameworkCore.Migrations;

namespace Compare.DAL.Migrations
{
    public partial class addFieldOrganizationProductUrl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "OrganizationProductUrl",
                table: "OrganizationProducts",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OrganizationProductUrl",
                table: "OrganizationProducts");
        }
    }
}
