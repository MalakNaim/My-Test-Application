using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TaskApp.Data.Migrations
{
    public partial class database11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Status",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Status",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "Status",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Status",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Status",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Status");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Status");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "Status");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Status");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Status");
        }
    }
}
