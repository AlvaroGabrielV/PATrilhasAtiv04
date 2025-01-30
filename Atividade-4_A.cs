using System;

namespace att01
{
	class Program
	{
		public static void Main()
		{	
			Console.Write("Qual a sua idade: ");
			int idade = int.Parse(Console.ReadLine());
			
			Console.Write("Voçê possui carteira de habilitaçâo: ");
			string carteira = Console.ReadLine().ToLower();
			

			if (idade >= 18 && carteira == "sim") {
				Console.WriteLine("\r\nVoçê pode dirigir!");
			}
			else if (idade >= 18 && carteira != "sim"){
				Console.WriteLine("\r\nVoçê nao pode dirigir!");
			}
			else {
				Console.WriteLine("\r\nVoçê não tem idade para dirigir!");
			}
			
			Console.WriteLine("\r\nAperte qualquer tecla para continuar...");
			Console.ReadKey(true);
		}
	}
}
