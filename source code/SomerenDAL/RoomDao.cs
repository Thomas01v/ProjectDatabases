using System.Data.SqlClient;
using System.Data;

namespace SomerenDAL
{
    public class RoomDao : BaseDao
    {
        public DataTable GetAllRooms()
        {
            string query = "SELECT * FROM [kamer]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ExecuteSelectQuery(query, sqlParameters);
        }

        public DataTable GetRoomById(string kammernummer) {
            string query = "SELECT * FROM [kamer] WHERE kamernummer = @kamernummer";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@kamernummer", kammernummer);
            return ExecuteSelectQuery(query, sqlParameters);
        }

        public DataTable StudentsInRoom(string kamernummer) {
            string query = "SELECT studentnummer, kamernummer FROM student WHERE kamernummer = @kamernummer";
            SqlParameter[] sqplParameters = new SqlParameter[1];
            sqplParameters[0] = new SqlParameter("@kamernummer", kamernummer);

            return ExecuteSelectQuery(query, sqplParameters);
        }

        public DataTable TeachersInRoom(string kamernummer) {
            string query = "SELECT docentnummer, kamernummer FROM docent WHERE kamernummer = @kamernummer";
            SqlParameter[] sqplParameters = new SqlParameter[1];
            sqplParameters[0] = new SqlParameter("@kamernummer", kamernummer);

            return ExecuteSelectQuery(query, sqplParameters);
        }

    }
}

