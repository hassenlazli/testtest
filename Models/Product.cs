using System;
using System.Collections.Generic;

#nullable disable

namespace test.Models
{
    public partial class Product
    {
        public Product()
        {
            ProductCustomerTypes = new HashSet<ProductCustomerType>();
        }

        public Guid Oid { get; set; }
        public double? ExchangeRate { get; set; }
        public string Id { get; set; }
        public bool? UseSnid { get; set; }
        public string Name { get; set; }
        public int? ProductType { get; set; }
        public byte[] Picture { get; set; }
        public decimal? PurchasePrice { get; set; }
        public string Description { get; set; }
        public string DescriptionPurchase { get; set; }
        public string DescriptionSales { get; set; }
        public string Note { get; set; }
        public int? ComputingMode { get; set; }
        public Guid? Tax { get; set; }
        public decimal? SalePriceBeforeTax { get; set; }
        public decimal? SalePriceTaxIncluded { get; set; }
        public decimal? ProfitMarginAmount { get; set; }
        public bool? SalesPricesFromPurchasePrice { get; set; }
        public bool? SalesPricesFromCostPrice { get; set; }
        public decimal? ProfitMarginRate { get; set; }
        public string Ean13code { get; set; }
        public bool? SubjectToContract { get; set; }
        public Guid? SalesAccount { get; set; }
        public Guid? PurchaseAccount { get; set; }
        public Guid? StockAccount { get; set; }
        public Guid? StockConsumptionAccount { get; set; }
        public double? ReservedQuantity { get; set; }
        public double? OrderedQuantity { get; set; }
        public double? PreparedQuantity { get; set; }
        public double? TheoreticalStock { get; set; }
        public decimal? MarketingBudgetRate { get; set; }
        public bool? ProductPos { get; set; }
        public bool? ImmoManagement { get; set; }
        public double? LinearAmortizationRate { get; set; }
        public DateTime? AcquisitionDate { get; set; }
        public DateTime? StartingPointOfAmortization { get; set; }
        public int? AmortizationType { get; set; }
        public double? FiscalCoefficient { get; set; }
        public int? NumberYearsUse { get; set; }
        public decimal? NetValueAccounting { get; set; }
        public double? Quantity { get; set; }
        public double? QuantiteAssise { get; set; }
        public double? QuantiteCarcasse { get; set; }
        public double? QuantiteTissusJettes { get; set; }
        public decimal? PrixP1 { get; set; }
        public decimal? PrixP2 { get; set; }
        public decimal? PrixP3 { get; set; }
        public decimal? PrixP4 { get; set; }
        public decimal? GlobalRefundRate { get; set; }
        public Guid? Parameters { get; set; }
        public int? CodeCounter { get; set; }
        public Guid? Category { get; set; }
        public Guid? DefaultWarehouse { get; set; }
        public decimal? WeightedAverageCost { get; set; }
        public decimal? InitialStock { get; set; }
        public decimal? TotalInput { get; set; }
        public decimal? TotalOutput { get; set; }
        public decimal? Stock { get; set; }
        public decimal? WarehouseGlobalStock { get; set; }
        public decimal? AlertStock { get; set; }
        public Guid? ProductNature { get; set; }
        public Guid? RevenueClassification { get; set; }
        public Guid? DefaultNomenclature { get; set; }
        public Guid? UnitOfMeasure { get; set; }
        public decimal? UnitWeight { get; set; }
        public Guid? DefaultPackagingInput { get; set; }
        public Guid? DefaultPackagingOutput { get; set; }
        public Guid? Currency { get; set; }
        public decimal? ExchangeRate1 { get; set; }
        public Guid? TariffPosition { get; set; }
        public decimal? CustomsDutyUnitaryCharge { get; set; }
        public decimal? ImportationUnitaryCharge { get; set; }
        public decimal? CostPrice { get; set; }
        public decimal? PurchasePriceInCurrency { get; set; }
        public bool? AvailableInDistributionMobileApp { get; set; }
        public bool? AvailableInSalesPointsApp { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }
        public string SupplierCode { get; set; }
        public bool? Bloqué { get; set; }
        public Guid? AssetAccount { get; set; }
        public bool? VatNonRecoverable { get; set; }
        public bool? SoumisAristourne { get; set; }
        public int? AssetType { get; set; }
        public double? QuantitéComptable { get; set; }
        public bool? IsPdr { get; set; }

        public virtual ProductCategory CategoryNavigation { get; set; }
        public virtual Warehouse DefaultWarehouseNavigation { get; set; }
        public virtual ICollection<ProductCustomerType> ProductCustomerTypes { get; set; }
    }
}
