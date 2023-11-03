using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Rent_Property.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Rent_Property.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly RentContext _context;

        public UsersController(RentContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("GetUsers")]
        public IActionResult GetUsers()
        {
            List<User> list = _context.Users.ToList();
            return StatusCode(StatusCodes.Status200OK, list);
        }
    }
}
