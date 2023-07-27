﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProgrammersBlog.Entities.Concrete;
using ProgrammersBlog.Entities.Dtos;

namespace ProgrammersBlog.Mvc.Models
{
    public class ArticleDetailRightSideBarViewModel
    {
        public string Header { get; set; }
        public ArticleListDto ArticleListDto { get; set; }
        public User User { get; set; }
    }
}
