using Microsoft.EntityFrameworkCore.Migrations;

namespace DisasterRecoveryAPI.Migrations
{
    public partial class Integration30 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobTimecards_Jobs_JobsId",
                table: "JobTimecards");

            migrationBuilder.DropForeignKey(
                name: "FK_JobTimecards_Timecards_TimecardId",
                table: "JobTimecards");

            migrationBuilder.DropForeignKey(
                name: "FK_Machines_Timecards_TimecardId",
                table: "Machines");

            migrationBuilder.DropForeignKey(
                name: "FK_MachineTimecards_Jobs_JobsId",
                table: "MachineTimecards");

            migrationBuilder.DropForeignKey(
                name: "FK_MachineTimecards_Timecards_TimecardId",
                table: "MachineTimecards");

            migrationBuilder.DropIndex(
                name: "IX_Machines_TimecardId",
                table: "Machines");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MachineTimecards",
                table: "MachineTimecards");

            migrationBuilder.DropPrimaryKey(
                name: "PK_JobTimecards",
                table: "JobTimecards");

            migrationBuilder.DropColumn(
                name: "TimecardId",
                table: "Machines");

            migrationBuilder.RenameTable(
                name: "MachineTimecards",
                newName: "Machines_Timecards");

            migrationBuilder.RenameTable(
                name: "JobTimecards",
                newName: "Jobs_Timecards");

            migrationBuilder.RenameIndex(
                name: "IX_MachineTimecards_TimecardId",
                table: "Machines_Timecards",
                newName: "IX_Machines_Timecards_TimecardId");

            migrationBuilder.RenameIndex(
                name: "IX_MachineTimecards_JobsId",
                table: "Machines_Timecards",
                newName: "IX_Machines_Timecards_JobsId");

            migrationBuilder.RenameIndex(
                name: "IX_JobTimecards_TimecardId",
                table: "Jobs_Timecards",
                newName: "IX_Jobs_Timecards_TimecardId");

            migrationBuilder.RenameIndex(
                name: "IX_JobTimecards_JobsId",
                table: "Jobs_Timecards",
                newName: "IX_Jobs_Timecards_JobsId");

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

            migrationBuilder.AddColumn<int>(
                name: "MachinesId",
                table: "Machines_Timecards",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Machines_Timecards",
                table: "Machines_Timecards",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Jobs_Timecards",
                table: "Jobs_Timecards",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Machines_Timecards_MachinesId",
                table: "Machines_Timecards",
                column: "MachinesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Jobs_Timecards_Jobs_JobsId",
                table: "Jobs_Timecards",
                column: "JobsId",
                principalTable: "Jobs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Jobs_Timecards_Timecards_TimecardId",
                table: "Jobs_Timecards",
                column: "TimecardId",
                principalTable: "Timecards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Machines_Timecards_Jobs_JobsId",
                table: "Machines_Timecards",
                column: "JobsId",
                principalTable: "Jobs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Machines_Timecards_Machines_MachinesId",
                table: "Machines_Timecards",
                column: "MachinesId",
                principalTable: "Machines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Machines_Timecards_Timecards_TimecardId",
                table: "Machines_Timecards",
                column: "TimecardId",
                principalTable: "Timecards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jobs_Timecards_Jobs_JobsId",
                table: "Jobs_Timecards");

            migrationBuilder.DropForeignKey(
                name: "FK_Jobs_Timecards_Timecards_TimecardId",
                table: "Jobs_Timecards");

            migrationBuilder.DropForeignKey(
                name: "FK_Machines_Timecards_Jobs_JobsId",
                table: "Machines_Timecards");

            migrationBuilder.DropForeignKey(
                name: "FK_Machines_Timecards_Machines_MachinesId",
                table: "Machines_Timecards");

            migrationBuilder.DropForeignKey(
                name: "FK_Machines_Timecards_Timecards_TimecardId",
                table: "Machines_Timecards");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Machines_Timecards",
                table: "Machines_Timecards");

            migrationBuilder.DropIndex(
                name: "IX_Machines_Timecards_MachinesId",
                table: "Machines_Timecards");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Jobs_Timecards",
                table: "Jobs_Timecards");

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

            migrationBuilder.DropColumn(
                name: "MachinesId",
                table: "Machines_Timecards");

            migrationBuilder.RenameTable(
                name: "Machines_Timecards",
                newName: "MachineTimecards");

            migrationBuilder.RenameTable(
                name: "Jobs_Timecards",
                newName: "JobTimecards");

            migrationBuilder.RenameIndex(
                name: "IX_Machines_Timecards_TimecardId",
                table: "MachineTimecards",
                newName: "IX_MachineTimecards_TimecardId");

            migrationBuilder.RenameIndex(
                name: "IX_Machines_Timecards_JobsId",
                table: "MachineTimecards",
                newName: "IX_MachineTimecards_JobsId");

            migrationBuilder.RenameIndex(
                name: "IX_Jobs_Timecards_TimecardId",
                table: "JobTimecards",
                newName: "IX_JobTimecards_TimecardId");

            migrationBuilder.RenameIndex(
                name: "IX_Jobs_Timecards_JobsId",
                table: "JobTimecards",
                newName: "IX_JobTimecards_JobsId");

            migrationBuilder.AddColumn<int>(
                name: "TimecardId",
                table: "Machines",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_MachineTimecards",
                table: "MachineTimecards",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_JobTimecards",
                table: "JobTimecards",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Machines_TimecardId",
                table: "Machines",
                column: "TimecardId");

            migrationBuilder.AddForeignKey(
                name: "FK_JobTimecards_Jobs_JobsId",
                table: "JobTimecards",
                column: "JobsId",
                principalTable: "Jobs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_JobTimecards_Timecards_TimecardId",
                table: "JobTimecards",
                column: "TimecardId",
                principalTable: "Timecards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Machines_Timecards_TimecardId",
                table: "Machines",
                column: "TimecardId",
                principalTable: "Timecards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MachineTimecards_Jobs_JobsId",
                table: "MachineTimecards",
                column: "JobsId",
                principalTable: "Jobs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MachineTimecards_Timecards_TimecardId",
                table: "MachineTimecards",
                column: "TimecardId",
                principalTable: "Timecards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
