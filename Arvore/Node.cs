using System;

namespace Arvore
{
	class Node
	{
		private Node Left, Right;
		private Patience Patience;

		public Node(Patience patience)
		{
			Patience = patience;
		}

		public void InsertData(Patience patience)
		{
			if (patience.Emergency <= Patience.Emergency) //O algoritmo ira verificar pra que lado da arvore ele vai
			{
				if (Left == null)
				{
					Left = new Node(patience); // Se estiver nulo vai criar um nó dentro do nó em questão
				}
				else
				{
					Left.InsertData(patience); // Caso não ele voltará para este método até criar um novo nó
				}
			}
			else
			{
				if (Right == null)				//O mesmo caso para direita da árvore
				{
					Right = new Node(patience);
				}
				else
				{
					Right.InsertData(patience);
				}
			}
		}
		public void WriteInOrderCrescent() //Imprimir em ordem crescete
		{
			if (Left != null) //Verifica se tem mais elementos a esquerda
			{
				Left.WriteInOrderCrescent();
			}
			Console.WriteLine(Patience); //Se não tiver imprime o elemento em si
			if (Right != null)
			{
				Right.WriteInOrderCrescent(); //Caso não tenha mais q esquerda ele vai pra direita
			}
		}
		public void WriteInOrderDecrescent() // Mesma coisa do de cima, porem no sentido inverso
		{
			if (Right != null)
			{
				Right.WriteInOrderDecrescent();
			}
			Console.WriteLine(Patience);
			if (Left != null)
			{
				Left.WriteInOrderDecrescent();
			}
		}
		public void WritePreOrderCrescent()
		{
			Console.WriteLine(Patience); //Imprime a raiz primeiro
			if (Left != null)
			{
				Left.WriteInOrderCrescent(); //Depois elementos da esquerda
			}
			
			if (Right != null)
			{
				Right.WriteInOrderCrescent(); //E depois elementos da direita
			}
		}
		public void WritePreOrderDecrescent() //Mesma coisa, porem sentido inverso
		{
			Console.WriteLine(Patience);
			if (Right != null)
			{
				Right.WriteInOrderCrescent();
			}
			if (Left != null)
			{
				Left.WriteInOrderCrescent();
			}
		}
		public void WritePosOrderCrescent() 
		{
			if (Left != null) //Ele verifica até o ultimo da esquerda e da direita pra entao imprimir
			{
				Left.WriteInOrderCrescent();
			}

			if (Right != null)
			{
				Right.WriteInOrderCrescent();
			}
			Console.WriteLine(Patience);
		}
		public void WritePosOrderDecrescent()
		{
			if (Right != null)
			{
				Right.WriteInOrderCrescent();
			}
			if (Left != null)
			{
				Left.WriteInOrderCrescent();
			}
			Console.WriteLine(Patience);
		}
	}
}
