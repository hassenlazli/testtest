using System;
using System.Collections.Generic;

#nullable disable

namespace apiProject.Models
{
    public partial class CustomerType
    {
        public CustomerType()
        {
            ProductCustomerTypes = new HashSet<ProductCustomerType>();
        }

        public Guid Oid { get; set; }
        public string Designation { get; set; }
        public decimal? DefaultProfitMargin { get; set; }
        public decimal? DefaultDiscountRate { get; set; }
        public Guid? Parameters { get; set; }
        public int? OptimisticLockField { get; set; }
        public int? Gcrecord { get; set; }

        public virtual ICollection<ProductCustomerType> ProductCustomerTypes { get; set; }
    }
}
