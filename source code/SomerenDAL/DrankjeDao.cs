using System.Data.SqlClient;
using System.Data;
using SomerenModel;

namespace SomerenDAL
{
    public class DrankjeDao : BaseDao
    {
        public DataTable GetAllDrankje()
        {
            string query = "SELECT * FROM drankje";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ExecuteSelectQuery(query, sqlParameters);
        }


        public void AddDrankje(Drankje drankje)
        {
            
            string query = "INSERT INTO drankje VALUES (@dranknaam, @inkoop, @voorraad, @btw, @inkoopprijs, @verkoopprijs)";
            SqlParameter[] sqlParameters = new SqlParameter[7];
            sqlParameters[0] = new SqlParameter("@dranknummer", drankje.dranknummer);
            sqlParameters[1] = new SqlParameter("@dranknaam", drankje.dranknaam);
            sqlParameters[2] = new SqlParameter("@inkoop", drankje.inkoop);
            sqlParameters[3] = new SqlParameter("@voorraad", drankje.voorraad);
            sqlParameters[4] = new SqlParameter("@btw", drankje.btw);
            sqlParameters[5] = new SqlParameter("@inkoopprijs", drankje.aankoopprijs);
            sqlParameters[6] = new SqlParameter("@verkoopprijs", drankje.verkoopprijs);

            ExecuteEditQuery(query, sqlParameters);
        }

        public void DeleteDrankje(Drankje drankje)
        {
            string query = "DELETE FROM drankje WHERE dranknummer = @dranknummer";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@dranknummer", drankje.dranknummer);
            ExecuteEditQuery(query, sqlParameters);
        }

        public DataTable getByID(int dranknummer) {
            string query = $"SELECT * FROM drankje WHERE dranknummer=@dranknummer";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@dranknummer", dranknummer);
            return ExecuteSelectQuery(query, sqlParameters);
        }

        public Drankje updateDrankje(Drankje drankje) {

            string query = "UPDATE drankje SET dranknaam=@dranknaam, inkoop=@inkoop, voorraad=@voorraad, btw=@btw, inkoopprijs=@inkoopprijs, verkoopprijs=@verkoopprijs WHERE dranknummer=@dranknummer";
            SqlParameter[] sqlParameters = new SqlParameter[7];
            sqlParameters[0] = new SqlParameter("@dranknummer", drankje.dranknummer);
            sqlParameters[1] = new SqlParameter("@dranknaam", drankje.dranknaam);
            sqlParameters[2] = new SqlParameter("@inkoop", drankje.inkoop);
            sqlParameters[3] = new SqlParameter("@voorraad", drankje.voorraad);
            sqlParameters[4] = new SqlParameter("@btw", drankje.btw);
            sqlParameters[5] = new SqlParameter("@inkoopprijs", drankje.aankoopprijs);
            sqlParameters[6] = new SqlParameter("@verkoopprijs", drankje.verkoopprijs);

            ExecuteEditQuery(query, sqlParameters);

            return drankje;
        }

    }
}
