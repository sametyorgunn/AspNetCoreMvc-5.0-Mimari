using BusinessLayer.Abstract;
using DataAccesLayer.EntityFramework;
using DataAccesLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        EfCategoryRepository efCategoriyRepository;

        public CategoryManager()
        {
            efCategoriyRepository = new EfCategoryRepository();
        }
        public void CategoryAdd(Category category)
        {
            efCategoriyRepository.Insert(category);
        }

        public void CategoryDelete(Category category)
        {
            efCategoriyRepository.Delete(category);
        }

        public void CategoryUpdate(Category category)
        {
            efCategoriyRepository.Update(category);
        }

        public Category GetById(int id)
        {
           return efCategoriyRepository.GetById(id);
        }

        public List<Category> GetList()
        {
           return efCategoriyRepository.GetListAll();
        }
    }
}
