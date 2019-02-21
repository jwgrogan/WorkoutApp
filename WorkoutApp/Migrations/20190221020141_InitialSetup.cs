using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WorkoutApp.Migrations
{
    public partial class InitialSetup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserNumber = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Username = table.Column<string>(maxLength: 50, nullable: false),
                    EmailAddress = table.Column<string>(maxLength: 50, nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    TotalWorkouts = table.Column<int>(nullable: false),
                    TotalDuration = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserNumber);
                });

            migrationBuilder.CreateTable(
                name: "Workouts",
                columns: table => new
                {
                    WorkoutNumber = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    WorkoutDate = table.Column<DateTime>(nullable: false),
                    WorkoutType = table.Column<int>(nullable: false),
                    WorkoutDuration = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Workouts", x => x.WorkoutNumber);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Workouts");
        }
    }
}
