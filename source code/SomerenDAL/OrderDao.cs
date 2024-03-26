using SomerenModel;
using System.Data.SqlClient;
using System.Data;
using System.Threading;
using System;

namespace SomerenDAL {
    public class OrderDao : BaseDao
    {

        public void createOrder(Order order) {

            string query = "INSERT INTO [order] VALUES (@dranknummer, @studentnummer, @aantal, @datum)";
            SqlParameter[] sqlParameters = new SqlParameter[4];
            sqlParameters[0] = new SqlParameter("@dranknummer", order.drankje.dranknummer);
            sqlParameters[1] = new SqlParameter("@studentnummer", order.student.studentnummer);
            sqlParameters[2] = new SqlParameter("@aantal", order.aantal);
            sqlParameters[3] = new SqlParameter("@datum", order.datum);

            ExecuteEditQuery(query, sqlParameters);
        }

        public DataTable GetOrdersByDateRange(DateTime startDate, DateTime endDate)
        {

            string query = "SELECT o.*, d.verkoopprijs FROM [order] o INNER JOIN dbo.drankje d ON o.dranknummer = d.dranknummer WHERE o.datum >= @startDate AND o.datum <= @endDate ORDER BY o.datum";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@startDate", startDate);
            sqlParameters[1] = new SqlParameter("@endDate", endDate);

            return ExecuteSelectQuery(query, sqlParameters);
        }

        public DataTable GetTotalOrderCount()
        {

            string query = "SELECT SUM(aantal) AS TotalOrders FROM [order]";
            SqlParameter[] sqlParameters = new SqlParameter[0];

            return ExecuteSelectQuery(query, sqlParameters);
        }

        public DataTable getTheTurnover(DateTime firstDate, DateTime lastDate)
        {

            string query = "SELECT sum(aantal_bestellingen * verkoopprijs) AS turnover FROM (SELECT dranknummer, sum(aantal) AS aantal_bestellingen FROM [order] WHERE datum >= @firstDate AND datum <= @lastDate GROUP BY dranknummer) AS bestellingen JOIN drankje ON bestellingen.dranknummer=drankje.dranknummer;";

            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@firstDate",firstDate);
            sqlParameters[1] = new SqlParameter("@lastDate", lastDate);

            
            return ExecuteSelectQuery(query, sqlParameters);


        }

        public DataTable amountOfConsumers(DateTime firstDate, DateTime lastDate)
        {

            string query = "SELECT count(DISTINCT studentnummer) AS amountOfConsumers FROM [order] WHERE datum >= @firstDate AND datum  <= @lastDate";

            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@firstDate", firstDate);
            sqlParameters[1] = new SqlParameter("@lastDate", lastDate);


            return ExecuteSelectQuery(query, sqlParameters);


        }
    }
}
