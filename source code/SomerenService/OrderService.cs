using SomerenDAL;
using SomerenModel;

namespace SomerenService {
    public class OrderService {

        private OrderDao orderdb = new OrderDao();
        public string createOrder(Order order) {

            DrankjeService drankjeservice = new DrankjeService();
            Drankje voorraadDrankje = drankjeservice.getByID(order.dranknummer);
            if (voorraadDrankje.voorraad >= order.aantal) {
                orderdb.createOrder(order);
                voorraadDrankje.voorraad -= order.aantal;
                drankjeservice.updateDrankje(voorraadDrankje);

                return $"{voorraadDrankje.dranknaam} besteld. nieuwe voorraad: {voorraadDrankje.voorraad}";
            }else {
                return $"niet genoeg {voorraadDrankje.dranknaam} op voorraad. ({voorraadDrankje.voorraad})";
            }
        }
    }
}
