using System;
using System.Collections.Generic;

namespace santisssimo
{
	class Program
	{
		public static void Main(string[] args)
		{
			  List<int> numero = new List<int> { 12, 45, 78, 23, 56, 89};

			  int maior = numero[0];
			  
			foreach (int numeros in numero) {
			  
			  	if (numeros > maior)
			  	{
			  		maior = numeros;
			  	}
			  }
			
			
			Console.WriteLine("O maior número da lista é :" + maior);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
