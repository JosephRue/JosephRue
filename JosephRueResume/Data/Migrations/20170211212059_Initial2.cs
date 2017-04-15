using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JosephRueResume.Data.Migrations
{
    public partial class Initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MyProperty",
                table: "jobs");

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "jobs",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDate",
                table: "jobs",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "jobTitle",
                table: "jobs",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "jobs");

            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "jobs");

            migrationBuilder.DropColumn(
                name: "jobTitle",
                table: "jobs");

            migrationBuilder.AddColumn<int>(
                name: "MyProperty",
                table: "jobs",
                nullable: false,
                defaultValue: 0);
        }
    }
}
