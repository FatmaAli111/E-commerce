﻿// <auto-generated />
using System;
using EEcomercEE.Models.Datas;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EEcomercEE.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241102110631_hhhh")]
    partial class hhhh
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseCollation("Arabic_CI_AI")
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EE_Commerce.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("EEcomercEE.Models.Entitiess.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .HasColumnType("int")
                        .HasColumnName("category_id");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("category_name");

                    b.HasKey("CategoryId")
                        .HasName("PK__category__D54EE9B4F13A3B8F");

                    b.ToTable("category", (string)null);
                });

            modelBuilder.Entity("EEcomercEE.Models.Entitiess.CustOrder", b =>
                {
                    b.Property<double>("OId")
                        .HasColumnType("float")
                        .HasColumnName("O_id");

                    b.Property<int>("CustId")
                        .HasColumnType("int")
                        .HasColumnName("Cust_id");

                    b.HasKey("OId")
                        .HasName("PK__Cust_Ord__5AA8081027C7B9BF");

                    b.HasIndex("CustId");

                    b.ToTable("Cust_Order", (string)null);
                });

            modelBuilder.Entity("EEcomercEE.Models.Entitiess.CustPhone", b =>
                {
                    b.Property<int>("CustId")
                        .HasColumnType("int")
                        .HasColumnName("cust_id");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(15)
                        .IsUnicode(false)
                        .HasColumnType("varchar(15)")
                        .HasColumnName("phone_number");

                    b.HasKey("CustId")
                        .HasName("PK__cust_pho__A1B71F900B499DAD");

                    b.ToTable("cust_phone", (string)null);
                });

            modelBuilder.Entity("EEcomercEE.Models.Entitiess.Customer", b =>
                {
                    b.Property<int>("CustId")
                        .HasColumnType("int")
                        .HasColumnName("Cust_id");

                    b.Property<string>("City")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("city");

                    b.Property<string>("CustName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("Cust_Name");

                    b.Property<string>("Street")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("street");

                    b.HasKey("CustId")
                        .HasName("PK__Customer__7B8E5D0F1FB0EBE1");

                    b.ToTable("Customer", (string)null);
                });

            modelBuilder.Entity("EEcomercEE.Models.Entitiess.Inventory", b =>
                {
                    b.Property<int>("InventoryId")
                        .HasColumnType("int")
                        .HasColumnName("inventory_id");

                    b.Property<string>("InventoryName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("inventory_name");

                    b.Property<string>("QuantityInStock")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Quantity_in_stock");

                    b.Property<string>("QuantitySold")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Quantity_sold");

                    b.HasKey("InventoryId")
                        .HasName("PK__inventor__B59ACC49591483A1");

                    b.ToTable("inventory", (string)null);
                });

            modelBuilder.Entity("EEcomercEE.Models.Entitiess.OrderTransaction", b =>
                {
                    b.Property<double>("OId")
                        .HasColumnType("float")
                        .HasColumnName("O_id");

                    b.Property<int?>("PayId")
                        .HasColumnType("int")
                        .HasColumnName("Pay_id");

                    b.HasKey("OId")
                        .HasName("PK__Order_Tr__5AA80810DC20EC69");

                    b.HasIndex("PayId");

                    b.ToTable("Order_Transaction", (string)null);
                });

            modelBuilder.Entity("EEcomercEE.Models.Entitiess.Orderr", b =>
                {
                    b.Property<double>("OrdId")
                        .HasColumnType("float")
                        .HasColumnName("Ord_id");

                    b.Property<DateOnly?>("ODate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("date")
                        .HasColumnName("O_Date")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<string>("OStatus")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("O_Status");

                    b.Property<string>("TotalAmount")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Total_amount");

                    b.HasKey("OrdId")
                        .HasName("PK__Orderr__1711AE46E1FB9D96");

                    b.ToTable("Orderr", (string)null);
                });

            modelBuilder.Entity("EEcomercEE.Models.Entitiess.ProdCategory", b =>
                {
                    b.Property<int>("ProdId")
                        .HasColumnType("int")
                        .HasColumnName("Prod_id");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int")
                        .HasColumnName("category_id");

                    b.HasKey("ProdId")
                        .HasName("PK__Prod_cat__C55AC32BBDB4CF73");

                    b.ToTable("Prod_category", (string)null);
                });

            modelBuilder.Entity("EEcomercEE.Models.Entitiess.ProdInventory", b =>
                {
                    b.Property<int>("ProdId")
                        .HasColumnType("int")
                        .HasColumnName("Prod_id");

                    b.Property<int>("InventoryId")
                        .HasColumnType("int")
                        .HasColumnName("inventory_id");

                    b.HasKey("ProdId")
                        .HasName("PK__Prod_inv__C55AC32B36C34A08");

                    b.HasIndex("InventoryId");

                    b.ToTable("Prod_inventory", (string)null);
                });

            modelBuilder.Entity("EEcomercEE.Models.Entitiess.ProdOrder", b =>
                {
                    b.Property<int>("ProdId")
                        .HasColumnType("int")
                        .HasColumnName("Prod_id");

                    b.Property<double>("OId")
                        .HasColumnType("float")
                        .HasColumnName("O_id");

                    b.Property<int?>("Discount")
                        .HasColumnType("int");

                    b.Property<int?>("Price")
                        .HasColumnType("int")
                        .HasColumnName("price");

                    b.Property<int?>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("ProdId", "OId")
                        .HasName("PK__Prod_ord__D0F043AAC9DB2B7B");

                    b.HasIndex("OId");

                    b.ToTable("Prod_order", (string)null);
                });

            modelBuilder.Entity("EEcomercEE.Models.Entitiess.Product", b =>
                {
                    b.Property<int>("PId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("P_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PId"));

                    b.Property<string>("Description")
                        .HasMaxLength(300)
                        .IsUnicode(false)
                        .HasColumnType("varchar(300)");

                    b.Property<string>("Imagepath")
                        .HasMaxLength(300)
                        .HasColumnType("nchar(300)")
                        .HasColumnName("imagepath")
                        .IsFixedLength();

                    b.Property<string>("PName")
                        .IsRequired()
                        .HasMaxLength(300)
                        .IsUnicode(false)
                        .HasColumnType("varchar(300)")
                        .HasColumnName("P_name");

                    b.Property<int?>("Price")
                        .HasColumnType("int");

                    b.HasKey("PId")
                        .HasName("PK__Products__A3410E4F49A0ABD9");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("EEcomercEE.Models.Entitiess.SuppCategory", b =>
                {
                    b.Property<int>("SupplierId")
                        .HasColumnType("int")
                        .HasColumnName("supplier_id");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int")
                        .HasColumnName("category_id");

                    b.HasKey("SupplierId", "CategoryId")
                        .HasName("PK__supp_cat__33B17A737140A310");

                    b.HasIndex("CategoryId");

                    b.ToTable("supp_category", (string)null);
                });

            modelBuilder.Entity("EEcomercEE.Models.Entitiess.Supplier", b =>
                {
                    b.Property<int>("SupplierId")
                        .HasColumnType("int")
                        .HasColumnName("supplier_id");

                    b.Property<string>("City")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("city");

                    b.Property<string>("ContactInfo")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("contact_info");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("name");

                    b.Property<string>("Street")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("street");

                    b.HasKey("SupplierId")
                        .HasName("PK__supplier__6EE594E8BEA1235B");

                    b.ToTable("supplier", (string)null);
                });

            modelBuilder.Entity("EEcomercEE.Models.Entitiess.Transactionn", b =>
                {
                    b.Property<int>("PaymentId")
                        .HasColumnType("int")
                        .HasColumnName("Payment_id");

                    b.Property<int?>("Amount")
                        .HasColumnType("int")
                        .HasColumnName("amount");

                    b.Property<string>("PayStatus")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("pay_status");

                    b.Property<string>("TranStatus")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Tran_status");

                    b.HasKey("PaymentId")
                        .HasName("PK__Transact__DA638B194468322E");

                    b.ToTable("Transactionn", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("RoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("UserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.ToTable("UserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("UserTokens");
                });

            modelBuilder.Entity("EEcomercEE.Models.Entitiess.CustOrder", b =>
                {
                    b.HasOne("EEcomercEE.Models.Entitiess.Customer", "Cust")
                        .WithMany("CustOrders")
                        .HasForeignKey("CustId")
                        .IsRequired()
                        .HasConstraintName("FK_Cust_Order_Customer1");

                    b.HasOne("EEcomercEE.Models.Entitiess.Orderr", "OIdNavigation")
                        .WithOne("CustOrder")
                        .HasForeignKey("EEcomercEE.Models.Entitiess.CustOrder", "OId")
                        .IsRequired()
                        .HasConstraintName("FK_Cust_Order_Orderr");

                    b.Navigation("Cust");

                    b.Navigation("OIdNavigation");
                });

            modelBuilder.Entity("EEcomercEE.Models.Entitiess.CustPhone", b =>
                {
                    b.HasOne("EEcomercEE.Models.Entitiess.Customer", "Cust")
                        .WithOne("CustPhone")
                        .HasForeignKey("EEcomercEE.Models.Entitiess.CustPhone", "CustId")
                        .IsRequired()
                        .HasConstraintName("fk_customer");

                    b.Navigation("Cust");
                });

            modelBuilder.Entity("EEcomercEE.Models.Entitiess.OrderTransaction", b =>
                {
                    b.HasOne("EEcomercEE.Models.Entitiess.Transactionn", "Pay")
                        .WithMany("OrderTransactions")
                        .HasForeignKey("PayId")
                        .HasConstraintName("FK_Order_Transaction_Transactionn1");

                    b.Navigation("Pay");
                });

            modelBuilder.Entity("EEcomercEE.Models.Entitiess.Orderr", b =>
                {
                    b.HasOne("EEcomercEE.Models.Entitiess.OrderTransaction", "Ord")
                        .WithOne("Orderr")
                        .HasForeignKey("EEcomercEE.Models.Entitiess.Orderr", "OrdId")
                        .IsRequired()
                        .HasConstraintName("FK_Orderr_Order_Transaction1");

                    b.Navigation("Ord");
                });

            modelBuilder.Entity("EEcomercEE.Models.Entitiess.ProdInventory", b =>
                {
                    b.HasOne("EEcomercEE.Models.Entitiess.Inventory", "Inventory")
                        .WithMany("ProdInventories")
                        .HasForeignKey("InventoryId")
                        .IsRequired()
                        .HasConstraintName("FK_Prod_inventory_inventory");

                    b.Navigation("Inventory");
                });

            modelBuilder.Entity("EEcomercEE.Models.Entitiess.ProdOrder", b =>
                {
                    b.HasOne("EEcomercEE.Models.Entitiess.Orderr", "OIdNavigation")
                        .WithMany("ProdOrders")
                        .HasForeignKey("OId")
                        .IsRequired()
                        .HasConstraintName("FK_Prod_order_Orderr");

                    b.HasOne("EEcomercEE.Models.Entitiess.Product", "Prod")
                        .WithMany("ProdOrders")
                        .HasForeignKey("ProdId")
                        .IsRequired()
                        .HasConstraintName("FK_Prod_order_Products");

                    b.Navigation("OIdNavigation");

                    b.Navigation("Prod");
                });

            modelBuilder.Entity("EEcomercEE.Models.Entitiess.SuppCategory", b =>
                {
                    b.HasOne("EEcomercEE.Models.Entitiess.Category", "Category")
                        .WithMany("SuppCategories")
                        .HasForeignKey("CategoryId")
                        .IsRequired()
                        .HasConstraintName("FK_supp_category_category");

                    b.HasOne("EEcomercEE.Models.Entitiess.ProdCategory", "CategoryNavigation")
                        .WithMany("SuppCategories")
                        .HasForeignKey("CategoryId")
                        .IsRequired()
                        .HasConstraintName("FK_supp_category_Prod_category");

                    b.HasOne("EEcomercEE.Models.Entitiess.Supplier", "Supplier")
                        .WithMany("SuppCategories")
                        .HasForeignKey("SupplierId")
                        .IsRequired()
                        .HasConstraintName("FK_supp_category_supplier");

                    b.Navigation("Category");

                    b.Navigation("CategoryNavigation");

                    b.Navigation("Supplier");
                });

            modelBuilder.Entity("EEcomercEE.Models.Entitiess.Category", b =>
                {
                    b.Navigation("SuppCategories");
                });

            modelBuilder.Entity("EEcomercEE.Models.Entitiess.Customer", b =>
                {
                    b.Navigation("CustOrders");

                    b.Navigation("CustPhone");
                });

            modelBuilder.Entity("EEcomercEE.Models.Entitiess.Inventory", b =>
                {
                    b.Navigation("ProdInventories");
                });

            modelBuilder.Entity("EEcomercEE.Models.Entitiess.OrderTransaction", b =>
                {
                    b.Navigation("Orderr");
                });

            modelBuilder.Entity("EEcomercEE.Models.Entitiess.Orderr", b =>
                {
                    b.Navigation("CustOrder");

                    b.Navigation("ProdOrders");
                });

            modelBuilder.Entity("EEcomercEE.Models.Entitiess.ProdCategory", b =>
                {
                    b.Navigation("SuppCategories");
                });

            modelBuilder.Entity("EEcomercEE.Models.Entitiess.Product", b =>
                {
                    b.Navigation("ProdOrders");
                });

            modelBuilder.Entity("EEcomercEE.Models.Entitiess.Supplier", b =>
                {
                    b.Navigation("SuppCategories");
                });

            modelBuilder.Entity("EEcomercEE.Models.Entitiess.Transactionn", b =>
                {
                    b.Navigation("OrderTransactions");
                });
#pragma warning restore 612, 618
        }
    }
}
