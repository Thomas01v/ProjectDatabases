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


        public void addBegeleider(int activiteitnummer, int docentnummer) {
            string query = $"INSERT INTO begeleid VALUES (@activiteitnummer, @docentnummer)";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@activiteitnummer", activiteitnummer);
            sqlParameters[1] = new SqlParameter("@docentnummer", docentnummer);
            ExecuteEditQuery(query, sqlParameters);
        }

        public void addStudent(int activiteitnummer, int studentnummer)
        {
            string query = $"INSERT INTO neemt_deel VALUES (@activiteitnummer, @studentnummer)";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@activiteitnummer", activiteitnummer);
            sqlParameters[1] = new SqlParameter("@studentnummer", studentnummer);
            ExecuteEditQuery(query, sqlParameters);
        }
        public void removeBegeleider(int activiteitnummer, int docentnummer) {
            string query = $"DELETE FROM begeleid WHERE activiteitnummer = @activiteitnummer AND docentnummer = @docentnummer";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@activiteitnummer", activiteitnummer);
            sqlParameters[1] = new SqlParameter("@docentnummer", docentnummer);
            ExecuteEditQuery(query, sqlParameters);
        }
        public void removeStudent(int activiteitnummer, int studentnummer)
        {
            string query = $"DELETE FROM neemt_deel WHERE activiteitnummer = @activiteitnummer AND studentnummer = @studentnummer";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@activiteitnummer", activiteitnummer);
            sqlParameters[1] = new SqlParameter("@studentnummer", studentnummer);
            ExecuteEditQuery(query, sqlParameters);
        }
        public DataTable getAllStudentsThatDoActivity(int activiteitnummer) 
        {
            string query = $"SELECT studentnummer FROM neemt_deel WHERE activiteitnummer = @activiteitnummer;";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@activiteitnummer", activiteitnummer);
            return ExecuteSelectQuery(query, sqlParameters);
      
        }        
    }
}