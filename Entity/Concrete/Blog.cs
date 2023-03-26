using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Blog
    {
        [Key]
        public int BlogId { get; set; }

        public string BlogName { get; set; }
        
        public string BlogDescription { get; set;}

        public bool BlogStatus { get; set; }

        public int BlogCategoryId { get; set; }

        public BlogCategory BlogCategory { get; set; }

        

    }
}
