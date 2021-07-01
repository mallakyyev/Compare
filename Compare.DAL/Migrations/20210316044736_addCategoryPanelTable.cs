using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Compare.DAL.Migrations
{
    public partial class addCategoryPanelTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CategoryPanels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CategoryId = table.Column<int>(type: "integer", nullable: false),
                    DisplayOrder = table.Column<int>(type: "integer", nullable: false),
                    IsPublish = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryPanels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CategoryPanels_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CategoryPanelAndProducts",
                columns: table => new
                {
                    CategoryPanelId = table.Column<int>(type: "integer", nullable: false),
                    ProductId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryPanelAndProducts", x => new { x.CategoryPanelId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_CategoryPanelAndProducts_CategoryPanels_CategoryPanelId",
                        column: x => x.CategoryPanelId,
                        principalTable: "CategoryPanels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryPanelAndProducts_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CategoryPanelTranslates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    LanguageCulture = table.Column<string>(type: "text", nullable: false),
                    CategoryPanelId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryPanelTranslates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CategoryPanelTranslates_CategoryPanels_CategoryPanelId",
                        column: x => x.CategoryPanelId,
                        principalTable: "CategoryPanels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategoryPanelAndProducts_ProductId",
                table: "CategoryPanelAndProducts",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryPanels_CategoryId",
                table: "CategoryPanels",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryPanelTranslates_CategoryPanelId",
                table: "CategoryPanelTranslates",
                column: "CategoryPanelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoryPanelAndProducts");

            migrationBuilder.DropTable(
                name: "CategoryPanelTranslates");

            migrationBuilder.DropTable(
                name: "CategoryPanels");
        }
    }
}
