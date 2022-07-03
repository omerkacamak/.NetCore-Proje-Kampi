using System.Collections.Generic;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class AboutManager : IAboutService
    {
        IAboutDal _aboutDal;
        

        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public About GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<About> GetList()
        {
           return _aboutDal.GetListAll();
        }

        public void TAdd(About t)
        {
            throw new System.NotImplementedException();
        }

        public void TDelete(About t)
        {
            throw new System.NotImplementedException();
        }

        public void TUpdate(About t)
        {
            throw new System.NotImplementedException();
        }
    }
}