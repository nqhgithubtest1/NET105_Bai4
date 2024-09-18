using NET105_Bai4.Context;
using NET105_Bai4.Models;

namespace NET105_Bai4.Repositories
{
    public class StudentRepo : IStudentRepo
    {
        private readonly MyDbContext _context;

        public StudentRepo(MyDbContext context)
        {
            _context = context;
        }

        public List<Student> GetAll()
        {
            return _context.Students.ToList();
        }
    }
}
