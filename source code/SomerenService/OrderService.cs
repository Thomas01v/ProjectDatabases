using SomerenDAL;
using SomerenModel;
using System;

namespace SomerenService {
    public class OrderService {

        private OrderDao orderdb = new OrderDao();
        public bool createOrder(Drankje voorraadDrankje, Student student, int aantal) {

            Order newOrder = new Order(
                    -1,
                    voorraadDrankje,
                    student,
                    aantal,
                    DateTime.Now
                );
            if (voorraadDrankje.voorraad >= newOrder.aantal) {
                orderdb.createOrder(newOrder);
                Drankje updateDrankje = new Drankje(voorraadDrankje.dranknummer, voorraadDrankje.dranknaam, voorraadDrankje.inkoop, voorraadDrankje.voorraad - newOrder.aantal, voorraadDrankje.btw, voorraadDrankje.aankoopprijs, voorraadDrankje.verkoopprijs);
                DrankjeService drankjeservice = new DrankjeService();
                drankjeservice.updateDrankje(updateDrankje);

                return true;
            }else {
                return false;
            }
        }
    }
}
