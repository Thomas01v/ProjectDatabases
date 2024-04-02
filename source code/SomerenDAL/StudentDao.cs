using System.Data.SqlClient;
using System.Data;
using SomerenModel;
using System;

namespace SomerenDAL
{
    public class StudentDao : BaseDao
    {
        public DataTable GetAllStudents()
        {
            string query = "SELECT * FROM student";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ExecuteSelectQuery(query, sqlParameters);
        }

        public DataTable getByID(int studentnummer) {
            string query = $"SELECT * FROM student WHERE studentnummer=@studentnummer";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@studentnummer", studentnummer);
            return ExecuteSelectQuery(query, sqlParameters);
        }

        public void AddStudent(Student student)
        {

            string query = "INSERT INTO student VALUES (@voornaam, @achternaam, @telefoonnummer, @klas, @room)";
            SqlParameter[] sqlParameters = new SqlParameter[5];
            sqlParameters[0] = new SqlParameter("@voornaam", student.voornaam);
            sqlParameters[1] = new SqlParameter("@achternaam", student.achternaam);
            sqlParameters[2] = new SqlParameter("@telefoonnummer", student.telefoonnummer);
            sqlParameters[3] = new SqlParameter("@klas", student.klas);
            sqlParameters[4] = new SqlParameter("@room", student.room.kamernummer);
            
            ExecuteEditQuery(query, sqlParameters);
        }

        public Student updateStudent(Student student)
        {

            string query = "UPDATE student SET voornaam=@voornaam, achternaam=@achternaam, telefoonnummer=@telefoonnummer, klas=@klas, kamernummer=@room WHERE studentnummer=@studentnummer";
            SqlParameter[] sqlParameters = new SqlParameter[6];
            sqlParameters[0] = new SqlParameter("@voornaam", student.voornaam);
            sqlParameters[1] = new SqlParameter("@achternaam", student.achternaam);
            sqlParameters[2] = new SqlParameter("@telefoonnummer", student.telefoonnummer);
            sqlParameters[3] = new SqlParameter("@klas", student.klas);
            sqlParameters[4] = new SqlParameter("@room", student.room.kamernummer);
            sqlParameters[5] = new SqlParameter("@studentnummer", student.studentnummer);

            ExecuteEditQuery(query, sqlParameters);

            return student;
        }

        public void DeleteStudent(Student student)
        {
            string query = "DELETE FROM student WHERE studentnummer = @studentnummer";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@studentnummer", student.studentnummer);
            ExecuteEditQuery(query, sqlParameters);
        }

        /*
         * TODO voor Thomas
         */
        public DataTable getActiviteitDeelnemers() {
            return new DataTable();
        }
    }
}