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
			Queue q = new Queue();

			int n = 1;

			while (true)
			{
				Console.WriteLine("Bem vindo ao Banco Batata!\n");
				Console.WriteLine("Digite seu nome (valor nulo p/ encerrar): ");
				string s = Console.ReadLine();

				if (String.IsNullOrWhiteSpace(s))
				{
					break;
				}

				q.Enqueue(new Pessoa(s, n));
				n++;
				Console.Clear();
			}
			q.TrimToSize();
			Console.Clear();
			while (q.Count > 0)
			{
				Console.WriteLine(q.Dequeue() + " Vá ao próximo guiche");
				Console.ReadLine();
				Console.WriteLine();
			}

			Console.WriteLine("Não há mais clientes");
			Console.Read();
		}
	}
}
