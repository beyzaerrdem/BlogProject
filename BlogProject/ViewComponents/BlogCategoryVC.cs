using Business.Concrete;
using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace BlogProject.ViewComponents
{
    public class BlogCategoryVC : ViewComponent
    {
        BlogCategoryManager blogCategoryManager = new BlogCategoryManager(new EfBlogCategoryDal());

        public IViewComponentResult Invoke()
        {
            var values = blogCategoryManager.GetList();
            return View(values);
        }
    }
}
