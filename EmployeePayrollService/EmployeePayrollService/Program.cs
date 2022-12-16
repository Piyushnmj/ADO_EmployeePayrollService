using EmployeePayrollService.Repository;

namespace EmployeePayrollService
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Payroll Service");

            EmployeePayroll objEmployee = new EmployeePayroll();
            objEmployee.GetAllEmployee();
        }
    }
}