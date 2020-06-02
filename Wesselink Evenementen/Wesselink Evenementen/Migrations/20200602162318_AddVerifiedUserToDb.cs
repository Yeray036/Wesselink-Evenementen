using Microsoft.EntityFrameworkCore.Migrations;

namespace Wesselink_Evenementen.Migrations
{
    public partial class AddVerifiedUserToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Verified_Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Surname = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    PhoneNumber = table.Column<int>(nullable: false),
                    Barkeeper = table.Column<int>(nullable: true),
                    Receptionist = table.Column<int>(nullable: true),
                    Waiter = table.Column<int>(nullable: true),
                    Host = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Verified_Users", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Verified_Users");
        }
    }
}
