using System;
using System.Collections.Generic;

class Jarmu
{
	public string Gyarto { get; set; }
	public string Modell { get; set; }
	public int Evjarat { get; set; }
	public int AlapAr { get; set; }
	public int KilometeroraAllas { get; set; }

	public Jarmu(string gyarto, string modell, int evjarat, int alapAr, int kilometeroraAllas)
	{
		Gyarto = gyarto;
		Modell = modell;
		Evjarat = evjarat;
		AlapAr = alapAr;
		KilometeroraAllas = kilometeroraAllas;
	}

	public void JarmuInfo()
	{
		Console.WriteLine($"Gyártó: {Gyarto}, Modell: {Modell}, Évjárat: {Evjarat}");
	}

	public int ArKalkulacio()
	{

		return AlapAr - (DateTime.Now.Year - Evjarat) * 100000;
	}

	public void KmAllasFrissites(int km)
	{
		KilometeroraAllas += km;
	}
}