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
    public class BlogCategoryManager : IBlogCategoryService
    {
        IBlogCategoryDal _blogCategoryDal;

        public BlogCategoryManager(IBlogCategoryDal blogCategoryDal)
        {
            _blogCategoryDal = blogCategoryDal;
        }

        public BlogCategory GetById(int id)
        {
            return _blogCategoryDal.GetById(id);
        }

        public List<BlogCategory> GetList()
        {
            return _blogCategoryDal.GetAllList();
        }

        public void TAdd(BlogCategory blogCategory)
        {
            _blogCategoryDal.Add(blogCategory);
        }

        public void TDelete(BlogCategory blogCategory)
        {
            _blogCategoryDal.Delete(blogCategory);
        }

        public void TUpdate(BlogCategory blogCategory)
        {
            _blogCategoryDal.Update(blogCategory);
        }
    }
}
