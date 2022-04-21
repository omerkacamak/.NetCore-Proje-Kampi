using System.Collections.Generic;
using BusinessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        EfCategoryRepository efCategoryRepository;
        public CategoryManager()
        {
            efCategoryRepository = new EfCategoryRepository();
        }
        public void CategoryAdd(Category category)
        {
            efCategoryRepository.Insert(category); 
                 
        }

        public void CategoryDelete(Category category)
        {
            throw new System.NotImplementedException();
        }

        public void CategoryUpdate(Category category)
        {
            throw new System.NotImplementedException();
        }

        public Category GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<Category> GetList()
        {
            throw new System.NotImplementedException();
        }
    }
}