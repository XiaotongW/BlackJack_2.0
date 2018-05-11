﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
	public class Cartes
	{
		string type; // Coeur, Carreaux, Trefle, Pique
		int figure; // 2..10, J = 11, Q = 12, K = 13, As = 1 ou 11
		int valeur; // 1..11
		public Cartes(string type, int figure)
		{

			this.type = type;
			this.figure = figure;
			valeur = calcValeur();
		}
		public Cartes(string type, int figure, int sommeCartes)
		{
			this.type = type;
			this.figure = figure;
			valeur = (figure == 1 && (sommeCartes + 11) > 21) ? calcValeur() : 11;
		}
		public Cartes(int valeur)
		{
			type = null;
			figure = 0;
			this.valeur = valeur;
		}

		public string imgCarte
		{
			get { return string.Format("{0}_{1}.png", figure, type); }
		}

		public string Type
		{
			get { return type; }
		}

		public int Valeur
		{
			get { return valeur; }
		}

		public static Cartes operator +(Cartes carte1, Cartes carte2)
		{
			return new Cartes(carte1.valeur + carte2.valeur);
		}

		private int calcValeur()
		{
			// Retourne la valeur de la carte selons sont type
			if (figure > 10)
			{
				return 10;
			}
			else if (figure == 1)
			{
				return 11;
			}
			return figure;
		}
	}
}
