
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;

CategoryManager categoryManager = new CategoryManager(new CategoryDal());
CourseManager courseManager = new CourseManager(new CourseDal());
InstructorManager instructorManager = new InstructorManager(new InstructorDal());

categoryManager.TAdd(new Category { Id = 5, Name = "SQL Veri Tabanı" });
Console.WriteLine("Bulunan :" + categoryManager.TGetById(1).Name);
categoryManager.TUpdate(new Category { Id = 1, Name = "Masaüstü Programlama" });
categoryManager.TDelete(1);
categoryManager.TGetAll();

Console.WriteLine("**************************************************************************************");

courseManager.TAdd(new Course { Id = 8, CourseName = "React Dersleri", Description = "React ile Frontend", Price = 50, CategoryId = 5, InstructorId = 1 });
Console.WriteLine("Bulunan : " + courseManager.TGetById(1).CourseName);
courseManager.TUpdate(new Course { Id = 3, CourseName = "HTML & CSS & Javascript", Description = "Site yapımı", Price = 20, CategoryId = 3, InstructorId = 2 });
courseManager.TDelete(2);
courseManager.TGetAll();

Console.WriteLine("**************************************************************************************");

instructorManager.TAdd(new Instructor { Id = 5, FirstName = "Murat", LastName = "Yücedağ" });
Console.WriteLine("Bulunan : " + instructorManager.TGetById(2).FirstName);
instructorManager.TUpdate(new Instructor { Id = 5, FirstName = "Yavuz Selim", LastName = "Kahraman" });
instructorManager.TDelete(1);
instructorManager.TGetAll();

Console.ReadLine();