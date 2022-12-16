﻿using EmployeePayrollService.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayrollService.Repository
{
    public class EmployeePayroll
    {
        public static string connectionString = "Server=PIYUSHNMJ;Database=EmployeePayroll_Service;User ID=PIYUSHNMJ/Piyush;Password=;TrustServerCertificate=True;integrated security=SSPI;";

        public void GetAllEmployee()
        {
            SqlConnection objConnection = new SqlConnection(connectionString);
            try
            {
                EmployeeModel objEmployeeModel = new EmployeeModel();
                using (objConnection)
                {
                    string query = @"SELECT * FROM employee_payroll";
                    
                    SqlCommand objCommand = new SqlCommand(query, objConnection);
                    objConnection.Open();
                    SqlDataReader objDataReader = objCommand.ExecuteReader();

                    if (objDataReader.HasRows)
                    {
                        while (objDataReader.Read())
                        {
                            objEmployeeModel.Id = objDataReader.IsDBNull("Id") ? 0 : objDataReader.GetInt32("Id");
                            objEmployeeModel.Name = objDataReader.IsDBNull("Name") ? string.Empty : objDataReader.GetString("Name");
                            objEmployeeModel.PhoneNumber = objDataReader.IsDBNull("PhoneNumber") ? 0 : objDataReader.GetInt32("PhoneNumber");
                            objEmployeeModel.Address = objDataReader.IsDBNull("Address") ? string.Empty : objDataReader.GetString("Address");
                            objEmployeeModel.Department = objDataReader.IsDBNull("Department") ? string.Empty : objDataReader.GetString("Department");
                            objEmployeeModel.Gender = Convert.ToChar(objDataReader.IsDBNull("Gender") ? string.Empty : objDataReader.GetString("Gender"));
                            objEmployeeModel.Basic_Pay = objDataReader.IsDBNull("Basic_Pay") ? 0.0 : (Double)(objDataReader.GetDecimal("Basic_Pay"));
                            objEmployeeModel.Deductions = objDataReader.IsDBNull("Deductions") ? 0.0 : (Double)objDataReader.GetDecimal("Deductions");
                            objEmployeeModel.Taxable_Pay = objDataReader.IsDBNull("Taxable_Pay") ? 0.0 : (Double)objDataReader.GetDecimal("Taxable_Pay");
                            objEmployeeModel.Tax = objDataReader.IsDBNull("Tax") ? 0.0 : (Double)objDataReader.GetDecimal("Tax");
                            objEmployeeModel.Net_Pay = objDataReader.IsDBNull("Net_Pay") ? 0.0 : (Double)objDataReader.GetDecimal("Net_Pay");
                            objEmployeeModel.Start = objDataReader.IsDBNull("Start") ? DateTime.MinValue : objDataReader.GetDateTime("Start");
                            objEmployeeModel.City = objDataReader.IsDBNull("City") ? string.Empty : objDataReader.GetString("City");
                            objEmployeeModel.Country = objDataReader.IsDBNull("Country") ? string.Empty : objDataReader.GetString("Country");

                            Console.WriteLine($"Id          : {objEmployeeModel.Id}\n" +
                                              $"Name        : {objEmployeeModel.Name}\n" +
                                              $"PhoneNumber : {objEmployeeModel.PhoneNumber}\n" +
                                              $"Address     : {objEmployeeModel.Address}\n" +
                                              $"Department  : {objEmployeeModel.Department}\n" +
                                              $"Gender      : {objEmployeeModel.Gender}\n" +
                                              $"Basic_Pay   : {objEmployeeModel.Basic_Pay}\n" +
                                              $"Deductions  : {objEmployeeModel.Deductions}\n" +
                                              $"Taxable_Pay : {objEmployeeModel.Taxable_Pay}\n" +
                                              $"Tax         : {objEmployeeModel.Tax}\n" +
                                              $"Net_Pay     : {objEmployeeModel.Net_Pay}\n" +
                                              $"Start       : {objEmployeeModel.Start}\n" +
                                              $"City        : {objEmployeeModel.City}\n" +
                                              $"Country     : {objEmployeeModel.Country}\n" +
                                              "\n********************\n");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (objConnection.State == ConnectionState.Open)
                {
                    objConnection.Close();
                }
            }
        }
    }
}