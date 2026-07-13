using StudentRecordSystem.Helpers;
using StudentRecordSystem.Interfaces;
using StudentRecordSystem.Models;
namespace StudentRecordSystem.Services
{
    public class StudentService : IStudentService
    {
        private List<Student> students = new List<Student>();
        public void AddStudent()
        {
            int id = ValidationHelper.ReadInt("Enter Id : ");
            if (students.Any(x => x.Id == id))
            {
                Console.WriteLine("Student already exists.");
                return;
            }
            string name = ValidationHelper.ReadString("Enter Name : ");
            int age = ValidationHelper.ReadInt("Enter Age : ");
            string department = ValidationHelper.ReadString("Enter Department : ");
            double marks = ValidationHelper.ReadDouble("Enter Marks : ");
            students.Add(new Student(id, name, age, department, marks));
            Console.WriteLine("Student Added Successfully.");
        }
        public void ViewStudents()
        {
            if (!students.Any())
            {
                Console.WriteLine("No Students Available.");
                return;
            }
            foreach (Student student in students)
            {
                Console.WriteLine("--------------------------------");
                Console.WriteLine($"Id : {student.Id}");
                Console.WriteLine($"Name : {student.Name}");
                Console.WriteLine($"Age : {student.Age}");
                Console.WriteLine($"Department : {student.Department}");
                Console.WriteLine($"Marks : {student.Marks}");
            }
        }
        public void SearchStudent()
        {
            int id = ValidationHelper.ReadInt("Enter Student Id : ");
            Student student = students.FirstOrDefault(x => x.Id == id);
            if (student == null)
            {
                Console.WriteLine("Student Not Found.");
                return;
            }
            Console.WriteLine(student.Name);
            Console.WriteLine(student.Department);
            Console.WriteLine(student.Marks);
        }
        public void UpdateStudent()
        {
            int id = ValidationHelper.ReadInt("Enter Student Id : ");
            Student student = students.FirstOrDefault(x => x.Id == id);
            if (student == null)
            {
                Console.WriteLine("Student Not Found.");
                return;
            }
            student.Name = ValidationHelper.ReadString("New Name : ");
            student.Age = ValidationHelper.ReadInt("New Age : ");
            student.Department = ValidationHelper.ReadString("New Department : ");
            student.Marks = ValidationHelper.ReadDouble("New Marks : ");
            Console.WriteLine("Updated Successfully.");
        }
        public void DeleteStudent()
        {
            int id = ValidationHelper.ReadInt("Enter Student Id : ");
            Student student = students.FirstOrDefault(x => x.Id == id);
            if (student == null)
            {
                Console.WriteLine("Student Not Found.");
                return;
            }
            students.Remove(student);
            Console.WriteLine("Deleted Successfully.");
        }
        public void SortStudents()
        {
            var result = students.OrderByDescending(x => x.Marks);
            foreach (Student student in result)
            {
                Console.WriteLine($"{student.Name} - {student.Marks}");
            }
        }
        public void ShowTopper()
        {
            Student topper = students.OrderByDescending(x => x.Marks).FirstOrDefault();
            if (topper == null)
            {
                Console.WriteLine("No Students.");
                return;
            }
            Console.WriteLine($"{topper.Name} : {topper.Marks}");
        }
        public void DepartmentWiseStudents()
        {
            string department = ValidationHelper.ReadString("Department : ");
            var result = students.Where(x => x.Department.Equals(department, StringComparison.OrdinalIgnoreCase));
            foreach (Student student in result)
            {
                Console.WriteLine($"{student.Name} - {student.Marks}");
            }
        }
    }
}