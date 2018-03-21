using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetTraining
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string RegisterNumber { get; set; }

        public List<StudentMarks> StudentMarks { get => studentMarks;
                                        set => studentMarks = value; }

        List<StudentMarks> studentMarks = new List<StudentMarks>();

        public void Save()
        {
            string conStr       = ConfigurationManager
                                    .ConnectionStrings["conStr"]
                                    .ConnectionString;

            SqlConnection con   = new SqlConnection(conStr);

            try
            {
                con.Open();

                string insertStudentSql = "INSERT INTO Students(Name,RegisterNumber) " +
                                          "Values(@Name,@RegisterNumber);" +
                                          "SELECT SCOPE_IDENTITY()";

                SqlCommand insertCommand = new SqlCommand(insertStudentSql, con);

                insertCommand.Parameters.AddWithValue("@Name", this.Name);
                insertCommand.Parameters.AddWithValue("@RegisterNumber", this.RegisterNumber);


                //insertCommand.ExecuteNonQuery();
                int retValue = int.Parse(insertCommand.ExecuteScalar().ToString());
                this.Id     = retValue;

                foreach(StudentMarks marks in this.StudentMarks)
                {
                   
                }
            }
            catch(Exception excp)
            {
                throw;
            }
        }

        public static List<Student> GetStudents()
        {
            List<Student> students = new List<Student>();

            string conStr    = ConfigurationManager
                                   .ConnectionStrings["conStr"]
                                   .ConnectionString;
           
            SqlConnection con = new SqlConnection(conStr);
            try
            {
                con.Open();
                string selectStudentQuery   = "SELECT * FROM STUDENTS";
                SqlCommand cmd              = new SqlCommand(selectStudentQuery, con);
                SqlDataReader reader        =  cmd.ExecuteReader();
                while(reader.Read())
                {
                    Student s             = new Student();
                    s.Id          = (int)reader["Id"];
                    s.Name      = (string)reader["Name"];
                    s.RegisterNumber= (string)reader["RegisterNumber"];

                    students.Add(s);
                }
            }
            catch(Exception excp)
            {
                throw;
            }
            return students;
        }

        public static int GetTotalStudentCount()
        {
            int totalStudents = 0;
            string conStr = ConfigurationManager
                                  .ConnectionStrings["conStr"]
                                  .ConnectionString;

            SqlConnection con = new SqlConnection(conStr);

            try
            {
                con.Open();
                string sqlQuery  = "SELECT COUNT(*) FROM Students";
                SqlCommand cmd   = new SqlCommand(sqlQuery, con);

                totalStudents    = int.Parse(cmd.ExecuteScalar().ToString());

            }
            catch(Exception excp)
            {
                throw;
            }

            return totalStudents;
        }

        public static int DeleteStudent(int studentId)
        {
            int retValue = 0;
            string conStr = ConfigurationManager
                                 .ConnectionStrings["conStr"]
                                 .ConnectionString;

            SqlConnection con = new SqlConnection(conStr);

            try
            {
                con.Open();

                string deleteQuery = "DELETE FROM Students WHERE Id= @St" +
                    "udentId";
                SqlCommand command = new SqlCommand(deleteQuery, con);
                command.Parameters.AddWithValue("@StudentId", studentId);

                retValue =  command.ExecuteNonQuery();

            }
            catch(Exception excp)
            {
                throw;
            }

            return retValue;
        }
    }
}
