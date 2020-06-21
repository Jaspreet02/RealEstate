using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DBHandler.Migrations
{
    public partial class _20200519 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "path",
                table: "Image",
                newName: "Path");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "ModifiedAt",
                table: "Type",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2020, 5, 19, 16, 33, 22, 623, DateTimeKind.Unspecified).AddTicks(4120), new TimeSpan(0, -4, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2020, 5, 1, 17, 53, 35, 579, DateTimeKind.Unspecified).AddTicks(6181), new TimeSpan(0, -4, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "CreatedAt",
                table: "Type",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2020, 5, 19, 16, 33, 22, 623, DateTimeKind.Unspecified).AddTicks(4120), new TimeSpan(0, -4, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2020, 5, 1, 17, 53, 35, 579, DateTimeKind.Unspecified).AddTicks(6181), new TimeSpan(0, -4, 0, 0, 0)));

            migrationBuilder.AddColumn<decimal>(
                name: "Prize",
                table: "Property",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "Room",
                table: "Property",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Image",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Prize",
                table: "Property");

            migrationBuilder.DropColumn(
                name: "Room",
                table: "Property");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Image");

            migrationBuilder.RenameColumn(
                name: "Path",
                table: "Image",
                newName: "path");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "ModifiedAt",
                table: "Type",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2020, 5, 1, 17, 53, 35, 579, DateTimeKind.Unspecified).AddTicks(6181), new TimeSpan(0, -4, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldDefaultValue: new DateTimeOffset(new DateTime(2020, 5, 19, 16, 33, 22, 623, DateTimeKind.Unspecified).AddTicks(4120), new TimeSpan(0, -4, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "CreatedAt",
                table: "Type",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2020, 5, 1, 17, 53, 35, 579, DateTimeKind.Unspecified).AddTicks(6181), new TimeSpan(0, -4, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldDefaultValue: new DateTimeOffset(new DateTime(2020, 5, 19, 16, 33, 22, 623, DateTimeKind.Unspecified).AddTicks(4120), new TimeSpan(0, -4, 0, 0, 0)));
        }
    }
}
