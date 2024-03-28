using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Data;

namespace SomerenService
{
    public class TeacherService
    {
        private TeacherDao teacherdb;

        public TeacherService()
        {
            teacherdb = new TeacherDao();
        }

        public List<Teacher> GetTeachers()
        {
            List<Teacher> teachers = new List<Teacher>();
            RoomService roomService = new RoomService();

            DataTable dataTable = teacherdb.GetAllTeachers();
            List<Room> rooms = roomService.GetRooms();

            foreach (DataRow dr in dataTable.Rows) {
                teachers.Add(getTeacherFromDataRow(dr, rooms));
            }
            return teachers;
        }

        public Teacher getById(int docentnummer) {
            RoomService roomService = new RoomService();
            List<Room> rooms = roomService.GetRooms();
            return getTeacherFromDataRow(teacherdb.GetById(docentnummer).Rows[0], rooms);
        }

        private Teacher getTeacherFromDataRow(DataRow dr, List<Room> possiblerooms) {

            RoomService roomService = new RoomService();
            Room room = roomService.getRoomById(dr["kamernummer"].ToString());

            Teacher teacher = new Teacher(
                    (int)dr["docentnummer"],
                    dr["voornaam"].ToString(),
                    dr["achternaam"].ToString(),
                    (int)dr["telefoonnummer"],
                    (DateTime)dr["geboortedatum"],
                    room
                    );
            return teacher;
        }

        public List<Teacher> getActiviteitBegeleiders(int activiteitnummer) {
            List<Teacher> teachers = new List<Teacher>();

            DataTable dataTable = teacherdb.getActiviteitBegeleiders(activiteitnummer);

            foreach (DataRow dr in dataTable.Rows) {
                teachers.Add(getById((int)dr["docentnummer"]));
            }
            return teachers;
        }
    }
}