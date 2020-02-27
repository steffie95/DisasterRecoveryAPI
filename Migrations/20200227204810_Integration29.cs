using Microsoft.EntityFrameworkCore.Migrations;

namespace DisasterRecoveryAPI.Migrations
{
    public partial class Integration29 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "JobTimecards",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobId = table.Column<int>(nullable: false),
                    TimecardId = table.Column<int>(nullable: false),
                    JobsId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobTimecards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JobTimecards_Jobs_JobsId",
                        column: x => x.JobsId,
                        principalTable: "Jobs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_JobTimecards_Timecards_TimecardId",
                        column: x => x.TimecardId,
                        principalTable: "Timecards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MachineTimecards",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MachineId = table.Column<int>(nullable: false),
                    TimecardId = table.Column<int>(nullable: false),
                    JobsId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MachineTimecards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MachineTimecards_Jobs_JobsId",
                        column: x => x.JobsId,
                        principalTable: "Jobs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MachineTimecards_Timecards_TimecardId",
                        column: x => x.TimecardId,
                        principalTable: "Timecards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_JobTimecards_JobsId",
                table: "JobTimecards",
                column: "JobsId");

            migrationBuilder.CreateIndex(
                name: "IX_JobTimecards_TimecardId",
                table: "JobTimecards",
                column: "TimecardId");

            migrationBuilder.CreateIndex(
                name: "IX_MachineTimecards_JobsId",
                table: "MachineTimecards",
                column: "JobsId");

            migrationBuilder.CreateIndex(
                name: "IX_MachineTimecards_TimecardId",
                table: "MachineTimecards",
                column: "TimecardId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JobTimecards");

            migrationBuilder.DropTable(
                name: "MachineTimecards");
        }
    }
}
