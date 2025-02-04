/*
 * Created by SharpDevelop.
 * User: Aluno_Manha
 * Date: 04/02/2025
 * Time: 09:19
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace h
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			
			Console.WriteLine("Digite uma palavra: ");
			
			string palavra = Console.ReadLine();
			
			int check = (palavra.Length > 0) ? (palavra.Length) : (palavra.Length);
			
			Console.WriteLine(check);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}