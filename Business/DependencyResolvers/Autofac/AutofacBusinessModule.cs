using Autofac;
using Business.Abstracts;
using Business.Concretes;
using DataAccess.Abstracts;
using DataAccess.Concretes.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CourseManager>().As<ICourseService>().SingleInstance();
            builder.RegisterType<CategoryManager>().As<ICategoryService>().SingleInstance();
            builder.RegisterType<InstructorManager>().As<IInstructorService>().SingleInstance();
            builder.RegisterType<CourseInstructorManager>().As<ICourseInstructorService>().SingleInstance();

            builder.RegisterType<EfCourseDal>().As<ICourseDal>().SingleInstance();
            builder.RegisterType<EfCategoryDal>().As<ICategoryDal>().SingleInstance();
            builder.RegisterType<EfInstructorDal>().As<IInstructorDal>().SingleInstance();
            builder.RegisterType<EfCourseInstructorDal>().As<ICourseInstructorDal>().SingleInstance();

        }
    }
}
//builder.Services.AddSingleton<ICourseService, CourseManager>();
//builder.Services.AddSingleton<ICourseDal, EfCourseDal>();

//builder.Services.AddSingleton<ICategoryService, CategoryManager>();
//builder.Services.AddSingleton<ICategoryDal, EfCategoryDal>();

//builder.Services.AddSingleton<IInstructorService, InstructorManager>();
//builder.Services.AddSingleton<IInstructorDal, EfInstructorDal>();

//builder.Services.AddSingleton<ICourseInstructorService, CourseInstructorManager>();
//builder.Services.AddSingleton<ICourseInstructorDal, EfCourseInstructorDal>();