using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class UpdatesToModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductTypeModel_ProductTypeId",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductTypeModel",
                table: "ProductTypeModel");

            migrationBuilder.RenameTable(
                name: "ProductTypeModel",
                newName: "ProductTypes");

            migrationBuilder.AddColumn<int>(
                name: "ProductCategoryModelId",
                table: "ProductTypes",
                type: "integer",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductTypes",
                table: "ProductTypes",
                column: "ProductTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductTypes_ProductCategoryModelId",
                table: "ProductTypes",
                column: "ProductCategoryModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductTypes_ProductCategorys_ProductCategoryModelId",
                table: "ProductTypes",
                column: "ProductCategoryModelId",
                principalTable: "ProductCategorys",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductTypes_ProductTypeId",
                table: "Products",
                column: "ProductTypeId",
                principalTable: "ProductTypes",
                principalColumn: "ProductTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductTypes_ProductCategorys_ProductCategoryModelId",
                table: "ProductTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductTypes_ProductTypeId",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductTypes",
                table: "ProductTypes");

            migrationBuilder.DropIndex(
                name: "IX_ProductTypes_ProductCategoryModelId",
                table: "ProductTypes");

            migrationBuilder.DropColumn(
                name: "ProductCategoryModelId",
                table: "ProductTypes");

            migrationBuilder.RenameTable(
                name: "ProductTypes",
                newName: "ProductTypeModel");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductTypeModel",
                table: "ProductTypeModel",
                column: "ProductTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductTypeModel_ProductTypeId",
                table: "Products",
                column: "ProductTypeId",
                principalTable: "ProductTypeModel",
                principalColumn: "ProductTypeId");
        }
    }
}
