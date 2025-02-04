/*
 * Created by SharpDevelop.
 * User: Aluno_Manha
 * Date: 04/02/2025
 * Time: 08:18
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace a
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Digite um número: ");
			double num = double.Parse(Console.ReadLine());
			
			string print = (num % 2 == 0) ? ("É par") : ("É ímpar");
			
			Console.WriteLine(print);
			
			Console.ReadKey();
			
		}
	}
}