using System;

namespace SomerenModel
{
    public class Teacher
    {
        public int docentnummer { get; set; }     // database id
        public string voornaam { get; set; }
        public string achternaam { get; set; }
        public string naam { get => voornaam + " " + achternaam; }
        public int telefoonnummer { get; set; } // StudentNumber, e.g. 474791
        public DateTime geboortedatum { get; set; }
        public string kamernummer { get; set; }
    }
}