﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
   public class Main
   {
        List<Cartes> listCarte;
        public Main()
        {
            listCarte = new List<Cartes>();
        }
		public Cartes this[int ind] 
		{
			get { return listCarte.ElementAt(ind); }
		}
		public int NbrCartes
		{
			get { return listCarte.Count; }
		}
        public void ajouterCarte(int figure, string type)
        {
            if (listCarte.Count < 5)
                listCarte.Add(new Cartes(type,figure,calculerSomme()));
            
        }
        public int calculerSomme()
        {
                int somme = 0;
                for (int i= 0; i < listCarte.Count; i++)
                {
                    somme = listCarte.ElementAt(i).Valeur;
                }
            return somme;
        }

        public void resetMain()
        {
			// Supprime toutes les cartes
            listCarte.Clear();
        }
   }
}
