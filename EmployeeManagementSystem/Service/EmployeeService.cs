using EmployeeManagementSystem.Interfaces;
using EmployeeManagementSystem.Models;
namespace EmployeeManagementSystem.Services
{
    public class EmployeeService : IEmployeeOperations
    {
        private List<Employee> employees = new List<Employee>();
        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
            Console.WriteLine("Employee Added Successfully.");
        }
        public void DisplayEmployees()
        {
            if (employees.Count == 0)
            {
                Console.WriteLine("No Employees Found.");
                return;
            }
            foreach (Employee emp in employees)
            {
                emp.DisplayEmployee();
            }
        }
        public void SearchEmployee(int id)
        {
            Employee emp = employees.FirstOrDefault(x => x.Id == id);
            if (emp != null)
            {
                emp.DisplayEmployee();
            }
            else
            {
                Console.WriteLine("Employee Not Found.");
            }
        }
        public void UpdateSalary(int id, decimal salary)
        {
            Employee emp = employees.FirstOrDefault(x => x.Id == id);
            if (emp != null)
            {
                emp.Salary = salary;
                Console.WriteLine("Salary Updated.");
            }
            else
            {
                Console.WriteLine("Employee Not Found.");
            }
        }
        public void DeleteEmployee(int id)
        {
            Employee emp = employees.FirstOrDefault(x => x.Id == id);
            if (emp != null)
            {
                employees.Remove(emp);
                Console.WriteLine("Employee Deleted.");
            }
            else
            {
                Console.WriteLine("Employee Not Found.");
            }
        }
    }
}