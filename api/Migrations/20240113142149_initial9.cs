using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class initial9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductTagModel_Products_ProductId",
                table: "ProductTagModel");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductTagModel_TagModel_TagId",
                table: "ProductTagModel");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductCategory_CategoryId",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TagModel",
                table: "TagModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductTagModel",
                table: "ProductTagModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductCategory",
                table: "ProductCategory");

            migrationBuilder.RenameTable(
                name: "TagModel",
                newName: "Tags");

            migrationBuilder.RenameTable(
                name: "ProductTagModel",
                newName: "ProductTags");

            migrationBuilder.RenameTable(
                name: "ProductCategory",
                newName: "ProductCategorys");

            migrationBuilder.RenameIndex(
                name: "IX_ProductTagModel_TagId",
                table: "ProductTags",
                newName: "IX_ProductTags_TagId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductTagModel_ProductId",
                table: "ProductTags",
                newName: "IX_ProductTags_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tags",
                table: "Tags",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductTags",
                table: "ProductTags",
                column: "ProductTagId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductCategorys",
                table: "ProductCategorys",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductTags_Products_ProductId",
                table: "ProductTags",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductTags_Tags_TagId",
                table: "ProductTags",
                column: "TagId",
                principalTable: "Tags",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductCategorys_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "ProductCategorys",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductTags_Products_ProductId",
                table: "ProductTags");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductTags_Tags_TagId",
                table: "ProductTags");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductCategorys_CategoryId",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tags",
                table: "Tags");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductTags",
                table: "ProductTags");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductCategorys",
                table: "ProductCategorys");

            migrationBuilder.RenameTable(
                name: "Tags",
                newName: "TagModel");

            migrationBuilder.RenameTable(
                name: "ProductTags",
                newName: "ProductTagModel");

            migrationBuilder.RenameTable(
                name: "ProductCategorys",
                newName: "ProductCategory");

            migrationBuilder.RenameIndex(
                name: "IX_ProductTags_TagId",
                table: "ProductTagModel",
                newName: "IX_ProductTagModel_TagId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductTags_ProductId",
                table: "ProductTagModel",
                newName: "IX_ProductTagModel_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TagModel",
                table: "TagModel",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductTagModel",
                table: "ProductTagModel",
                column: "ProductTagId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductCategory",
                table: "ProductCategory",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductTagModel_Products_ProductId",
                table: "ProductTagModel",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductTagModel_TagModel_TagId",
                table: "ProductTagModel",
                column: "TagId",
                principalTable: "TagModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductCategory_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "ProductCategory",
                principalColumn: "Id");
        }
    }
}
