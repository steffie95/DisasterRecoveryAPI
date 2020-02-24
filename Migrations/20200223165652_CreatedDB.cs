using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DisasterRecoveryAPI.Migrations
{
    public partial class CreatedDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Timecards",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Timecards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Jobs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobCode = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    HrRate = table.Column<int>(nullable: false),
                    MaxHrPerDay = table.Column<int>(nullable: false),
                    TimecardId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jobs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Jobs_Timecards_TimecardId",
                        column: x => x.TimecardId,
                        principalTable: "Timecards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Machines",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MachineCode = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    HrRent = table.Column<int>(nullable: false),
                    MaxHrPerDay = table.Column<int>(nullable: false),
                    TimecardId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Machines", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Machines_Timecards_TimecardId",
                        column: x => x.TimecardId,
                        principalTable: "Timecards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Jobs_TimecardId",
                table: "Jobs",
                column: "TimecardId");

            migrationBuilder.CreateIndex(
                name: "IX_Machines_TimecardId",
                table: "Machines",
                column: "TimecardId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Jobs");

            migrationBuilder.DropTable(
                name: "Machines");

            migrationBuilder.DropTable(
                name: "Timecards");
        }
    }
}
