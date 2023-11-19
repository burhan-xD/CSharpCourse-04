using Business.Abstracts;
using DataAccess.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstracts;
using Entities.Concretes;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using Business.Constants;

namespace Business.Concretes
{
    public class CourseInstructorManager : ICourseInstructorService
    {
        private ICourseInstructorDal _courseInstructorDal;

        public CourseInstructorManager(ICourseInstructorDal courseInstructorDal)
        {
            _courseInstructorDal = courseInstructorDal;
        }

        public IResult Add(CourseInstructor courseInstructor)
        {
            _courseInstructorDal.Add(courseInstructor);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(CourseInstructor courseInstructor)
        {
            _courseInstructorDal.Delete(courseInstructor);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<CourseInstructor>> GetAll()
        {
            return new SuccessDataResult<List<CourseInstructor>>(_courseInstructorDal.GetAll());    
        }

        public IDataResult<List<CourseInstructor>> GetByCourseId(int id)
        {
            return new SuccessDataResult<List<CourseInstructor>>(_courseInstructorDal.GetAll(p => p.CourseId == id));
        }

        public IDataResult<List<CourseInstructor>> GetByInstructorId(int id)
        {
            return new SuccessDataResult<List<CourseInstructor>>(_courseInstructorDal.GetAll(p => p.InstructorId == id));
        }

        public IResult Update(CourseInstructor courseInstructor)
        {
            _courseInstructorDal.Update(courseInstructor);
            return new SuccessResult(Messages.Updated);
        }
    }
}
