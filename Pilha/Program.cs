using System;
using System.Collections;

namespace Pilha
{
	class Program
	{
		static void Main(string[] args)
		{
			Stack s = new Stack();

			s.Push(1);
			s.Push(2);
			s.Push(3);

			while (s.Count > 0)
			{
				Console.WriteLine(s.Pop());
			}
		}
	}
}
