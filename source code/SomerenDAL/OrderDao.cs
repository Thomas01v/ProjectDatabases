using SomerenModel;
using System.Data.SqlClient;

namespace SomerenDAL {
    public class OrderDao : BaseDao {

        public void createOrder(Order order) {

            string query = "INSERT INTO [order] VALUES (@dranknummer, @studentnummer, @aantal, @datum)";
            SqlParameter[] sqlParameters = new SqlParameter[4];
            sqlParameters[0] = new SqlParameter("@dranknummer", order.drankje.dranknummer);
            sqlParameters[1] = new SqlParameter("@studentnummer", order.student.studentnummer);
            sqlParameters[2] = new SqlParameter("@aantal", order.aantal);
            sqlParameters[3] = new SqlParameter("@datum", order.datum);
            
            ExecuteEditQuery(query, sqlParameters);
        }

    }
}
