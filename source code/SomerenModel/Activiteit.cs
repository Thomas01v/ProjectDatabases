using System;

namespace SomerenModel {
    class Activiteit {

        public int activiteitnummer { get; init; }     // database id
        public string activiteitnaam { get; init; }
        public DateTime datumtijd { get; init; }     

        public Activiteit(int activiteitnummer, string activiteitnaam, DateTime datumtijd) {
            this.activiteitnummer = activiteitnummer;
            this.activiteitnaam = activiteitnaam;
            this.datumtijd = datumtijd;
        }
    }
}
