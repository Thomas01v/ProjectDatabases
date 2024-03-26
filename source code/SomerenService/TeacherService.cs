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
            DataTable dataTable = teacherdb.GetAllTeachers();

            foreach (DataRow dr in dataTable.Rows) {
                teachers.Add(getTeacherFromDataRow(dr));
            }
            return teachers;
        }

        private Teacher getTeacherFromDataRow(DataRow dr) {

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
    }
}