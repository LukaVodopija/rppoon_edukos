using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edukos_zadaca1
{
	public class Korisnik : Osoba, IBankovniracun
	{
		public double Stanje;
		public Korisnik(string ime, string prezime,double brojRacuna, double stanje) : base(ime, prezime,brojRacuna)
		{
			
			Stanje = stanje;
		}
		public void Uplata(double iznos)
		{
			Stanje += iznos;
		}
		public void Isplata(double iznos)
		{
			if(Stanje < iznos)
			{
				Console.WriteLine("nema dovoljno novaca na racunu");
			}
			else { Stanje -= iznos; }
			
		}
		public double StanjeRacuna()
		{
			return Stanje;
		}
	}
}
