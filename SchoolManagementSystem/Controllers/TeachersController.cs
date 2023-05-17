using Microsoft.AspNetCore.Mvc;
using SchoolManagementSystem.Context;

namespace SchoolManagementSystem.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TeachersController : ControllerBase
    {
        private readonly SchoolManagementSystemDbContext _dbContext;

        public TeachersController(SchoolManagementSystemDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult GetTeachers()
        {
            var teachers = _dbContext.Teachers.ToList();
            return Ok(teachers);
        }
    }
}
