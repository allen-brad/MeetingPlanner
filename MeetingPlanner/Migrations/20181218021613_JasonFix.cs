using Microsoft.EntityFrameworkCore.Migrations;

namespace MeetingPlanner.Migrations
{
    public partial class JasonFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Meeting_Bishopric_BishopricID",
                table: "Meeting");

            migrationBuilder.AlterColumn<int>(
                name: "BishopricID",
                table: "Meeting",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Meeting_Bishopric_BishopricID",
                table: "Meeting",
                column: "BishopricID",
                principalTable: "Bishopric",
                principalColumn: "BishopricID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Meeting_Bishopric_BishopricID",
                table: "Meeting");

            migrationBuilder.AlterColumn<int>(
                name: "BishopricID",
                table: "Meeting",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Meeting_Bishopric_BishopricID",
                table: "Meeting",
                column: "BishopricID",
                principalTable: "Bishopric",
                principalColumn: "BishopricID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
