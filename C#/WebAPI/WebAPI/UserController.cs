using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI
{
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly DbHelper _db;
        public UserController(DataContext DataContext)
        {
            _db = new DbHelper(DataContext);
        }
        // GET: /<controller>/
        [HttpGet]
        [Route("api/users")]
        public IActionResult Get()
        {
            try
            {
                IEnumerable<UserModel> data = _db.GetUsers();
                if (!data.Any())
                {
                    return NotFound();
                }
                return Ok(data);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}

