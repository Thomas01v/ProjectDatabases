﻿using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using SomerenModel;

namespace SomerenDAL
{
    public class TeacherDao : BaseDao
    {
        public List<Teacher> GetAllTeachers()
        {
            string query = "SELECT * FROM docent";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Teacher> ReadTables(DataTable dataTable)
        {
            List<Teacher> teachers = new List<Teacher>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Teacher teacher = new Teacher()
                {
                    docentnummer = (int) dr["docentnummer"],
                    voornaam = dr["voornaam"].ToString(),
                    achternaam = dr["achternaam"].ToString(),
                    telefoonnummer = (int)dr["docentnummer"],
                    //geboortedatum = dr["docentnummer"],
                    kamernummer = dr["docentnummer"].ToString(),
                };
                teachers.Add(teacher);
            }
            return teachers;
        }
    }
}