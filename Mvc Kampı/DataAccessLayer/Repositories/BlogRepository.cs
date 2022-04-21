using System.Collections.Generic;
using System.Linq;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;

namespace DataAccessLayer.Repositories
{
    public class BlogRepository : IBlogDal
    {
        public void Delete(Blog t)
        {
            throw new System.NotImplementedException();
        }

        public Blog GetByID(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<Blog> GetListAll()
        {
            throw new System.NotImplementedException();
        }

        public void Insert(Blog t)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Blog t)
        {
            throw new System.NotImplementedException();
        }
    }
}