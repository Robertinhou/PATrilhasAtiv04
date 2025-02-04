/*
 * Created by SharpDevelop.
 * User: Aluno_Manha
 * Date: 04/02/2025
 * Time: 08:02
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace b
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Deseja comprar o CIVIC 2025?");
			
			string escolha = Console.ReadLine();
			
			if (escolha.ToLower() == "sim"){
				Console.WriteLine("Você tem R$400.000?");
				string check = Console.ReadLine();
				
				if(check.ToLower() == "sim"){
					Console.WriteLine("Você pode comprar!");
				}
				
			}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}