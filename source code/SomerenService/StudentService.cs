using SomerenDAL;
using SomerenModel;
using System.Collections.Generic;
using System.Data;

namespace SomerenService
{
    public class StudentService
    {
        private StudentDao studentdb;

        public StudentService()
        {
            studentdb = new StudentDao();
        }

        public List<Student> GetStudents()
        {
            DataTable dataTable = studentdb.GetAllStudents();

            List<Student> students = new List<Student>();

            foreach (DataRow dr in dataTable.Rows) {

                students.Add(getStudentFromDataRow(dr));
            }
            
            return students;
        }

        private Student getStudentFromDataRow(DataRow dr) {
            int Telefoonnummer;
            if (dr.IsNull("telefoonnummer")) {
                Telefoonnummer = 0;
            } else {
                Telefoonnummer = (int)dr["telefoonnummer"];
            }
            RoomService roomService = new RoomService();
            Room room = roomService.getRoomById(dr["kamernummer"].ToString());

            Student student = new Student(
                (int)dr["studentnummer"],
                dr["voornaam"].ToString(),
                dr["achternaam"].ToString(),
                Telefoonnummer,
                dr["klas"].ToString(),
                room
            );

            return student;
        }
    }
}