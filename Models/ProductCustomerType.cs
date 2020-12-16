using System;
using System.Collections.Generic;

#nullable disable

namespace test.Models
{
    public partial class ProductCustomerType
    {
        public Guid Oid { get; set; }
        public Guid? Product { get; set; }
        public Guid? CustomerType { get; set; }
        public decimal? ProfitMargin { get; set; }
        public decimal? ProfitMarginAmount { get; set; }
        public decimal? PriceBeforeTax { get; set; }
        public decimal? PriceAfterTax { get; set; }
        public decimal? DiscountRate { get; set; }
        public decimal? DiscountedAmount { get; set; }
        public decimal? PriceBeforeTaxAfterDiscount { get; set; }
        public decimal? PriceAfterTaxAfterDiscount { get; set; }
        public decimal? RefundRate { get; set; }
        public Guid? Parameters { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }

        public virtual CustomerType CustomerTypeNavigation { get; set; }
        public virtual Product ProductNavigation { get; set; }
    }
}
