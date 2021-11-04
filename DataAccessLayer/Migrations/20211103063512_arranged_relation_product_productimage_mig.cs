using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class arranged_relation_product_productimage_mig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductImages_Products_ProductID",
                table: "ProductImages");

            migrationBuilder.DropIndex(
                name: "IX_ProductImages_ProductID",
                table: "ProductImages");

            migrationBuilder.DropColumn(
                name: "ProductID",
                table: "ProductImages");

            migrationBuilder.AddColumn<int>(
                name: "ProductImageID",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductImageID",
                table: "Products",
                column: "ProductImageID");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductImages_ProductImageID",
                table: "Products",
                column: "ProductImageID",
                principalTable: "ProductImages",
                principalColumn: "ProductImageID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductImages_ProductImageID",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_ProductImageID",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ProductImageID",
                table: "Products");

            migrationBuilder.AddColumn<int>(
                name: "ProductID",
                table: "ProductImages",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ProductID",
                table: "ProductImages",
                column: "ProductID");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductImages_Products_ProductID",
                table: "ProductImages",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "ProductID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
