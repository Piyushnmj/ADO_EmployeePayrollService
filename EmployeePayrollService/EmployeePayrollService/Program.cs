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
            //objEmployee.UpdateEmployeeSalary();
            //objEmployee.UpdateSalaryUsingStoredProcedure();
            objEmployee.GetAllEmployeeByDate();
            //objEmployee.AggregateFunction('M');
            //objEmployee.AggregateFunction('F');
            objEmployee.InsertEmployee();
        }
    }
}