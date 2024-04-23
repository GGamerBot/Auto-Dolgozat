using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dogaauto
{
	internal class Szemelyauto
	{
		class Szemelyautok : Jarmu
		{
			public int UlesekSzama { get; set; }
			public double Fogyasztas { get; set; }
			public string Szin { get; set; }
			public string Allapot { get; set; }

			public Szemelyautok(string gyarto, string modell, int evjarat, int alapAr, int kilometeroraAllas, int ulesekSzama, double fogyasztas, string szin)
				: base(gyarto, modell, evjarat, alapAr, kilometeroraAllas)
			{
				UlesekSzama = ulesekSzama;
				Fogyasztas = fogyasztas;
				Szin = szin;
				Allapot = allapot;
			}

			public void KenyelmiExtraBeszerzese(string extra)
			{
				Console.WriteLine($"Hozzáadott extra: {extra}");
				AlapAr += 50000;
			}

			public void SzinFrissitese(string ujSzin)
			{
				Szin = ujSzin;
			}
		}
	}
}
