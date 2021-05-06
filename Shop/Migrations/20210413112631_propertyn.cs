using Microsoft.EntityFrameworkCore.Migrations;

namespace Shop.Migrations
{
    public partial class propertyn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "PropertyNames",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PropertyNames_CategoryId",
                table: "PropertyNames",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyNames_categories_CategoryId",
                table: "PropertyNames",
                column: "CategoryId",
                principalTable: "categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PropertyNames_categories_CategoryId",
                table: "PropertyNames");

            migrationBuilder.DropIndex(
                name: "IX_PropertyNames_CategoryId",
                table: "PropertyNames");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "PropertyNames");
        }
    }
}
