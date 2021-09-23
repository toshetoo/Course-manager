using Microsoft.EntityFrameworkCore;
using MyCourseManager1.Models;
using MyCourseManager1.Repositories.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCourseManager1.Repositories.Implementations
{
    public class CategoriesRepository : ICategoriesRepository
    {
        private readonly MyCourseManagerDbContext context;
        private readonly DbSet<Category> dbSet;

        public CategoriesRepository(MyCourseManagerDbContext dbContext)
        {
            this.context = dbContext;
            this.dbSet = this.context.Set<Category>();
        }

        public List<Category> GetAll()
        {
            return this.dbSet.ToList();
        }

        public Category GetById(int id)
        {
            return this.dbSet.Find(id);
        }

        public void Insert(Category category)
        {
            this.dbSet.Add(category);
            this.context.SaveChanges();
        }

        public void Update(Category category)
        {
            Category item = this.GetById(category.Id);

            if (item != null)
            {
                this.context.Entry(item).State = EntityState.Detached;
            }

            this.context.Entry(category).State = EntityState.Modified;
            this.context.SaveChanges();
        }

        public void Delete(int id)
        {
            this.dbSet.Remove(GetById(id));
            this.context.SaveChanges();
        }
    }
}
