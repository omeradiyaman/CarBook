using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarBook.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Add_RentACarProcess : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<TimeOnly>(
                name: "PickUpTime",
                table: "RentACarProcesses",
                type: "Time",
                nullable: false,
                oldClrType: typeof(TimeOnly),
                oldType: "time");

            migrationBuilder.AlterColumn<DateOnly>(
                name: "PickUpDate",
                table: "RentACarProcesses",
                type: "Date",
                nullable: false,
                oldClrType: typeof(DateOnly),
                oldType: "date");

            migrationBuilder.AlterColumn<TimeOnly>(
                name: "DropOffTime",
                table: "RentACarProcesses",
                type: "Time",
                nullable: false,
                oldClrType: typeof(TimeOnly),
                oldType: "time");

            migrationBuilder.AlterColumn<DateOnly>(
                name: "DropOffDate",
                table: "RentACarProcesses",
                type: "Date",
                nullable: false,
                oldClrType: typeof(DateOnly),
                oldType: "date");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<TimeOnly>(
                name: "PickUpTime",
                table: "RentACarProcesses",
                type: "time",
                nullable: false,
                oldClrType: typeof(TimeOnly),
                oldType: "Time");

            migrationBuilder.AlterColumn<DateOnly>(
                name: "PickUpDate",
                table: "RentACarProcesses",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateOnly),
                oldType: "Date");

            migrationBuilder.AlterColumn<TimeOnly>(
                name: "DropOffTime",
                table: "RentACarProcesses",
                type: "time",
                nullable: false,
                oldClrType: typeof(TimeOnly),
                oldType: "Time");

            migrationBuilder.AlterColumn<DateOnly>(
                name: "DropOffDate",
                table: "RentACarProcesses",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateOnly),
                oldType: "Date");
        }
    }
}
