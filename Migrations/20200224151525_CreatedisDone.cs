using Microsoft.EntityFrameworkCore.Migrations;

namespace DisasterRecoveryAPI.Migrations
{
    public partial class CreatedisDone : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "isDone",
                table: "Timecards",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isDone",
                table: "Timecards");
        }
    }
}
