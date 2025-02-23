using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace FirstADO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", optional: false);

            IConfiguration configuration = builder.Build();

            using var conn = new SqlConnection(configuration.GetConnectionString("DefaultConnection"));

            conn.Open();

            var trans = conn.BeginTransaction();


            CreateEmployee(
                    "Nguyen",
                    "TRANS 3",
                    "nguyena@gmail.com",
                    "0123456789",
                    DateTime.Today,
                    9,
                    10000,
                    6,
                    100,
                    conn, trans
                );

            CreateEmployee(
                    "Nguyen",
                    "TRANS 4",
                    "nguyena@gmail.com",
                    "0123456789",
                    DateTime.Today,
                    9,
                    10000,
                    6,
                    100,
                    conn, trans
                );

            trans.Rollback();

            conn.Close();
        }

        private static int GetValidDepartmentId(SqlConnection conn)
        {
            var cmd = new SqlCommand("SELECT TOP 1 department_id FROM departments", conn);
            var result = cmd.ExecuteScalar();
            return result != null ? (int)result : -1;
        }

        private static int CreateEmployee(
            string firstName, string lastName, string email, string phoneNumber, DateTime hireDate,
            int jobId, double salary, int departmentId, int managerId,  SqlConnection conn, SqlTransaction trans)
        {
            var cmd = new SqlCommand(@"INSERT INTO employees (
                  first_name, 
			      last_name,
			      email,
			      phone_number, 
			      hire_date,
			      job_id,
			      salary,
			      manager_id,
			      department_id 
			      
			      
                )VALUES(
                    @first_name,
                    @last_name,
                    @email,
                    @phone_number,
                    @hire_date,
                    @job_id,
                    @salary,
                    @manager_id, 
                    @department_id 
                    
                                    
                )", conn, trans);

            cmd.Parameters.Add(new SqlParameter("@first_name", System.Data.SqlDbType.VarChar, 20)).Value = firstName;
            cmd.Parameters.Add(new SqlParameter("@last_name", System.Data.SqlDbType.VarChar, 25)).Value = lastName;
            cmd.Parameters.Add(new SqlParameter("@email", System.Data.SqlDbType.VarChar, 100)).Value = email;
            cmd.Parameters.Add(new SqlParameter("@phone_number", System.Data.SqlDbType.VarChar, 20)).Value = phoneNumber;
            cmd.Parameters.Add(new SqlParameter("@hire_date", System.Data.SqlDbType.Date)).Value = hireDate;
            cmd.Parameters.Add(new SqlParameter("@job_id", System.Data.SqlDbType.Int)).Value = jobId;
            cmd.Parameters.Add(new SqlParameter("@salary", System.Data.SqlDbType.Decimal)).Value = salary;
            cmd.Parameters.Add(new SqlParameter("@manager_id", System.Data.SqlDbType.Int)).Value = managerId;
            cmd.Parameters.Add(new SqlParameter("@department_id", System.Data.SqlDbType.Int)).Value = departmentId;
            

            var result = cmd.ExecuteNonQuery();

            return result;
        }
    }
}
