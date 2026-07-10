namespace EmployeeManagementSystem.Models
{
    public class PermanentEmployee : Employee
    {
        public decimal Bonus { get; set; }
        public PermanentEmployee(int id,
                                 string name,
                                 int age,
                                 decimal salary,
                                 decimal bonus)
            : base(id, name, age, salary)
        {
            Bonus = bonus;
        }
        public override void DisplayEmployee()
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Employee Type : Permanent");
            Console.WriteLine($"Id            : {Id}");
            Console.WriteLine($"Name          : {Name}");
            Console.WriteLine($"Age           : {Age}");
            Console.WriteLine($"Salary        : {Salary}");
            Console.WriteLine($"Bonus         : {Bonus}");
        }
    }
}