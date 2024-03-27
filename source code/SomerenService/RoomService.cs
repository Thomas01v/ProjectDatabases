using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomerenDAL;
using SomerenModel;

namespace SomerenService
{
    public class RoomService
    {
        private RoomDao roomdb;

        public RoomService()
        {
            roomdb = new RoomDao();
        }

        public List<Room> GetRooms()
        {
            DataTable dataTable = roomdb.GetAllRooms();

            List<Room> rooms = new List<Room>();

            foreach (DataRow dr in dataTable.Rows) {

                rooms.Add(getRoomFromRow(dr));
            }
            return rooms;
        }

        public Room getRoomById(string kamernummer) {
            return getRoomFromRow(roomdb.GetRoomById(kamernummer).Rows[0]);
        }


        public Room getRoomById(string kamernummer, List<Room> rooms) {
            foreach (Room room in rooms) {
                if (room.kamernummer.Equals(kamernummer)) {
                    return room;
                }
            }
            return null;
        }

            private RoomType getRoomType(string kamernummer) {
            DataTable roomResult = roomdb.StudentsInRoom(kamernummer);

            if (roomResult.Rows.Count > 0) {
                return RoomType.StudentRoom;
            } else {
                roomResult = roomdb.TeachersInRoom(kamernummer);

                if (roomResult.Rows.Count > 0) {
                   return RoomType.TeacherRoom;
                } else {
                    return RoomType.EmptyRoom;
                }
            }
        }

        private Room getRoomFromRow(DataRow dr) {
            string kamerNummer = dr["kamernummer"].ToString();
            RoomType roomType = getRoomType(kamerNummer);


            Room room = new Room(
                kamerNummer,
                roomType
            );

            return room;
        }
    }
}
