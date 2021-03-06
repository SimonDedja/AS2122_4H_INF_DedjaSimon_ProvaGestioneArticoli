namespace AS2122_4H_INF_Prof_ProvaGestioneArticoli
{
    public class Articolo
    {
        // [8]
        int codice;
        string descrizione;
        string unitaMisura;
        double prezzo;

        // [9]
        public int Codice { get => codice; }
        public string Descrizione { get => descrizione; }
        public string UnitaMisura { get => unitaMisura; }
        public double Prezzo { get => prezzo; }

        public Articolo(int codice, string descrizione, string unitaMisura, double prezzo)
        {
            // [10]
            this.codice = codice;
            this.descrizione = descrizione;
            this.unitaMisura = unitaMisura;
            this.prezzo = prezzo;
        }

        public string Visualizzati()
        {
            return $"{descrizione} {unitaMisura} {prezzo} ({codice})";
        }

        public override string ToString()
        {
            return Descrizione;
        }
    }
}