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
            RoomService roomService = new RoomService();

            List<Student> students = new List<Student>();
            List<Room> rooms = roomService.GetRooms(); 

            foreach (DataRow dr in dataTable.Rows) {

                students.Add(getStudentFromDataRow(dr, rooms));
            }
            
            return students;
        }

        private Student getStudentFromDataRow(DataRow dr, List<Room> possiblerooms) {
            int Telefoonnummer;
            if (dr.IsNull("telefoonnummer")) {
                Telefoonnummer = 0;
            } else {
                Telefoonnummer = (int)dr["telefoonnummer"];
            }
            RoomService roomService = new RoomService();
            Room room = roomService.getRoomById(dr["kamernummer"].ToString(), possiblerooms);

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

        public Student getByID(int studentnummer) {
            RoomService roomService = new RoomService();
            List<Room> rooms = roomService.GetRooms();
            return getStudentFromDataRow(studentdb.getByID(studentnummer).Rows[0], rooms);
        }

        public void AddStudent(Student student)
        {
            studentdb.AddStudent(student);
        }

        public void updateStudent(Student student)
        {
            studentdb.updateStudent(student);

        }
        public void DeleteStudent(Student student)
        {
            studentdb.DeleteStudent(student);
        }
    }
}