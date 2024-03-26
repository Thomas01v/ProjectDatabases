using SomerenDAL;
using SomerenModel;

namespace SomerenService {
    public class OrderService {

        private OrderDao orderdb = new OrderDao();
        public bool createOrder(Order order) {

            DrankjeService drankjeservice = new DrankjeService();
            Drankje voorraadDrankje = drankjeservice.getByID(order.dranknummer);
            if (voorraadDrankje.voorraad >= order.aantal) {
                orderdb.createOrder(order);
                voorraadDrankje.voorraad -= order.aantal;
                drankjeservice.updateDrankje(voorraadDrankje);

                return true;
            }else {
                return false;
            }
        }
    }
}
