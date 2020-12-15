using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using test.Models;
using Microsoft.EntityFrameworkCore;

namespace exempleApiTenders.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductCustomerTypeController : ControllerBase
    {
        private readonly apiContext _context;

        public ProductCustomerTypeController(apiContext context)
        {
            _context = context;
        }
        // Get api/ProductCustomerType/GetProductCustomerTypes
        [HttpGet("")]
        public ActionResult<IList<Object>> GetProductCustomerTypes()
        {

            var result = _context.ProductCustomerTypes
              .Include(x => x.CustomerTypeNavigation)
              .Include(x => x.ProductNavigation)
              .Select(row => new
              {
                  id = row.ProductNavigation.Id,
                  barCode = row.ProductNavigation.Ean13code,
                  name = row.ProductNavigation.Name,
                  category = row.ProductNavigation.CategoryNavigation.FullName,
                  price = row.ProductNavigation.SalePriceTaxIncluded,
                  quantity = row.ProductNavigation.Quantity,
                  productPrices = new
                  {

                      typeClient = row.CustomerTypeNavigation.Designation,
                      price = row.PriceAfterTax
                  }

                  //  .Select(p => new
                  //  {
                  //      typeClient = p.ProductNavigation.CategoryNavigation.FullName,
                  //      price = row.PriceAfterTax,
                  //  })

              }).ToList();




            return result.ToList().Cast<Object>().ToList();

        }
        [HttpGet]
        [Route("2")]
        public ActionResult<IList<Object>> GetProductCustomerTypes2()
        {

            var result = _context.ProductCustomerTypes
              .Include(x => x.CustomerTypeNavigation)
              .Include(x => x.ProductNavigation).Where(x => x.ProductNavigation.Id != null)
              .Select(row => new
              {
                  id = row.ProductNavigation.Id,
                  barCode = row.ProductNavigation.Ean13code,
                  name = row.ProductNavigation.Name,
                  category = row.ProductNavigation.CategoryNavigation.FullName,
                  price = row.ProductNavigation.SalePriceTaxIncluded,
                  quantity = row.ProductNavigation.Quantity,
                  typeClient = row.ProductNavigation.CategoryNavigation.FullName,
                  prices = row.PriceAfterTax,


              }).Take(5);




            return result.ToList().Cast<Object>().ToList();

        }

    }
}
