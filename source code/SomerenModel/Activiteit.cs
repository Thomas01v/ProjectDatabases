using System;
using System.Collections.Generic;

namespace SomerenModel {
    public class Activiteit {

        public int activiteitnummer { get; init; }     // database id
        public string activiteitnaam { get; init; }
        public DateTime datumtijd { get; init; }

        public List<Teacher> begeleiders;
        public List<Student> deelnemers;

        public Activiteit(int activiteitnummer, string activiteitnaam, DateTime datumtijd) {
            begeleiders = new List<Teacher>();
            deelnemers = new List<Student>();
            this.activiteitnummer = activiteitnummer;
            this.activiteitnaam = activiteitnaam;
            this.datumtijd = datumtijd;
        }
    }
}
