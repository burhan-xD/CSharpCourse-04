using Business.Abstracts;
using DataAccess.Concretes;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstracts;
using DataAccess.Concretes.EntityFramework;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using Business.Constants;

namespace Business.Concretes
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDal _categorydal;

        public CategoryManager(ICategoryDal categorydal)
        {
            _categorydal = categorydal;
        }

        public IResult Add(Category category)
        {
            _categorydal.Add(category);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(int id)
        {
            _categorydal.Delete(GetById(id).Data);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<Category>> GetAll()
        {
            return new SuccessDataResult<List<Category>>(_categorydal.GetAll());
        }

        public IDataResult<Category> GetById(int id)
        {
            return new SuccessDataResult<Category>(_categorydal.Get(c => c.Id == id));
        }

        public IResult Update(Category category)
        {
            return new SuccessResult(Messages.Updated);
        }
    }
}
