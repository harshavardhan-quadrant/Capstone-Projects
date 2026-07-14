using StudentRecordSystem.Interfaces;
using StudentRecordSystem.Services;
IStudentService studentService = new StudentService();
while (true)
{
    Console.Clear();
    Console.WriteLine("=========================================");
    Console.WriteLine("       STUDENT RECORD SYSTEM");
    Console.WriteLine("=========================================");
    Console.WriteLine("1. Add Student");
    Console.WriteLine("2. View Students");
    Console.WriteLine("3. Search Student");
    Console.WriteLine("4. Update Student");
    Console.WriteLine("5. Delete Student");
    Console.WriteLine("6. Sort Students by Marks");
    Console.WriteLine("7. Show Topper");
    Console.WriteLine("8. Department Wise Students");
    Console.WriteLine("9. Exit");
    Console.WriteLine("=========================================");
    Console.Write("Enter Your Choice : ");
    if (!int.TryParse(Console.ReadLine(), out int choice))
    {
        Console.WriteLine();
        Console.WriteLine("Invalid input. Please enter a valid number.");
        WaitForMainMenu();
        continue;
    }
    Console.Clear();
    switch (choice)
    {
        case 1:
            Console.WriteLine("===== ADD STUDENT =====\n");
            studentService.AddStudent();
            break;
        case 2:
            Console.WriteLine("===== VIEW STUDENTS =====\n");
            studentService.ViewStudents();
            break;
        case 3:
            Console.WriteLine("===== SEARCH STUDENT =====\n");
            studentService.SearchStudent();
            break;
        case 4:
            Console.WriteLine("===== UPDATE STUDENT =====\n");
            studentService.UpdateStudent();
            break;
        case 5:
            Console.WriteLine("===== DELETE STUDENT =====\n");
            studentService.DeleteStudent();
            break;
        case 6:
            Console.WriteLine("===== SORT STUDENTS =====\n");
            studentService.SortStudents();
            break;
        case 7:
            Console.WriteLine("===== TOPPER DETAILS =====\n");
            studentService.ShowTopper();
            break;
        case 8:
            Console.WriteLine("===== DEPARTMENT WISE STUDENTS =====\n");
            studentService.DepartmentWiseStudents();
            break;
        case 9:
            Console.Clear();
            Console.WriteLine("Thank you for using Student Record System.");
            Console.WriteLine("Have a Great Day!");
            return;
        default:
            Console.WriteLine("Invalid Choice.");
            break;
    }
    WaitForMainMenu();
}
static void WaitForMainMenu()
{
    Console.WriteLine();
    Console.WriteLine("-----------------------------------------");
    Console.WriteLine("Press Enter or Esc to return to Main Menu");
    Console.WriteLine("-----------------------------------------");
    ConsoleKey key;
    do
    {
        key = Console.ReadKey(true).Key;
    }
    while (key != ConsoleKey.Enter && key != ConsoleKey.Escape);
}