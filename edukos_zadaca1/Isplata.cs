﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edukos_zadaca1
{
	public class Isplata : Transakcija
	{
		public Isplata(IBankovniracun racun, double iznos) : base(racun, null, iznos) { }
		public override void IzvrsiTransakciju()
		{
			racun1.Isplata(iznos);
		}

	}
}
