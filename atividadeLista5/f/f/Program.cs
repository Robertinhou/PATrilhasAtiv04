/*
 * Created by SharpDevelop.
 * User: Aluno_Manha
 * Date: 04/02/2025
 * Time: 08:59
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace f
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Digite um número: ");
			
			float num = float.Parse(Console.ReadLine());

			Console.WriteLine(Math.Abs(num));
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}