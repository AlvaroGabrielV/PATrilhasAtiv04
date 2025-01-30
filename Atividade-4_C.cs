using System;

namespace att01
{
	class Program
	{
		public static void Main()
		{	
			Console.Write("Voçê possui diploma de ENSINO SUPERIOR? SIM ou NAO: ");
			string diploma = Console.ReadLine().ToLower();
			
			Console.Write("Qual a sua idade?: ");
			int idade = int.Parse(Console.ReadLine());
			

			if (diploma == "sim" && idade >= 21) {
				Console.WriteLine("\r\nParabéns, você está qualificado para a vaga!");
			}
			else if (diploma == "sim" && idade < 21 || diploma != "sim" && idade >= 21 ){
				Console.WriteLine("\r\nInfelizmente você não está qualificado para a vaga!");
			}

			
			Console.WriteLine("\r\nAperte qualquer tecla para continuar...");
			Console.ReadKey(true);
		}
	}
}
