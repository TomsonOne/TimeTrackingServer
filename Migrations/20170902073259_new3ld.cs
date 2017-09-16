using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace TimeTrackingServer.Migrations
{
    public partial class new3ld : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Projects_ProjectId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_Users_UserId",
                table: "Items");

            migrationBuilder.RenameColumn(
                name: "WorkingPlace",
                table: "Items",
                newName: "workingPlace");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Items",
                newName: "userId");

            migrationBuilder.RenameColumn(
                name: "ProjectId",
                table: "Items",
                newName: "projectId");

            migrationBuilder.RenameColumn(
                name: "Hours",
                table: "Items",
                newName: "hours");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Items",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "Date",
                table: "Items",
                newName: "date");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Items",
                newName: "id");

            migrationBuilder.RenameIndex(
                name: "IX_Items_UserId",
                table: "Items",
                newName: "IX_Items_userId");

            migrationBuilder.RenameIndex(
                name: "IX_Items_ProjectId",
                table: "Items",
                newName: "IX_Items_projectId");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Projects_projectId",
                table: "Items",
                column: "projectId",
                principalTable: "Projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Users_userId",
                table: "Items",
                column: "userId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Projects_projectId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_Users_userId",
                table: "Items");

            migrationBuilder.RenameColumn(
                name: "workingPlace",
                table: "Items",
                newName: "WorkingPlace");

            migrationBuilder.RenameColumn(
                name: "userId",
                table: "Items",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "projectId",
                table: "Items",
                newName: "ProjectId");

            migrationBuilder.RenameColumn(
                name: "hours",
                table: "Items",
                newName: "Hours");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "Items",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "date",
                table: "Items",
                newName: "Date");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Items",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Items_userId",
                table: "Items",
                newName: "IX_Items_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Items_projectId",
                table: "Items",
                newName: "IX_Items_ProjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Projects_ProjectId",
                table: "Items",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Users_UserId",
                table: "Items",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
