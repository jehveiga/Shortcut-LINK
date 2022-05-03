// See https://aka.ms/new-console-template for more information
using Aula_Func.Entities;

List<Product> list = new List<Product>();

list.Add(new Product("Tv", 900.00));
list.Add(new Product("Mouse", 50.00));
list.Add(new Product("Tablet", 350.50));
list.Add(new Product("HD Case", 80.90));

//Func<Product, string> func = NameUpper; // outra forma de fazer usando a função delegate Func

Func<Product, string> func = p => p.Name.ToUpper(); // usando a expressão lambda

//List<string> result = list.Select(NameUpper).ToList(); // Pega cada elemento da lista e aplica a condição determinada no exemplo a função NameUpper
//List<string> result = list.Select(func).ToList();
List<string> result = list.Select(p => p.Name.ToUpper()).ToList(); // usando inline a expressão lambda
foreach (string s in result)
{
    Console.WriteLine(s);
}

//static string NameUpper(Product p) { return p.Name.ToUpper(); } // Função para colocar os produtos em caixa alta


