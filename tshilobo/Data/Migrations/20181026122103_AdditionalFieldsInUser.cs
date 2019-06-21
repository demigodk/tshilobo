using Microsoft.EntityFrameworkCore.Migrations;

namespace tshilobo.Migrations
{
    public partial class AdditionalFieldsInUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "BelongsToAChurch",
                table: "User",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "ChurchId",
                table: "User",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GenderId",
                table: "User",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "User",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TitleId",
                table: "User",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BelongsToAChurch",
                table: "User");

            migrationBuilder.DropColumn(
                name: "ChurchId",
                table: "User");

            migrationBuilder.DropColumn(
                name: "GenderId",
                table: "User");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "User");

            migrationBuilder.DropColumn(
                name: "TitleId",
                table: "User");
        }
    }
}
