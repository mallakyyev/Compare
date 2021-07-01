using Microsoft.EntityFrameworkCore.Migrations;

namespace Compare.DAL.Migrations
{
    public partial class renameFieldMetaKeywordsInToTitle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MetaKeywords",
                table: "CategoryTranslates",
                newName: "MetaTitle");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MetaTitle",
                table: "CategoryTranslates",
                newName: "MetaKeywords");
        }
    }
}
