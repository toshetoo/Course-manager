using Microsoft.AspNetCore.Mvc;
using MyCourseManager1.Services.Abstractions;
using MyCourseManager1.ViewModels.Categories;

namespace MyCourseManager1.Controllers
{
    public class CategoriesController : Controller
    {
        private ICategoriesService service;

        public CategoriesController(ICategoriesService service)
        {
            this.service = service;
        }

        public IActionResult List()
        {
            return View(service.GetAll());
        }

        public IActionResult Details(int id)
        {
            var model = this.service.GetById(id);
            return View(model);
        }

        public IActionResult Edit(int? id)
        {
            if (!id.HasValue)
            {
                return View(new CategoryCreateEditViewModel());
            }

            var model = this.service.GetById(id.Value);

            if (model == null)
            {
                return RedirectToAction("List");
            }

            return View(new CategoryCreateEditViewModel() 
            { 
                Id = model.Id,
                Title = model.Title
            });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(CategoryCreateEditViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            if (model.Id == 0)
            {
                this.service.Insert(model);
            }
            else
            {
                this.service.Update(model);
            }

            return RedirectToAction("List");
        }

        public IActionResult Delete(int id)
        {
            this.service.Delete(id);
            return RedirectToAction("List");
        }
    }
}
