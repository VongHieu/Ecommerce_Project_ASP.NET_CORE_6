using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ecommerce.Server.Migrations
{
    /// <inheritdoc />
    public partial class Initial_Db : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tb_Cart",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    User_Id = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_Cart", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tb_Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    SEOTitle = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    SEOAlias = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tb_Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    Consignee = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Email = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AmountTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    User_Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_Orders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tb_Policies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Detail = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_Policies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tb_Promotions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Details = table.Column<string>(type: "nvarchar(max)", maxLength: 2147483647, nullable: true),
                    FromDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ToDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PercentageDiscount = table.Column<float>(type: "real", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_Promotions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tb_Contacts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Email = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false, defaultValueSql: "getutcdate()"),
                    PhoneNumber = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    Message = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Category_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_Contacts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contact_Category",
                        column: x => x.Category_Id,
                        principalTable: "Tb_Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tb_News",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Image = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", maxLength: 2147483647, nullable: true),
                    Detail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SEOAlias = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    Category_Id = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_News", x => x.Id);
                    table.ForeignKey(
                        name: "FK_News_Category",
                        column: x => x.Category_Id,
                        principalTable: "Tb_Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tb_ProductCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    SEOAlias = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    SEOTitle = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Category_Id = table.Column<int>(type: "int", nullable: false),
                    Promotion_Id = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_ProductCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductCategory_Category",
                        column: x => x.Category_Id,
                        principalTable: "Tb_Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductCategory_Promotion",
                        column: x => x.Promotion_Id,
                        principalTable: "Tb_Promotions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Tb_Advertisements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Link = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "getutcdate()"),
                    ProductCategory_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_Advertisements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Advertisement_ProductCategory",
                        column: x => x.ProductCategory_Id,
                        principalTable: "Tb_ProductCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tb_Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Thumbnail = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    Images = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Detail = table.Column<string>(type: "nvarchar(max)", maxLength: 2147483647, nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValue: 0m),
                    OriginalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValue: 0m),
                    Stock = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    SEOTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SEOAlias = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    ViewCount = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    ProductCategory_Id = table.Column<int>(type: "int", nullable: false),
                    Promotion_Id = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Product_ProductCategory",
                        column: x => x.ProductCategory_Id,
                        principalTable: "Tb_ProductCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Product_Promotion",
                        column: x => x.Promotion_Id,
                        principalTable: "Tb_Promotions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Tb_CartDetail",
                columns: table => new
                {
                    Cart_Id = table.Column<int>(type: "int", nullable: false),
                    Product_Id = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_CartDetail", x => new { x.Product_Id, x.Cart_Id });
                    table.ForeignKey(
                        name: "FK_CartDetail_Cart",
                        column: x => x.Cart_Id,
                        principalTable: "Tb_Cart",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CartDetail_Product",
                        column: x => x.Product_Id,
                        principalTable: "Tb_Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tb_OrderDetails",
                columns: table => new
                {
                    Product_Id = table.Column<int>(type: "int", nullable: false),
                    Order_Id = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_OrderDetails", x => new { x.Order_Id, x.Product_Id });
                    table.ForeignKey(
                        name: "FK_OrderDetail_Order",
                        column: x => x.Order_Id,
                        principalTable: "Tb_Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetail_Product",
                        column: x => x.Product_Id,
                        principalTable: "Tb_Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tb_Advertisements_ProductCategory_Id",
                table: "Tb_Advertisements",
                column: "ProductCategory_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Tb_CartDetail_Cart_Id",
                table: "Tb_CartDetail",
                column: "Cart_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Tb_Contacts_Category_Id",
                table: "Tb_Contacts",
                column: "Category_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Tb_News_Category_Id",
                table: "Tb_News",
                column: "Category_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Tb_OrderDetails_Product_Id",
                table: "Tb_OrderDetails",
                column: "Product_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Tb_ProductCategories_Category_Id",
                table: "Tb_ProductCategories",
                column: "Category_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Tb_ProductCategories_Promotion_Id",
                table: "Tb_ProductCategories",
                column: "Promotion_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Tb_Products_ProductCategory_Id",
                table: "Tb_Products",
                column: "ProductCategory_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Tb_Products_Promotion_Id",
                table: "Tb_Products",
                column: "Promotion_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tb_Advertisements");

            migrationBuilder.DropTable(
                name: "Tb_CartDetail");

            migrationBuilder.DropTable(
                name: "Tb_Contacts");

            migrationBuilder.DropTable(
                name: "Tb_News");

            migrationBuilder.DropTable(
                name: "Tb_OrderDetails");

            migrationBuilder.DropTable(
                name: "Tb_Policies");

            migrationBuilder.DropTable(
                name: "Tb_Cart");

            migrationBuilder.DropTable(
                name: "Tb_Orders");

            migrationBuilder.DropTable(
                name: "Tb_Products");

            migrationBuilder.DropTable(
                name: "Tb_ProductCategories");

            migrationBuilder.DropTable(
                name: "Tb_Categories");

            migrationBuilder.DropTable(
                name: "Tb_Promotions");
        }
    }
}
