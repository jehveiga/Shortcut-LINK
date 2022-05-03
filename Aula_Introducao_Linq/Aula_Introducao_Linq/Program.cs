// See https://aka.ms/new-console-template for more information

// Specify the data source
int[] numbers = new int[] { 2, 3, 4, 5 };

// Define the query expression
var result = numbers
    .Where(x => x % 2 == 0) // Usando Linq com where passando um predicado gerando uma nova fonte de dados para pegar todo número par de retorno
    .Select(x => x * 10); // Usando Select para pegar cada item do resultado da divisão e multiplicando por 10

// Execute the query 
foreach (int x in result)
{
    Console.WriteLine(x);
}