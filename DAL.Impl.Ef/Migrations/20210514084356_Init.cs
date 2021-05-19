using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Impl.Ef.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Article",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Price = table.Column<double>(nullable: false),
                    SKU = table.Column<double>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Article", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    DefaultAddress = table.Column<string>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Description",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    DescriptionTextSmall = table.Column<string>(nullable: true),
                    DescriptionTextFull = table.Column<string>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Description", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    TotalAmount = table.Column<double>(nullable: false),
                    TaxAmount = table.Column<double>(nullable: false),
                    CustomerId = table.Column<Guid>(nullable: false),
                    DeliveryAddress = table.Column<string>(nullable: true),
                    BillingAddress = table.Column<string>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Order_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DescriptionInArticle",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    DescriptionId = table.Column<Guid>(nullable: false),
                    ArticleId = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DescriptionInArticle", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DescriptionInArticle_Article_ArticleId",
                        column: x => x.ArticleId,
                        principalTable: "Article",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DescriptionInArticle_Description_DescriptionId",
                        column: x => x.DescriptionId,
                        principalTable: "Description",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ArticleInOrder",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ArticleId = table.Column<Guid>(nullable: false),
                    OrderId = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticleInOrder", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ArticleInOrder_Article_ArticleId",
                        column: x => x.ArticleId,
                        principalTable: "Article",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArticleInOrder_Order_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Order",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ArticleInOrder_ArticleId",
                table: "ArticleInOrder",
                column: "ArticleId");

            migrationBuilder.CreateIndex(
                name: "IX_ArticleInOrder_OrderId",
                table: "ArticleInOrder",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_DescriptionInArticle_ArticleId",
                table: "DescriptionInArticle",
                column: "ArticleId");

            migrationBuilder.CreateIndex(
                name: "IX_DescriptionInArticle_DescriptionId",
                table: "DescriptionInArticle",
                column: "DescriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_CustomerId",
                table: "Order",
                column: "CustomerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArticleInOrder");

            migrationBuilder.DropTable(
                name: "DescriptionInArticle");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Article");

            migrationBuilder.DropTable(
                name: "Description");

            migrationBuilder.DropTable(
                name: "Customer");
        }
    }
}
