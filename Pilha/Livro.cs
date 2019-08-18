namespace Pilha
{
	class Livro
	{
		private string Nome;
		private int Id;

		public Livro(string nome, int id)
		{
			Nome = nome;
			Id = id;
		}

		public override string ToString()
		{
			return "O livro " + Nome + " estará na #" + Id + " posição.";
		}
	}
}
