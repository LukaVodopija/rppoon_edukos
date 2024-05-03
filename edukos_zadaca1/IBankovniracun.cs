using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edukos_zadaca1
{
	public interface IBankovniracun
	{
		public void Uplata(double iznos);
		public void Isplata(double iznos);
		public double StanjeRacuna();
	}
}
 