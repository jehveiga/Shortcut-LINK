// See https://aka.ms/new-console-template for more information

using Comparison.Entities;

List<Product> list = new List<Product>();

list.Add(new Product("TV", 900.00));
list.Add(new Product("Notebook", 1200.00));
list.Add(new Product("Tablet", 450.00));

//Comparison<Product> comp = (p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper()); // expressão lambda atribuindo em uma varíavel (usando Comparison)

list.Sort((p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper())); // Sort é usado para listar produtos (só funciona se fazer a implementação com IComparable)

foreach (Product p in list)
{
    Console.WriteLine(p);
}

//static int CompareProducts(Product p1, Product p2) (Função Comparison)
//{
//    return p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
//}


