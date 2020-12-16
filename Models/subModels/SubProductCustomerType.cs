using apiProject.Models.subModels;
using System.Collections.Generic;
namespace apiProject.Models
{
    public class SubProductCustomerType
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public decimal? Price { get; set; }

        public double? Quantity { get; set; }

        public string BarCode { get; set; }
        public string Categoriy { get; set; }
        public virtual IList<ProductPrice> ProductPrices { get; set; }



    }
}