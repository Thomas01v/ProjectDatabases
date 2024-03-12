using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using SomerenModel;

namespace SomerenDAL
{
    public class StudentDao : BaseDao
    {
        public List<Student> GetAllStudents()
        {
            string query = "SELECT studentnummer, voornaam, achternaam FROM [student]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Student> ReadTables(DataTable dataTable)
        {
            List<Student> students = new List<Student>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Student student = new Student()
                {
                    studentnummer = (int)dr["studentnummer"],
                    voornaam = dr["voornaam"].ToString(),
                    achternaam = dr["achternaam"].ToString()
                };
                students.Add(student);
            }
            return students;
        }
    }
}