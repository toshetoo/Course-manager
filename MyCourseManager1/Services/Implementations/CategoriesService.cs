using MyCourseManager1.Models;
using MyCourseManager1.Repositories.Abstractions;
using MyCourseManager1.Services.Abstractions;
using MyCourseManager1.ViewModels.Categories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyCourseManager1.Services.Implementations
{
    public class CategoriesService : ICategoriesService
    {

        private readonly ICategoriesRepository repo;

        public CategoriesService(ICategoriesRepository repo)
        {
            this.repo = repo;
        }

        public List<CategoryDetailsViewModel> GetAll()
        {
            return this.repo.GetAll().Select(category => new CategoryDetailsViewModel
            {
                Id = category.Id,
                Title = category.Title
            }).ToList();
        }

        public CategoryDetailsViewModel GetById(int id)
        {
            Category category = this.repo.GetById(id);

            if (category == null)
            {
                return null;
            }

            CategoryDetailsViewModel model = new CategoryDetailsViewModel()
            {
                Id = category.Id,
                Title = category.Title
            };

            return model;
        }

        public void Insert(CategoryCreateEditViewModel model)
        {
            var item = new Category()
            {
                Title = model.Title
            };

            this.repo.Insert(item);
        }

        public void Update(CategoryCreateEditViewModel model)
        {
            var category = new Category()
            {
                Id = model.Id,
                Title = model.Title
            };

            this.repo.Update(category);
        }

        public void Delete(int id)
        {
            this.repo.Delete(id);
        }
    }
}
