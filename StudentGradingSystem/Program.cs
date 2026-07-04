// using System;
// using System.Collections.Generic;
// using System.Linq;
// Data Storage
List<Student> students = new();
int nextId = 1001;
while (true)
{
    Console.Clear();
    Console.WriteLine("====================================");
    Console.WriteLine("   STUDENT GRADING SYSTEM");
    Console.WriteLine("====================================");
    Console.WriteLine("1. Add Student");
    Console.WriteLine("2. View Students");
    Console.WriteLine("3. Search Student");
    Console.WriteLine("4. Update Student");
    Console.WriteLine("5. Delete Student");
    Console.WriteLine("6. Display Rank List");
    Console.WriteLine("7. Exit");
    Console.Write("\nEnter Choice : ");
    if (!int.TryParse(Console.ReadLine(), out int choice))
    {
        Console.WriteLine("Invalid Input");
        Pause();
        continue;
    }
    switch (choice)
    {
        case 1:
            AddStudent();
            break;
        case 2:
            ViewStudents();
            break;
        case 3:
            SearchStudent();
            break;
        case 4:
            UpdateStudent();
            break;
        case 5:
            DeleteStudent();
            break;
        case 6:
            DisplayRanks();
            break;
        case 7:
            Console.WriteLine("Thank You!");
            return;
        default:
            Console.WriteLine("Invalid Choice");
            Pause();
            break;
    }
}
void AddStudent()
{
    Console.Clear();
    Student student = new Student();
    student.StudentId = nextId++;
    Console.Write("Enter Student Name : ");
    student.Name = Console.ReadLine()!;
    // Subject Names
    string[] subjects =
    {
        "English",
        "Mathematics",
        "Science",
        "Social",
        "Computer"
    };
    for (int i = 0; i < subjects.Length; i++)
    {
        while (true)
        {
            Console.Write($"Enter {subjects[i]} Marks : ");
            if (int.TryParse(Console.ReadLine(), out int mark) &&
                mark >= 0 &&
                mark <= 100)
            {
                student.Marks.Add(mark);
                break;
            }
            Console.WriteLine("Marks should be between 0 and 100.");
        }
    }
    CalculateResult(student);
    students.Add(student);
    Console.WriteLine("\nStudent Added Successfully.");
    Pause();
}
void CalculateResult(Student student)
{
    student.Total = student.Marks.Sum();
    student.Average = student.Total / 5.0;
    bool pass = true;
    foreach (int mark in student.Marks)
    {
        if (mark < 35)
        {
            pass = false;
            break;
        }
    }
    student.Result = pass ? "PASS" : "FAIL";
    if (student.Average >= 90)
        student.Grade = "A+";
    else if (student.Average >= 80)
        student.Grade = "A";
    else if (student.Average >= 70)
        student.Grade = "B";
    else if (student.Average >= 60)
        student.Grade = "C";
    else if (student.Average >= 50)
        student.Grade = "D";
    else
        student.Grade = "F";
}
void ViewStudents()
{
    Console.Clear();
    if (students.Count == 0)
    {
        Console.WriteLine("No Student Records Found.");
        Pause();
        return;
    }
    Console.WriteLine("-------------------------------------------------------------------------------------------");
    Console.WriteLine("ID\tName\t\tTotal\tAverage\tGrade\tResult");
    Console.WriteLine("-------------------------------------------------------------------------------------------");
    foreach (var s in students)
    {
        Console.WriteLine($"{s.StudentId}\t{s.Name,-15}{s.Total}\t{s.Average:F2}\t{s.Grade}\t{s.Result}");
    }
    Pause();
}
void SearchStudent()
{
    Console.Clear();
    Console.Write("Enter Student ID : ");
    if (!int.TryParse(Console.ReadLine(), out int id))
    {
        Console.WriteLine("Invalid ID");
        Pause();
        return;
    }
    Student? student = students.Find(s => s.StudentId == id);
    if (student == null)
    {
        Console.WriteLine("Student Not Found");
    }
    else
    {
        Console.WriteLine($"\nID      : {student.StudentId}");
        Console.WriteLine($"Name    : {student.Name}");
        Console.WriteLine($"Total   : {student.Total}");
        Console.WriteLine($"Average : {student.Average:F2}");
        Console.WriteLine($"Grade   : {student.Grade}");
        Console.WriteLine($"Result  : {student.Result}");
    }
    Pause();
}
void UpdateStudent()
{
    Console.Clear();
    Console.Write("Enter Student ID : ");
    if (!int.TryParse(Console.ReadLine(), out int id))
    {
        Console.WriteLine("Invalid ID");
        Pause();
        return;
    }
    Student? student = students.Find(s => s.StudentId == id);
    if (student == null)
    {
        Console.WriteLine("Student Not Found");
        Pause();
        return;
    }
    student.Marks.Clear();
    Console.WriteLine("\nEnter New Marks");
    string[] subjects =
    {
        "English",
        "Mathematics",
        "Science",
        "Social",
        "Computer"
    };

    for (int i = 0; i < subjects.Length; i++)
    {
        while (true)
        {
            Console.Write($"Enter {subjects[i]} Marks : ");
            if (int.TryParse(Console.ReadLine(), out int mark) &&
                mark >= 0 &&
                mark <= 100)
            {
                student.Marks.Add(mark);
                break;
            }
            Console.WriteLine("Marks should be between 0 and 100.");
        }
    }
    CalculateResult(student);
    Console.WriteLine("\nStudent Updated Successfully.");
    Pause();
}
void DeleteStudent()
{
    Console.Clear();
    Console.Write("Enter Student ID : ");
    if (!int.TryParse(Console.ReadLine(), out int id))
    {
        Console.WriteLine("Invalid ID");
        Pause();
        return;
    }
    Student? student = students.Find(s => s.StudentId == id);
    if (student == null)
    {
        Console.WriteLine("Student Not Found");
    }
    else
    {
        students.Remove(student);
        Console.WriteLine("Student Deleted Successfully.");
    }
    Pause();
}
void DisplayRanks()
{
    Console.Clear();
    if (students.Count == 0)
    {
        Console.WriteLine("No Student Records.");
        Pause();
        return;
    }
    var rankedStudents = students
        .OrderByDescending(s => s.Total)
        .ToList();
    for (int i = 0; i < rankedStudents.Count; i++)
    {
        rankedStudents[i].Rank = i + 1;
    }
    Console.WriteLine("--------------------------------------------------------------------------------");
    Console.WriteLine("Rank\tID\tName\t\tTotal\tAverage\tGrade");
    Console.WriteLine("--------------------------------------------------------------------------------");
    foreach (var s in rankedStudents)
    {
        Console.WriteLine($"{s.Rank}\t{s.StudentId}\t{s.Name,-15}{s.Total}\t{s.Average:F2}\t{s.Grade}");
    }
    var topper = rankedStudents.First();
    Console.WriteLine("\nClass Topper");
    Console.WriteLine($"Name  : {topper.Name}");
    Console.WriteLine($"Total : {topper.Total}");
    Console.WriteLine($"Grade : {topper.Grade}");
    Pause();
}
void Pause()
{
    Console.WriteLine("\nPress Enter To Continue...");
    Console.ReadLine();
}
class Student
{
    public int StudentId { get; set; }
    public string Name { get; set; } = "";
    public List<int> Marks { get; set; } = new();
    public int Total { get; set; }
    public double Average { get; set; }
    public string Grade { get; set; } = "";
    public string Result { get; set; } = "";
    public int Rank { get; set; }
}