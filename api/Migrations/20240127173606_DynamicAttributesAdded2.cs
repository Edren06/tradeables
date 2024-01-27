using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class DynamicAttributesAdded2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DynamicAttributeModel_Products_ProductId",
                table: "DynamicAttributeModel");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductTypes_ProductCategorys_ProductCategoryModelId",
                table: "ProductTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductCategorys_CategoryId",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductCategorys",
                table: "ProductCategorys");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DynamicAttributeModel",
                table: "DynamicAttributeModel");

            migrationBuilder.RenameTable(
                name: "ProductCategorys",
                newName: "ProductCategories");

            migrationBuilder.RenameTable(
                name: "DynamicAttributeModel",
                newName: "DynamicAttributes");

            migrationBuilder.RenameIndex(
                name: "IX_DynamicAttributeModel_ProductId",
                table: "DynamicAttributes",
                newName: "IX_DynamicAttributes_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductCategories",
                table: "ProductCategories",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DynamicAttributes",
                table: "DynamicAttributes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DynamicAttributes_Products_ProductId",
                table: "DynamicAttributes",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductTypes_ProductCategories_ProductCategoryModelId",
                table: "ProductTypes",
                column: "ProductCategoryModelId",
                principalTable: "ProductCategories",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductCategories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "ProductCategories",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DynamicAttributes_Products_ProductId",
                table: "DynamicAttributes");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductTypes_ProductCategories_ProductCategoryModelId",
                table: "ProductTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductCategories_CategoryId",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductCategories",
                table: "ProductCategories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DynamicAttributes",
                table: "DynamicAttributes");

            migrationBuilder.RenameTable(
                name: "ProductCategories",
                newName: "ProductCategorys");

            migrationBuilder.RenameTable(
                name: "DynamicAttributes",
                newName: "DynamicAttributeModel");

            migrationBuilder.RenameIndex(
                name: "IX_DynamicAttributes_ProductId",
                table: "DynamicAttributeModel",
                newName: "IX_DynamicAttributeModel_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductCategorys",
                table: "ProductCategorys",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DynamicAttributeModel",
                table: "DynamicAttributeModel",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DynamicAttributeModel_Products_ProductId",
                table: "DynamicAttributeModel",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductTypes_ProductCategorys_ProductCategoryModelId",
                table: "ProductTypes",
                column: "ProductCategoryModelId",
                principalTable: "ProductCategorys",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductCategorys_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "ProductCategorys",
                principalColumn: "Id");
        }
    }
}
