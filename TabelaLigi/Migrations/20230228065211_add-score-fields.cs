using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TabelaLigi.Migrations
{
    public partial class addscorefields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GoalsLost",
                table: "Teams",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GoalsScored",
                table: "Teams",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<byte>(
                name: "MatchesDrawn",
                table: "Teams",
                type: "INTEGER",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<byte>(
                name: "MatchesLost",
                table: "Teams",
                type: "INTEGER",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<byte>(
                name: "MatchesWon",
                table: "Teams",
                type: "INTEGER",
                nullable: false,
                defaultValue: (byte)0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GoalsLost",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "GoalsScored",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "MatchesDrawn",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "MatchesLost",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "MatchesWon",
                table: "Teams");
        }
    }
}
