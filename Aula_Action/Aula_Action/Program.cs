// See https://aka.ms/new-console-template for more information
using Aula_Action.Entities;

List<Product> list = new List<Product>();

list.Add(new Product("Tv", 900.00));
list.Add(new Product("Mouse", 50.00));
list.Add(new Product("Tablet", 350.50));
list.Add(new Product("HD Case", 80.90));

Action<Product> act = p => { p.Price += p.Price * 0.1; }; // Atribuindo a variavel uma expressão lambda void

//list.ForEach(act); // Testando Action(void), pela função criada e passando como parametro para a função ForEach
list.ForEach(p => p.Price += p.Price * 0.1); // ou pode ser usado uma expressao lambda diretamente no corpo da função ForEach sendo passada como parametro
foreach (var p in list)
{
    Console.WriteLine(p);
}

static void UpdatePrice(Product p) // aumentando em 10% para cada elemento na minha lista
{
    p.Price += p.Price * 0.1;
}


