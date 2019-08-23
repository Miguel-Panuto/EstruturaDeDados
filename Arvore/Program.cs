/* Criado por: Miguel
*
* 23/08/2019 as 12:22
*/
using System;

namespace Arvore
{
	class Program
	{
		static void Main(string[] args)
		{
			Node treeRoot; //Crio a raiz da árvore
			{
				Console.Write("Insira o nome do paciente: ");
				string name = Console.ReadLine();
				Console.Write("Insira o grau: ");
				int grau = int.Parse(Console.ReadLine());
				treeRoot = new Node(new Patience(name, grau)); //Mando os valores dela, aplicando o conceito de pacientes
			}

			Console.Clear();
			
			while (true)
			{
				Console.Write("Insira o nome do paciente: ");
				string name = Console.ReadLine();
				if (String.IsNullOrWhiteSpace(name)) //Ir colocando os pacientes
				{
					break;
				}
				Console.Write("Insira o grau: ");
				int data = int.Parse(Console.ReadLine());
				treeRoot.InsertData(new Patience(name, data));
				Console.Clear();
			}
			Console.Clear();
			Console.WriteLine("Colocando os pacientes em ordem de emergencia");
			Console.WriteLine();
			treeRoot.WriteInOrderDecrescent();
		}
	}
}
