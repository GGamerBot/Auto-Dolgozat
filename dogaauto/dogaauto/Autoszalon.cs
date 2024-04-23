using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dogaauto
{
	internal class Autosalon
	{
		class Autoszalon
		{
			public List<Jarmu> Jarmuvek { get; set; }

			public Autoszalon()
			{
				Jarmuvek = new List<Jarmu>();
			}

			public void UjJarmuHozzaadasa(Jarmu jarmu)
			{
				Jarmuvek.Add(jarmu);
			}

			public bool JarmuEladasa(string gyarto, string modell)
			{
				Jarmu eladando = Jarmuvek.Find(j => j.Gyarto == gyarto && j.Modell == modell);
				if (eladando != null)
				{
					Jarmuvek.Remove(eladando);
					Console.WriteLine("A jármű eladva.");
					return true;
				}
				else
				{
					Console.WriteLine("A jármű nem található.");
					return false;
				}
			}

			public Jarmu JarmuKeresese(string gyarto, string modell)
			{
				return Jarmuvek.Find(j => j.Gyarto == gyarto && j.Modell == modell);
			}

			public void JarmuvekListazasa()
			{
				foreach (Jarmu j in Jarmuvek)
				{
					j.JarmuInfo();
				}
			}

			public void EladasokJelentes()
			{
				Console.WriteLine("Eladási statisztikák:");
			}
		}
	}
}