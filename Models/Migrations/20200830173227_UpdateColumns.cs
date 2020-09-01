using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Models.Migrations
{
    public partial class UpdateColumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "CardId",
                keyValue: 1742920750);

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "CardId",
                keyValue: 1934230825);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "Customers",
                nullable: true);

            migrationBuilder.InsertData(
                table: "CreditCards",
                columns: new[] { "CardId", "APR", "AgeLimit", "BankName", "CardType", "CreatedBy", "CreatedDate", "Image", "Message", "MinAnnualIncome", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 1896408025, 19.99m, 18, "Barclay", "Visa", "SYSTEM", new DateTime(2020, 8, 30, 23, 2, 25, 148, DateTimeKind.Local).AddTicks(9715), ".\\CCPreQualificationCheckerTool\\ClientApp\\images\\Barclays-credit-card.png", "When you spend with our Purchase card, you can buy today, and spread the repayments over time. Or you might prefer our Rewards card, which could give you cashback on your everyday spending. The choice is yours.", 30000.00m, null, null });

            migrationBuilder.InsertData(
                table: "CreditCards",
                columns: new[] { "CardId", "APR", "AgeLimit", "BankName", "CardType", "CreatedBy", "CreatedDate", "Image", "Message", "MinAnnualIncome", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 580058379, 39.90m, 18, "Vanquis", "Visa", "SYSTEM", new DateTime(2020, 8, 30, 23, 2, 25, 152, DateTimeKind.Local).AddTicks(2310), "..\\CCPreQualificationCheckerTool\\ClientApp\\imagesanquis-credit-card.png", "A Vanquis credit card can help you improve your rating by helping you prove to lenders that you can handle credit responsibly. Our credit cards are designed for people who find themselves with a poor credit score, maybe because they’ve had financial problems in the past, or no credit history as they’ve never taken out credit before.", 0.00m, null, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "CardId",
                keyValue: 580058379);

            migrationBuilder.DeleteData(
                table: "CreditCards",
                keyColumn: "CardId",
                keyValue: 1896408025);

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Customers");

            migrationBuilder.InsertData(
                table: "CreditCards",
                columns: new[] { "CardId", "APR", "AgeLimit", "BankName", "CardType", "CreatedBy", "CreatedDate", "Image", "Message", "MinAnnualIncome", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 1742920750, 19.99m, 18, "Barclay", "Visa", "SYSTEM", new DateTime(2020, 8, 30, 18, 21, 52, 227, DateTimeKind.Local).AddTicks(7378), ".\\CCPreQualificationCheckerTool\\ClientApp\\images\\Barclays-credit-card.png", "When you spend with our Purchase card, you can buy today, and spread the repayments over time. Or you might prefer our Rewards card, which could give you cashback on your everyday spending. The choice is yours.", 30000.00m, null, null });

            migrationBuilder.InsertData(
                table: "CreditCards",
                columns: new[] { "CardId", "APR", "AgeLimit", "BankName", "CardType", "CreatedBy", "CreatedDate", "Image", "Message", "MinAnnualIncome", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 1934230825, 39.90m, 18, "Vanquis", "Visa", "SYSTEM", new DateTime(2020, 8, 30, 18, 21, 52, 229, DateTimeKind.Local).AddTicks(2872), "..\\CCPreQualificationCheckerTool\\ClientApp\\imagesanquis-credit-card.png", "A Vanquis credit card can help you improve your rating by helping you prove to lenders that you can handle credit responsibly. Our credit cards are designed for people who find themselves with a poor credit score, maybe because they’ve had financial problems in the past, or no credit history as they’ve never taken out credit before.", 0.00m, null, null });
        }
    }
}
