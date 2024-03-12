using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomerenModel;

namespace SomerenDAL
{
    public class RoomDao : BaseDao
    {
        public List<Room> GetAllRooms()
        {
            string query = "SELECT kamernummer FROM [kamer]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Room> ReadTables(DataTable dataTable)
        {
            List<Room> rooms = new List<Room>();

            foreach (DataRow dr in dataTable.Rows)
            {
                string kamerNummer = dr["kamernummer"].ToString();
                string query = $"SELECT studentnummer, kamernummer FROM student WHERE kamernummer = '{kamerNummer}'";
                DataTable roomResult = ExecuteSelectQuery(query);

                RoomType roomType;

                if (roomResult.Rows.Count >0 ) 
                {
                    roomType = RoomType.StudentRoom;
                }
                else 
                {
                    query = $"SELECT docentnummer, kamernummer FROM docent WHERE kamernummer = '{kamerNummer}'";
                    roomResult = ExecuteSelectQuery(query);
                    
                    if (roomResult.Rows.Count > 0 ) 
                    {
                        roomType = RoomType.TeacherRoom;
                    }
                    else 
                    {
                        roomType = RoomType.EmptyRoom;
                    }
                }


                Room room = new Room()
                {
                    kamernummer = kamerNummer,
                    roomType = roomType
                };
                rooms.Add(room);
            }
            return rooms;
        }


    }
}

