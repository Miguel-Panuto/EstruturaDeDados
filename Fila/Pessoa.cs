namespace Fila
{
	class Pessoa
	{
		private string Nome;
		private int NumFila;

		public Pessoa(string nome, int numFila)
		{
			Nome = nome;
			NumFila = numFila;
		}

		public override string ToString()
		{
			return Nome + ", senha: " + NumFila;
		}
	}
}
