using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomerenModel;
using System.Data.Common;
using System.Configuration;

namespace SomerenDAL
{
    public class DrankjeDao : BaseDao
    {
        public List<Drankje> GetAllDrankje()
        {
            string query = "SELECT * FROM drankje";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Drankje> ReadTables(DataTable dataTable)
        {
            List<Drankje> drankjes = new List<Drankje>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Drankje drankje = new Drankje()
                {
                    dranknummer = (int)dr["dranknummer"],
                    dranknaam = dr["dranknaam"].ToString(),
                    inkoop = (int)dr["inkoop"],
                    voorraad = (int)dr["voorraad"],
                    btw = Convert.ToDouble(dr["btw"]),
                    aankoopprijs = Convert.ToDecimal(dr["inkoopprijs"]),
                    verkoopprijs = Convert.ToDecimal(dr["verkoopprijs"])
                };
                drankjes.Add(drankje);
            }
            return drankjes;
        }

        public Drankje AddDrankje(Drankje drankje)
        {
            SqlConnection dbConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["SomerenDatabase"].ConnectionString);
            OpenConnection();
            SqlCommand cmd = new SqlCommand("INSERT INTO drankje VALUES (@dranknaam, @inkoop, @btw, @inkoopprijs, @verkoopprijs);" +
                "SELECT CAST(scope_identity() As int)", dbConnection);
            
            cmd.Parameters.AddWithValue("@dranknaam", drankje.dranknaam);
            cmd.Parameters.AddWithValue("@inkoop", drankje.inkoop);
            cmd.Parameters.AddWithValue("@btw", drankje.btw);
            cmd.Parameters.AddWithValue("@inkoopprijs", drankje.aankoopprijs);
            cmd.Parameters.AddWithValue("@verkoopprijs", drankje.verkoopprijs);
            
            int id = (int)cmd.ExecuteScalar();
            CloseConnection(); 
            return new Drankje(id, drankje.dranknaam, drankje.inkoop, drankje.btw, drankje.aankoopprijs, drankje.verkoopprijs);
        }

        public void ChangeDrankje(Drankje drankje)
        {
            SqlConnection dbConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["SomerenDatabase"].ConnectionString);
            OpenConnection();
            SqlCommand cmd = new SqlCommand("UPDATE drankje SET dranknaam=@dranknaam, verkoopprijs=@verkoopprijs, btw=@btw, voorraad=@voorraad," +
                "", dbConnection);

            cmd.Parameters.AddWithValue("@dranknaam", drankje.dranknaam);
            cmd.Parameters.AddWithValue("@verkoopprijs", drankje.verkoopprijs);
            cmd.Parameters.AddWithValue("@btw", drankje.btw);
            cmd.Parameters.AddWithValue("@voorraad", drankje.voorraad);
            cmd.ExecuteNonQuery();
            CloseConnection();
        }
    }
}
