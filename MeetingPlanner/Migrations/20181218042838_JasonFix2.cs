using Microsoft.EntityFrameworkCore.Migrations;

namespace MeetingPlanner.Migrations
{
    public partial class JasonFix2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Conducting",
                table: "Meeting");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Conducting",
                table: "Meeting",
                maxLength: 50,
                nullable: false,
                defaultValue: "");
        }
    }
}
