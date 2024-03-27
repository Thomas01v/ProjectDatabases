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

        public DataTable GetById(int docentnummer) {
            string query = $"SELECT * FROM docent WHERE docentnummer=@docentnummer";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@docentnummer", docentnummer);
            return ExecuteSelectQuery(query, sqlParameters);
        }

        public DataTable getActiviteitBegeleiders(int activiteitnummer) {
            string query = $"SELECT * FROM begeleid WHERE activiteitnummer = @activiteitnummer";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@activiteitnummer", activiteitnummer);
            return ExecuteSelectQuery(query, sqlParameters);
        }
    }
}
