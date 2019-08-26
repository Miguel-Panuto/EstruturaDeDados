namespace Fila
{
	class Fila
	{
		private class Node
		{
			public Pessoa Data { get; private set; } // Dado referenciado ao objeto pessoa desse nó
			public Node Next { get; set; } // O próximo elemento em referencia ao colocado
			public Node(Pessoa data)
			{
				Data = data;
			}
		}

		private Node Head; // O primeiro elemento a ser inserido e o primeiro a sair
		private Node Tail; // Último elemento a ser inserido e o último a sair


		public bool IsEmpty()
		{
			return Head == null;
		}

		public void Add(Pessoa data) // Adiciona mais um nó à fila
		{
			Node node = new Node(data);
			if (Tail != null) // Se não for nulo o ultimo ele elemento, o penúltimo elemento vira o .Next do Tail
			{
				Tail.Next = node;
			}
			Tail = node; // Em algum momento o primeiro elemento foi o Tail e tem o .Next sendo o proximo elemento a ser inserido
			if (Head == null) // Isso é pro primeiro elemento
			{
				Head = node;
			}
		}

		public Pessoa Dequeue() // Retorna o primeiro elemento da fila e para de apontar pra ele
		{
			Pessoa data = Head.Data; 
			Head = Head.Next; // O Head vira o proximo elemento da fila
			if (Head == null)
			{
				Tail = null;
			}
			return data;
		}
	}
}
