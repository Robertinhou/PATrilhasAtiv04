/*
 * Created by SharpDevelop.
 * User: Aluno_Manha
 * Date: 04/02/2025
 * Time: 08:23
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
			Console.WriteLine("Digite um número: ");
			
			double num = double.Parse(Console.ReadLine());
			
			Console.WriteLine("Digite outro número: ");
			
			double segundoNum = double.Parse(Console.ReadLine());
			
			string print = (num > segundoNum) ? (num+ " é maior") : (segundoNum+ " é maior");
			
			Console.WriteLine(print);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}