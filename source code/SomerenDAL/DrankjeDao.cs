using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomerenModel;

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
    }
}