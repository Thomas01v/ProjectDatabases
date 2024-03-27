using System.Data.SqlClient;
using System.Data;

namespace SomerenDAL
{
    public class StudentDao : BaseDao
    {
        public DataTable GetAllStudents()
        {
            string query = "SELECT * FROM student";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ExecuteSelectQuery(query, sqlParameters);
        }

        public DataTable getByID(int studentnummer) {
            string query = $"SELECT * FROM student WHERE studentnummer=@studentnummer";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@studentnummer", studentnummer);
            return ExecuteSelectQuery(query, sqlParameters);
        }

        /*
         * TODO voor Thomas
         */
        public DataTable getActiviteitDeelnemers() {
            return new DataTable();
        }
    }
}