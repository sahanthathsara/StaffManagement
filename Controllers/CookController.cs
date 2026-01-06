using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StaffManagement.Data;

namespace StaffManagement.Controllers
{
    [ApiController]
    [Route("api/cook")]
    public class CookController : ControllerBase
    {
        private readonly AppDbContext _context;
        public CookController(AppDbContext context) { _context = context; }

        [Authorize(Roles = "Cook")]
        [HttpGet("tasks")]
        public IActionResult GetCookTasks(int cookId)
        {
            var tasks = _context.CookTasks.Where(t => t.AssignedCookId == cookId).ToList();
            return Ok(tasks);
            //jop
        }
    }
}
