using Microsoft.EntityFrameworkCore.Migrations;

namespace Shop.Migrations
{
    public partial class propertyname2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "PropertyNames",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "PropertyNames",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));
        }
    }
}
