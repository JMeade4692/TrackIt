using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TrackIt.Migrations
{
    public partial class addVolunteerRecords : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "FK_AspNetUsers_Company_CompnayId",
            //    table: "AspNetUsers");

            //migrationBuilder.DropIndex(
            //    name: "IX_AspNetUsers_CompnayId",
            //    table: "AspNetUsers");

            ////migrationBuilder.DropColumn(
            //    name: "CompnayId",
            //    table: "AspNetUsers");

            //migrationBuilder.AddColumn<int>(
            //    name: "CompanyId",
            //    table: "VolunteerHours",
            //    nullable: false,
            //    defaultValue: 0);

            //migrationBuilder.AddColumn<byte[]>(
            //    name: "Document",
            //    table: "VolunteerHours",
            //    nullable: true);

            //migrationBuilder.AddColumn<int>(
            //    name: "DocumentType",
            //    table: "VolunteerHours",
            //    nullable: false,
            //    defaultValue: 0);

            //migrationBuilder.CreateIndex(
            //    name: "IX_VolunteerHours_CompanyId",
            //    table: "VolunteerHours",
            //    column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_CompanyId",
                table: "AspNetUsers",
                column: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Company_CompanyId",
                table: "AspNetUsers",
                column: "CompanyId",
                principalTable: "Company",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_VolunteerHours_Company_CompanyId",
            //    table: "VolunteerHours",
            //    column: "CompanyId",
            //    principalTable: "Company",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Company_CompanyId",
                table: "AspNetUsers");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_VolunteerHours_Company_CompanyId",
            //    table: "VolunteerHours");

            //migrationBuilder.DropIndex(
            //    name: "IX_VolunteerHours_CompanyId",
            //    table: "VolunteerHours");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_CompanyId",
                table: "AspNetUsers");

            //migrationBuilder.DropColumn(
            //    name: "CompanyId",
            //    table: "VolunteerHours");

            //migrationBuilder.DropColumn(
            //    name: "Document",
            //    table: "VolunteerHours");

            //migrationBuilder.DropColumn(
            //    name: "DocumentType",
                //table: "VolunteerHours");

            migrationBuilder.AddColumn<int>(
                name: "CompnayId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_CompnayId",
                table: "AspNetUsers",
                column: "CompnayId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Company_CompnayId",
                table: "AspNetUsers",
                column: "CompnayId",
                principalTable: "Company",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
