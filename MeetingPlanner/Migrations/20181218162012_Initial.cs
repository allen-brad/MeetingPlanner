using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MeetingPlanner.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bishopric",
                columns: table => new
                {
                    BishopricID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(maxLength: 50, nullable: false),
                    position = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bishopric", x => x.BishopricID);
                });

            migrationBuilder.CreateTable(
                name: "Meeting",
                columns: table => new
                {
                    MeetingID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Date = table.Column<DateTime>(nullable: false),
                    Choirister = table.Column<string>(maxLength: 50, nullable: true),
                    Organist = table.Column<string>(maxLength: 50, nullable: true),
                    Invocation = table.Column<string>(maxLength: 50, nullable: false),
                    Presiding = table.Column<string>(maxLength: 50, nullable: false),
                    Announcements = table.Column<string>(nullable: true),
                    WardBusiness = table.Column<string>(nullable: true),
                    StakeBusiness = table.Column<string>(nullable: true),
                    OpenHymn = table.Column<string>(maxLength: 50, nullable: false),
                    SacHymn = table.Column<string>(maxLength: 50, nullable: false),
                    IntHymn = table.Column<string>(maxLength: 50, nullable: true),
                    CloseHymn = table.Column<string>(maxLength: 50, nullable: false),
                    TalkName1 = table.Column<string>(maxLength: 50, nullable: true),
                    TalkSubj1 = table.Column<string>(maxLength: 50, nullable: true),
                    TalkName2 = table.Column<string>(maxLength: 50, nullable: true),
                    TalkSubj2 = table.Column<string>(maxLength: 50, nullable: true),
                    TalkName3 = table.Column<string>(maxLength: 50, nullable: true),
                    TalkSubj3 = table.Column<string>(maxLength: 50, nullable: true),
                    TalkName4 = table.Column<string>(maxLength: 50, nullable: true),
                    TalkSubj4 = table.Column<string>(maxLength: 50, nullable: true),
                    TalkName5 = table.Column<string>(maxLength: 50, nullable: true),
                    TalkSubj5 = table.Column<string>(maxLength: 50, nullable: true),
                    Benediction = table.Column<string>(maxLength: 50, nullable: false),
                    BishopricID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meeting", x => x.MeetingID);
                    table.ForeignKey(
                        name: "FK_Meeting_Bishopric_BishopricID",
                        column: x => x.BishopricID,
                        principalTable: "Bishopric",
                        principalColumn: "BishopricID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Meeting_BishopricID",
                table: "Meeting",
                column: "BishopricID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Meeting");

            migrationBuilder.DropTable(
                name: "Bishopric");
        }
    }
}
