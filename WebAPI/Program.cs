using Autofac;
using Autofac.Extensions.DependencyInjection;
using Business.Abstracts;
using Business.Concretes;
using Business.DependencyResolvers.Autofac;
using DataAccess.Abstracts;
using DataAccess.Concretes.EntityFramework;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
/* Default AOP
//builder.Services.AddSingleton<ICourseService, CourseManager>();
//builder.Services.AddSingleton<ICourseDal, EfCourseDal>();

//builder.Services.AddSingleton<ICategoryService, CategoryManager>();
//builder.Services.AddSingleton<ICategoryDal, EfCategoryDal>();

//builder.Services.AddSingleton<IInstructorService, InstructorManager>();
//builder.Services.AddSingleton<IInstructorDal, EfInstructorDal>();

//builder.Services.AddSingleton<ICourseInstructorService, CourseInstructorManager>();
//builder.Services.AddSingleton<ICourseInstructorDal, EfCourseInstructorDal>();
*/

//Autofac AOP
builder.Host.UseServiceProviderFactory(services => new AutofacServiceProviderFactory());
builder.Host.ConfigureContainer<ContainerBuilder>(builder => { builder.RegisterModule(new AutofacBusinessModule()); });

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
