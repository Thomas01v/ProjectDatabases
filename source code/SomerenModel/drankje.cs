namespace SomerenModel {
    public class Drankje 
    {
        public Drankje()
        {
        }

        public int dranknummer { get; set; }

        public string dranknaam { get; set; }

        public int inkoop {  get; set; }

        public int voorraad { get; set; }

        public double btw { get; set; }

        public decimal aankoopprijs { get; set; }

        public decimal verkoopprijs { get; set; }

        public string type 
        {
            get
            {
                if (btw == 21)
                {
                    return "alcoholisch";
                }
                else
                {
                    return "niet alcoholisch";
                }
            }
        }

        public Drankje(int dranknummer, string dranknaam, int inkoop, double btw, decimal aankoopprijs, decimal verkoopprijs)
        {
            this.dranknummer = dranknummer;
            this.dranknaam = dranknaam;
            this.inkoop = inkoop;
            this.btw = btw;
            this.aankoopprijs = aankoopprijs;
            this.verkoopprijs = verkoopprijs;
        }
    }
}
