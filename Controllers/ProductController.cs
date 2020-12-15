// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using Microsoft.AspNetCore.Mvc;
// using test.Models;

// namespace test.Controllers
// {
//     [Route("api/[controller]")]
//     [ApiController]
//     public class ProductController : ControllerBase
//     {
//         private readonly apiContext _context;
//         public ProductController(apiContext context)
//         {
//             _context = context;
//         }

//         [HttpGet("")]
//         public ActionResult<IEnumerable<SubProduct>> GetProductss()
//         {
//             var result = _context.Products.Select(x => new SubProduct()
//             {
//                 Id = x.Id,
//                 Name = x.Name
//             })
//           .ToList();
//             return result;
//         }

//         [HttpGet("{id}")]
//         public ActionResult<Product> GetProductsById(int id)
//         {
//             return null;
//         }

//         [HttpPost("")]
//         public ActionResult<Product> PostProducts(Product model)
//         {
//             return null;
//         }

//         [HttpPut("{id}")]
//         public IActionResult PutProducts(int id, Product model)
//         {
//             return NoContent();
//         }

//         [HttpDelete("{id}")]
//         public ActionResult<Product> DeleteProductsById(int id)
//         {
//             return null;
//         }
//     }
// }