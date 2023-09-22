using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelProject.DataAccessLayer.Migrations
{
    public partial class mig_add_messageCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MessageCategoryID",
                table: "ContactM",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "MessageCategories",
                columns: table => new
                {
                    MessageCategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MessageCategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MessageCategories", x => x.MessageCategoryID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ContactM_MessageCategoryID",
                table: "ContactM",
                column: "MessageCategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_ContactM_MessageCategories_MessageCategoryID",
                table: "ContactM",
                column: "MessageCategoryID",
                principalTable: "MessageCategories",
                principalColumn: "MessageCategoryID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ContactM_MessageCategories_MessageCategoryID",
                table: "ContactM");

            migrationBuilder.DropTable(
                name: "MessageCategories");

            migrationBuilder.DropIndex(
                name: "IX_ContactM_MessageCategoryID",
                table: "ContactM");

            migrationBuilder.DropColumn(
                name: "MessageCategoryID",
                table: "ContactM");
        }
    }
}
