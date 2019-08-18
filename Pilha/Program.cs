/*Criado por: Gabriel Pasqualini e Victor Reis
 * 
 * 18/08/2019 às 14:00
 */

using System;
using System.Collections;

namespace Pilha
{
	class Program
	{
		static void Main(string[] args)
		{
			Stack myStacks = new Stack(); //Criação da pilha
			int n = 1; //cria a variavel de Id

			while (true) //Repetirá o loop até que a string seja nula ou em branco
			{
				Console.WriteLine("Coloque o nome do Livro (Espaço em branco nulo para encerrar a entrada de dados.)");
				string myString = Console.ReadLine(); //Pega o que foi escrito no console

				if (String.IsNullOrWhiteSpace(myString)) //Cancela o lopping caso a string seja nula ou somente espaços em branco
				{
					break;
				}

				myStacks.Push(new Livro(myString, n)); // Adiciona elementos na pilha
				n++;

				Console.Clear();
			}

			Console.Clear();

			Console.WriteLine("\nQuantidade de livros na pilha: " + myStacks.Count + "\n"); // Apenas para mostrar quantos elementos há na pilha

			while (myStacks.Count > 0)
			{
				Console.WriteLine(myStacks.Pop());

				//Pop exclui os elementos da fila e retorna a string do último elemento adicionado

			}

			Console.WriteLine("Não há mais nenhum livro.");
		}
	}
}