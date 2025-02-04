/*
 * Created by SharpDevelop.
 * User: Aluno_Manha
 * Date: 04/02/2025
 * Time: 10:08
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace i
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Digite um número: ");
			
			int num = int.Parse(Console.ReadLine());
			
			Console.WriteLine("Digite outro número: ");
			
			int numDois = int.Parse(Console.ReadLine());
			
			Console.WriteLine((num % numDois == 0 ) ? ("É divisível") : ("Não é divisível "));
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}