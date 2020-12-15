using test.Models.subModels;
using System.Collections.Generic;
namespace test.Models
{
    public class SubProductCustomerType
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public decimal? SalePriceTaxIncluded { get; set; }

        public double? Quantity { get; set; }

        public string Ean13code { get; set; }
        public string FullName { get; set; }
        public virtual IEnumerable<NestedSubProductCustomerType> nestedArray { get; set; }


    }
}