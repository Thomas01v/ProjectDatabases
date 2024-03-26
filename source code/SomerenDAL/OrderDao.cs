using SomerenModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Threading;

namespace SomerenDAL {
    public class OrderDao : BaseDao
    {

        public Order createOrder(Order order)
        {

            string query = "INSERT INTO [order] VALUES (@dranknummer, @studentnummer, @aantal, @datum)";
            SqlParameter[] sqlParameters = new SqlParameter[4];
            sqlParameters[0] = new SqlParameter("@dranknummer", order.dranknummer);
            sqlParameters[1] = new SqlParameter("@studentnummer", order.studentnummer);
            sqlParameters[2] = new SqlParameter("@aantal", order.aantal);
            sqlParameters[3] = new SqlParameter("@datum", $"{order.datum.Month:00}-{order.datum.Day:00}-{order.datum.Year:0000} {order.datum.Hour}:{order.datum.Minute}:{order.datum.Second}");

            ExecuteEditQuery(query, sqlParameters);

            return order;
        }

        public List<Order> GetOrdersByDateRange(DateTime startDate, DateTime endDate)
        {
            List<Order> orders = new List<Order>();

            string query = "SELECT o.*, d.verkoopprijs FROM [order] o INNER JOIN dbo.drankje d ON o.dranknummer = d.dranknummer WHERE o.datum >= @startDate AND o.datum <= @endDate ORDER BY o.datum";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@startDate", startDate);
            sqlParameters[1] = new SqlParameter("@endDate", endDate);

            DataTable dataTable = ExecuteSelectQuery(query, sqlParameters);

            foreach (DataRow row in dataTable.Rows)
            {

                Order order = new Order
                {
                    dranknummer = Convert.ToInt32(row["dranknummer"]),
                    studentnummer = Convert.ToInt32(row["studentnummer"]),
                    aantal = Convert.ToInt32(row["aantal"]),
                    datum = Convert.ToDateTime(row["datum"]),
                    

                };
                orders.Add(order);
            }

            return orders;
        }

        public int GetTotalOrderCount()
        {
            int totalOrders = 0;

            string query = "SELECT SUM(aantal) AS TotalOrders FROM [order]";
            SqlParameter[] sqlParameters = new SqlParameter[0];

            DataTable dataTable = ExecuteSelectQuery(query, sqlParameters);

            if (dataTable.Rows.Count > 0)
            {
                totalOrders = Convert.ToInt32(dataTable.Rows[0]["TotalOrders"]);
            }

            return totalOrders;
        }

        public decimal getTheTurnover(DateTime firstDate, DateTime lastDate)
        {

            decimal turnOver = 0;

            string query = "SELECT sum(aantal_bestellingen * verkoopprijs) AS turnover FROM (SELECT dranknummer, sum(aantal) AS aantal_bestellingen FROM [order] WHERE datum >= @firstDate AND datum <= @lastDate GROUP BY dranknummer) AS bestellingen JOIN drankje ON bestellingen.dranknummer=drankje.dranknummer;";

            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@firstDate",firstDate);
            sqlParameters[1] = new SqlParameter("@lastDate", lastDate);

            
            DataTable dataTable = ExecuteSelectQuery(query, sqlParameters);

            if (dataTable.Rows.Count > 0)
            {
                turnOver = Convert.ToDecimal(dataTable.Rows[0]["turnover"]);
            }

            return turnOver;


        }

        public int amountOfConsumers(DateTime firstDate, DateTime lastDate)
        {

             int amountOfConsumers = 0;

            string query = "SELECT count(DISTINCT studentnummer) AS amountOfConsumers FROM [order] WHERE datum >= @firstDate AND datum  <= @lastDate";

            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@firstDate", firstDate);
            sqlParameters[1] = new SqlParameter("@lastDate", lastDate);


            DataTable dataTable = ExecuteSelectQuery(query, sqlParameters);

            if (dataTable.Rows.Count > 0)
            {
                amountOfConsumers = Convert.ToInt32(dataTable.Rows[0]["amountOfConsumers"]);
            }

            return amountOfConsumers;


        }
    }
}
