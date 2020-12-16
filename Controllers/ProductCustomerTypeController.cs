using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using apiProject.Models;
using apiProject.Models.subModels;
using MoreLinq.Extensions;

using Microsoft.EntityFrameworkCore;

namespace exempleApiTenders.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductCustomerTypeController : ControllerBase
    {
        private readonly palcdist_2020Context _context;

        public ProductCustomerTypeController(palcdist_2020Context context)
        {
            _context = context;
        }
        // Get api/ProductCustomerType/GetProductCustomerTypes
        [HttpGet("")]
        [Route("1")]
        public ActionResult<IEnumerable<Object>> GetProductCustomerTypes()

        {
            var result = _context.ProductCustomerTypes
            .Include(x => x.CustomerTypeNavigation)
            .Include(x => x.ProductNavigation)
            .Select(e => new SubProductCustomerType
            {
                Id = e.ProductNavigation.Id,
                BarCode = e.ProductNavigation.Ean13code,
                Name = e.ProductNavigation.Name,
                Categoriy = e.ProductNavigation.CategoryNavigation.FullName,
                Price = e.ProductNavigation.SalePriceTaxIncluded,
                Quantity = e.ProductNavigation.Quantity,
                ProductPrices = e.ProductNavigation.ProductCustomerTypes
               .Select(row => new ProductPrice
               {
                   Designation = row.CustomerTypeNavigation.Designation,
                   PriceAfterTax = row.PriceAfterTax
               }).ToList()
            }).ToList();
            return result.DistinctBy(x => x.Id).ToList();

        }
        [HttpGet("")]
        [Route("2")]
        public ActionResult<IEnumerable<Object>> GetProductwithouCustomerType()

        {
            var result = _context.Products
            .Select(e => new SubProductCustomerType
            {
                Id = e.Id,
                BarCode = e.Ean13code,
                Name = e.Name,
                Categoriy = e.CategoryNavigation.FullName,
                Price = e.SalePriceTaxIncluded,
                Quantity = e.Quantity,
                ProductPrices = e.ProductCustomerTypes
               .Select(row => new ProductPrice
               {
                   Designation = row.CustomerTypeNavigation.Designation,
                   PriceAfterTax = row.PriceAfterTax
               }).ToList()
            }).ToList();
            return result.DistinctBy(x => x.Id).ToList();

        }

    }
}
