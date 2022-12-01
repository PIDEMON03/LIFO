using System;
using System.Collections.Generic;

class GFG
{
	// Mettre les éléments en haut de la pile
	static void stack_push(Stack<int> stack)
	{
		for (int i = 0; i < 5; i++)
		{
			stack.Push(i);
		}
	}

	// Enlever l'élément en haut de la pile
	static void stack_pop(Stack<int> stack)
	{
		Console.WriteLine("Pop :");

		for (int i = 0; i < 5; i++)
		{
			int y = (int)stack.Pop();
			Console.WriteLine(y);
		}
	}

	// Afficher l'élément en haut de la pile
	static void stack_peek(Stack<int> stack)
	{
		int element = (int)stack.Peek();
		Console.WriteLine("Elément en haut de la pile : " + element);
	}

	// Rechercher l'élément dans la pile
	static void stack_search(Stack<int> stack, int element)
	{
		bool pos = stack.Contains(element);

		if (pos == false)
			Console.WriteLine("Elément non trouvé");
		else
			Console.WriteLine("L'élément se trouve dans la pile : " + pos);
	}

	
	public static void Main(String[] args)
	{
		Stack<int> stack = new Stack<int>();

		stack_push(stack);
		stack_pop(stack);
		stack_push(stack);
		stack_peek(stack);
		stack_search(stack, 2);
		stack_search(stack, 6);
	}
}