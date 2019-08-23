namespace Arvore
{
	class Patience
	{
		public string Name { get; private set; }
		public int Emergency { get; private set; }

		public Patience(string name, int emergency)
		{
			Name = name;
			Emergency = emergency;
		}

		public override string ToString()
		{
			return Name + ", grau de emergencia: " + Emergency;
		}
	}
}
