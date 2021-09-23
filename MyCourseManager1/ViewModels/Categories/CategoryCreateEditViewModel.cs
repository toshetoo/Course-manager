using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyCourseManager1.ViewModels.Categories
{
    public class CategoryCreateEditViewModel
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
    }
}
