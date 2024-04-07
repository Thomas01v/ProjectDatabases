using System;
using System.Collections.Generic;
using SomerenDAL;
using SomerenModel;
using System.Linq;
using System.Data;

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

        private Order getOrderFromDataRow(DataRow dr) {
            DrankjeService drankjeService = new DrankjeService();
            StudentService studentService = new StudentService();
            Drankje drankje = drankjeService.getByID(Convert.ToInt32(dr["dranknummer"]));
            Student student = studentService.getByID(Convert.ToInt32(dr["studentnummer"]));

            Order order = new Order (
                Convert.ToInt32(dr["ordernummer"]),
                drankje,
                student,
                Convert.ToInt32(dr["aantal"]),
                Convert.ToDateTime(dr["datum"])
                );
            return order;
        }

        public int amountOfOrders(DateTime firstDate, DateTime lastDate) 
        {

            List<Order> orders = GetOrdersByDateRange(firstDate, lastDate);

            int totalOrders = orders.Sum(order => order.aantal);

            return totalOrders;

        }

        public List<Order> GetOrdersByDateRange(DateTime firstDate, DateTime lastDate) {
            DataTable dataTable = orderdb.GetOrdersByDateRange(firstDate, lastDate);
            List<Order> orders = new List<Order>();

            foreach (DataRow dr in dataTable.Rows) {
                orders.Add(getOrderFromDataRow(dr));
            }

            return orders;
        }

        public decimal getTheTurnover(DateTime firstDate, DateTime lastDate) 
        {
            DataTable turnoverData = orderdb.getTheTurnover(firstDate, lastDate);

            if (turnoverData.Rows[0].IsNull("turnover"))
            {
                return 0;
            }
            else 
            {
                return Convert.ToDecimal(turnoverData.Rows[0]["turnover"]);


            }
        }
        public int amountOfConsumers(DateTime firstDate, DateTime lastDate)
        {

            DataTable amountOfConsumers = orderdb.amountOfConsumers(firstDate, lastDate);

            if (amountOfConsumers.Rows[0].IsNull("amountOfConsumers"))
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(amountOfConsumers.Rows[0]["amountOfConsumers"]);
            }
        }
    }
}
