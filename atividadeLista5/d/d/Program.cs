﻿/*
 * Created by SharpDevelop.
 * User: Aluno_Manha
 * Date: 04/02/2025
 * Time: 08:34
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace d
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Digite uma palavra: ");
			
			string palavra = Console.ReadLine();
			
			string check = (palavra.Length == 0) ? ("Digite algo, está vazio!") : ("Obrigado! A palavra é: "+ palavra);
			
			Console.WriteLine(check);
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}