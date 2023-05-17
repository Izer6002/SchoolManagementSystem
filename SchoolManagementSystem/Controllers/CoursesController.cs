using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SchoolManagementSystem.Context;

namespace SchoolManagementSystem.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CoursesController : ControllerBase
    {
        private readonly SchoolManagementSystemDbContext _dbContext;

        public CoursesController(SchoolManagementSystemDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult GetCourses()
        {
            var courses = _dbContext.Courses.Include(c => c.Teacher).ToList();
            return Ok(courses);
        }

        [HttpPost("{courseId}/assign-teacher")]
        public IActionResult AssignTeacherToCourse(int courseId, [FromBody] int teacherId)
        {
            var course = _dbContext.Courses.Find(courseId);
            if (course == null)
            {
                return NotFound();
            }

            var teacher = _dbContext.Teachers.Find(teacherId);
            if (teacher == null)
            {
                return NotFound();
            }

            course.TeacherId = teacherId;
            _dbContext.SaveChanges();

            return Ok(course);
        }
    }
}
