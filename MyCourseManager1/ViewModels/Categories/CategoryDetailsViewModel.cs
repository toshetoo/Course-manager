using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace MyCourseManager1.ViewModels.Categories
{
    public class CategoryDetailsViewModel
    {
        [DisplayName("Category ID: ")]
        public int Id { get; set; }
        public string Title { get; set; }
    }
}
