using test.Models.subModels;
using System.Collections.Generic;
namespace test.Models.subModels
{
    public class NestedSubProductCustomerType
    {
        public string Designation { get; set; }
        public decimal? PriceAfterTax { get; set; }
        public virtual SubProductCustomerType SubProductCustomerTypes { get; set; }


    }
}