using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class CourseDal : ICourseDal
    {
        private List<Course> _courses;

        public CourseDal()
        {
            _courses = new List<Course>
            {
                new Course { Id = 1, CourseName = "Asp.Net", Description = "Web Geliştirme", Price = 10, CategoryId = 1, InstructorId = 1 },
                new Course { Id = 2, CourseName = "Kotlin", Description = "Mobil Geliştirme", Price = 20, CategoryId = 2, InstructorId = 2 },
                new Course { Id = 3, CourseName = "HTML & CSS", Description = "Front end Geliştirme", Price = 30, CategoryId = 3, InstructorId = 3 }
            };
        }

        public void Add(Course entity)
        {
            _courses.Add(entity);
            Console.WriteLine("Başarıyla Eklendi");
        }

        public void Delete(int id)
        {
            _courses.Remove(_courses.SingleOrDefault(c => c.Id == id));
            Console.WriteLine("Başarıyla Silindi");
        }

        public List<Course> GetAll()
        {
            foreach (var x in _courses)
            {
                Console.WriteLine("Kurs = " + x.CourseName + " / " + x.Description + " / " + x.Price);
            }
            return _courses;
        }              

        public Course GetById(int id)
        {
            var result = _courses.Find(x => x.Id == id);
            return result;
        }

        public void Update(Course entity)
        {
            var found = _courses.FirstOrDefault(x => x.Id == entity.Id);
            if (found != null)
            {
                found.CourseName = entity.CourseName;
                found.Description = entity.Description;
                found.Price = entity.Price;
                found.CategoryId = entity.CategoryId;
                found.InstructorId = entity.InstructorId;
                Console.WriteLine("Başarıyla güncellendi.");
            }
            else
            {
                Console.WriteLine("Başarısız işlem.");
            }
        }
    }
}
