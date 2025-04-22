using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string input = "hello world";

        // Consulta LINQ para obtener el conteo de cada carácter
		var result = input
			.Where(c => !char.IsWhiteSpace(c)) // Ignorar espacios
			.GroupBy(c => c)
			.Select(g => new 
			{ 
				Caracter = g.Key, 
				Repeticiones = g.Count() 
			});

        // Mostramos los resultados en una sola línea
        Console.WriteLine("Conteo de caracteres:");
        Console.WriteLine(string.Join(", ", result.Select(item => $"'{item.Caracter}': {item.Repeticiones}")));
    }
}