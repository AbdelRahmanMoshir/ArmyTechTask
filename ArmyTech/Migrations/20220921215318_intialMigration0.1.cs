using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ArmyTech.Migrations
{
    public partial class intialMigration01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cashiers_Branches_BranchID",
                table: "Cashiers");

            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceHeaders_Cashiers_CashierID",
                table: "InvoiceHeaders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cashiers",
                table: "Cashiers");

            migrationBuilder.RenameTable(
                name: "Cashiers",
                newName: "Cashier");

            migrationBuilder.RenameIndex(
                name: "IX_Cashiers_BranchID",
                table: "Cashier",
                newName: "IX_Cashier_BranchID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cashier",
                table: "Cashier",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Cashier_Branches_BranchID",
                table: "Cashier",
                column: "BranchID",
                principalTable: "Branches",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceHeaders_Cashier_CashierID",
                table: "InvoiceHeaders",
                column: "CashierID",
                principalTable: "Cashier",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cashier_Branches_BranchID",
                table: "Cashier");

            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceHeaders_Cashier_CashierID",
                table: "InvoiceHeaders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cashier",
                table: "Cashier");

            migrationBuilder.RenameTable(
                name: "Cashier",
                newName: "Cashiers");

            migrationBuilder.RenameIndex(
                name: "IX_Cashier_BranchID",
                table: "Cashiers",
                newName: "IX_Cashiers_BranchID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cashiers",
                table: "Cashiers",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Cashiers_Branches_BranchID",
                table: "Cashiers",
                column: "BranchID",
                principalTable: "Branches",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceHeaders_Cashiers_CashierID",
                table: "InvoiceHeaders",
                column: "CashierID",
                principalTable: "Cashiers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
