using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace test.Models
{
    public partial class palcdist_2020Context : DbContext
    {
        public palcdist_2020Context()
        {
        }

        public palcdist_2020Context(DbContextOptions<palcdist_2020Context> options)
            : base(options)
        {
        }

        public virtual DbSet<CustomerType> CustomerTypes { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductCategory> ProductCategories { get; set; }
        public virtual DbSet<ProductCustomerType> ProductCustomerTypes { get; set; }
        public virtual DbSet<Truck> Trucks { get; set; }
        public virtual DbSet<Vendor> Vendors { get; set; }
        public virtual DbSet<Warehouse> Warehouses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=tcp:0.tcp.ngrok.io,15136;Initial Catalog=palcdist_2020;Persist Security Info=False;User ID=sa;Password=58206670;MultipleActiveResultSets=False;Encrypt=false;TrustServerCertificate=False;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "French_CI_AS");

            modelBuilder.Entity<CustomerType>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("CustomerType");

                entity.HasIndex(e => e.Gcrecord, "iGCRecord_CustomerType");

                entity.HasIndex(e => e.Parameters, "iparameters_CustomerType");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.DefaultDiscountRate)
                    .HasColumnType("decimal(28, 10)")
                    .HasColumnName("defaultDiscountRate");

                entity.Property(e => e.DefaultProfitMargin)
                    .HasColumnType("decimal(28, 10)")
                    .HasColumnName("defaultProfitMargin");

                entity.Property(e => e.Designation)
                    .HasMaxLength(100)
                    .HasColumnName("designation");

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.Parameters).HasColumnName("parameters");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("Product");

                entity.HasIndex(e => e.Gcrecord, "iGCRecord_Product");

                entity.HasIndex(e => e.AssetAccount, "iassetAccount_Product");

                entity.HasIndex(e => e.Category, "icategory_Product");

                entity.HasIndex(e => e.Currency, "icurrency_Product");

                entity.HasIndex(e => e.DefaultNomenclature, "idefaultNomenclature_Product");

                entity.HasIndex(e => e.DefaultPackagingInput, "idefaultPackagingInput_Product");

                entity.HasIndex(e => e.DefaultPackagingOutput, "idefaultPackagingOutput_Product");

                entity.HasIndex(e => e.DefaultWarehouse, "idefaultWarehouse_Product");

                entity.HasIndex(e => e.Parameters, "iparameters_Product");

                entity.HasIndex(e => e.ProductNature, "iproductNature_Product");

                entity.HasIndex(e => e.PurchaseAccount, "ipurchaseAccount_Product");

                entity.HasIndex(e => e.RevenueClassification, "irevenueClassification_Product");

                entity.HasIndex(e => e.SalesAccount, "isalesAccount_Product");

                entity.HasIndex(e => e.StockAccount, "istockAccount_Product");

                entity.HasIndex(e => e.StockConsumptionAccount, "istockConsumptionAccount_Product");

                entity.HasIndex(e => e.TariffPosition, "itariffPosition_Product");

                entity.HasIndex(e => e.Tax, "itax_Product");

                entity.HasIndex(e => e.UnitOfMeasure, "iunitOfMeasure_Product");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.AcquisitionDate)
                    .HasColumnType("datetime")
                    .HasColumnName("acquisitionDate");

                entity.Property(e => e.AlertStock)
                    .HasColumnType("decimal(28, 10)")
                    .HasColumnName("alertStock");

                entity.Property(e => e.AmortizationType).HasColumnName("amortizationType");

                entity.Property(e => e.AssetAccount).HasColumnName("assetAccount");

                entity.Property(e => e.AssetType).HasColumnName("assetType");

                entity.Property(e => e.AvailableInDistributionMobileApp).HasColumnName("availableInDistributionMobileApp");

                entity.Property(e => e.AvailableInSalesPointsApp).HasColumnName("availableInSalesPointsApp");

                entity.Property(e => e.Bloqué).HasColumnName("bloqué");

                entity.Property(e => e.Category).HasColumnName("category");

                entity.Property(e => e.CodeCounter).HasColumnName("codeCounter");

                entity.Property(e => e.ComputingMode).HasColumnName("computingMode");

                entity.Property(e => e.CostPrice)
                    .HasColumnType("money")
                    .HasColumnName("costPrice");

                entity.Property(e => e.Currency).HasColumnName("currency");

                entity.Property(e => e.CustomsDutyUnitaryCharge)
                    .HasColumnType("money")
                    .HasColumnName("customsDutyUnitaryCharge");

                entity.Property(e => e.DefaultNomenclature).HasColumnName("defaultNomenclature");

                entity.Property(e => e.DefaultPackagingInput).HasColumnName("defaultPackagingInput");

                entity.Property(e => e.DefaultPackagingOutput).HasColumnName("defaultPackagingOutput");

                entity.Property(e => e.DefaultWarehouse).HasColumnName("defaultWarehouse");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.DescriptionPurchase).HasColumnName("description_purchase");

                entity.Property(e => e.DescriptionSales).HasColumnName("description_sales");

                entity.Property(e => e.Ean13code)
                    .HasMaxLength(100)
                    .HasColumnName("EAN13Code");

                entity.Property(e => e.ExchangeRate).HasColumnName("_exchangeRate");

                entity.Property(e => e.ExchangeRate1)
                    .HasColumnType("decimal(28, 10)")
                    .HasColumnName("exchangeRate");

                entity.Property(e => e.FiscalCoefficient).HasColumnName("fiscalCoefficient");

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.GlobalRefundRate)
                    .HasColumnType("decimal(28, 10)")
                    .HasColumnName("globalRefundRate");

                entity.Property(e => e.Id)
                    .HasMaxLength(100)
                    .HasColumnName("id");

                entity.Property(e => e.ImmoManagement).HasColumnName("immoManagement");

                entity.Property(e => e.ImportationUnitaryCharge)
                    .HasColumnType("money")
                    .HasColumnName("importationUnitaryCharge");

                entity.Property(e => e.InitialStock)
                    .HasColumnType("decimal(28, 10)")
                    .HasColumnName("initialStock");

                entity.Property(e => e.IsPdr).HasColumnName("isPDR");

                entity.Property(e => e.LinearAmortizationRate).HasColumnName("linearAmortizationRate");

                entity.Property(e => e.MarketingBudgetRate)
                    .HasColumnType("decimal(28, 10)")
                    .HasColumnName("marketingBudgetRate");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .HasColumnName("name");

                entity.Property(e => e.NetValueAccounting)
                    .HasColumnType("money")
                    .HasColumnName("netValueAccounting");

                entity.Property(e => e.Note).HasColumnName("note");

                entity.Property(e => e.NumberYearsUse).HasColumnName("numberYearsUse");

                entity.Property(e => e.OrderedQuantity).HasColumnName("orderedQuantity");

                entity.Property(e => e.Parameters).HasColumnName("parameters");

                entity.Property(e => e.Picture).HasColumnName("picture");

                entity.Property(e => e.PreparedQuantity).HasColumnName("preparedQuantity");

                entity.Property(e => e.PrixP1)
                    .HasColumnType("money")
                    .HasColumnName("prixP1");

                entity.Property(e => e.PrixP2)
                    .HasColumnType("money")
                    .HasColumnName("prixP2");

                entity.Property(e => e.PrixP3)
                    .HasColumnType("money")
                    .HasColumnName("prixP3");

                entity.Property(e => e.PrixP4)
                    .HasColumnType("money")
                    .HasColumnName("prixP4");

                entity.Property(e => e.ProductNature).HasColumnName("productNature");

                entity.Property(e => e.ProductPos).HasColumnName("productPOS");

                entity.Property(e => e.ProductType).HasColumnName("productType");

                entity.Property(e => e.ProfitMarginAmount)
                    .HasColumnType("money")
                    .HasColumnName("profit_margin_amount");

                entity.Property(e => e.ProfitMarginRate)
                    .HasColumnType("decimal(28, 10)")
                    .HasColumnName("profit_margin_rate");

                entity.Property(e => e.PurchaseAccount).HasColumnName("purchaseAccount");

                entity.Property(e => e.PurchasePrice)
                    .HasColumnType("money")
                    .HasColumnName("purchasePrice");

                entity.Property(e => e.PurchasePriceInCurrency)
                    .HasColumnType("money")
                    .HasColumnName("purchasePriceInCurrency");

                entity.Property(e => e.QuantiteAssise).HasColumnName("quantiteAssise");

                entity.Property(e => e.QuantiteCarcasse).HasColumnName("quantiteCarcasse");

                entity.Property(e => e.QuantiteTissusJettes).HasColumnName("quantiteTissusJettes");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.QuantitéComptable).HasColumnName("quantitéComptable");

                entity.Property(e => e.ReservedQuantity).HasColumnName("reservedQuantity");

                entity.Property(e => e.RevenueClassification).HasColumnName("revenueClassification");

                entity.Property(e => e.SalePriceBeforeTax)
                    .HasColumnType("money")
                    .HasColumnName("salePrice_before_tax");

                entity.Property(e => e.SalePriceTaxIncluded)
                    .HasColumnType("money")
                    .HasColumnName("salePrice_tax_included");

                entity.Property(e => e.SalesAccount).HasColumnName("salesAccount");

                entity.Property(e => e.SalesPricesFromCostPrice).HasColumnName("salesPricesFromCostPrice");

                entity.Property(e => e.SalesPricesFromPurchasePrice).HasColumnName("salesPricesFromPurchasePrice");

                entity.Property(e => e.SoumisAristourne).HasColumnName("soumisARistourne");

                entity.Property(e => e.StartingPointOfAmortization)
                    .HasColumnType("datetime")
                    .HasColumnName("startingPointOfAmortization");

                entity.Property(e => e.Stock)
                    .HasColumnType("decimal(28, 10)")
                    .HasColumnName("stock");

                entity.Property(e => e.StockAccount).HasColumnName("stockAccount");

                entity.Property(e => e.StockConsumptionAccount).HasColumnName("stockConsumptionAccount");

                entity.Property(e => e.SubjectToContract).HasColumnName("subjectToContract");

                entity.Property(e => e.SupplierCode)
                    .HasMaxLength(100)
                    .HasColumnName("supplierCode");

                entity.Property(e => e.TariffPosition).HasColumnName("tariffPosition");

                entity.Property(e => e.Tax).HasColumnName("tax");

                entity.Property(e => e.TheoreticalStock).HasColumnName("theoreticalStock");

                entity.Property(e => e.TotalInput)
                    .HasColumnType("decimal(28, 10)")
                    .HasColumnName("totalInput");

                entity.Property(e => e.TotalOutput)
                    .HasColumnType("decimal(28, 10)")
                    .HasColumnName("totalOutput");

                entity.Property(e => e.UnitOfMeasure).HasColumnName("unitOfMeasure");

                entity.Property(e => e.UnitWeight)
                    .HasColumnType("decimal(28, 10)")
                    .HasColumnName("unitWeight");

                entity.Property(e => e.UseSnid).HasColumnName("useSNID");

                entity.Property(e => e.VatNonRecoverable).HasColumnName("vatNonRecoverable");

                entity.Property(e => e.WarehouseGlobalStock)
                    .HasColumnType("decimal(28, 10)")
                    .HasColumnName("warehouseGlobalStock");

                entity.Property(e => e.WeightedAverageCost)
                    .HasColumnType("money")
                    .HasColumnName("weightedAverageCost");

                entity.HasOne(d => d.CategoryNavigation)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.Category)
                    .HasConstraintName("FK_Product_category");

                entity.HasOne(d => d.DefaultWarehouseNavigation)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.DefaultWarehouse)
                    .HasConstraintName("FK_Product_defaultWarehouse");
            });

            modelBuilder.Entity<ProductCategory>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("ProductCategory");

                entity.HasIndex(e => e.Gcrecord, "iGCRecord_ProductCategory");

                entity.HasIndex(e => e.Account, "iaccount_ProductCategory");

                entity.HasIndex(e => e.Parameters, "iparameters_ProductCategory");

                entity.HasIndex(e => e.ParentCategory, "iparentCategory_ProductCategory");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Account).HasColumnName("account");

                entity.Property(e => e.Counter).HasColumnName("counter");

                entity.Property(e => e.FullName).HasColumnName("fullName");

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.Id)
                    .HasMaxLength(100)
                    .HasColumnName("id");

                entity.Property(e => e.ImmoManagement).HasColumnName("immoManagement");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .HasColumnName("name");

                entity.Property(e => e.Parameters).HasColumnName("parameters");

                entity.Property(e => e.ParentCategory).HasColumnName("parentCategory");

                entity.Property(e => e.TypeFamille).HasColumnName("typeFamille");

                entity.HasOne(d => d.ParentCategoryNavigation)
                    .WithMany(p => p.InverseParentCategoryNavigation)
                    .HasForeignKey(d => d.ParentCategory)
                    .HasConstraintName("FK_ProductCategory_parentCategory");
            });

            modelBuilder.Entity<ProductCustomerType>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("ProductCustomerType");

                entity.HasIndex(e => e.Gcrecord, "iGCRecord_ProductCustomerType");

                entity.HasIndex(e => e.CustomerType, "icustomerType_ProductCustomerType");

                entity.HasIndex(e => e.Parameters, "iparameters_ProductCustomerType");

                entity.HasIndex(e => e.Product, "iproduct_ProductCustomerType");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.CustomerType).HasColumnName("customerType");

                entity.Property(e => e.DiscountRate)
                    .HasColumnType("decimal(28, 10)")
                    .HasColumnName("discountRate");

                entity.Property(e => e.DiscountedAmount)
                    .HasColumnType("money")
                    .HasColumnName("discountedAmount");

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.Parameters).HasColumnName("parameters");

                entity.Property(e => e.PriceAfterTax)
                    .HasColumnType("money")
                    .HasColumnName("priceAfterTax");

                entity.Property(e => e.PriceAfterTaxAfterDiscount)
                    .HasColumnType("money")
                    .HasColumnName("priceAfterTaxAfterDiscount");

                entity.Property(e => e.PriceBeforeTax)
                    .HasColumnType("money")
                    .HasColumnName("priceBeforeTax");

                entity.Property(e => e.PriceBeforeTaxAfterDiscount)
                    .HasColumnType("money")
                    .HasColumnName("priceBeforeTaxAfterDiscount");

                entity.Property(e => e.Product).HasColumnName("product");

                entity.Property(e => e.ProfitMargin)
                    .HasColumnType("decimal(28, 10)")
                    .HasColumnName("profitMargin");

                entity.Property(e => e.ProfitMarginAmount)
                    .HasColumnType("money")
                    .HasColumnName("profitMarginAmount");

                entity.Property(e => e.RefundRate)
                    .HasColumnType("decimal(28, 10)")
                    .HasColumnName("refundRate");

                entity.HasOne(d => d.CustomerTypeNavigation)
                    .WithMany(p => p.ProductCustomerTypes)
                    .HasForeignKey(d => d.CustomerType)
                    .HasConstraintName("FK_ProductCustomerType_customerType");

                entity.HasOne(d => d.ProductNavigation)
                    .WithMany(p => p.ProductCustomerTypes)
                    .HasForeignKey(d => d.Product)
                    .HasConstraintName("FK_ProductCustomerType_product");
            });

            modelBuilder.Entity<Truck>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("Truck");

                entity.HasIndex(e => e.Vehicule, "ivehicule_Truck");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Matricule)
                    .HasMaxLength(100)
                    .HasColumnName("matricule");

                entity.Property(e => e.Vehicule).HasColumnName("vehicule");

                entity.HasOne(d => d.OidNavigation)
                    .WithOne(p => p.Truck)
                    .HasForeignKey<Truck>(d => d.Oid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Truck_Oid");
            });

            modelBuilder.Entity<Vendor>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("Vendor");

                entity.HasIndex(e => e.Gcrecord, "iGCRecord_Vendor");

                entity.HasIndex(e => e.CashRegister, "icashRegister_Vendor");

                entity.HasIndex(e => e.CurrentTruck, "icurrentTruck_Vendor");

                entity.HasIndex(e => e.Employee, "iemployee_Vendor");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.CashRegister).HasColumnName("cashRegister");

                entity.Property(e => e.CurrentTruck).HasColumnName("currentTruck");

                entity.Property(e => e.Employee).HasColumnName("employee");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(100)
                    .HasColumnName("firstName");

                entity.Property(e => e.FullName)
                    .HasMaxLength(100)
                    .HasColumnName("fullName");

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.LastName)
                    .HasMaxLength(100)
                    .HasColumnName("lastName");

                entity.Property(e => e.MatriculeEmployé)
                    .HasMaxLength(100)
                    .HasColumnName("matricule_employé");

                entity.Property(e => e.MiddleName)
                    .HasMaxLength(100)
                    .HasColumnName("middleName");

                entity.HasOne(d => d.CurrentTruckNavigation)
                    .WithMany(p => p.Vendors)
                    .HasForeignKey(d => d.CurrentTruck)
                    .HasConstraintName("FK_Vendor_currentTruck");
            });

            modelBuilder.Entity<Warehouse>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("Warehouse");

                entity.HasIndex(e => e.Gcrecord, "iGCRecord_Warehouse");

                entity.HasIndex(e => e.ObjectType, "iObjectType_Warehouse");

                entity.HasIndex(e => e.Manager, "imanager_Warehouse");

                entity.HasIndex(e => e.Parameters, "iparameters_Warehouse");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.AllowBulkQuantities).HasColumnName("allowBulkQuantities");

                entity.Property(e => e.BarCode)
                    .HasMaxLength(100)
                    .HasColumnName("barCode");

                entity.Property(e => e.ExcludedFromPreparation).HasColumnName("excludedFromPreparation");

                entity.Property(e => e.Gcrecord).HasColumnName("GCRecord");

                entity.Property(e => e.Id)
                    .HasMaxLength(100)
                    .HasColumnName("id");

                entity.Property(e => e.ImmoManagement).HasColumnName("immoManagement");

                entity.Property(e => e.IsActif).HasColumnName("isActif");

                entity.Property(e => e.IsDefaultWarehouse).HasColumnName("isDefaultWarehouse");

                entity.Property(e => e.Manager).HasColumnName("manager");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .HasColumnName("name");

                entity.Property(e => e.Parameters).HasColumnName("parameters");

                entity.Property(e => e.Priority).HasColumnName("priority");

                entity.Property(e => e.Type).HasColumnName("type");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
