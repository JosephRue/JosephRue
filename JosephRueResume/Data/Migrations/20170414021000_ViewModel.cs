using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace JosephRueResume.Data.Migrations
{
    public partial class ViewModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Resume");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Resume",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ContactInfoID = table.Column<int>(nullable: true),
                    ReferencesID = table.Column<int>(nullable: true),
                    jobsID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resume", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Resume_ContactInfo_ContactInfoID",
                        column: x => x.ContactInfoID,
                        principalTable: "ContactInfo",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Resume_References_ReferencesID",
                        column: x => x.ReferencesID,
                        principalTable: "References",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Resume_jobs_jobsID",
                        column: x => x.jobsID,
                        principalTable: "jobs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Resume_ContactInfoID",
                table: "Resume",
                column: "ContactInfoID");

            migrationBuilder.CreateIndex(
                name: "IX_Resume_ReferencesID",
                table: "Resume",
                column: "ReferencesID");

            migrationBuilder.CreateIndex(
                name: "IX_Resume_jobsID",
                table: "Resume",
                column: "jobsID");
        }
    }
}
