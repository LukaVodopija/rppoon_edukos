using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace edukos_zadaca1
{
	public abstract class Osoba
	{
		public string ime;
		public string prezime;
		public double brojRacuna;

		public Osoba(string ime, string prezime, double brojRacuna)
		{
			this.ime = ime;
			this.prezime = prezime;
			this.brojRacuna = brojRacuna;
		}
	}
}
