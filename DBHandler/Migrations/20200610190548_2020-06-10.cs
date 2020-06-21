using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DBHandler.Migrations
{
    public partial class _20200610 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "ModifiedAt",
                table: "Type",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2020, 6, 10, 15, 5, 46, 839, DateTimeKind.Unspecified).AddTicks(2216), new TimeSpan(0, -4, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2020, 5, 19, 16, 33, 22, 623, DateTimeKind.Unspecified).AddTicks(4120), new TimeSpan(0, -4, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "CreatedAt",
                table: "Type",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2020, 6, 10, 15, 5, 46, 839, DateTimeKind.Unspecified).AddTicks(2216), new TimeSpan(0, -4, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2020, 5, 19, 16, 33, 22, 623, DateTimeKind.Unspecified).AddTicks(4120), new TimeSpan(0, -4, 0, 0, 0)));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "State",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "code",
                table: "State",
                maxLength: 2,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "City",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "code",
                table: "State");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "ModifiedAt",
                table: "Type",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2020, 5, 19, 16, 33, 22, 623, DateTimeKind.Unspecified).AddTicks(4120), new TimeSpan(0, -4, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldDefaultValue: new DateTimeOffset(new DateTime(2020, 6, 10, 15, 5, 46, 839, DateTimeKind.Unspecified).AddTicks(2216), new TimeSpan(0, -4, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "CreatedAt",
                table: "Type",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2020, 5, 19, 16, 33, 22, 623, DateTimeKind.Unspecified).AddTicks(4120), new TimeSpan(0, -4, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldDefaultValue: new DateTimeOffset(new DateTime(2020, 6, 10, 15, 5, 46, 839, DateTimeKind.Unspecified).AddTicks(2216), new TimeSpan(0, -4, 0, 0, 0)));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "State",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "City",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
