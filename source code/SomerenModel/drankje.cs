namespace SomerenModel {
    public class Drankje 
    {
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
                if (btw == 0.21)
                {
                    return "alcoholisch";
                }
                else
                {
                    return "niet alcoholisch";
                }
            }
        }
    }
}
