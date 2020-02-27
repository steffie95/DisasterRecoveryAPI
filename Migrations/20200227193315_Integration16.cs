using Microsoft.EntityFrameworkCore.Migrations;

namespace DisasterRecoveryAPI.Migrations
{
    public partial class Integration16 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Machines_Timecards_TimecardId",
                table: "Machines");

            migrationBuilder.DropIndex(
                name: "IX_Machines_TimecardId",
                table: "Machines");

            migrationBuilder.DropColumn(
                name: "TimecardId",
                table: "Machines");

            migrationBuilder.AddColumn<string>(
                name: "SiteCode",
                table: "Timecards",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TotalJobAmount",
                table: "Timecards",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TotalJobHrs",
                table: "Timecards",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TotalMachineAmount",
                table: "Timecards",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TotalMachineHrs",
                table: "Timecards",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Jobs_Timecards",
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
                    table.PrimaryKey("PK_Jobs_Timecards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Jobs_Timecards_Jobs_JobsId",
                        column: x => x.JobsId,
                        principalTable: "Jobs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Jobs_Timecards_Timecards_TimecardId",
                        column: x => x.TimecardId,
                        principalTable: "Timecards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Machines_Timecards",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MachineId = table.Column<int>(nullable: false),
                    TimecardId = table.Column<int>(nullable: false),
                    JobsId = table.Column<int>(nullable: true),
                    MachinesId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Machines_Timecards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Machines_Timecards_Jobs_JobsId",
                        column: x => x.JobsId,
                        principalTable: "Jobs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Machines_Timecards_Machines_MachinesId",
                        column: x => x.MachinesId,
                        principalTable: "Machines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Machines_Timecards_Timecards_TimecardId",
                        column: x => x.TimecardId,
                        principalTable: "Timecards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Jobs_Timecards_JobsId",
                table: "Jobs_Timecards",
                column: "JobsId");

            migrationBuilder.CreateIndex(
                name: "IX_Jobs_Timecards_TimecardId",
                table: "Jobs_Timecards",
                column: "TimecardId");

            migrationBuilder.CreateIndex(
                name: "IX_Machines_Timecards_JobsId",
                table: "Machines_Timecards",
                column: "JobsId");

            migrationBuilder.CreateIndex(
                name: "IX_Machines_Timecards_MachinesId",
                table: "Machines_Timecards",
                column: "MachinesId");

            migrationBuilder.CreateIndex(
                name: "IX_Machines_Timecards_TimecardId",
                table: "Machines_Timecards",
                column: "TimecardId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Jobs_Timecards");

            migrationBuilder.DropTable(
                name: "Machines_Timecards");

            migrationBuilder.DropColumn(
                name: "SiteCode",
                table: "Timecards");

            migrationBuilder.DropColumn(
                name: "TotalJobAmount",
                table: "Timecards");

            migrationBuilder.DropColumn(
                name: "TotalJobHrs",
                table: "Timecards");

            migrationBuilder.DropColumn(
                name: "TotalMachineAmount",
                table: "Timecards");

            migrationBuilder.DropColumn(
                name: "TotalMachineHrs",
                table: "Timecards");

            migrationBuilder.AddColumn<int>(
                name: "TimecardId",
                table: "Machines",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Machines_TimecardId",
                table: "Machines",
                column: "TimecardId");

            migrationBuilder.AddForeignKey(
                name: "FK_Machines_Timecards_TimecardId",
                table: "Machines",
                column: "TimecardId",
                principalTable: "Timecards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
