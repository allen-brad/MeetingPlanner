using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MeetingPlanner.Migrations
{
    public partial class MeetingTestimony : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Testimonies",
                table: "Testimonies");

            migrationBuilder.DropIndex(
                name: "IX_Testimonies_MeetingID",
                table: "Testimonies");

            migrationBuilder.DropColumn(
                name: "TestimoniesID",
                table: "Testimonies");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Testimonies",
                table: "Testimonies",
                column: "MeetingID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Testimonies",
                table: "Testimonies");

            migrationBuilder.AddColumn<int>(
                name: "TestimoniesID",
                table: "Testimonies",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Testimonies",
                table: "Testimonies",
                column: "TestimoniesID");

            migrationBuilder.CreateIndex(
                name: "IX_Testimonies_MeetingID",
                table: "Testimonies",
                column: "MeetingID",
                unique: true);
        }
    }
}
