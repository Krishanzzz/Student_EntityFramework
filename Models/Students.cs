namespace EntityFramework.Models
{
    public class Students
    {
        public int Id { get; set; }
        public string studentName { get; set; }
        public string Department { get; set; }

        public Students() { }

        public Students(int id, string name, string dept)
        {
            Id = id;
            studentName = name;
            Department = dept;
        }
    }
}
