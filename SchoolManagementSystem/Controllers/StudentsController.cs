using Microsoft.AspNetCore.Mvc;
using SchoolManagementSystem.Context;

namespace SchoolManagementSystem.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentsController : ControllerBase
    {
        private readonly SchoolManagementSystemDbContext _dbContext;

        public StudentsController(SchoolManagementSystemDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult GetStudents()
        {
            var students = _dbContext.Students.ToList();
            return Ok(students);
        }
    }
}
