using Core.Utilities.Results.Abstract;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface ICourseInstructorService
    {
        IDataResult<List<CourseInstructor>> GetAll();
        IDataResult<List<CourseInstructor>> GetByCourseId(int id);
        IDataResult<List<CourseInstructor>> GetByInstructorId(int id);
        IResult Add(CourseInstructor courseInstructor);
        IResult Update(CourseInstructor courseInstructor);
        IResult Delete(CourseInstructor courseInstructor);
    }
}
