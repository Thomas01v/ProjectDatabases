using System;

namespace SomerenModel
{
    public class Student
    {
        public int studentnummer { get; set; }    
        public string voornaam { get; set; }
        public string achternaam { get; set; }
        public string naam { get => voornaam + " " + achternaam; }
        public int telefoonnummer { get; set; } 
        public string klas { get; set; }
        public string kamernummer { get; set; }
    }
}