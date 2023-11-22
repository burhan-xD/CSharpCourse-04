using Business.Abstracts;
using DataAccess.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstracts;
using Entities.Concretes;
using Entities.Concretes.DTOs;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using Business.Constants;
using System.ComponentModel.DataAnnotations;
using FluentValidation;
using Business.ValidationRules.FluentValidation;
using ValidationException = FluentValidation.ValidationException;
using Core.CrossCuttingConcerns.Validation;
using Core.Aspects.Autofac.Validation;


namespace Business.Concretes
{
    public class CourseManager : ICourseService
    {
        private ICourseDal _course;

        public CourseManager(ICourseDal course)
        {
            _course = course;
        }

        [ValidationAspect(typeof(CourseValidator))]
        public IResult Add(Course course)
        {
            //ValidationTool.Validate(new CourseValidator(), course);
            _course.Add(course);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(int id)
        {
            //var course = GetById(id).Data;
            _course.Delete(GetById(id).Data);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<Course>> GetAll()
        {
            if (DateTime.Now.Hour == 10)
            {
                return new ErrorDataResult<List<Course>>(Messages.Error);
            }
            return new SuccessDataResult<List<Course>>(_course.GetAll(), Messages.Listed);
        }

        public IDataResult<List<Course>> GetByCategoryId(int id)
        {
            return new SuccessDataResult<List<Course>>(_course.GetAll(p => p.CategoryId == id));
        }

        public IDataResult<Course> GetById(int id)
        {
            return new SuccessDataResult<Course>(_course.Get(p=>p.Id == id));
        }

        public IDataResult<List<Course>> GetByUnitPrice(int min, int max)
        {
            return new SuccessDataResult<List<Course>>(_course.GetAll(p => p.Price > min && p.Price < max));
        }

        public IDataResult<List<CourseDetailDto>> GetCourseDetail()
        {
            return new SuccessDataResult<List<CourseDetailDto>>(_course.GetCourseDetail());
        }

        public IResult Update(Course course)
        {
            _course.Update(course);
            return new SuccessResult(Messages.Updated);
        }
    }
}
