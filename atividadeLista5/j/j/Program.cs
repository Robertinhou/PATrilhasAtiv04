/*
 * Created by SharpDevelop.
 * User: Aluno_Manha
 * Date: 04/02/2025
 * Time: 10:32
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace j
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Digite alguma coisa: ");
			
			string coisa = Console.ReadLine();
			
			Console.WriteLine( (coisa == null || coisa.Length == 0) ? ("Tá nulo!!!") : ("O valor é: "+ coisa) );
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}