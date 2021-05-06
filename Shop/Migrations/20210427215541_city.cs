using Microsoft.EntityFrameworkCore.Migrations;

namespace Shop.Migrations
{
    public partial class city : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProvincId",
                table: "Cities",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Cities_ProvincId",
                table: "Cities",
                column: "ProvincId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cities_Provincs_ProvincId",
                table: "Cities",
                column: "ProvincId",
                principalTable: "Provincs",
                principalColumn: "ProvincId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cities_Provincs_ProvincId",
                table: "Cities");

            migrationBuilder.DropIndex(
                name: "IX_Cities_ProvincId",
                table: "Cities");

            migrationBuilder.DropColumn(
                name: "ProvincId",
                table: "Cities");
        }
    }
}
