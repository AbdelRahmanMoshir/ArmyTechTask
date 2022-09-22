using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ArmyTech.Migrations
{
    public partial class intialMigration02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_invoiceDetails_InvoiceHeaders_InvoiceHeaderID",
                table: "invoiceDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceHeaders_Branches_BranchID",
                table: "InvoiceHeaders");

            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceHeaders_Cashier_CashierID",
                table: "InvoiceHeaders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_InvoiceHeaders",
                table: "InvoiceHeaders");

            migrationBuilder.RenameTable(
                name: "InvoiceHeaders",
                newName: "InvoiceHeader");

            migrationBuilder.RenameColumn(
                name: "Invoicedata",
                table: "InvoiceHeader",
                newName: "Invoicedate");

            migrationBuilder.RenameIndex(
                name: "IX_InvoiceHeaders_CashierID",
                table: "InvoiceHeader",
                newName: "IX_InvoiceHeader_CashierID");

            migrationBuilder.RenameIndex(
                name: "IX_InvoiceHeaders_BranchID",
                table: "InvoiceHeader",
                newName: "IX_InvoiceHeader_BranchID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_InvoiceHeader",
                table: "InvoiceHeader",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_invoiceDetails_InvoiceHeader_InvoiceHeaderID",
                table: "invoiceDetails",
                column: "InvoiceHeaderID",
                principalTable: "InvoiceHeader",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceHeader_Branches_BranchID",
                table: "InvoiceHeader",
                column: "BranchID",
                principalTable: "Branches",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceHeader_Cashier_CashierID",
                table: "InvoiceHeader",
                column: "CashierID",
                principalTable: "Cashier",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_invoiceDetails_InvoiceHeader_InvoiceHeaderID",
                table: "invoiceDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceHeader_Branches_BranchID",
                table: "InvoiceHeader");

            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceHeader_Cashier_CashierID",
                table: "InvoiceHeader");

            migrationBuilder.DropPrimaryKey(
                name: "PK_InvoiceHeader",
                table: "InvoiceHeader");

            migrationBuilder.RenameTable(
                name: "InvoiceHeader",
                newName: "InvoiceHeaders");

            migrationBuilder.RenameColumn(
                name: "Invoicedate",
                table: "InvoiceHeaders",
                newName: "Invoicedata");

            migrationBuilder.RenameIndex(
                name: "IX_InvoiceHeader_CashierID",
                table: "InvoiceHeaders",
                newName: "IX_InvoiceHeaders_CashierID");

            migrationBuilder.RenameIndex(
                name: "IX_InvoiceHeader_BranchID",
                table: "InvoiceHeaders",
                newName: "IX_InvoiceHeaders_BranchID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_InvoiceHeaders",
                table: "InvoiceHeaders",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_invoiceDetails_InvoiceHeaders_InvoiceHeaderID",
                table: "invoiceDetails",
                column: "InvoiceHeaderID",
                principalTable: "InvoiceHeaders",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceHeaders_Branches_BranchID",
                table: "InvoiceHeaders",
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
    }
}
