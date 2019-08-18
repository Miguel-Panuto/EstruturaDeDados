using System;
using System.Collections;

namespace Pilha
{
	class Program
	{
		static void Main(string[] args)
		{
			Stack myStacks = new Stack();

			while (true)
			{
				string miguel = Console.ReadLine();
				if (String.IsNullOrWhiteSpace(miguel))
					break;

				myStacks.Push(miguel);

				Console.Clear();
			}

			Console.Clear();

			Console.WriteLine("\nNumero de elementos: " + myStacks.Count + "\n");

			while (myStacks.Count > 0)
			{
				Console.WriteLine(myStacks.Pop());

				//pop exclui os elementos da fila

			}

			Console.WriteLine("\nNumero de elementos: " + myStacks.Count + "\n");
		}
	}
}
