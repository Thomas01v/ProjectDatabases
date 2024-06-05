using System;

namespace SomerenModel
{
    public class Student
    {
        public int studentnummer { get; init; }    
        public string voornaam { get; init; }
        public string achternaam { get; init; }
        public string naam { get => voornaam + " " + achternaam; }
        public int telefoonnummer { get; set; } 
        public string klas { get; init; }
        public Room room { get; init; }

        public Student(int studentnummer, string voornaam, string achternaam, string klas, Room room) {
            this.studentnummer = studentnummer;
            this.voornaam = voornaam;
            this.achternaam = achternaam;
            this.klas = klas;
            this.room = room;
        }

        public Student(int studentnummer, string voornaam, string achternaam, int telefoonnummer, string klas, Room room) : this(studentnummer, voornaam, achternaam, klas, room) {
            this.telefoonnummer = telefoonnummer;
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() != typeof(Student)) return false;

            Student otherStudent = (Student)obj;

            return this.studentnummer==otherStudent.studentnummer;
        }
    }
}