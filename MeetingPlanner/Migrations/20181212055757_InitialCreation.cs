using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MeetingPlanner.Migrations
{
    public partial class InitialCreation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Meeting",
                columns: table => new
                {
                    MeetingID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Date = table.Column<DateTime>(nullable: false),
                    Choirister = table.Column<string>(nullable: true),
                    Organist = table.Column<string>(nullable: true),
                    Invocation = table.Column<string>(nullable: true),
                    Presiding = table.Column<string>(nullable: true),
                    Conducting = table.Column<string>(nullable: true),
                    Announcements = table.Column<string>(nullable: true),
                    WardBusiness = table.Column<string>(nullable: true),
                    StakeBusiness = table.Column<string>(nullable: true),
                    Benediction = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meeting", x => x.MeetingID);
                });

            migrationBuilder.CreateTable(
                name: "MusicalNumber",
                columns: table => new
                {
                    MusicalNumberID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MeetingID = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    SortOrder = table.Column<int>(nullable: false),
                    HymnNumber = table.Column<int>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Performers = table.Column<string>(nullable: true),
                    Accompaniement = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MusicalNumber", x => x.MusicalNumberID);
                    table.ForeignKey(
                        name: "FK_MusicalNumber_Meeting_MeetingID",
                        column: x => x.MeetingID,
                        principalTable: "Meeting",
                        principalColumn: "MeetingID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Talk",
                columns: table => new
                {
                    TalkID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MeetingID = table.Column<int>(nullable: false),
                    SortOrder = table.Column<int>(nullable: false),
                    SpeakerFirstName = table.Column<string>(nullable: true),
                    SpeakerLastName = table.Column<string>(nullable: true),
                    Topic = table.Column<string>(nullable: true),
                    Assigned = table.Column<bool>(nullable: false),
                    Accepted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Talk", x => x.TalkID);
                    table.ForeignKey(
                        name: "FK_Talk_Meeting_MeetingID",
                        column: x => x.MeetingID,
                        principalTable: "Meeting",
                        principalColumn: "MeetingID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Testimonies",
                columns: table => new
                {
                    TestimoniesID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MeetingID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Testimonies", x => x.TestimoniesID);
                    table.ForeignKey(
                        name: "FK_Testimonies_Meeting_MeetingID",
                        column: x => x.MeetingID,
                        principalTable: "Meeting",
                        principalColumn: "MeetingID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MusicalNumber_MeetingID",
                table: "MusicalNumber",
                column: "MeetingID");

            migrationBuilder.CreateIndex(
                name: "IX_Talk_MeetingID",
                table: "Talk",
                column: "MeetingID");

            migrationBuilder.CreateIndex(
                name: "IX_Testimonies_MeetingID",
                table: "Testimonies",
                column: "MeetingID",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MusicalNumber");

            migrationBuilder.DropTable(
                name: "Talk");

            migrationBuilder.DropTable(
                name: "Testimonies");

            migrationBuilder.DropTable(
                name: "Meeting");
        }
    }
}
