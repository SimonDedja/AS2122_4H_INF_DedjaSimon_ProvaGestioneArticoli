using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS2122_4H_INF_Prof_ProvaGestioneArticoli
{
    public class Articolo
    {
        static int codice;
        string descrizione;
        string unitaMisura;
        double prezzo;

        public int Codice { get => codice; }
        public string Descrizione { get => descrizione; }
        public string UnitaMisura { get => unitaMisura; }
        public double Prezzo { get => prezzo; }

        public Articolo(int codice, string descrizione, string unitaMisura, double prezzo)
        {
            // TODO: (10) impostazione costruttore classe Articolo come utilizzato da frmMain
            // ...
        }

        public string Visualizzati()
        {
            return $"{descrizione} {unitaMisura} {prezzo} ({codice})";
        }
    }
}