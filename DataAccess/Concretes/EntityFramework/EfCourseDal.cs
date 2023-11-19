using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstracts;
using Entities.Concretes;
using Entities.Concretes.DTOs;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfCourseDal : EfEntityRepositoryBase<Course, TobetoContext>, ICourseDal
    {
        public List<CourseDetailDto> GetCourseDetail()
        {
            using (TobetoContext context = new TobetoContext())
            {
                var result = from c in context.Courses
                             join cat in context.Categories
                             on c.CategoryId equals cat.Id
                             select new CourseDetailDto
                             {
                                 CategoryName = cat.Name,
                                 CourseName = c.Name,
                                 CourseId = c.Id,
                                 Description = c.Description,
                             };
                return result.ToList();
            }
        }
    }
}
