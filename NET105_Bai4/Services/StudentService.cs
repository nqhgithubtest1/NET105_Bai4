using NET105_Bai4.Models;
using NET105_Bai4.Repositories;

namespace NET105_Bai4.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepo _studentRepo;
        public StudentService(IStudentRepo studentRepo)
        {
            _studentRepo = studentRepo;
        }

        public List<Student> GetAll()
        {
            return _studentRepo.GetAll();
        }
    }
}
