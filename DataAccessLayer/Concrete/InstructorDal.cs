using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class InstructorDal : IInstructorDal
    {
        private List<Instructor> _instructors;

        public InstructorDal()
        {
            _instructors = new List<Instructor>
            {
                new Instructor { Id = 1, FirstName = "Engin", LastName = "Demiroğ" },
                new Instructor { Id = 2, FirstName = "Halit Enes", LastName = "Kalaycı" },
            };
        }

        public void Add(Instructor entity)
        {
            _instructors.Add(entity);
            Console.WriteLine("Başarıyla Eklendi");
        }

        public void Delete(int id)
        {
            _instructors.Remove(_instructors.SingleOrDefault(c => c.Id == id));
            Console.WriteLine("Başarıyla Silindi");
        }

        public List<Instructor> GetAll()
        {
            foreach (var x in _instructors)
            {
                Console.WriteLine("Eğitmen --> " + x.FirstName + " " + x.LastName);
            }
            return _instructors;
        }
       

        public Instructor GetById(int id)
        {
            var result = _instructors.Find(x => x.Id == id);
            return result;
        }

        public void Update(Instructor entity)
        {
            var found = _instructors.FirstOrDefault(x => x.Id == entity.Id);
            if (found != null)
            {
                found.FirstName = entity.FirstName;
                found.LastName = entity.LastName;
                Console.WriteLine("Başarıyla güncellendi.");
            }
            else
            {
                Console.WriteLine("Başarısız işlem.");
            }
        }
    }
}
