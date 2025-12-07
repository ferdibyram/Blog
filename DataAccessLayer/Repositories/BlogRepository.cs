using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntitiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    internal class BlogRepository : IBlogDal
    {
        Context c = new Context();
        public void AddCategory(Blog blog)
        {
            c.Add(blog);
            c.SaveChanges();
        }

        public void DeleteCategory(Blog blog)
        {
            c.Remove(blog);
            c.SaveChanges();
        }

        public Blog GetById(int id)
        {
            return c.Blogs.Find(id);
        }

        public List<Blog> ListAllBlog()
        {
            return c.Blogs.ToList();
        }

        public void UpdateCategory(Blog blog)
        {
            c.Update(blog);
            c.SaveChanges();
        }
    }
}
