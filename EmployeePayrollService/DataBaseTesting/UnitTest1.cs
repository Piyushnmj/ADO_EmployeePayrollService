using EmployeePayrollService.Repository;

namespace DataBaseTesting
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void Compare_EmployeePayrollObject_WithDatabase()
        {
            EmployeePayroll objEmployee = new EmployeePayroll();
            string actual = objEmployee.UpdateEmployeeSalary();

            Assert.AreEqual("Date update status: Successfull", actual);
        }

        [TestMethod]
        public void Compare_EmployeePayrollObject_WithDatabase_StoredProcedureMethod()
        {
            EmployeePayroll objEmployee = new EmployeePayroll();
            string actual = objEmployee.UpdateSalaryUsingStoredProcedure();

            Assert.AreEqual("Date update status: Successfull", actual);
        }
    }
}