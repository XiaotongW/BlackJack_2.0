using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
	public class Partie
	{
		Joueurs[] TJoueur;
		Joueurs unJoueur;
		Paquet paquet;//paquet
		PartieForm formPartie;
		int JoueurTour;
		public delegate void RecevoirNom(string nomJoueur);
		public RecevoirNom NomJoueur;

		public Partie(string nom, int nbJoueur, int nbPaquet, int Min, int Max, int ArgentDebut) // Constructeur pour host
		{
			JoueurTour = 1;
			this.Min = Min;
			this.Max = Max;
			TJoueur = new Joueurs[nbJoueur];
			unJoueur = new Joueurs(nom, nbJoueur);
			TJoueur[0] = unJoueur;
			paquet = new Paquet(nbPaquet);
			formPartie = new PartieForm(this);
			formPartie.Show();
			for (int i = 1; i <= nbJoueur-1; i++)
			{
				TJoueur[i] = new Joueurs("");
				TJoueur[i].ID = i;
				RecevoirNomJoueur(unJoueur.Network.recevoirMessage(i+1));
			}
			for (int i = nbJoueur-1; i >0 ; i--)
			{
				distribuerInfo(TJoueur[i].ID,TJoueur[i].Nom);
			}

		}
		public Partie(string nom, string IpAddrs)//Counstrusteur pour client
		{
			TJoueur = new Joueurs[4];
			for (int i = 0; i < 4; i++)
			{
				TJoueur[i] = null;
			}
			unJoueur = new Joueurs(nom);
			unJoueur.JoindrePartie(IpAddrs);
			TJoueur[unJoueur.ID] = unJoueur;
			JoueurTour = 1;
			formPartie = new PartieForm(this);
			formPartie.Show();
			unJoueur.envoyerNom();
			String[] tmpMessage;
			for (int i = 0; i < TJoueur.Count(); i++)
			{
				tmpMessage = unJoueur.Network.recevoirMessage().Split(new char[1] { ';' });
				TJoueur[int.Parse(tmpMessage[0])] = new Joueurs("");
				if (i != unJoueur.ID && TJoueur[i] != null)
					RecevoirNomJoueur(FormatMessage(int.Parse(tmpMessage[0]), tmpMessage[1]));
			}
			
		}
		public int Min
		{
			// Mise Minimal
			get;
			set;
		}
		public int Max
		{
			//Mise Maximal
			get;
			set;
		}
		public Joueurs this[int ID]
		{
			get { return TJoueur[ID]; }
		}
		public string FormatMessage(int IDJoueur, string message)
		{
			return string.Format("{0};{1}", IDJoueur, message);
		}
		public void RecevoirNomJoueur(string Nom)
		{
			//IDJoueur;Nom Joueur
			string[] nomJoueur = Nom.Split(new char[1] { ';' });
			TJoueur[int.Parse(nomJoueur[0]) - 1].Nom = nomJoueur[1];
		}

		public void EnvoyerTous(string message)
		{
			//Envoi un message à tous les joueurs
			for (int i = 1; i < TJoueur.Count(); i++)
			{
				unJoueur.Network.envoyerMessage(message, TJoueur[i].ID);
			}
		}

		public void distribuerInfo(int IDReception, string message)
		{
			// Envoie les information à tous les autres joueurs (serv)
			int Next;
			Next = IDReception - 1;
			do
			{
				if (Next >= 3)
					Next = 0;
				try
				{
					if (TJoueur[Next] != null)
						unJoueur.Network.envoyerMessage(FormatMessage(IDReception,message));
				}
				catch {}
				Next++;
			} while (Next != IDReception);
		}
		public void RecevoirCarte(string carteRecut)
		{
			string[] infoCarte; // message : IDJoueur;figureCarte;typeCarte
			infoCarte = carteRecut.Split(new char[1] { ';' });
			TJoueur[int.Parse(infoCarte[0])].Main.ajouterCarte(int.Parse(infoCarte[1]), infoCarte[2]);
		}
	}
}
