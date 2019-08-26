namespace Pilha
{
	class Pilha
	{
		private class Node
		{
			public Livro Data { get; private set; } //O Livro em si, o objeto que esse nó representa
			public Node Next { get; set; } //O proximo item da fila
			public Node(Livro data)
			{
				Data = data;
			}
		}

		private Node Top; // O último nó que foi adicionado
		public int Count { get; private set; } // Contagem dos elementos

		public Pilha()
		{
			Count = 0;
		}

		public void Add(Livro data) // Adicionar um novo elemento na fila
		{
			Node node = new Node(data); // O nó que foi criado
			if (Top != null) // Verificação de se não foi o primeiro elemento
			{
				node.Next = Top;
			}
			Top = node; // O nó que acabou de entra vira o primeiro
			Count++;
		}

		public Livro Pop()
		{
			Livro data = Top.Data; // Deixa como auxiliar a variavel do topo da pilha
			if (Top.Next != null) // Se não for nulo o próximo elemento vira o topo
			{
				Node next = Top.Next;
				Top = next;
			}
			else
			{
				Top = null; // Vira nulo caso não há e retorna o "IsEmpty()" como true e para o loop
			}
			Count--;
			return data;
		}

		public bool IsEmpty()
		{
			return Top == null;
		}
	}
}
