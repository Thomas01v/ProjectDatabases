﻿using System;
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
                Drankje drankje = DrankjeFromDataRow(dr);
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


        public Drankje getByID(int dranknummer) {
            string query = $"SELECT * FROM drankje WHERE dranknummer=@dranknummer";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@dranknummer", dranknummer);
            DataTable data = ExecuteSelectQuery(query, sqlParameters);
            DataRow dr = data.Rows[0];
            return DrankjeFromDataRow(dr);
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

        private Drankje DrankjeFromDataRow(DataRow dr) {
            Drankje drankje = new Drankje() {
                dranknummer = (int)dr["dranknummer"],
                dranknaam = dr["dranknaam"].ToString(),
                inkoop = (int)dr["inkoop"],
                voorraad = (int)dr["voorraad"],
                btw = Convert.ToDouble(dr["btw"]),
                aankoopprijs = Convert.ToDecimal(dr["inkoopprijs"]),
                verkoopprijs = Convert.ToDecimal(dr["verkoopprijs"])
            };
            return drankje;

        }
    }
}
