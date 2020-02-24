using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DisasterRecoveryAPI.Migrations
{
    public partial class PostCloneInitMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isDone",
                table: "Timecards");

            migrationBuilder.AddColumn<bool>(
                name: "isConfirmed",
                table: "Timecards",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(nullable: true),
                    PasswordHash = table.Column<byte[]>(nullable: true),
                    PasswordSalt = table.Column<byte[]>(nullable: true),
                    Role = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropColumn(
                name: "isConfirmed",
                table: "Timecards");

            migrationBuilder.AddColumn<bool>(
                name: "isDone",
                table: "Timecards",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
