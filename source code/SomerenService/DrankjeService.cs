using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomerenDAL;
using SomerenModel;

namespace SomerenService
{
    public class DrankjeService {
        private DrankjeDao drankjedb;

        public DrankjeService() {
            drankjedb = new DrankjeDao();
        }

        public List<Drankje> GetDrankjes() {
            List<Drankje> drankjes = new List<Drankje>();
            DataTable dataTable = drankjedb.GetAllDrankje();

            foreach (DataRow dr in dataTable.Rows) {
                Drankje drankje = DrankjeFromDataRow(dr);
                drankjes.Add(drankje);
            }
            return drankjes;
        }


        public string VoorraadStatus(Drankje drankje)
        {
            double voorraad = drankje.inkoop / drankje.voorraad;
            switch (voorraad)
            {
                case double d when d < 0:
                    return "stock empty";

                case double d when d <=0.2:
                    return "stock nearly depleted";

                default:
                    return "stock sufficient";
            }
        }

        public void AddDrankje(Drankje drankje)
        {
            drankjedb.AddDrankje(drankje);
        }
        public void DeleteDrankje(Drankje drankje)
        {
            drankjedb.DeleteDrankje(drankje);
        }

        public Drankje getByID(int dranknummer) {
            return DrankjeFromDataRow(drankjedb.getByID(dranknummer).Rows[0]);
        }

        public void updateDrankje(Drankje drankje) { 
            drankjedb.updateDrankje(drankje);

        }


        private Drankje DrankjeFromDataRow(DataRow dr) {
            Drankje drankje = new Drankje(
                (int)dr["dranknummer"],
                dr["dranknaam"].ToString(),
                (int)dr["inkoop"],
                (int)dr["voorraad"],
                Convert.ToDouble(dr["btw"]),
                Convert.ToDecimal(dr["inkoopprijs"]),
                Convert.ToDecimal(dr["verkoopprijs"])
            );
            return drankje;

        }
    }
}
    