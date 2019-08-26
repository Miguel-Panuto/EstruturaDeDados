/*	Criado por : Roberto e Miguel
 *
 *	17/08/2019 as 12:00
 */

using System;
using System.Collections;

namespace Fila
{
	class Program
	{
		static void Main(string[] args)
		{
			Fila q = new Fila(); //A fila em si

			int n = 1; //O id que ficará em cada objeto

			while (true) //O usuário digitará quantos elementos quiser até entra com alguma string nula ou com espaços em branco
			{
				Console.WriteLine("Bem vindo ao Banco Batata!\n");
				Console.WriteLine("Digite seu nome (valor nulo p/ encerrar): ");
				string s = Console.ReadLine();

				if (String.IsNullOrWhiteSpace(s)) // Comando para verificar isso
				{
					break;
				}

				q.Add(new Pessoa(s, n)); //Criação dos objetos
				n++;
				Console.Clear();
			}
			Console.Clear();
			while (!q.IsEmpty()) //Mostrará os elementos na tela
			{
				Console.WriteLine(q.Dequeue() + " Vá ao próximo guiche"); //Irá retirar os elementos e printa na tela, ao mesmo tempo que tira da fila
				Console.ReadLine(); //Espera pra apertar enter para voltar no loop
				Console.WriteLine();
			}

			Console.WriteLine("Não há mais clientes");
			Console.Read();
		}
	}
}
