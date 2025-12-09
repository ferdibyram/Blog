using BusinessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntitiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        EfCategoryRepository cR;

        public CategoryManager()
        {
            cR = new EfCategoryRepository();
        }
        public void CategoryUpdate(Category category)
        {
            cR.Update(category);
        }

        public void CateoryAdd(Category category)
        {
            cR.Insert(category);
        }

        public void CateoryDelete(Category category)
        {
            cR.Delete(category);
        }

        public Category GetById(int id)
        {
            return cR.GetById(id);
        }

        public List<Category> GetList()
        {
            return cR.GetListAll();
        }
    }
}
