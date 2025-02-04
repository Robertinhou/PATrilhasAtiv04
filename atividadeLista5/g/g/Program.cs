/*
 * Created by SharpDevelop.
 * User: Aluno_Manha
 * Date: 04/02/2025
 * Time: 08:46
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace g
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Digite um número: ");
			
			int num = int.Parse(Console.ReadLine());
			
			string check = (num > 0 ) ? ("É postivo!") : ("É negativo!");
			
			check = (num == 0 ) ? ("É nulo!") : (check);
			Console.WriteLine(check);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}