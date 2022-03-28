using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AS2122_4H_INF_Prof_ProvaGestioneArticoli
{
    public partial class frmMain : Form
    {
        List<Articolo> articoli;

        public frmMain()
        {
            InitializeComponent();

            // [4] istanzio la lista di articoli
            articoli = new();
        }

        private void btnAggiungiArticolo_Click(object sender, EventArgs e)
        {
            frmArticolo f = new frmArticolo(articoli.Count);

            f.ShowDialog();

            if (f.Status == DialogResult.OK)
            {
                // [1] aggiungi l'articolo all'elenco di articoli
                articoli.Add(f.Articolo);
                
                lblArticoliInseriti.Text = $"Articoli ({articoli.Count})";
            }
        }

        private void btnVisualizza_Click(object sender, EventArgs e)
        {
            lstElenco.Items.Clear();
            switch (cmbVisualizza.Text)
            {
                case "Visualizza articoli":

                    // [2]
                    foreach (var articolo in articoli)
                        lstElenco.Items.Add(articolo);

                    break;
            }
        }

        private void lstElenco_SelectedIndexChanged(object sender, EventArgs e)
        {
            string curItem = lstElenco.SelectedItem.ToString();

            // Find the string in ListBox.
            int index = lstElenco.FindString(curItem);

            // [3] Modifico il testo di lblDescrizione
            lblDescrizione.Text = articoli[index].Descrizione;
            lblUnitaMisura.Text = articoli[index].UnitaMisura;
            lblPrezzo.Text = articoli[index].Prezzo.ToString();
        }
    }
}