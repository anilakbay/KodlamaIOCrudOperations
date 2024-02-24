using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class InstructorManager : IInstructorService
    {
        private readonly IInstructorDal _instructorDal;
        
        public InstructorManager(IInstructorDal instructorDal)
        {
            _instructorDal = instructorDal;
        }
        public void TAdd(Instructor entity)
        {
            _instructorDal.Add(entity);
        }

        public void TDelete(int id)
        {
           _instructorDal.Delete(id);
        }

        public List<Instructor> TGetAll()
        {
            return _instructorDal.GetAll();
        }
       
        public Instructor TGetById(int id)
        {
           return _instructorDal.GetById(id);
        }

        public void TUpdate(Instructor entity)
        {
            _instructorDal.Update(entity);
        }
    }
}
