namespace NET105_Bai4.Models
{
    public class Classes
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}
