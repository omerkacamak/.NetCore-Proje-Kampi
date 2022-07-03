using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class WriterManager : IWriterService
    {
        IWriterDal _writerdal;
        public WriterManager(IWriterDal writerDal)
        {
            _writerdal=writerDal;
            
        }
        public void WriterAdd(Writer writer)
        {
            _writerdal.Insert(writer);
        }
    }
}