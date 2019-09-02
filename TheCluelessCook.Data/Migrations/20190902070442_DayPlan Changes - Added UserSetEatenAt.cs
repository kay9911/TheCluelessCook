using Microsoft.EntityFrameworkCore.Migrations;

namespace TheCluelessCook.Data.Migrations
{
    public partial class DayPlanChangesAddedUserSetEatenAt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserBestEatenAt",
                table: "DayPlans",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserBestEatenAt",
                table: "DayPlans");
        }
    }
}
