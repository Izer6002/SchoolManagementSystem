using Microsoft.AspNetCore.Mvc;
using SchoolManagementSystem.Context;
using SchoolManagementSystem.Models;

namespace SchoolManagementSystem.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EnrollmentsController : ControllerBase
    {
        private readonly SchoolManagementSystemDbContext _dbContext;

        public EnrollmentsController(SchoolManagementSystemDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpPost]
        public IActionResult EnrollStudentInCourse([FromBody] Enrollment enrollment)
        {
            _dbContext.Enrollments.Add(enrollment);
            _dbContext.SaveChanges();

            return Ok(enrollment);
        }
    }
}
