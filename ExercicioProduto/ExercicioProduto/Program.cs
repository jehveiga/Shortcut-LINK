// See https://aka.ms/new-console-template for more information
using ExercicioProduto.Entities;
using System.Globalization;
using System.Linq;

Console.Write("Enter full file path: ");
string path = Console.ReadLine();

List<Product> products = new List<Product>();

using (StreamReader sr = File.OpenText(path))
{
    while (!sr.EndOfStream)
    {
        string[] fields = sr.ReadLine().Split(','); // Separando a string por virgula e colocando no vetor criado
        string name = fields[0];
        double price = double.Parse(fields[1], CultureInfo.InvariantCulture);
        products.Add(new Product(name, price));
    }
}

var avg = products.Select(p => p.Price).DefaultIfEmpty(0.0).Average();

Console.WriteLine($"Average price {avg.ToString("F2", CultureInfo.InvariantCulture)}");

var names = products.Where(p => p.Price < avg).OrderByDescending(p => p.Name).Select(p => p.Name);
foreach (var name in names)
{
    Console.WriteLine(name);
}
