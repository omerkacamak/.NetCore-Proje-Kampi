using System.Collections.Generic;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{ 
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;
    


          public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal=categoryDal;
        }
        

        public Category GetById(int id)
        {
             return _categoryDal.GetByID(id);
        }

        public List<Category> GetList()
        {
            return _categoryDal.GetListAll();
        }

        

        public List<Category> GetListWithBlogs()
        {
            return _categoryDal.GetListByBlogs();
        }

        public void TAdd(Category t)
        {
            _categoryDal.Insert(t);
        }

        public void TDelete(Category t)
        {
            _categoryDal.Delete(t);
        }

        public void TUpdate(Category t)
        {
             _categoryDal.Update(t);
        }

        
    }
}