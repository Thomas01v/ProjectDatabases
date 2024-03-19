using SomerenModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace SomerenDAL {
    public class OrderDao : BaseDao {

        public Order createOrder(Order order) {

            string query = "INSERT INTO [order] VALUES (@dranknummer, @studentnummer, @aantal, @datum)";
            SqlParameter[] sqlParameters = new SqlParameter[4];
            sqlParameters[0] = new SqlParameter("@dranknummer", order.dranknummer);
            sqlParameters[1] = new SqlParameter("@studentnummer", order.studentnummer);
            sqlParameters[2] = new SqlParameter("@aantal", order.aantal);
            sqlParameters[3] = new SqlParameter("@datum", $"{order.datum.Month:00}-{order.datum.Day:00}-{order.datum.Year:0000} {order.datum.Hour}:{order.datum.Minute}:{order.datum.Second}");
            
            ExecuteEditQuery(query, sqlParameters);

            return order;
        }

    }
}
