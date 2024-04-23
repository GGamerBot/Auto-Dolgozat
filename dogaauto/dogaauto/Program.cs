using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dogaauto
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Autosalon autosalon = new Autosalon();

			Szemelyauto toyotaCorolla = new Szemelyauto("Toyota", "Corolla", 2021, 800);
		}
	}
}