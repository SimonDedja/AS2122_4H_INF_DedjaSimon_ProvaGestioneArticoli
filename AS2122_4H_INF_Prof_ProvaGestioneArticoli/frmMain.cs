﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AS2122_4H_INF_Prof_ProvaGestioneArticoli
{
    public partial class frmMain : Form
    {
        List<Articolo> articoli;

        public frmMain()
        {
            InitializeComponent();

            // istanzio la lista di articoli
            articoli = new();
        }

        private void btnAggiungiArticolo_Click(object sender, EventArgs e)
        {
            frmArticolo f = new frmArticolo();

            f.ShowDialog();

            if (f.Status == DialogResult.OK)
            {
                // aggiungi l'articolo all'elenco di articoli
                frmArticolo frmArticolo = new();
                articoli.Add(frmArticolo.Articolo);
                
                lblArticoliInseriti.Text = $"Articoli ({articoli.Count})";
            }
        }

        private void btnVisualizza_Click(object sender, EventArgs e)
        {
            lstElenco.Items.Clear();
            switch (cmbVisualizza.Text)
            {
                case "Visualizza articoli":
                    lstElenco.DataSource = null;
                    lstElenco.DataSource = articoli;
                    lstElenco.DisplayMember = "Visualizzati";
                    break;
            }
        }

        private void lstElenco_SelectedIndexChanged(object sender, EventArgs e)
        {
            string curItem = lstElenco.SelectedItem.ToString();

            // Find the string in ListBox.
            int index = lstElenco.FindString(curItem);

            // Modifico il testo di lblDescrizione
            lblDescrizione.Text = articoli[index].Visualizzati();
        }
    }
}