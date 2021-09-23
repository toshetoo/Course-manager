using MyCourseManager1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCourseManager1.Repositories.Abstractions
{
    // Create Read Update Delete
    public interface ICategoriesRepository
    {
        void Insert(Category category);
        Category GetById(int id);
        List<Category> GetAll();
        void Update(Category category);
        void Delete(int id);
    }
}
