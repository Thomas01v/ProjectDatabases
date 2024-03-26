using System.Data.SqlClient;
using System.Data;

namespace SomerenDAL
{
    public class TeacherDao : BaseDao {
        public DataTable GetAllTeachers() {
            string query = "SELECT * FROM docent";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ExecuteSelectQuery(query, sqlParameters);
        }
    }
        
}
