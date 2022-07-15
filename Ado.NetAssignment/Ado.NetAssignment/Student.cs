using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Ado.NetAssignment
{
    internal class Student
    {
        public Student()
        {

        }

        string conString = "Server=W1045VD7Y2;Database=StudentDatabase;Integrated Security=true; MultipleActiveResultSets=True;";
        public void CreateStudent()
        {
            // Managed Code - Garbage Collector - GC manages all the objects - destroys unused objects
            // Non - Managed code - Code which connects to external services and objects cannot be destroyed by GC 
            using (SqlConnection con = new SqlConnection(conString))
            {
                string command = "CreateStudent";
                SqlCommand cmd = new SqlCommand(command, con);
                cmd.CommandType=System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@stud_id", "1");
                cmd.Parameters.AddWithValue("@stud_name", "Lavanya");
                cmd.Parameters.AddWithValue("@department", "IT");

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                Console.WriteLine("Student is created");

            }
        }

        public void GetStudent(int stud_id)
        {

            using (SqlConnection con = new SqlConnection(conString))
            {
                string command = "select stud_id,stud_name,department from studentmaster where stud_id="+stud_id;
                SqlCommand cmd = new SqlCommand(command, con);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine("Student details:");
                    Console.WriteLine(reader["stud_id"].ToString());
                    Console.WriteLine(reader["stud_name"].ToString());
                    Console.WriteLine(reader["department"].ToString());
                }
                con.Close();

            }
        }

        public void GetStudentCount()
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                string command = "select count(*) from studentmaster";
                SqlCommand cmd = new SqlCommand(command, con);              

                con.Open();                               
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                con.Close();
                Console.WriteLine("-------------------");
                Console.WriteLine("Student count:"+ count);
                Console.WriteLine("-------------------");

            }
        }


        public void GetMaxMinAvgScore(string subject)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                string command = "select max("+subject+") MaxScore,min("+subject+") MinScore,avg("+subject+") AvgScore from studentscore";
                SqlCommand cmd = new SqlCommand(command, con);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine("------------");
                    Console.WriteLine(subject+":");
                    Console.WriteLine("------------");
                    Console.WriteLine("MaxScore: "+ reader["MaxScore"].ToString()+"; MinScore: "+ reader["MinScore"].ToString()+"; AvgScore: "+ reader["AvgScore"].ToString());
                }
                con.Close();            
                

            }
        }
        public void GetHighestScorer(string subject)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                string command = "select stud_name from studentmaster";
                command+= " where stud_id in (select stud_id from studentscore";
                command+= " where "+ subject + " = (select max(" + subject + " ) from studentscore ))";
                SqlCommand cmd = new SqlCommand(command, con);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(subject+" Highest Scorer:" + reader["stud_name"].ToString());

                }
                con.Close();


            }

        }

        public void GetLowestScorer(string subject)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                string command = "select stud_name from studentmaster";
                command+= " where stud_id in (select stud_id from studentscore";
                command+= " where "+ subject + " = (select min(" + subject + " ) from studentscore ))";
                SqlCommand cmd = new SqlCommand(command, con);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(subject+" Lowest Scorer:" + reader["stud_name"].ToString());

                }
                con.Close();


            }
        }
    }
}
