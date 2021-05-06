using Microsoft.EntityFrameworkCore.Migrations;

namespace Shop.Migrations
{
    public partial class Account1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserAddresses_Provincs_ProvinceId1",
                table: "UserAddresses");

            migrationBuilder.DropIndex(
                name: "IX_UserAddresses_ProvinceId1",
                table: "UserAddresses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Provincs",
                table: "Provincs");

            migrationBuilder.DropColumn(
                name: "ProvinceId",
                table: "UserAddresses");

            migrationBuilder.DropColumn(
                name: "ProvinceId1",
                table: "UserAddresses");

            migrationBuilder.DropColumn(
                name: "ProvinceId",
                table: "Provincs");

            migrationBuilder.AddColumn<int>(
                name: "ProvincId",
                table: "UserAddresses",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProvincId",
                table: "Provincs",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Provincs",
                table: "Provincs",
                column: "ProvincId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAddresses_ProvincId",
                table: "UserAddresses",
                column: "ProvincId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserAddresses_Provincs_ProvincId",
                table: "UserAddresses",
                column: "ProvincId",
                principalTable: "Provincs",
                principalColumn: "ProvincId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserAddresses_Provincs_ProvincId",
                table: "UserAddresses");

            migrationBuilder.DropIndex(
                name: "IX_UserAddresses_ProvincId",
                table: "UserAddresses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Provincs",
                table: "Provincs");

            migrationBuilder.DropColumn(
                name: "ProvincId",
                table: "UserAddresses");

            migrationBuilder.DropColumn(
                name: "ProvincId",
                table: "Provincs");

            migrationBuilder.AddColumn<int>(
                name: "ProvinceId",
                table: "UserAddresses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProvinceId1",
                table: "UserAddresses",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProvinceId",
                table: "Provincs",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Provincs",
                table: "Provincs",
                column: "ProvinceId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAddresses_ProvinceId1",
                table: "UserAddresses",
                column: "ProvinceId1");

            migrationBuilder.AddForeignKey(
                name: "FK_UserAddresses_Provincs_ProvinceId1",
                table: "UserAddresses",
                column: "ProvinceId1",
                principalTable: "Provincs",
                principalColumn: "ProvinceId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
