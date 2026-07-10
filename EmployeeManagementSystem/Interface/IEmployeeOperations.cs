using EmployeeManagementSystem.Models;
namespace EmployeeManagementSystem.Interfaces
{
    public interface IEmployeeOperations
    {
        void AddEmployee(Employee employee);
        void DisplayEmployees();
        void SearchEmployee(int id);
        void UpdateSalary(int id, decimal salary);
        void DeleteEmployee(int id);
    }
}