using System;
using System.Collections;
using System.Collections.Generic;
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
            List<Drankje> drankjes = drankjedb.GetAllDrankje();
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

        public Drankje getByID(int dranknummer) {
            return drankjedb.getByID(dranknummer);
        }

        public void updateDrankje(Drankje drankje) { 
            drankjedb.updateDrankje(drankje);

        }
    }
}
    