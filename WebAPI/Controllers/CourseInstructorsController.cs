using Business.Abstracts;
using DataAccess.Abstracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseInstructorsController : ControllerBase
    {
        ICourseInstructorService _courseInstructorDal;

        public CourseInstructorsController(ICourseInstructorService courseInstructorDal)
        {
            _courseInstructorDal = courseInstructorDal;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _courseInstructorDal.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
