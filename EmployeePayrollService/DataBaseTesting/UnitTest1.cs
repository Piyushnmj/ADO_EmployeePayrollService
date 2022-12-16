using EmployeePayrollService.Repository;

namespace DataBaseTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            EmployeePayroll objEmployee = new EmployeePayroll();
            string actual = objEmployee.UpdateEmployeeSalary();

            Assert.AreEqual("Date update status: Successfull", actual);
        }
    }
}