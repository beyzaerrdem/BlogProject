using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BlogManager : IBlogService
    {
        IBlogDal _blogDal;

        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }

        public Blog GetById(int id)
        {
            return _blogDal.GetById(id);
        }

        public List<Blog> GetList()
        {
            return _blogDal.GetAllList();
        }

        public void TAdd(Blog blog)
        {
            _blogDal.Add(blog);
        }

        public void TDelete(Blog blog)
        {
            _blogDal.Delete(blog);
        }

        public void TUpdate(Blog blog)
        {
            _blogDal.Update(blog);
        }
    }
}
