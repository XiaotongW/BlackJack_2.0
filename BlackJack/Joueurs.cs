using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace BlackJack
{
	public class Joueurs
	{
		public Joueurs(string nom, int nbrJoueur)
		{
			// Joueur local
			Nom = nom;
			Main = new Main();
			Network = new Net(nbrJoueur);
		}
		public Joueurs(string nom, string IPAddrs)
		{
			// Joueurs Client 
			Nom = nom;
			Network = new Net(IPAddrs);
		}
		public string Nom
		{
			get;
			set;
		}

		public int ID
		{
			get { return Network.ID; }
		}

		public bool IsHost
		{
			get;
			set;
		}

		public Net Network
		{
			get;
			private set;
		}

		public Main Main
		{
			get;
			private set;
		}

		public int Argent
		{
			get;
			set;
		}

		public void JoindrePartie(string IPJoin)
		{
			new Thread(() => creeConnection(IPJoin));
		}

		private void creeConnection(string IPJoin)
		{
			Network = new Net(IPJoin);
		}
	}
}
