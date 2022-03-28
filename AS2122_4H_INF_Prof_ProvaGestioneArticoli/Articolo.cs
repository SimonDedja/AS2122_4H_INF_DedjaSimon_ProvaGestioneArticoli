namespace AS2122_4H_INF_Prof_ProvaGestioneArticoli
{
    public class Articolo
    {
        int codice;
        string descrizione;
        string unitaMisura;
        double prezzo;

        public int Codice { get => codice; }
        public string Descrizione { get => descrizione; }
        public string UnitaMisura { get => unitaMisura; }
        public double Prezzo { get => prezzo; }

        public Articolo(int codice, string descrizione, string unitaMisura, double prezzo)
        {
            this.codice = codice;
            this.descrizione = descrizione;
            this.unitaMisura = unitaMisura;
            this.prezzo = prezzo;
        }

        public string Visualizzati()
        {
            return $"{descrizione} {unitaMisura} {prezzo} ({codice})";
        }
    }
}