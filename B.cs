using System;
using System.Collections.Generic;

namespace santisssimo
{
	class Program
	{
		public static void Main(string[] args)
		{
			  List<int> numero = new List<int> { 12, 45, 78, 23, 56, 89};

			foreach (int numeros in numero) {
			         	Console.Write(numeros + " ");
			         }
			Console.WriteLine();
	
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
