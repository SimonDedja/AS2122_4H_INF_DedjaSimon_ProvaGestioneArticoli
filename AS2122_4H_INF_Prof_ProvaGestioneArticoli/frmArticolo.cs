using System;
using System.Windows.Forms;

namespace AS2122_4H_INF_Prof_ProvaGestioneArticoli
{
    public partial class frmArticolo : Form
    {
        DialogResult status = DialogResult.Cancel;
        public DialogResult Status { get => status; }


        private int codice;
        private Articolo articolo;
        public Articolo Articolo { get => articolo; }


        public frmArticolo(int codice)
        {
            InitializeComponent();
            this.codice = codice;
        }


        private void btnSalva_Click(object sender, EventArgs e)
        {
            if (txtDescrizione.Text == "")
            {
                MessageBox.Show("Non é presente nessuna descrizione");
                return;
            }

            if (cmbUnitaMisura.SelectedItem == null)
            {
                MessageBox.Show("Nessuna unitá di misura selezioniata");
                return;
            }

            if (txtPrezzo.Text == "")
            {
                MessageBox.Show("Prezzo non impostato");
                return;
            }

            articolo = new Articolo(codice, txtDescrizione.Text, cmbUnitaMisura.Text, double.Parse(txtPrezzo.Text));

            status = DialogResult.OK;
            Close();
        }

        private void btnAnnulla_Click(object sender, EventArgs e)
        {
            status = DialogResult.Cancel;
            Close();
        }
    }
}
