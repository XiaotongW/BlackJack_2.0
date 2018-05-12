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

    public partial class PartieForm : Form
    {
        Partie partie;
        ConnectionForm FormConnection;
        public PartieForm(Partie partie)
        {
            this.partie = partie;
            InitializeComponent();
            FormConnection = new ConnectionForm();
            FormConnection.Show();
            FormConnection.TopMost = true;
        }

        public void RecevoirNom(int ID, string Nom) //Recoit en parametre les noms de joueurs et les attributs au bon joueur
        {
            switch (ID)
            {
                case 1:
                    lb_Nom_J1.Text = Nom;
                    break;
                case 2:
                    lb_Nom_J2.Text = Nom;
                    break;
                case 3:
                    lb_Nom_J3.Text = Nom;
                    break;
                case 4:
                    lb_Nom_J4.Text = Nom;
                    break;
            } 
        }
        public void RecevoirArgent(int Argent)
        {
           lb_Argent.Text = Argent.ToString() + "$";      
        }
        public void RecevoirCarte(int ID, string Carte) //Recoit en paramètre une carte qui sera attribuer au bon joueur ou croupier
        {
            String[] CarteElement = Carte.Split(';'); //Séparer le contenue pour refaire la carte
            Cartes TempCarte = new Cartes(CarteElement[0], int.Parse(CarteElement[1])); //Creer une carte temporaire
            Bitmap imageCarte = (Bitmap)RessImages.ResourceManager.GetObject(TempCarte.imgCarte); //Prend l'image lier à la carte
            switch (ID)
            {
                case 1:
                    RecevoirCarteJ1(imageCarte); 
                    break;
                case 2:
                    RecevoirCarteJ2(imageCarte);
                    break;
                case 3:
                    RecevoirCarteJ3(imageCarte);
                    break;
                case 4:
                    RecevoirCarteJ4(imageCarte);
                    break;
                case 5:
                    RecevoirCarteCroup(imageCarte);
                    break;
            }
        }
        private void RecevoirCarteJ1(Bitmap imageCarte) //Met l'image d'un carte obtenue au joueur 1
        {
            if (img_C1_J1.Visible == false)
            {
                img_C1_J1.Image = imageCarte;
                img_C1_J1.Visible = true;
            }
            else if (img_C2_J1.Visible == false)
            {
                img_C2_J1.Image = imageCarte;
                img_C2_J1.Visible = true;
            }
            else if (img_C3_J1.Visible == false)
            {
                img_C3_J1.Image = imageCarte;
                img_C3_J1.Visible = true;
            }
            else if (img_C4_J1.Visible == false)
            {
                img_C4_J1.Image = imageCarte;
                img_C4_J1.Visible = true;
            }
            else if (img_C5_J1.Visible == false)
            {
                img_C5_J1.Image = imageCarte;
                img_C5_J1.Visible = true;
            }
        }
        private void RecevoirCarteJ2(Bitmap imageCarte)//Met l'image d'un carte obtenue au joueur 2
        {
            if (img_C1_J2.Visible == false)
            {
                img_C1_J2.Image = imageCarte;
                img_C1_J2.Visible = true;
            }
            else if (img_C2_J2.Visible == false)
            {
                img_C2_J2.Image = imageCarte;
                img_C2_J2.Visible = true;
            }
            else if (img_C3_J2.Visible == false)
            {
                img_C3_J2.Image = imageCarte;
                img_C3_J2.Visible = true;
            }
            else if (img_C4_J2.Visible == false)
            {
                img_C4_J2.Image = imageCarte;
                img_C4_J2.Visible = true;
            }
            else if (img_C5_J2.Visible == false)
            {
                img_C5_J2.Image = imageCarte;
                img_C5_J2.Visible = true;
            }
        }
        private void RecevoirCarteJ3(Bitmap imageCarte)//Met l'image d'un carte obtenue au joueur 3
        {
            if (img_C1_J3.Visible == false)
            {
                img_C1_J3.Image = imageCarte;
                img_C1_J3.Visible = true;
            }
            else if (img_C2_J3.Visible == false)
            {
                img_C2_J3.Image = imageCarte;
                img_C2_J3.Visible = true;
            }
            else if (img_C3_J3.Visible == false)
            {
                img_C3_J3.Image = imageCarte;
                img_C3_J3.Visible = true;
            }
            else if (img_C4_J3.Visible == false)
            {
                img_C4_J3.Image = imageCarte;
                img_C4_J3.Visible = true;
            }
            else if (img_C5_J3.Visible == false)
            {
                img_C5_J3.Image = imageCarte;
                img_C5_J3.Visible = true;
            }
        }
        private void RecevoirCarteJ4(Bitmap imageCarte)//Met l'image d'un carte obtenue au joueur 4
        {
            if (img_C1_J4.Visible == false)
            {
                img_C1_J4.Image = imageCarte;
                img_C1_J4.Visible = true;
            }
            else if (img_C2_J4.Visible == false)
            {
                img_C2_J4.Image = imageCarte;
                img_C2_J4.Visible = true;
            }
            else if (img_C3_J4.Visible == false)
            {
                img_C3_J4.Image = imageCarte;
                img_C3_J4.Visible = true;
            }
            else if (img_C4_J4.Visible == false)
            {
                img_C4_J4.Image = imageCarte;
                img_C4_J4.Visible = true;
            }
            else if (img_C5_J4.Visible == false)
            {
                img_C5_J4.Image = imageCarte;
                img_C5_J4.Visible = true;
            }
        }
        private void RecevoirCarteCroup(Bitmap imageCarte)//Met l'image d'un carte obtenue au croupier
        {
            if (img_C1_C.Visible == false)
            {
                img_C1_C.Image = imageCarte;
                img_C1_C.Visible = true;
            }
            else if (img_C2_C.Visible == false)
            {
                img_C2_C.Image = imageCarte;
                img_C2_C.Visible = true;
            }
            else if (img_C3_C.Visible == false)
            {
                img_C3_C.Image = imageCarte;
                img_C3_C.Visible = true;
            }
            else if (img_C4_C.Visible == false)
            {
                img_C4_C.Image = imageCarte;
                img_C4_C.Visible = true;
            }
            else if (img_C5_C.Visible == false)
            {
                img_C5_C.Image = imageCarte;
                img_C5_C.Visible = true;
            }
        }
        public void RecevoirMise(int ID, int Mise) // affiche la mise d'un joueur
        {
            switch (ID)
            {
                case 1://joueur 1
                    lb_Nom_J1.Text = Mise.ToString();
                    break;
                case 2://joueur 2
                    lb_Nom_J2.Text = Mise.ToString();
                    break;
                case 3://joueur 3
                    lb_Nom_J3.Text = Mise.ToString();
                    break;
                case 4://joueur 4
                    lb_Nom_J4.Text = Mise.ToString();
                    break;
            }
        }
    }
}

