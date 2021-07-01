using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Compare.DAL.Migrations
{
    public partial class addAttributesTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductDetailAttributeId",
                table: "Products",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ProductAttributeTemplates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductAttributeTemplates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductDetailAttributes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ProductId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductDetailAttributes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductOptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductOptions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductAttributeTemplateTranslates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    LanguageCulture = table.Column<string>(type: "text", nullable: false),
                    ProductAttributeTemplateId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductAttributeTemplateTranslates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductAttributeTemplateTranslates_ProductAttributeTemplate~",
                        column: x => x.ProductAttributeTemplateId,
                        principalTable: "ProductAttributeTemplates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductDetailAttributeTranslates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: false),
                    LanguageCulture = table.Column<string>(type: "text", nullable: false),
                    ProductDetailAttributeId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductDetailAttributeTranslates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductDetailAttributeTranslates_ProductDetailAttributes_Pr~",
                        column: x => x.ProductDetailAttributeId,
                        principalTable: "ProductDetailAttributes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductAttributeTemplateAndProductOptions",
                columns: table => new
                {
                    ProductAttributeTemplateId = table.Column<int>(type: "integer", nullable: false),
                    ProductOptionId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductAttributeTemplateAndProductOptions", x => new { x.ProductAttributeTemplateId, x.ProductOptionId });
                    table.ForeignKey(
                        name: "FK_ProductAttributeTemplateAndProductOptions_ProductAttributeT~",
                        column: x => x.ProductAttributeTemplateId,
                        principalTable: "ProductAttributeTemplates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductAttributeTemplateAndProductOptions_ProductOptions_Pr~",
                        column: x => x.ProductOptionId,
                        principalTable: "ProductOptions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductOptionTranslates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    LanguageCulture = table.Column<string>(type: "text", nullable: false),
                    ProductOptionId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductOptionTranslates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductOptionTranslates_ProductOptions_ProductOptionId",
                        column: x => x.ProductOptionId,
                        principalTable: "ProductOptions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductDetailAttributeId",
                table: "Products",
                column: "ProductDetailAttributeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductAttributeTemplateAndProductOptions_ProductOptionId",
                table: "ProductAttributeTemplateAndProductOptions",
                column: "ProductOptionId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductAttributeTemplateTranslates_ProductAttributeTemplate~",
                table: "ProductAttributeTemplateTranslates",
                column: "ProductAttributeTemplateId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductDetailAttributeTranslates_ProductDetailAttributeId",
                table: "ProductDetailAttributeTranslates",
                column: "ProductDetailAttributeId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductOptionTranslates_ProductOptionId",
                table: "ProductOptionTranslates",
                column: "ProductOptionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductDetailAttributes_ProductDetailAttributeId",
                table: "Products",
                column: "ProductDetailAttributeId",
                principalTable: "ProductDetailAttributes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductDetailAttributes_ProductDetailAttributeId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "ProductAttributeTemplateAndProductOptions");

            migrationBuilder.DropTable(
                name: "ProductAttributeTemplateTranslates");

            migrationBuilder.DropTable(
                name: "ProductDetailAttributeTranslates");

            migrationBuilder.DropTable(
                name: "ProductOptionTranslates");

            migrationBuilder.DropTable(
                name: "ProductAttributeTemplates");

            migrationBuilder.DropTable(
                name: "ProductDetailAttributes");

            migrationBuilder.DropTable(
                name: "ProductOptions");

            migrationBuilder.DropIndex(
                name: "IX_Products_ProductDetailAttributeId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ProductDetailAttributeId",
                table: "Products");
        }
    }
}
