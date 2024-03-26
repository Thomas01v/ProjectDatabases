using System;

namespace SomerenModel
{
    public class Teacher
    {
        public int docentnummer { get; init; }     // database id
        public string voornaam { get; init; }
        public string achternaam { get; init; }
        public string naam { get => voornaam + " " + achternaam; }
        public int telefoonnummer { get; set; } 
        public DateTime geboortedatum { get; init; }
        public Room room { get; init; }

        public Teacher(int docentnummer, string voornaam, string achternaam, DateTime geoboortedatum, Room room) {
            this.docentnummer = docentnummer;
            this.voornaam = voornaam;
            this.achternaam = achternaam;
            this.geboortedatum = geoboortedatum;
            this.room = room;
        }

        public Teacher(int docentnummer, string voornaam, string achternaam, int telefoonnummer, DateTime geoboortedatum, Room room) : this(docentnummer, voornaam, achternaam, geoboortedatum, room) {
            this.telefoonnummer = telefoonnummer;
        }
    }
}