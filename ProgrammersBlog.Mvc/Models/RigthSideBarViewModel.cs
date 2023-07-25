using System.Collections;
using System.Collections.Generic;
using ProgrammersBlog.Entities.Concrete;

namespace ProgrammersBlog.Mvc.Models
{
    public class RigthSideBarViewModel
    {
        public IList<Category> Categories { get; set; }
        public IList<Article> Articles { get; set; }

    }
}
