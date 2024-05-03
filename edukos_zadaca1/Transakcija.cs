using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edukos_zadaca1
{
	public abstract class Transakcija : ITransakcija
	{
		public double iznos;
		public IBankovniracun racun1;
		public IBankovniracun racun2;
		//public DateTime datum;

		public Transakcija(IBankovniracun racun1,IBankovniracun racun2, double iznos)
		{
			this.racun1 = racun1;
			this.racun2 = racun2;
			this.iznos = iznos;
		}
		public abstract void IzvrsiTransakciju();
	}
}
