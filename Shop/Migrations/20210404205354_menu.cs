using Microsoft.EntityFrameworkCore.Migrations;

namespace Shop.Migrations
{
    public partial class menu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MainMenus",
                columns: table => new
                {
                    MenuId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MenuTitle = table.Column<string>(maxLength: 50, nullable: false),
                    ImageName = table.Column<string>(maxLength: 150, nullable: false),
                    Link = table.Column<string>(maxLength: 250, nullable: false),
                    Sort = table.Column<int>(nullable: false),
                    Type = table.Column<byte>(nullable: false),
                    ParentId = table.Column<int>(nullable: true),
                    MainMenuMenuId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MainMenus", x => x.MenuId);
                    table.ForeignKey(
                        name: "FK_MainMenus_MainMenus_MainMenuMenuId",
                        column: x => x.MainMenuMenuId,
                        principalTable: "MainMenus",
                        principalColumn: "MenuId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MainMenus_MainMenuMenuId",
                table: "MainMenus",
                column: "MainMenuMenuId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MainMenus");
        }
    }
}
