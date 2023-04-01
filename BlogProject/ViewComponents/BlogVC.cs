using Business.Concrete;
using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace BlogProject.ViewComponents
{
    public class BlogVC : ViewComponent
    {

        BlogManager blogManager = new BlogManager(new EfBlogDal());

        public IViewComponentResult Invoke()
        {
            var value = blogManager.GetList();
            return View(value);
        }
    }
}
