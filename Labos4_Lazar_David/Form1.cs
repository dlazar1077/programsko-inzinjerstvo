using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labos4_Lazar_David
{
    public partial class Form1 : Form
    {
        public static string ispisiMe = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnUnesi_Click(object sender, EventArgs e)
        {
            int ocjena = Convert.ToInt32(TxtOcjena.Text);
            string nazivKolegija = TxtNaziv.Text;
            Kolegij noviKolegij = new Kolegij(nazivKolegija, ocjena);
            ispisiMe += noviKolegij.NazivKolegija + " - " + noviKolegij.ProsjecnaOcjena + Environment.NewLine;
            TxtIspisSvih.Text = ispisiMe;
        }

        private void ProvjeraIspisa_Tick(object sender, EventArgs e)
        {
            if(TxtIspisSvih.Lines.Length > 1)
            {
                List < Kolegij > sortiranaLista = new List<Kolegij>();
                sortiranaLista = Kolegij.SviKolegiji.OrderBy(x => x.ProsjecnaOcjena).ToList();
                string ispisKolegija = "";
                ispisKolegija = "Najlosoji: " + sortiranaLista.First().NazivKolegija + " - " + sortiranaLista.First().ProsjecnaOcjena + Environment.NewLine;
                ispisKolegija +="Najbolji: " + sortiranaLista.Last().NazivKolegija + " - " + sortiranaLista.Last().ProsjecnaOcjena + Environment.NewLine;
                TxtIspisNaj.Text = ispisKolegija;

            }
        }

        private void TxtIspisSvih_TextChanged(object sender, EventArgs e)
        {
            ProvjeraIspisa.Enabled = true;
        }
    }
}
