using System.Collections.Generic;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class BlogManager : IBlogService
    {
        IBlogDal _blogDal;
        public BlogManager(IBlogDal blogDal)
        {
            _blogDal=blogDal; 
        }
        

        public List<Blog> GetBlogListWithCategory()
        {
            return _blogDal.GetListWithCategory();
        }
        public List<Blog> GetListWithCategoryByWriterBm(int id)
        {
            return _blogDal.GetListWithCategoryByWriter(id);
        }

        public Blog GetById(int id)
        {
            return _blogDal.GetByID(id);
        }

       public  List<Blog> GetBlogByID(int id)
       {
           return _blogDal.GetListAll(x=>x.BlogID==id);
       }
        public List<Blog> GetList()
        {
            return _blogDal.GetListAll();
        }

        public List<Blog> GetBlogListByWriter(int id)
        {
           return _blogDal.GetListAll(x=>x.WriterID==id);
        }

        public void TAdd(Blog t)
        {
            _blogDal.Insert(t);
        }

        public void TDelete(Blog t)
        {
            throw new System.NotImplementedException();
        }

        public void TUpdate(Blog t)
        {
           _blogDal.Update(t);
        }
    }
}