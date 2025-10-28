using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.SqlClient;
using Microsoft.Data;
using System.Data;
using Microsoft.IdentityModel.Tokens;
namespace Assignments_10_23_2025
{

    public class EmployeesOperations
    {
        private string connectionString = "Server=localhost;Database=EmOperation;User Id=sa;Password=Sufiyan@123;TrustServerCertificate=True;";


        public void EmployeeInsertion()
        {

            using (SqlConnection con = new SqlConnection(@connectionString))
            {
                try
                {
                    con.Open();
                    Console.WriteLine("Enter the Name Of the Employee");
                    string Name = Console.ReadLine();
                    string str;
                    Console.WriteLine("Enter the salary Of the Employee");
                    string stringSalary = Console.ReadLine();
                    if (long.TryParse(stringSalary, out long salary))
                    {
                        str = "Insert into Employee values('" + Name + "'," + salary + ")";
                        using (SqlCommand cmd = new SqlCommand(str, con))
                        {
                            int ins = cmd.ExecuteNonQuery();
                            if (ins > 0)
                            {
                                Console.WriteLine("Insertion successfull");
                                DisplayTable();
                            }
                            else
                            {

                                Console.WriteLine("Erorr while inserting");

                            }

                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid salary input. Please enter a valid number.");
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("An error occurred while connecting to the database: " + ex.Message);
                }

            }

        }
        public void EmployeesUpdateOperation()
        {
            Console.WriteLine("Enter the Id of The Employee update needed to be Performed");
            int EmployeeId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter new salary");
            int Salary = Convert.ToInt32(Console.ReadLine());
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string Upd = "Update Employee set Salary=" + Salary + "where Eid =" + EmployeeId;
                    SqlCommand cmd = new SqlCommand(Upd, con);
                    int statusid = cmd.ExecuteNonQuery();
                    if (statusid > 0)
                    {
                        Console.WriteLine("Updation successfull");
                        DisplayTable();
                    }
                    else
                    {
                        Console.WriteLine("Updation Faild");
                    }

                }
                catch (SqlException ex)
                {
                    Console.WriteLine("An error occurred while connecting to the database: " + ex.Message);
                }
            }
        }
        public void EmployeesDeleteOperation()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                Console.WriteLine("Enter the Id of The Employee Delete needed to be Performed");
                int EmployeeId = Convert.ToInt32(Console.ReadLine());
                try
                {
                    con.Open();
                    string Del = "Delete from Employee where Eid=" + EmployeeId;
                    SqlCommand cmd = new SqlCommand(Del, con);
                    int statusid = cmd.ExecuteNonQuery();
                    if (statusid > 0)
                    {
                        Console.WriteLine("Delete successfull");
                        DisplayTable();
                    }
                    else
                    {
                        Console.WriteLine("Delete Faild");
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("An error occurred while connecting to the database: " + ex.Message);
                }
            }
        }
        public void DisplayTable()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string sel = "Select * from Employee";
                SqlCommand cmd = new SqlCommand(sel, con);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        Console.WriteLine("Employee ID:" + reader["Eid"] + "Employee Name:" + reader["Ename"] + "Employee Salary:" + reader["Salary"]);
                    }

                }



            }
        }
        public void TotalCount()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string consel = "select Count(*) from Employee";
                SqlCommand cmd = new SqlCommand(consel, con);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                Console.WriteLine("The total Count is :" + count);
            }
        }
        public void DiscDisplay()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string sel = "select * from Employee";

                SqlDataAdapter da = new SqlDataAdapter(sel, con);
                DataSet ds = new DataSet();
                da.Fill(ds, "Employee");
                DataTable dt = ds.Tables["Employee"];
                foreach (DataRow dr in dt.Rows)
                {

                    foreach (DataColumn col in dt.Columns)
                    {
                        Console.Write($"{col.ColumnName}: {dr[col]}  ");
                    }
                    Console.WriteLine();
                }




            }
        }
        public void DiscUpdate()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    Console.WriteLine("Enter the Id of The Employee update needed to be Performed");
                    int EmployeeId = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("enter new salary");
                    int Salary = Convert.ToInt32(Console.ReadLine());
                    string sel = "select * from Employee";
                    SqlDataAdapter da = new SqlDataAdapter(sel, con);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Employee");
                    DataTable dt = ds.Tables["Employee"];
                    foreach (DataRow dr in dt.Rows)
                    {
                        if ((int)dr["Eid"] == EmployeeId)
                        {
                            dr["Salary"] = Salary;
                        }


                    }
                    SqlCommandBuilder commandBuilder = new SqlCommandBuilder(da);
                    da.Update(ds, "Employee");

                }
                catch (SqlException ex)
                {
                    Console.WriteLine("An error occurred while connecting to the database: " + ex.Message);
                }

            }
        }
        public void parameterizedInline()
        {
            using (SqlConnection con = new SqlConnection(@connectionString))
            {
                try
                {

                    Console.WriteLine("Enter the Name Of the Student");
                    string Name = Console.ReadLine();
                    string str;
                    Console.WriteLine("Enter the Age Of the Student");
                    string AgeS = Console.ReadLine();
                    Console.WriteLine("Enter the Class Of the Student");
                    int ClassofS = Convert.ToInt32(Console.ReadLine());
                    if (long.TryParse(AgeS, out long Age))
                    {

                        str = "Insert into Student values( @Name,@Age,@StudentClass)";
                        using (SqlCommand cmd = new SqlCommand(str, con))
                        {
                            cmd.Parameters.AddWithValue("Name", Name);
                            cmd.Parameters.AddWithValue("Age", Age);
                            cmd.Parameters.AddWithValue("StudentClass", ClassofS);
                            int ins = cmd.ExecuteNonQuery();
                            if (ins > 0)
                            {
                                Console.WriteLine("Insertion successfull");

                            }
                            else
                            {

                                Console.WriteLine("Erorr while inserting");

                            }

                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid salary input. Please enter a valid number.");
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("An error occurred while connecting to the database: " + ex.Message);
                }

            }
        }
        public void GetStudentById()
        {
            using (SqlConnection con = new SqlConnection(@connectionString))
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand("GetStudentById", con))
                {
                    cmd.Parameters.AddWithValue("StudentId", 1);
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine("Student Name:" + reader["StudentName"] + " Student Age:" + reader["StudentAge"] + " Student Class" + reader["StudentClass"]);
                        }
                    }

                }

            }
        }
        public void InsertStudent()
        {
            using (SqlConnection con = new SqlConnection(@connectionString))
            {
                con.Open();
                Console.WriteLine("Enter the Name Of the Student");
                string S_Name = Console.ReadLine();
                Console.WriteLine("Enter the Age Of the Student");
                int Age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Class Of the Student");
                int ClassOfS = Convert.ToInt32(Console.ReadLine());
                using (SqlCommand cmd = new SqlCommand("Sp_InsertStudent", con))
                {
                    cmd.Parameters.AddWithValue("@StudentName", S_Name);
                    cmd.Parameters.AddWithValue("@StudentAge", Age);
                    cmd.Parameters.AddWithValue("@StudentClass", ClassOfS);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter outPutId = new SqlParameter("@StudentId", SqlDbType.Int);
                    outPutId.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(outPutId);
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("the Last Enterred Sudent id Output Value is" + outPutId.Value);
                }
            }
        }
        public void DeleteStudent()
        {
            using (SqlConnection con = new SqlConnection(@connectionString))
            {
                con.Open();

                Console.WriteLine("Enter the ID Of the Student");
                int Sid = Convert.ToInt32(Console.ReadLine());

                using (SqlCommand cmd = new SqlCommand("Sp_StudentDelete", con))
                {

                    cmd.Parameters.AddWithValue("@StudentId", Sid);

                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter outPutId = new SqlParameter("@StudentName", SqlDbType.NVarChar, 50);
                    outPutId.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(outPutId);
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("the Last Enterred Sudent id Output Value is" + outPutId.Value);
                }
            }

        }
        public void UpdateStudent()
        {
            using (SqlConnection con = new SqlConnection(@connectionString))
            {
                con.Open();

                Console.WriteLine("Enter the ID Of the Student");
                int Sid = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Name to be Of the Student");
                string name = Console.ReadLine();
                Console.WriteLine("Enter the Class Of the Student");
                int Classof = Convert.ToInt32(Console.ReadLine());

                using (SqlCommand cmd = new SqlCommand("Sp_UpdateStudent", con))
                {

                    cmd.Parameters.AddWithValue("@StudentId", Sid);
                    cmd.Parameters.AddWithValue("@StudentName", name);
                    cmd.Parameters.AddWithValue("@StudentClass", Classof);
                    cmd.CommandType = CommandType.StoredProcedure;


                    int i = cmd.ExecuteNonQuery();
                    {
                        if (i > 0)
                        {
                            Console.WriteLine("uPDATATION successfull");
                        }
                        else
                        {
                            Console.WriteLine("ERROR");
                        }
                    }
                }

            }
        }
    }
}
