using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class initial4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductCategoryModel_CategoryId",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductCategoryModel",
                table: "ProductCategoryModel");

            migrationBuilder.RenameTable(
                name: "ProductCategoryModel",
                newName: "ProductCategory");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductCategory",
                table: "ProductCategory",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductCategory_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "ProductCategory",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductCategory_CategoryId",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductCategory",
                table: "ProductCategory");

            migrationBuilder.RenameTable(
                name: "ProductCategory",
                newName: "ProductCategoryModel");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductCategoryModel",
                table: "ProductCategoryModel",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductCategoryModel_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "ProductCategoryModel",
                principalColumn: "Id");
        }
    }
}
