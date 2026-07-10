namespace EmployeeManagementSystem.Models
{
    public class ContractEmployee : Employee
    {
        public int ContractMonths { get; set; }
        public ContractEmployee(int id,
                                string name,
                                int age,
                                decimal salary,
                                int months)
            : base(id, name, age, salary)
        {
            ContractMonths = months;
        }
        public override void DisplayEmployee()
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Employee Type : Contract");
            Console.WriteLine($"Id       : {Id}");
            Console.WriteLine($"Name     : {Name}");
            Console.WriteLine($"Age      : {Age}");
            Console.WriteLine($"Salary   : {Salary}");
            Console.WriteLine($"Months   : {ContractMonths}");
        }
    }
}