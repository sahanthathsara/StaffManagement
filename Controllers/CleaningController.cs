using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StaffManagement.Data;

namespace StaffManagement.Controllers
{
    [ApiController]
    [Route("api/cleaning")]
    public class CleaningController : ControllerBase
    {
        private readonly AppDbContext _context;
        public CleaningController(AppDbContext context) { _context = context; }

        [Authorize(Roles = "Cleaning")]
        [HttpGet("tasks")]
        public IActionResult GetCleaningTasks(int staffId)
        {
            var tasks = _context.CleaningTasks.Where(t => t.AssignedStaffId == staffId).ToList();
            return Ok(tasks);
        }
    }
}

