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
                    OpenHymn = table.Column<string>(nullable: true),
                    SacHymn = table.Column<string>(nullable: true),
                    IntHymn = table.Column<string>(nullable: true),
                    CloseHymn = table.Column<string>(nullable: true),
                    TalkName1 = table.Column<string>(nullable: true),
                    TalkSubj1 = table.Column<string>(nullable: true),
                    TalkName2 = table.Column<string>(nullable: true),
                    TalkSubj2 = table.Column<string>(nullable: true),
                    TalkName3 = table.Column<string>(nullable: true),
                    TalkSubj3 = table.Column<string>(nullable: true),
                    TalkName4 = table.Column<string>(nullable: true),
                    TalkSubj4 = table.Column<string>(nullable: true),
                    TalkName5 = table.Column<string>(nullable: true),
                    TalkSubj5 = table.Column<string>(nullable: true),


                    Benediction = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meeting", x => x.MeetingID);
                });

        }    
        protected override void Down(MigrationBuilder migrationBuilder)
        {


            migrationBuilder.DropTable(
                name: "Meeting");
        }
    }
}
