using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DBHandler.Migrations
{
    public partial class _07082020 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Prize",
                table: "Property");

            migrationBuilder.DropColumn(
                name: "HouseNumber",
                table: "Address");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "ModifiedAt",
                table: "Type",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2020, 7, 8, 19, 52, 20, 97, DateTimeKind.Unspecified).AddTicks(6442), new TimeSpan(0, -4, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2020, 6, 10, 15, 5, 46, 839, DateTimeKind.Unspecified).AddTicks(2216), new TimeSpan(0, -4, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "CreatedAt",
                table: "Type",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2020, 7, 8, 19, 52, 20, 97, DateTimeKind.Unspecified).AddTicks(6442), new TimeSpan(0, -4, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2020, 6, 10, 15, 5, 46, 839, DateTimeKind.Unspecified).AddTicks(2216), new TimeSpan(0, -4, 0, 0, 0)));

            migrationBuilder.AddColumn<decimal>(
                name: "Rent",
                table: "Property",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "Intersection",
                table: "Address",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Number",
                table: "Address",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rent",
                table: "Property");

            migrationBuilder.DropColumn(
                name: "Intersection",
                table: "Address");

            migrationBuilder.DropColumn(
                name: "Number",
                table: "Address");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "ModifiedAt",
                table: "Type",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2020, 6, 10, 15, 5, 46, 839, DateTimeKind.Unspecified).AddTicks(2216), new TimeSpan(0, -4, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldDefaultValue: new DateTimeOffset(new DateTime(2020, 7, 8, 19, 52, 20, 97, DateTimeKind.Unspecified).AddTicks(6442), new TimeSpan(0, -4, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "CreatedAt",
                table: "Type",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2020, 6, 10, 15, 5, 46, 839, DateTimeKind.Unspecified).AddTicks(2216), new TimeSpan(0, -4, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldDefaultValue: new DateTimeOffset(new DateTime(2020, 7, 8, 19, 52, 20, 97, DateTimeKind.Unspecified).AddTicks(6442), new TimeSpan(0, -4, 0, 0, 0)));

            migrationBuilder.AddColumn<decimal>(
                name: "Prize",
                table: "Property",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "HouseNumber",
                table: "Address",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
