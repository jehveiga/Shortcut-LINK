// See https://aka.ms/new-console-template for more information

using Predicate.Entities;

List<Product> list = new List<Product>();
list.Add(new Product("Tv", 900.00));
list.Add(new Product("Mouse", 50.00));
list.Add(new Product("Tablet", 350.50));
list.Add(new Product("HD Case", 80.90));

list.RemoveAll(ProductTest); // Retirando da lista o produto que é maior que a condição informada como predicado (expressão lambda)

foreach (var p in list)
{
    Console.WriteLine(p);
}

bool ProductTest(Product p)
{
    return p.Price >= 100.0;
}