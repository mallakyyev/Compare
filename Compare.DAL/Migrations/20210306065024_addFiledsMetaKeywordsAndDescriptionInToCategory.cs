using Microsoft.EntityFrameworkCore.Migrations;

namespace Compare.DAL.Migrations
{
    public partial class addFiledsMetaKeywordsAndDescriptionInToCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MetaDescription",
                table: "CategoryTranslates",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MetaKeywords",
                table: "CategoryTranslates",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MetaDescription",
                table: "CategoryTranslates");

            migrationBuilder.DropColumn(
                name: "MetaKeywords",
                table: "CategoryTranslates");
        }
    }
}
