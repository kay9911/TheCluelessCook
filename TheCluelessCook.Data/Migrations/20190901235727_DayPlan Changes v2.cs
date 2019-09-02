using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TheCluelessCook.Data.Migrations
{
    public partial class DayPlanChangesv2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DayPlans_Chefs_ChefId",
                table: "DayPlans");

            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingLists_Chefs_ChefId",
                table: "ShoppingLists");

            migrationBuilder.DropTable(
                name: "Chefs");

            migrationBuilder.DropIndex(
                name: "IX_ShoppingLists_ChefId",
                table: "ShoppingLists");

            migrationBuilder.DropIndex(
                name: "IX_DayPlans_ChefId",
                table: "DayPlans");

            migrationBuilder.DropColumn(
                name: "ChefId",
                table: "ShoppingLists");

            migrationBuilder.DropColumn(
                name: "ChefId",
                table: "DayPlans");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ChefId",
                table: "ShoppingLists",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ChefId",
                table: "DayPlans",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Chefs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Country = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chefs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Chefs_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingLists_ChefId",
                table: "ShoppingLists",
                column: "ChefId");

            migrationBuilder.CreateIndex(
                name: "IX_DayPlans_ChefId",
                table: "DayPlans",
                column: "ChefId");

            migrationBuilder.CreateIndex(
                name: "IX_Chefs_UserId",
                table: "Chefs",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_DayPlans_Chefs_ChefId",
                table: "DayPlans",
                column: "ChefId",
                principalTable: "Chefs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingLists_Chefs_ChefId",
                table: "ShoppingLists",
                column: "ChefId",
                principalTable: "Chefs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
