namespace edukos_zadaca1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Banka banka = new Banka();

			Korisnik korisnik1 = new Korisnik("Luka", "Vodopija", 123456789, 1000);
			Korisnik korisnik2 = new Korisnik("Marko", "Markovic", 987654321, 500);

			banka.DodajKorisnika(korisnik1);
			banka.DodajKorisnika(korisnik2);

			Transakcija uplata = new Uplata(korisnik1, 100);
			banka.IzvrsiTransakciju(uplata);

			uplata = new Uplata(korisnik2, 10);
			banka.IzvrsiTransakciju(uplata);

			uplata = new Isplata(korisnik1, 1);
			banka.IzvrsiTransakciju(uplata);
			Console.WriteLine(korisnik1.StanjeRacuna());
			Console.WriteLine(korisnik2.StanjeRacuna());
		}
	}
}
