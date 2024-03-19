using System;
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

        public Drankje getByID(int dranknummer) {
            return drankjedb.getByID(dranknummer);
        }

        public void updateDrankje(Drankje drankje) { 
            drankjedb.updateDrankje(drankje);
        }
    }
}
    