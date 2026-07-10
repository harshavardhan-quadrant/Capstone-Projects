using EmployeeManagementSystem.Models;
using EmployeeManagementSystem.Services;
EmployeeService service = new EmployeeService();
bool exit = false;
while (!exit)
{
    Console.WriteLine();
    Console.WriteLine("===== Employee Management System =====");
    Console.WriteLine("1. Add Permanent Employee");
    Console.WriteLine("2. Add Contract Employee");
    Console.WriteLine("3. View Employees");
    Console.WriteLine("4. Search Employee");
    Console.WriteLine("5. Update Salary");
    Console.WriteLine("6. Delete Employee");
    Console.WriteLine("7. Exit");
    Console.Write("Enter Choice : ");
    int choice = Convert.ToInt32(Console.ReadLine());
    switch (choice)
    {
        case 1:
            Console.Write("Id : ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Name : ");
            string name = Console.ReadLine();
            Console.Write("Age : ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Salary : ");
            decimal salary = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Bonus : ");
            decimal bonus = Convert.ToDecimal(Console.ReadLine());
            service.AddEmployee(new PermanentEmployee(id, name, age, salary, bonus));
            break;
        case 2:
            Console.Write("Id : ");
            id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Name : ");
            name = Console.ReadLine();
            Console.Write("Age : ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Salary : ");
            salary = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Contract Months : ");
            int months = Convert.ToInt32(Console.ReadLine());
            service.AddEmployee(new ContractEmployee(id, name, age, salary, months));
            break;
        case 3:
            service.DisplayEmployees();
            break;
        case 4:
            Console.Write("Enter Employee Id : ");
            id = Convert.ToInt32(Console.ReadLine());
            service.SearchEmployee(id);
            break;
        case 5:
            Console.Write("Enter Employee Id : ");
            id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter New Salary : ");
            salary = Convert.ToDecimal(Console.ReadLine());
            service.UpdateSalary(id, salary);
            break;
        case 6:
            Console.Write("Enter Employee Id : ");
            id = Convert.ToInt32(Console.ReadLine());
            service.DeleteEmployee(id);
            break;
        case 7:
            exit = true;
            break;
        default:
            Console.WriteLine("Invalid Choice.");
            break;
    }
}