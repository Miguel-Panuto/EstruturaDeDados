using System;
using System.Collections;

namespace Pilha
{
	class Program
	{
		static void Main(string[] args)
		{
			Stack myStacks = new Stack(); //Criação da pilha

			while (true) //Repetirá o loop até que a string seja nula ou em branco
			{
				string myString = Console.ReadLine(); //Pega o que foi escrito no console
				if (String.IsNullOrWhiteSpace(myString))
				{
					break;
				}

				myStacks.Push(myString); // Adiciona elementos na pilha

				Console.Clear();
			}

			Console.Clear();

			Console.WriteLine("\nNumero de elementos: " + myStacks.Count + "\n"); // Apenas para mostrar quantos elementos há na pilha

			while (myStacks.Count > 0)
			{
				Console.WriteLine(myStacks.Pop());

				//pop exclui os elementos da fila e retorna a string do último elemento adicionado

			}

			Console.WriteLine("\nNumero de elementos: " + myStacks.Count + "\n");
		}
	}
}
