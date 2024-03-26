namespace SomerenModel {
    public class Drankje 
    {

        public int dranknummer { get; init; }

        public string dranknaam { get; init; }

        public int inkoop {  get; init; }

        public int voorraad { get; init; }

        public double btw { get; init; }

        public decimal aankoopprijs { get; init; }

        public decimal verkoopprijs { get; init; }

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

        public Drankje(int dranknummer, string dranknaam, int inkoop, int voorraad, double btw, decimal aankoopprijs, decimal verkoopprijs)
        {
            this.dranknummer = dranknummer;
            this.dranknaam = dranknaam;
            this.inkoop = inkoop;
            this.voorraad = voorraad;
            this.btw = btw;
            this.aankoopprijs = aankoopprijs;
            this.verkoopprijs = verkoopprijs;
        }
    }
}
