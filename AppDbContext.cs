using System;
using System.Collections.Generic;
using EEcomercEE.Models.Entitiess;
using Microsoft.EntityFrameworkCore;

namespace EEcomercEE.Models.Datas;

public partial class AppDbContext : DbContext
{
    public AppDbContext()
    {
    }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<CustOrder> CustOrders { get; set; }

    public virtual DbSet<CustPhone> CustPhones { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Inventory> Inventories { get; set; }

    public virtual DbSet<OrderTransaction> OrderTransactions { get; set; }

    public virtual DbSet<Orderr> Orderrs { get; set; }

    public virtual DbSet<ProdCategory> ProdCategories { get; set; }

    public virtual DbSet<ProdInventory> ProdInventories { get; set; }

    public virtual DbSet<ProdOrder> ProdOrders { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<SuppCategory> SuppCategories { get; set; }

    public virtual DbSet<Supplier> Suppliers { get; set; }

    public virtual DbSet<Transactionn> Transactionns { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("server=.;database=FahdDb;integrated security=sspi;trust server certificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("Arabic_CI_AI");

        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.CategoryId).HasName("PK__category__D54EE9B4F13A3B8F");

            entity.ToTable("category");

            entity.Property(e => e.CategoryId)
                .ValueGeneratedNever()
                .HasColumnName("category_id");
            entity.Property(e => e.CategoryName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("category_name");
        });

        modelBuilder.Entity<CustOrder>(entity =>
        {
            entity.HasKey(e => e.OId).HasName("PK__Cust_Ord__5AA8081027C7B9BF");

            entity.ToTable("Cust_Order");

            entity.Property(e => e.OId).HasColumnName("O_id");
            entity.Property(e => e.CustId).HasColumnName("Cust_id");

            entity.HasOne(d => d.Cust).WithMany(p => p.CustOrders)
                .HasForeignKey(d => d.CustId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Cust_Order_Customer1");

            entity.HasOne(d => d.OIdNavigation).WithOne(p => p.CustOrder)
                .HasForeignKey<CustOrder>(d => d.OId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Cust_Order_Orderr");
        });

        modelBuilder.Entity<CustPhone>(entity =>
        {
            entity.HasKey(e => e.CustId).HasName("PK__cust_pho__A1B71F900B499DAD");

            entity.ToTable("cust_phone");

            entity.Property(e => e.CustId)
                .ValueGeneratedNever()
                .HasColumnName("cust_id");
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("phone_number");

            entity.HasOne(d => d.Cust).WithOne(p => p.CustPhone)
                .HasForeignKey<CustPhone>(d => d.CustId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_customer");
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.CustId).HasName("PK__Customer__7B8E5D0F1FB0EBE1");

            entity.ToTable("Customer");

            entity.Property(e => e.CustId)
                .ValueGeneratedNever()
                .HasColumnName("Cust_id");
            entity.Property(e => e.City)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("city");
            entity.Property(e => e.CustName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Cust_Name");
            entity.Property(e => e.Street)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("street");
        });

        modelBuilder.Entity<Inventory>(entity =>
        {
            entity.HasKey(e => e.InventoryId).HasName("PK__inventor__B59ACC49591483A1");

            entity.ToTable("inventory");

            entity.Property(e => e.InventoryId)
                .ValueGeneratedNever()
                .HasColumnName("inventory_id");
            entity.Property(e => e.InventoryName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("inventory_name");
            entity.Property(e => e.QuantityInStock)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Quantity_in_stock");
            entity.Property(e => e.QuantitySold)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Quantity_sold");
        });

        modelBuilder.Entity<OrderTransaction>(entity =>
        {
            entity.HasKey(e => e.OId).HasName("PK__Order_Tr__5AA80810DC20EC69");

            entity.ToTable("Order_Transaction");

            entity.Property(e => e.OId).HasColumnName("O_id");
            entity.Property(e => e.PayId).HasColumnName("Pay_id");

            entity.HasOne(d => d.Pay).WithMany(p => p.OrderTransactions)
                .HasForeignKey(d => d.PayId)
                .HasConstraintName("FK_Order_Transaction_Transactionn1");
        });

        modelBuilder.Entity<Orderr>(entity =>
        {
            entity.HasKey(e => e.OrdId).HasName("PK__Orderr__1711AE46E1FB9D96");

            entity.ToTable("Orderr");

            entity.Property(e => e.OrdId).HasColumnName("Ord_id");
            entity.Property(e => e.ODate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("O_Date");
            entity.Property(e => e.OStatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("O_Status");
            entity.Property(e => e.TotalAmount)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Total_amount");

            entity.HasOne(d => d.Ord).WithOne(p => p.Orderr)
                .HasForeignKey<Orderr>(d => d.OrdId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Orderr_Order_Transaction1");
        });

        modelBuilder.Entity<ProdCategory>(entity =>
        {
            entity.HasKey(e => e.ProdId).HasName("PK__Prod_cat__C55AC32BBDB4CF73");

            entity.ToTable("Prod_category");

            entity.Property(e => e.ProdId)
                .ValueGeneratedNever()
                .HasColumnName("Prod_id");
            entity.Property(e => e.CategoryId).HasColumnName("category_id");
        });

        modelBuilder.Entity<ProdInventory>(entity =>
        {
            entity.HasKey(e => e.ProdId).HasName("PK__Prod_inv__C55AC32B36C34A08");

            entity.ToTable("Prod_inventory");

            entity.Property(e => e.ProdId)
                .ValueGeneratedNever()
                .HasColumnName("Prod_id");
            entity.Property(e => e.InventoryId).HasColumnName("inventory_id");

            entity.HasOne(d => d.Inventory).WithMany(p => p.ProdInventories)
                .HasForeignKey(d => d.InventoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Prod_inventory_inventory");
        });

        modelBuilder.Entity<ProdOrder>(entity =>
        {
            entity.HasKey(e => new { e.ProdId, e.OId }).HasName("PK__Prod_ord__D0F043AAC9DB2B7B");

            entity.ToTable("Prod_order");

            entity.Property(e => e.ProdId).HasColumnName("Prod_id");
            entity.Property(e => e.OId).HasColumnName("O_id");
            entity.Property(e => e.Price).HasColumnName("price");

            entity.HasOne(d => d.OIdNavigation).WithMany(p => p.ProdOrders)
                .HasForeignKey(d => d.OId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Prod_order_Orderr");

            entity.HasOne(d => d.Prod).WithMany(p => p.ProdOrders)
                .HasForeignKey(d => d.ProdId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Prod_order_Products");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.PId).HasName("PK__Products__A3410E4F49A0ABD9");

            entity.Property(e => e.PId).HasColumnName("P_id");
            entity.Property(e => e.Description)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.Imagepath)
                .HasMaxLength(300)
                .IsFixedLength()
                .HasColumnName("imagepath");
            entity.Property(e => e.PName)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("P_name");
        });

        modelBuilder.Entity<SuppCategory>(entity =>
        {
            entity.HasKey(e => new { e.SupplierId, e.CategoryId }).HasName("PK__supp_cat__33B17A737140A310");

            entity.ToTable("supp_category");

            entity.Property(e => e.SupplierId).HasColumnName("supplier_id");
            entity.Property(e => e.CategoryId).HasColumnName("category_id");

            entity.HasOne(d => d.Category).WithMany(p => p.SuppCategories)
                .HasForeignKey(d => d.CategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_supp_category_category");

            entity.HasOne(d => d.CategoryNavigation).WithMany(p => p.SuppCategories)
                .HasForeignKey(d => d.CategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_supp_category_Prod_category");

            entity.HasOne(d => d.Supplier).WithMany(p => p.SuppCategories)
                .HasForeignKey(d => d.SupplierId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_supp_category_supplier");
        });

        modelBuilder.Entity<Supplier>(entity =>
        {
            entity.HasKey(e => e.SupplierId).HasName("PK__supplier__6EE594E8BEA1235B");

            entity.ToTable("supplier");

            entity.Property(e => e.SupplierId)
                .ValueGeneratedNever()
                .HasColumnName("supplier_id");
            entity.Property(e => e.City)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("city");
            entity.Property(e => e.ContactInfo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("contact_info");
            entity.Property(e => e.Name)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Street)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("street");
        });

        modelBuilder.Entity<Transactionn>(entity =>
        {
            entity.HasKey(e => e.PaymentId).HasName("PK__Transact__DA638B194468322E");

            entity.ToTable("Transactionn");

            entity.Property(e => e.PaymentId)
                .ValueGeneratedNever()
                .HasColumnName("Payment_id");
            entity.Property(e => e.Amount).HasColumnName("amount");
            entity.Property(e => e.PayStatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("pay_status");
            entity.Property(e => e.TranStatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Tran_status");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
