using Microsoft.EntityFrameworkCore.Migrations;

namespace TheCluelessCook.Data.Migrations
{
    public partial class AddEntityModelsGhostingFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Recipes_DayPlans_DayPlanId",
                table: "Recipes");

            migrationBuilder.DropForeignKey(
                name: "FK_Recipes_DayPlans_DayPlanId1",
                table: "Recipes");

            migrationBuilder.DropForeignKey(
                name: "FK_Recipes_DayPlans_DayPlanId2",
                table: "Recipes");

            migrationBuilder.DropIndex(
                name: "IX_Recipes_DayPlanId",
                table: "Recipes");

            migrationBuilder.DropIndex(
                name: "IX_Recipes_DayPlanId1",
                table: "Recipes");

            migrationBuilder.DropIndex(
                name: "IX_Recipes_DayPlanId2",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "DayPlanId",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "DayPlanId1",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "DayPlanId2",
                table: "Recipes");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DayPlanId",
                table: "Recipes",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DayPlanId1",
                table: "Recipes",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DayPlanId2",
                table: "Recipes",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_DayPlanId",
                table: "Recipes",
                column: "DayPlanId");

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_DayPlanId1",
                table: "Recipes",
                column: "DayPlanId1");

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_DayPlanId2",
                table: "Recipes",
                column: "DayPlanId2");

            migrationBuilder.AddForeignKey(
                name: "FK_Recipes_DayPlans_DayPlanId",
                table: "Recipes",
                column: "DayPlanId",
                principalTable: "DayPlans",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Recipes_DayPlans_DayPlanId1",
                table: "Recipes",
                column: "DayPlanId1",
                principalTable: "DayPlans",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Recipes_DayPlans_DayPlanId2",
                table: "Recipes",
                column: "DayPlanId2",
                principalTable: "DayPlans",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
