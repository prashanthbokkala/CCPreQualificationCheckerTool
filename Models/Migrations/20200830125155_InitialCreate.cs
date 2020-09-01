using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Models.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CreditCards",
                columns: table => new
                {
                    CardId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CardType = table.Column<string>(maxLength: 15, nullable: false),
                    BankName = table.Column<string>(maxLength: 100, nullable: false),
                    AgeLimit = table.Column<int>(nullable: false),
                    MinAnnualIncome = table.Column<decimal>(nullable: false),
                    APR = table.Column<decimal>(nullable: false),
                    Message = table.Column<string>(maxLength: 1000, nullable: false),
                    Image = table.Column<string>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreditCards", x => x.CardId);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(maxLength: 15, nullable: false),
                    LastName = table.Column<string>(maxLength: 15, nullable: false),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    AnnualIncome = table.Column<decimal>(type: "money", nullable: false),
                    CardRefId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                    table.ForeignKey(
                        name: "FK_Customers_CreditCards_CardRefId",
                        column: x => x.CardRefId,
                        principalTable: "CreditCards",
                        principalColumn: "CardId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "CreditCards",
                columns: new[] { "CardId", "APR", "AgeLimit", "BankName", "CardType", "CreatedBy", "CreatedDate", "Image", "Message", "MinAnnualIncome", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 1742920750, 19.99m, 18, "Barclay", "Visa", "SYSTEM", new DateTime(2020, 8, 30, 18, 21, 52, 227, DateTimeKind.Local).AddTicks(7378), ".\\CCPreQualificationCheckerTool\\ClientApp\\images\\Barclays-credit-card.png", "When you spend with our Purchase card, you can buy today, and spread the repayments over time. Or you might prefer our Rewards card, which could give you cashback on your everyday spending. The choice is yours.", 30000.00m, null, null });

            migrationBuilder.InsertData(
                table: "CreditCards",
                columns: new[] { "CardId", "APR", "AgeLimit", "BankName", "CardType", "CreatedBy", "CreatedDate", "Image", "Message", "MinAnnualIncome", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 1934230825, 39.90m, 18, "Vanquis", "Visa", "SYSTEM", new DateTime(2020, 8, 30, 18, 21, 52, 229, DateTimeKind.Local).AddTicks(2872), "..\\CCPreQualificationCheckerTool\\ClientApp\\imagesanquis-credit-card.png", "A Vanquis credit card can help you improve your rating by helping you prove to lenders that you can handle credit responsibly. Our credit cards are designed for people who find themselves with a poor credit score, maybe because they’ve had financial problems in the past, or no credit history as they’ve never taken out credit before.", 0.00m, null, null });

            migrationBuilder.CreateIndex(
                name: "IX_Customers_CardRefId",
                table: "Customers",
                column: "CardRefId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "CreditCards");
        }
    }
}
