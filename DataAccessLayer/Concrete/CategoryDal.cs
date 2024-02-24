using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class CategoryDal : ICategoryDal
    {
        private List<Category> _categories;

        public CategoryDal()
        {
            _categories = new List<Category>
            {
                new Category { Id = 1, Name = "Back end Development" },
                new Category { Id = 2, Name = "Front end Development" },
                new Category { Id = 3, Name = "Fullstack Development" }
            };
        }

        public void Add(Category entity)
        {
           _categories.Add(entity);
            Console.WriteLine(entity.Name + "Kategorisi Başarıyla Eklendi");
        }

        public void Delete(int id)
        {
            _categories.Remove(_categories.SingleOrDefault(c => c.Id == id));
            Console.WriteLine("Kategori Başarıyla Silindi");
        }

        public List<Category> GetAll()
        {
            foreach (var x in _categories)
            {
                Console.WriteLine(x.Name);
            }
            return _categories;
        }

        public Category GetById(int id)
        {
            var result = _categories.Find(x => x.Id == id);
            return result;
        }

        public void Update(Category entity)
        {
            var updatedCategory = _categories.FirstOrDefault(x => x.Id == entity.Id);

            updatedCategory.Name = entity.Name;

            Console.WriteLine("Başarıyla güncellendi.");          

        }
    }
}
