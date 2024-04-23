using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dogaauto
{
	internal class Terepjaro
	{
		class Terepjarok : Jarmu
		{
			public string Hajtas { get; set; }
			public bool OffroadKepessegek { get; set; }
			public int Vontatokepesseg { get; set; }

			public Terepjarok(string gyarto, string modell, int evjarat, int alapAr, int kilometeroraAllas, string hajtas, bool offroadKepessegek, int vontatokepesseg)
				: base(gyarto, modell, evjarat, alapAr, kilometeroraAllas)
			{
				Hajtas = hajtas;
				OffroadKepessegek = offroadKepessegek;
				Vontatokepesseg = vontatokepesseg;
			}

			public void OffroadCsomagFelszerel()
			{
				Console.WriteLine("Offroad csomag felszerelve.");
				AlapAr += 100000; 
				OffroadKepessegek = true;
			}

			public void VontatokepessegBeallitasa(int kepesseg)
			{
				Vontatokepesseg = kepesseg;
			}
		}
	}
}
