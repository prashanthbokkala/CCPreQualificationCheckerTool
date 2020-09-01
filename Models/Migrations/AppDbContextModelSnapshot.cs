﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Models;

namespace Models.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Models.CreditCardDetails", b =>
                {
                    b.Property<int>("CardId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("CardId")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("APR")
                        .HasColumnName("APR")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("AgeLimit")
                        .HasColumnName("AgeLimit")
                        .HasColumnType("int");

                    b.Property<string>("BankName")
                        .IsRequired()
                        .HasColumnName("BankName")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("CardType")
                        .IsRequired()
                        .HasColumnName("CardType")
                        .HasColumnType("nvarchar(15)")
                        .HasMaxLength(15);

                    b.Property<string>("CreatedBy")
                        .HasColumnName("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnName("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnName("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnName("Message")
                        .HasColumnType("nvarchar(1000)")
                        .HasMaxLength(1000);

                    b.Property<decimal>("MinAnnualIncome")
                        .HasColumnName("MinAnnualIncome")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("UpdatedBy")
                        .HasColumnName("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnName("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("CardId");

                    b.ToTable("CreditCards");

                    b.HasData(
                        new
                        {
                            CardId = 1896408025,
                            APR = 19.99m,
                            AgeLimit = 18,
                            BankName = "Barclay",
                            CardType = "Visa",
                            CreatedBy = "SYSTEM",
                            CreatedDate = new DateTime(2020, 8, 30, 23, 2, 25, 148, DateTimeKind.Local).AddTicks(9715),
                            Image = ".\\CCPreQualificationCheckerTool\\ClientApp\\images\\Barclays-credit-card.png",
                            Message = "When you spend with our Purchase card, you can buy today, and spread the repayments over time. Or you might prefer our Rewards card, which could give you cashback on your everyday spending. The choice is yours.",
                            MinAnnualIncome = 30000.00m
                        },
                        new
                        {
                            CardId = 580058379,
                            APR = 39.90m,
                            AgeLimit = 18,
                            BankName = "Vanquis",
                            CardType = "Visa",
                            CreatedBy = "SYSTEM",
                            CreatedDate = new DateTime(2020, 8, 30, 23, 2, 25, 152, DateTimeKind.Local).AddTicks(2310),
                            Image = "..\\CCPreQualificationCheckerTool\\ClientApp\\imagesanquis-credit-card.png",
                            Message = "A Vanquis credit card can help you improve your rating by helping you prove to lenders that you can handle credit responsibly. Our credit cards are designed for people who find themselves with a poor credit score, maybe because they’ve had financial problems in the past, or no credit history as they’ve never taken out credit before.",
                            MinAnnualIncome = 0.00m
                        });
                });

            modelBuilder.Entity("Models.CustomerDetails", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("CustomerId")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("AnnualIncome")
                        .HasColumnName("AnnualIncome")
                        .HasColumnType("money");

                    b.Property<int>("CardRefId")
                        .HasColumnType("int");

                    b.Property<string>("CreatedBy")
                        .HasColumnName("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnName("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnName("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnName("FirstName")
                        .HasColumnType("nvarchar(15)")
                        .HasMaxLength(15);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnName("LastName")
                        .HasColumnType("nvarchar(15)")
                        .HasMaxLength(15);

                    b.Property<string>("UpdatedBy")
                        .HasColumnName("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnName("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("CustomerId");

                    b.HasIndex("CardRefId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Models.CustomerDetails", b =>
                {
                    b.HasOne("Models.CreditCardDetails", "CreditCardDetails")
                        .WithMany()
                        .HasForeignKey("CardRefId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
