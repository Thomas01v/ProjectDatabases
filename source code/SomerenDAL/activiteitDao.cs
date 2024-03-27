using System.Data.SqlClient;
using System.Data;

namespace SomerenDAL
{
    public class ActiviteitDao : BaseDao
    {
        public DataTable GetAllActiviteiten()
        {
            string query = "SELECT * FROM activiteit";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ExecuteSelectQuery(query, sqlParameters);
        }

        public DataTable getByID(int activiteitnummer) {
            string query = $"SELECT * FROM activiteit WHERE activiteitnummer=@activiteitnummer";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@activiteitnummer", activiteitnummer);
            return ExecuteSelectQuery(query, sqlParameters);
        }

        
    }
}