/*
 * Created by SharpDevelop.
 * User: Aluno_Manha
 * Date: 04/02/2025
 * Time: 08:27
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace c
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			int[] numeros = {};
			
			string print = (numeros.Length == 0) ? ("A lista é vazia!") : ("Não está vazia");
			
			Console.WriteLine(print);
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}