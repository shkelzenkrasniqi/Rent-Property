using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rent_Property.Models;

namespace Rent_Property.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ListingsController : ControllerBase
    {
        private readonly RentContext _context;

        public ListingsController(RentContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("GetListings")]
        public IActionResult GetListings()
        {
            List<Listing> list = _context.Listings.ToList();
            return StatusCode(StatusCodes.Status200OK, list);
        }
    }
}
