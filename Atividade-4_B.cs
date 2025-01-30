using System;

namespace att01
{
	class Program
	{
		public static void Main()
		{	
			Console.Write("Deseja comprar um carro novo? SIM ou NAO: ");
			string comprar = Console.ReadLine().ToLower();
			
			Console.Write("Voçê possui dinheiro suficiente?: ");
			string dinheiro = Console.ReadLine().ToLower();
			

			if (comprar == "sim" && dinheiro == "sim") {
				Console.WriteLine("\r\nParabéns, você pode comprar um carro novo!");
			}
			else if (comprar == "sim" && dinheiro != "sim"){
				Console.WriteLine("\r\nInfelizmente você não pode comprar um carro novo!");
			}
			else {
				Console.WriteLine("\r\nVoçê não quer comprar um carro!");
			}
			
			Console.WriteLine("\r\nAperte qualquer tecla para continuar...");
			Console.ReadKey(true);
		}
	}
}
