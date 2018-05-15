using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack
{
   public partial class MenuPartie : Form
   {
        MenuOption FormOption;
      public MenuPartie()
      {
         InitializeComponent();
            FormOption = new MenuOption();
      }

        private void btnCreer_Click(object sender, EventArgs e)
        {
            lblNom.Visible = false;
            txtNom.Visible = false;
            btnCreer.Visible = false;
            btnRejoindre.Visible = false;
            cmbJoueur.Visible = true;
            btnHeberger.Visible = true;
            btnOption.Visible = true;
            btnRetour.Visible = true;
        }

        private void btnHeberger_Click(object sender, EventArgs e)
        {
			if (txtNom.Text != "")
			{
				Partie laPartie = new Partie(txtNom.Text, cmbJoueur.SelectedIndex+1,FormOption.NbPaquet,FormOption.MiseMin,FormOption.MiseMax, FormOption.Argent);
				FormOption.Close();
			}
        }

        private void btnRejoindre_Click(object sender, EventArgs e)
        {
            lblNom.Visible = false;
            txtNom.Visible = false;
            btnCreer.Visible = false;
            btnRejoindre.Visible = false;
            txtIP.Visible = true;
            btnConnection.Visible = true;
            btnRetour.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblNom.Visible = true;
            txtNom.Visible = true;
            btnCreer.Visible = true;
            btnRejoindre.Visible = true;
            cmbJoueur.Visible = false;
            btnHeberger.Visible = false;
            btnRetour.Visible = false;
            btnConnection.Visible = false;
            txtIP.Visible = false;
            btnOption.Visible = false;
            
        }

        private void btnOption_Click(object sender, EventArgs e)
        {
            FormOption.Show();
        }

		private void btnConnection_MouseClick(object sender, MouseEventArgs e)
		{
			if (txtNom.Text != "" && txtIP.Text != "")
			{
				Partie laPartie = new Partie(txtNom.Text, txtIP.Text);
			}
		}
	}
}
