using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EEcomercEE.Migrations
{
    /// <inheritdoc />
    public partial class firstbesmellah : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "category",
                columns: table => new
                {
                    category_id = table.Column<int>(type: "int", nullable: false),
                    category_name = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__category__D54EE9B4F13A3B8F", x => x.category_id);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    Cust_id = table.Column<int>(type: "int", nullable: false),
                    Cust_Name = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    street = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    city = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    CustPhone = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Customer__7B8E5D0F1FB0EBE1", x => x.Cust_id);
                });

            migrationBuilder.CreateTable(
                name: "inventory",
                columns: table => new
                {
                    inventory_id = table.Column<int>(type: "int", nullable: false),
                    inventory_name = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    Quantity_sold = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Quantity_in_stock = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__inventor__B59ACC49591483A1", x => x.inventory_id);
                });

            migrationBuilder.CreateTable(
                name: "Prod_category",
                columns: table => new
                {
                    Prod_id = table.Column<int>(type: "int", nullable: false),
                    category_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Prod_cat__C55AC32BBDB4CF73", x => x.Prod_id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    P_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    P_name = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    Price = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    imagepath = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Products__A3410E4F49A0ABD9", x => x.P_id);
                });

            migrationBuilder.CreateTable(
                name: "supplier",
                columns: table => new
                {
                    supplier_id = table.Column<int>(type: "int", nullable: false),
                    name = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    contact_info = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    street = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    city = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__supplier__6EE594E8BEA1235B", x => x.supplier_id);
                });

            migrationBuilder.CreateTable(
                name: "Transactionn",
                columns: table => new
                {
                    Payment_id = table.Column<int>(type: "int", nullable: false),
                    amount = table.Column<int>(type: "int", nullable: true),
                    pay_status = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Tran_status = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Transact__DA638B194468322E", x => x.Payment_id);
                });

            migrationBuilder.CreateTable(
                name: "cust_phone",
                columns: table => new
                {
                    cust_id = table.Column<int>(type: "int", nullable: false),
                    phone_number = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    CustTempId1 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__cust_pho__A1B71F900B499DAD", x => x.cust_id);
                    table.ForeignKey(
                        name: "FK_cust_phone_Customer_CustTempId1",
                        column: x => x.CustTempId1,
                        principalTable: "Customer",
                        principalColumn: "Cust_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Prod_inventory",
                columns: table => new
                {
                    Prod_id = table.Column<int>(type: "int", nullable: false),
                    inventory_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Prod_inv__C55AC32B36C34A08", x => x.Prod_id);
                    table.ForeignKey(
                        name: "FK_Prod_inventory_inventory",
                        column: x => x.inventory_id,
                        principalTable: "inventory",
                        principalColumn: "inventory_id");
                });

            migrationBuilder.CreateTable(
                name: "supp_category",
                columns: table => new
                {
                    supplier_id = table.Column<int>(type: "int", nullable: false),
                    category_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__supp_cat__33B17A737140A310", x => new { x.supplier_id, x.category_id });
                    table.ForeignKey(
                        name: "FK_supp_category_Prod_category",
                        column: x => x.category_id,
                        principalTable: "Prod_category",
                        principalColumn: "Prod_id");
                    table.ForeignKey(
                        name: "FK_supp_category_category",
                        column: x => x.category_id,
                        principalTable: "category",
                        principalColumn: "category_id");
                    table.ForeignKey(
                        name: "FK_supp_category_supplier",
                        column: x => x.supplier_id,
                        principalTable: "supplier",
                        principalColumn: "supplier_id");
                });

            migrationBuilder.CreateTable(
                name: "Order_Transaction",
                columns: table => new
                {
                    O_id = table.Column<double>(type: "float", nullable: false),
                    Pay_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Order_Tr__5AA80810DC20EC69", x => x.O_id);
                    table.ForeignKey(
                        name: "FK_Order_Transaction_Transactionn1",
                        column: x => x.Pay_id,
                        principalTable: "Transactionn",
                        principalColumn: "Payment_id");
                });

            migrationBuilder.CreateTable(
                name: "Orderr",
                columns: table => new
                {
                    Ord_id = table.Column<double>(type: "float", nullable: false),
                    Total_amount = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    O_Status = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    O_Date = table.Column<DateOnly>(type: "date", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Orderr__1711AE46E1FB9D96", x => x.Ord_id);
                    table.ForeignKey(
                        name: "FK_Orderr_Order_Transaction1",
                        column: x => x.Ord_id,
                        principalTable: "Order_Transaction",
                        principalColumn: "O_id");
                });

            migrationBuilder.CreateTable(
                name: "Cust_Order",
                columns: table => new
                {
                    O_id = table.Column<double>(type: "float", nullable: false),
                    Cust_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Cust_Ord__5AA8081027C7B9BF", x => x.O_id);
                    table.ForeignKey(
                        name: "FK_Cust_Order_Customer1",
                        column: x => x.Cust_id,
                        principalTable: "Customer",
                        principalColumn: "Cust_id");
                    table.ForeignKey(
                        name: "FK_Cust_Order_Orderr",
                        column: x => x.O_id,
                        principalTable: "Orderr",
                        principalColumn: "Ord_id");
                });

            migrationBuilder.CreateTable(
                name: "Prod_order",
                columns: table => new
                {
                    Prod_id = table.Column<int>(type: "int", nullable: false),
                    O_id = table.Column<double>(type: "float", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: true),
                    price = table.Column<int>(type: "int", nullable: true),
                    Discount = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Prod_ord__D0F043AAC9DB2B7B", x => new { x.Prod_id, x.O_id });
                    table.ForeignKey(
                        name: "FK_Prod_order_Orderr",
                        column: x => x.O_id,
                        principalTable: "Orderr",
                        principalColumn: "Ord_id");
                    table.ForeignKey(
                        name: "FK_Prod_order_Products",
                        column: x => x.Prod_id,
                        principalTable: "Products",
                        principalColumn: "P_id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cust_Order_Cust_id",
                table: "Cust_Order",
                column: "Cust_id");

            migrationBuilder.CreateIndex(
                name: "IX_cust_phone_CustTempId1",
                table: "cust_phone",
                column: "CustTempId1");

            migrationBuilder.CreateIndex(
                name: "IX_Order_Transaction_Pay_id",
                table: "Order_Transaction",
                column: "Pay_id");

            migrationBuilder.CreateIndex(
                name: "IX_Prod_inventory_inventory_id",
                table: "Prod_inventory",
                column: "inventory_id");

            migrationBuilder.CreateIndex(
                name: "IX_Prod_order_O_id",
                table: "Prod_order",
                column: "O_id");

            migrationBuilder.CreateIndex(
                name: "IX_supp_category_category_id",
                table: "supp_category",
                column: "category_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cust_Order");

            migrationBuilder.DropTable(
                name: "cust_phone");

            migrationBuilder.DropTable(
                name: "Prod_inventory");

            migrationBuilder.DropTable(
                name: "Prod_order");

            migrationBuilder.DropTable(
                name: "supp_category");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "inventory");

            migrationBuilder.DropTable(
                name: "Orderr");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Prod_category");

            migrationBuilder.DropTable(
                name: "category");

            migrationBuilder.DropTable(
                name: "supplier");

            migrationBuilder.DropTable(
                name: "Order_Transaction");

            migrationBuilder.DropTable(
                name: "Transactionn");
        }
    }
}
