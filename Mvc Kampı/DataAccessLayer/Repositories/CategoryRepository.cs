using System.Collections.Generic;
using System.Linq;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;

namespace DataAccessLayer.Repositories
{
    public class CategoryRepository : ICategoryDal
    {
        Context c = new Context();

        public void Delete(Category t)
        {
            throw new System.NotImplementedException();
        }

        public Category GetByID(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<Category> GetListAll()
        {
            throw new System.NotImplementedException();
        }

        public void Insert(Category t)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Category t)
        {
            throw new System.NotImplementedException();
        }
    }
}