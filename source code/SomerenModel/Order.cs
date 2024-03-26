using System;

namespace SomerenModel {
    public class Order {
        public int ordernummer { get; init; }
        public Drankje drankje { get; init; }
        public Student student { get; init; }
        public int aantal { get; init; }
        public DateTime datum { get; init; }

        public Order(int ordernummer, Drankje drankje, Student student, int aantal, DateTime datum) { 
            this.ordernummer = ordernummer;
            this.drankje = drankje;
            this.student = student;
            this.aantal = aantal;
            this.datum = datum;
        }
    }
}
