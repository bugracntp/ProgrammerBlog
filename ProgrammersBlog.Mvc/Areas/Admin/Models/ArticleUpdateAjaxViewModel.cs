using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProgrammersBlog.Entities.Dtos;

namespace ProgrammersBlog.Mvc.Areas.Admin.Models
{
    public class ArticleUpdateAjaxViewModel
    {
        public ArticleUpdateDto ArticleUpdateDto { get; set; }
        public string ArticleUpdatePartial { get; set; }
        public ArticleDto ArticleDto { get; set; }
    }
}
