using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Compare.DAL.Migrations
{
    public partial class addIdInAndPriceInToTableProductOrganization : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductsAndOrganizations",
                table: "ProductsAndOrganizations");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "ProductsAndOrganizations",
                type: "integer",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "ProductsAndOrganizations",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductsAndOrganizations",
                table: "ProductsAndOrganizations",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_ProductsAndOrganizations_ProductId",
                table: "ProductsAndOrganizations",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductsAndOrganizations",
                table: "ProductsAndOrganizations");

            migrationBuilder.DropIndex(
                name: "IX_ProductsAndOrganizations_ProductId",
                table: "ProductsAndOrganizations");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "ProductsAndOrganizations");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "ProductsAndOrganizations");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductsAndOrganizations",
                table: "ProductsAndOrganizations",
                columns: new[] { "ProductId", "OrganizationId" });
        }
    }
}
