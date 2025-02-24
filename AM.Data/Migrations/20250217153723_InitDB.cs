using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AM.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Planes",
                columns: table => new
                {
                    PlaneId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MyPlaneType = table.Column<int>(type: "int", nullable: false),
                    Capacity = table.Column<int>(type: "int", nullable: false),
                    ManufactureDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Planes", x => x.PlaneId);
                });

            migrationBuilder.CreateTable(
                name: "Passengers",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PassportNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TelNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    Destination = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Departure = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FlightDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FlightId = table.Column<int>(type: "int", nullable: true),
                    EffectiveArrival = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EstimatedDuration = table.Column<int>(type: "int", nullable: true),
                    MyPlanePlaneId = table.Column<int>(type: "int", nullable: true),
                    EmployementDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Function = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Salary = table.Column<int>(type: "int", nullable: true),
                    HealthInformation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nationality = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Passengers", x => x.id);
                    table.ForeignKey(
                        name: "FK_Passengers_Planes_MyPlanePlaneId",
                        column: x => x.MyPlanePlaneId,
                        principalTable: "Planes",
                        principalColumn: "PlaneId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FlightPassenger",
                columns: table => new
                {
                    Flightsid = table.Column<int>(type: "int", nullable: false),
                    Passengersid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlightPassenger", x => new { x.Flightsid, x.Passengersid });
                    table.ForeignKey(
                        name: "FK_FlightPassenger_Passengers_Flightsid",
                        column: x => x.Flightsid,
                        principalTable: "Passengers",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_FlightPassenger_Passengers_Passengersid",
                        column: x => x.Passengersid,
                        principalTable: "Passengers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FlightPassenger_Passengersid",
                table: "FlightPassenger",
                column: "Passengersid");

            migrationBuilder.CreateIndex(
                name: "IX_Passengers_MyPlanePlaneId",
                table: "Passengers",
                column: "MyPlanePlaneId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FlightPassenger");

            migrationBuilder.DropTable(
                name: "Passengers");

            migrationBuilder.DropTable(
                name: "Planes");
        }
    }
}
