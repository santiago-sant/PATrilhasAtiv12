using System;

namespace santisssimo
{
	class Program
	{
		public static void Main(string[] args)
		{
			int [] numero =  { 1 ,12 ,3 ,4 ,45};
			
			foreach (int numeros in numero) {
			         	Console.Write(numeros + " ");
			         }
			Console.WriteLine();
	
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
