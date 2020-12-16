using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using test.Models;

namespace test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VendorController : ControllerBase
    {
        private readonly palcdist_2020Context _context;
        public VendorController(palcdist_2020Context context)
        {
            _context = context;
        }

        [HttpGet("")]
        public ActionResult<IEnumerable<Object>> GetVendors()
        {
            var result = _context.Vendors
              .Where(x => x.Gcrecord == null)
              .Select(x => new
              {
                  matriculeEmploye = x.MatriculeEmployé,
                  fullName = x.FullName,
              }).ToList();
            return result.ToList().Cast<Object>().ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<Vendor> GetVendorById(int id)
        {
            return null;
        }

        [HttpPost("")]
        public ActionResult<Vendor> PostVendor(Vendor model)
        {
            return null;
        }

        [HttpPut("{id}")]
        public IActionResult PutVendor(int id, Vendor model)
        {
            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult<Vendor> DeleteVendorById(int id)
        {
            return null;
        }
    }
}
