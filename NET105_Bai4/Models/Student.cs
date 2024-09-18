namespace NET105_Bai4.Models
{
    public class Student
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public Guid ClassId { get; set; }
        public virtual Classes Class { get; set; }
    }
}
