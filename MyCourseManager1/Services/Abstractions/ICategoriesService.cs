using MyCourseManager1.ViewModels.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCourseManager1.Services.Abstractions
{
    public interface ICategoriesService
    {
        List<CategoryDetailsViewModel> GetAll();
        CategoryDetailsViewModel GetById(int id);
        void Insert(CategoryCreateEditViewModel model);
        void Update(CategoryCreateEditViewModel model);
        void Delete(int id);
    }
}
