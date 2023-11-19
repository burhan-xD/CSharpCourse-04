using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Entities.Concretes;
using Business.Abstracts;
using Business.Concretes;
using DataAccess.Concretes.EntityFramework;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        ICourseService _courseService;

        public CoursesController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            //ICourseService courseService = new CourseManager(new EfCourseDal());
            var result = _courseService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _courseService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("geybycat")]
        public IActionResult GetByCat(int id) 
        { 
            var result = _courseService.GetByCategoryId(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpPost("addcourse")]
        public IActionResult AddCourse(Course course)
        {
            var result = _courseService.Add(course);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }




        //[HttpGet]
        //public List<Course> Get()
        //{
        //    //ICourseService courseService = new CourseManager(new EfCourseDal());
        //    var result = _courseService.GetAll();
        //    return result.Data;
        //}
    }   
}
