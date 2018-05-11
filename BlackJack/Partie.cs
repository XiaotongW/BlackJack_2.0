﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
	public class Partie
	{
		Joueurs[] TJoueur;
		Paquet paquet;//paquet
		PartieForm formPartie;
		int JoueurTour;
		public delegate void RecevoirNom(string nomJoueur);
		public RecevoirNom NomJoueur;

		public Partie(int nbJoueur, int nbPaquet, int Min, int Max, int ArgentDebut) // Constructeur pour host
		{
			JoueurTour = 1;
			this.Min = Min;
			this.Max = Max;
			TJoueur = new Joueurs[nbJoueur];
			// Initier l'argent des joueurs
			for (int ID_J = 0; ID_J < nbJoueur; ID_J++)
				TJoueur[ID_J].Argent = ArgentDebut;
			paquet = new Paquet(nbPaquet);
			formPartie = new PartieForm(this);
			formPartie.Show();
		}
		public int Min
		{
			get;
			set;
		}		
		public int Max
		{
			get;
			set;
		}
		public Partie()//Counstrusteur pour client
		{
			TJoueur = new Joueurs[4];
			for (int i=0; i < 4; i++)
			{
				TJoueur[i] = null;
			}
			JoueurTour = 1;
			formPartie = new PartieForm(this);
			formPartie.Show();
		}
		public Joueurs this[int ID]
		{
			get { return TJoueur[ID]; }
		}
		public void RecevoirNomJoueur(string Nom)
		{
			//IDJoueur;Nom Joueur
			string[] nomJoueur = Nom.Split(new char[1] { ';' });
			TJoueur[int.Parse(nomJoueur[0])].Nom = nomJoueur[1];
		}
		public void distribuerInfo(int IDReception, string message)
		{
			int Next;
			Next = IDReception-1;
			do
			{
				if (Next >= 3)
					Next = 0;
				if (TJoueur[Next] != null)
					TJoueur[Next].netJoueur.envoyerMessage(message, IDReception);
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
