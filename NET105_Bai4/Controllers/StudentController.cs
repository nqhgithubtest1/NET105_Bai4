using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NET105_Bai4.Context;
using NET105_Bai4.Models;
using NET105_Bai4.Services;

namespace NET105_Bai4.Controllers
{
    public class StudentController : Controller
    {
        private readonly MyDbContext _context;
        private readonly IStudentService _studentService;

        public StudentController(MyDbContext context, IStudentService studentService)
        {
            _context = context;
            _studentService = studentService;
        }

        public IActionResult Index()
        {
            var listStudents = _studentService.GetAll();
            return View();
        }

        public IActionResult InsertSingle()
        {
            var student = new Student()
            {
                Id = Guid.NewGuid(),
                Name = "Single Student",
                Address = "Hanoi"
            };

            _context.Students.Add(student);
            _context.SaveChanges();

            return Content("DONE");
        }

        public IActionResult InsertMultiple()
        {
            var listStudents = new List<Student>();
            var student1 = new Student()
            {
                Id = Guid.NewGuid(),
                Name = "Multiple Student 1",
                Address = "Hanoi"
            };

            var student2 = new Student()
            {
                Id = Guid.NewGuid(),
                Name = "Multiple Student 2",
                Address = "Hanoi"
            };

            var student3 = new Student()
            {
                Id = Guid.NewGuid(),
                Name = "Multiple Student 3",
                Address = "Hanoi"
            };

            listStudents.Add(student1);
            listStudents.Add(student2);
            listStudents.Add(student3);

            _context.Students.AddRange(listStudents);
            _context.SaveChanges();

            return Content("DONE");
        }

        public IActionResult GetStudentInfo(Guid id)
        {
            //eager loading
            //var student = _context.Students.Where(s => s.Id == id).Include(s => s.Class).FirstOrDefault();

            //lazy loading
            var student = _context.Students.Where(s => s.Id == id).FirstOrDefault();
            var c = student.Class;
            return View();
        }
    }
}
