/*
 * Created by SharpDevelop.
 * User: Aluno_Manha
 * Date: 04/02/2025
 * Time: 08:12
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
			Console.Write("Voce possui diploma de ensino superior?");
			string diploma = Console.ReadLine();
			Console.Write("Quantos anos voce tem? ");
			int idade = int.Parse((Console.ReadLine()));
			
			if(diploma.ToLower() == "sim" && idade >= 21){
				Console.WriteLine("Parabéns, você esta qualificado para a vaga!");
			}
			
			Console.ReadKey();
			
		}
	}
}