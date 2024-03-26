using System;
using System.Collections.Generic;
using SomerenDAL;
using SomerenModel;
using System.Linq;

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

        public int amountOfOrders(DateTime firstDate, DateTime lastDate) 
        {

            List<Order> orders = orderdb.GetOrdersByDateRange(firstDate, lastDate);

            int totalOrders = orders.Sum(order => order.aantal);

            return totalOrders;



        }

        public decimal getTheTurnover(DateTime firstDate, DateTime lastDate) 
        {

            

            return orderdb.getTheTurnover(firstDate, lastDate);
        
        
        }
        public int amountOfConsumers(DateTime firstDate, DateTime lastDate)
        {



            return orderdb.amountOfConsumers(firstDate, lastDate);


        }




    }
}
