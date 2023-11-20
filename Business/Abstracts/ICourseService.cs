using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results.Abstract;
using Entities.Concretes;
using Entities.Concretes.DTOs;

namespace Business.Abstracts
{
    public interface ICourseService
    {
        IDataResult<List<Course>> GetAll();
        IDataResult<List<Course>> GetByUnitPrice (int min, int max);
        IDataResult<List<Course>> GetByCategoryId(int id);
        IDataResult<Course> GetById(int id);
        IResult Add(Course course);
        IResult Update(Course course);
        //IResult Delete(Course course);
        IResult Delete(int id);

        IDataResult<List<CourseDetailDto>> GetCourseDetail();
        
    }
}
