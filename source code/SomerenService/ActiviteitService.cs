using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Data;

namespace SomerenService
{
    public class ActiviteitService
    {
        private ActiviteitDao activiteitdb;

        public ActiviteitService()
        {
            activiteitdb = new ActiviteitDao();
        }

        public List<Activiteit> GetActiviteiten()
        {
            DataTable dataTable = activiteitdb.GetAllActiviteiten();

            List<Activiteit> activiteiten = new List<Activiteit>();

            foreach (DataRow dr in dataTable.Rows) {

                activiteiten.Add(getActiviteitFromDataRow(dr));
            }
            
            return activiteiten;
        }

        private Activiteit getActiviteitFromDataRow(DataRow dr) {

            Activiteit activiteit = new Activiteit(
                (int)dr["activiteitnummer"],
                dr["activiteit_naam"].ToString(),
                Convert.ToDateTime(dr["datumtijd"])
            );

            //verkrijg de begeleiders
            TeacherService teacherService = new TeacherService();
            List<Teacher> begeleiders = teacherService.getActiviteitBegeleiders(activiteit.activiteitnummer);
            activiteit.begeleiders = begeleiders;

            //TODO voor Thomas: verkrijg de deelnemers

            

            return activiteit;
        }

        public Activiteit getByID(int activiteitnummer) {
            return getActiviteitFromDataRow(activiteitdb.getByID(activiteitnummer).Rows[0]);
        }

        public void addBegeleider(Activiteit activiteit, Teacher docent) {
            activiteitdb.addBegeleider(activiteit.activiteitnummer, docent.docentnummer);
        }

        public void removeBegeleider(Activiteit activiteit, Teacher docent) {
            activiteitdb.removeBegeleider(activiteit.activiteitnummer, docent.docentnummer);
        }

    }
}