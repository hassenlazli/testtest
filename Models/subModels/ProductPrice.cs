using apiProject.Models.subModels;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace apiProject.Models.subModels
{

    public class ProductPrice
    {

        public string Designation { get; set; }
        public decimal? PriceAfterTax { get; set; }


        // public virtual SubProductCustomerType SubProductCustomerType { get; set; }




    }
}