using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TravelBlog.Migrations
{
    public partial class AddYearPropertyToExperience3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Experiences_Location_LocationId",
                table: "Experiences");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Location",
                table: "Location");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Locations",
                table: "Location",
                column: "LocationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Experiences_Locations_LocationId",
                table: "Experiences",
                column: "LocationId",
                principalTable: "Location",
                principalColumn: "LocationId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.RenameTable(
                name: "Location",
                newName: "Locations");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Experiences_Locations_LocationId",
                table: "Experiences");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Locations",
                table: "Locations");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Location",
                table: "Locations",
                column: "LocationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Experiences_Location_LocationId",
                table: "Experiences",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "LocationId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.RenameTable(
                name: "Locations",
                newName: "Location");
        }
    }
}
