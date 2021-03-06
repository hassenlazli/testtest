using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using apiProject.Models;

namespace apiProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WareHouseController : ControllerBase
    {

        private readonly palcdist_2020Context _Context;
        public WareHouseController(palcdist_2020Context context)
        {
            _Context = context;
        }

        [HttpGet("")]
        public ActionResult<IEnumerable<Object>> GetWarehouses()
        {
            var result = _Context.Trucks
             .Where(x => x.OidNavigation.Oid == x.Oid)
             .Select(x => new
             {
                 code = x.OidNavigation.Id,
                 name = x.OidNavigation.Name
             }).ToList();

            return result.ToList().Cast<Object>().ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<Warehouse> GetWarehouseById(int id)
        {
            return null;
        }

        [HttpPost("")]
        public ActionResult<Warehouse> PostWarehouse(Warehouse model)
        {
            return null;
        }

        [HttpPut("{id}")]
        public IActionResult PutWarehouse(int id, Warehouse model)
        {
            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult<Warehouse> DeleteWarehouseById(int id)
        {
            return null;
        }
    }
}