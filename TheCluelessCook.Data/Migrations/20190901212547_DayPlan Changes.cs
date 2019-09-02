using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TheCluelessCook.Data.Migrations
{
    public partial class DayPlanChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DayPlans_AspNetUsers_UserId",
                table: "DayPlans");

            migrationBuilder.DropColumn(
                name: "CreatedFor",
                table: "DayPlans");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "DayPlans",
                newName: "UserIdId");

            migrationBuilder.RenameColumn(
                name: "DayOfTheWeek",
                table: "DayPlans",
                newName: "Day");

            migrationBuilder.RenameIndex(
                name: "IX_DayPlans_UserId",
                table: "DayPlans",
                newName: "IX_DayPlans_UserIdId");

            migrationBuilder.AddColumn<string>(
                name: "Date",
                table: "DayPlans",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RecipeId",
                table: "DayPlans",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_DayPlans_RecipeId",
                table: "DayPlans",
                column: "RecipeId");

            migrationBuilder.AddForeignKey(
                name: "FK_DayPlans_Recipes_RecipeId",
                table: "DayPlans",
                column: "RecipeId",
                principalTable: "Recipes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DayPlans_AspNetUsers_UserIdId",
                table: "DayPlans",
                column: "UserIdId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DayPlans_Recipes_RecipeId",
                table: "DayPlans");

            migrationBuilder.DropForeignKey(
                name: "FK_DayPlans_AspNetUsers_UserIdId",
                table: "DayPlans");

            migrationBuilder.DropIndex(
                name: "IX_DayPlans_RecipeId",
                table: "DayPlans");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "DayPlans");

            migrationBuilder.DropColumn(
                name: "RecipeId",
                table: "DayPlans");

            migrationBuilder.RenameColumn(
                name: "UserIdId",
                table: "DayPlans",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "Day",
                table: "DayPlans",
                newName: "DayOfTheWeek");

            migrationBuilder.RenameIndex(
                name: "IX_DayPlans_UserIdId",
                table: "DayPlans",
                newName: "IX_DayPlans_UserId");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedFor",
                table: "DayPlans",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddForeignKey(
                name: "FK_DayPlans_AspNetUsers_UserId",
                table: "DayPlans",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
