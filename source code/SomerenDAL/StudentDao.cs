using System.Data.SqlClient;
using System.Data;

namespace SomerenDAL
{
    public class StudentDao : BaseDao
    {
        public DataTable GetAllStudents()
        {
            string query = "SELECT * FROM [student]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ExecuteSelectQuery(query, sqlParameters);
        }
    }
}