using Samplelib;
using Samplelib.Data;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Net.NetworkInformation;
namespace SampleWinApp
{
    enum SqlParameters
    {
        Query, Insert, Update, Delete
    }
    static class SQLData
    {
        public static DataTable ExecuteQuery(string commandText, params SqlParameters[] parameters)
        {
            string strConnectionString = ConfigurationManager.ConnectionStrings["connConfig"].ConnectionString;
            var con = new SqlConnection(strConnectionString);
            var com = con.CreateCommand();
            com.CommandText = commandText;
            foreach (var param in parameters)
            {
                com.Parameters.Add(param);
            }
            con.Open();
            var reader = com.ExecuteReader();
            var table = new DataTable("Data");
            table.Load(reader);
            con.Close();
            return table;
        }
        public static void ExecuteNonQuery(string commandText, params SqlParameters[] parameters)
        {
            string strConnectionString = ConfigurationManager.ConnectionStrings["connConfig"].ConnectionString;
            var con = new SqlConnection(strConnectionString);
            var com = con.CreateCommand();
            com.CommandText = commandText;
            foreach (var param in parameters)
            {
                com.Parameters.Add(param);
            }
            con.Open();        
            com.ExecuteNonQuery();
            con.Close();
        }
    }
    internal class ConnectedModel
    {
        //static string strConnectionString = ConfigurationManager.ConnectionStrings["connConfig"].ConnectionString;
        static void Main(string[] args)
        {
            EmpDB empDB = new EmpDB();
            //empDB.FindEmp();
            //InsertEMP(new emp { EmpName = "qwerty", EmpAddress = "new york",EmpSalary = 123456,DeptID = 1});
            //empDB.addEmp(new emp { EmpName = "qwerty2", EmpAddress = "new york", EmpSalary = 9999, DeptID = 1 });
            //empDB.updateEmp(new emp { EmpName = "qwerty3", EmpAddress = "new mock", EmpSalary = 4208, DeptID = 1 });
            //empDB.deleteEmp(1);
            //delEmp(2);
            GetALLEmp();
            //GetAllDe();

        }

        private static void GetAllDe()
        {
            DataTable dt = SQLData.ExecuteQuery("SELECT * FROM Department");
            foreach (DataRow row in dt.Rows)
            {
                Console.WriteLine($"ID: {row["DeptId"]}, Name: {row["DeptName"]}");
            }
        }


        //public static void InsertEMP(emp emp)
        //{
        //    string query = "INSERT INTO Employee VALUES (@EmpName, @EmpAddress, @EmpSalary, @DeptID)";

        //    using (var con = new SqlConnection(strConnectionString))
        //    using (var com = new SqlCommand(query, con))
        //    {
        //        com.Parameters.AddWithValue("@EmpName", emp.EmpName);
        //        com.Parameters.AddWithValue("@EmpAddress", emp.EmpAddress);
        //        com.Parameters.AddWithValue("@EmpSalary", emp.EmpSalary);
        //        com.Parameters.AddWithValue("@DeptID", emp.DeptID);

        //        try
        //        {
        //            con.Open();
        //            com.ExecuteNonQuery();
        //        }
        //        catch (Exception ex)
        //        {
        //            throw;
        //        }
        //    }
        //}

        private static void GetALLEmp()
        {
            EmpDB empDB = new EmpDB();
            var res = empDB.GetAllEmployees();
            foreach (var emp in res)
            {
                Console.WriteLine($"Emp ID :{emp.EmpId}, name :{emp.EmpName} ,Address :{emp.EmpAddress} ");
            }
            //DataTable dt = SQLData.ExecuteQuery("SELECT * FROM Employee");
            //foreach (DataRow row in dt.Rows)
            //{
            //    Console.WriteLine($"ID: {row["EmpId"]}, Name: {row["EmpName"]}, Address: {row["EmpAddress"]}");
            //}
        }

        private static void delEmp(int id)
        {
            string empDelete = $"delete from Employee where EmpId={id}";
            SQLData.ExecuteNonQuery(empDelete);
        }
    }
    //private static void firstEx()
    //{
    //    var sqlCon = new SqlConnection(strConnectionString);
    //    SqlCommand cmd = sqlCon.CreateCommand();
    //    cmd.CommandText = getAll;
    //    try
    //    {
    //        sqlCon.Open();
    //        //SqlDataReader reader = cmd.ExecuteReader();
    //        var reader = cmd.ExecuteReader();
    //        while (reader.Read())
    //        {
    //            Console.WriteLine($"Name: {reader["EmpName"]} \nAddress:{reader["EmpAddress"]} \nSalary: {reader[3]}\nSalary: {reader[4]}\n\n");
    //        }
    //    }
    //    catch (SqlException ex)
    //    {
    //        Console.WriteLine(ex.Message);
    //    }
    //}
}

