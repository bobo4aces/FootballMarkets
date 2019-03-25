using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FootballMarkets.Migrations
{
    public partial class initialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    HomeTeam = table.Column<string>(nullable: true),
                    AwayTeam = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    League = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ExactScore",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Score = table.Column<string>(nullable: true),
                    Odds = table.Column<decimal>(nullable: false),
                    GameId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExactScore", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExactScore_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Winner",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    HomeWin = table.Column<decimal>(nullable: false),
                    Draw = table.Column<decimal>(nullable: false),
                    AwayWin = table.Column<decimal>(nullable: false),
                    GameId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Winner", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Winner_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ExactScore_GameId",
                table: "ExactScore",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_Winner_GameId",
                table: "Winner",
                column: "GameId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExactScore");

            migrationBuilder.DropTable(
                name: "Winner");

            migrationBuilder.DropTable(
                name: "Games");
        }
    }
}
