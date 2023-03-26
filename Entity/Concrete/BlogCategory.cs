using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class BlogCategory
    {
        [Key]
        public int BlogCategoryId { get; set; }

        public string CategoryName { get; set; }

        public string CategoryDescription { get; set; }

        public bool CategoryStatus { get; set; }

        ICollection<Blog> Blogs { get; set; }
    }
}
