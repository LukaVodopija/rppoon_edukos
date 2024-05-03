using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edukos_zadaca1
{
	public class Banka
	{
		List<Korisnik> korisnici=new List<Korisnik>();
		public void DodajKorisnika(Korisnik korisnik)
		{
			korisnici.Add(korisnik);
		}
		public void IzvrsiTransakciju(Transakcija transakcija)
		{
			transakcija.IzvrsiTransakciju();
		}
	}
}
