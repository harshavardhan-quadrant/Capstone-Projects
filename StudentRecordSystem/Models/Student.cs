namespace StudentRecordSystem.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Department { get; set; }
        public double Marks { get; set; }
        public Student()
        {
        }
        public Student(int id, string name, int age, string department, double marks)
        {
            Id = id;
            Name = name;
            Age = age;
            Department = department;
            Marks = marks;
        }
    }
}