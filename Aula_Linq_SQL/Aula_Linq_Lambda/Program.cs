// See https://aka.ms/new-console-template for more information
using Aula_Linq_Lambda.Entities;

static void Print<T>(string message, IEnumerable<T> collection) // Metodo somente para impressão dos resultados dos filtros Linq
{
    Console.WriteLine(message);
    foreach (T obj in collection)
    {
        Console.WriteLine(obj);

    }
    Console.WriteLine();
}

Category c1 = new Category() { Id = 1, Name = "Tools", Tier = 2 };
Category c2 = new Category() { Id = 2, Name = "Computers", Tier = 1 };
Category c3 = new Category() { Id = 3, Name = "Electronics", Tier = 1 };

List<Product> products = new List<Product>()
{
    new Product(){Id = 1, Name = "Computer", Price = 1100.0, Category = c2},
    new Product(){Id = 2, Name = "Hammer", Price = 90.0, Category = c1},
    new Product(){Id = 3, Name = "TV", Price = 1700.0, Category = c3},
    new Product(){Id = 4, Name = "Notebook", Price = 1300.0, Category = c2},
    new Product(){Id = 5, Name = "Saw", Price = 80.0, Category = c1},
    new Product(){Id = 6, Name = "Tablet", Price = 700.0, Category = c2},
    new Product(){Id = 7, Name = "Camera", Price = 700.0, Category = c3},
    new Product(){Id = 8, Name = "Printer", Price = 350.0, Category = c3},
    new Product(){Id = 9, Name = "MacBook", Price = 3500.0, Category = c2},
    new Product(){Id = 10, Name = "Sound Bar", Price = 700.0, Category = c3},
    new Product(){Id = 11, Name = "Level", Price = 70.0, Category = c1}
};

//var result1 = products.Where(p => p.Category.Tier == 1 && p.Price < 900.0);
var result1 =
    from p in products
    where p.Category.Tier == 1 && p.Price < 900.0
    select p;
Print("TIER 1 AND PRICE < 900.0: ", result1);

//var result2 = products.Where(p => p.Category.Name == "Tools").Select(p => p.Name);
var result2 =
    from p in products
    where p.Category.Name == "Tools"
    select p.Name;
Print("NAMES OF PRODUCTS FROM TOOLS: ", result2);

//var result3 = products.Where(p => p.Name[0] == 'C')
//    .Select(p => new { p.Name, p.Price, CategoryName = p.Category.Name }); // CategoryName é um apelido para representar p.Category.Name
var result3 =
    from p in products
    where p.Name[0] == 'C'
    select new
    {
        p.Name,
        p.Price,
        CategoryName = p.Category.Name
    };
Print("NAMES STARTED WITH 'C' AND ANONYMOUS OBJEC0T: ", result3);

//var result4 = products.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name); // Ordenando duas vezes como OrderBy e ThenBy
var result4 =
    from p in products
    where p.Category.Tier == 1
    orderby p.Name
    orderby p.Price
    select p;
Print("TIER 1 ORDER BY PRICE THEN BY NAME: ", result4);

//var result5 = result4.Skip(2).Take(4); // Paginação pulando dois elementos e pegando os outros 4
var result5 =
    (from p in result4
     select p).Skip(2).Take(4);
Print("TIER 1 ORDER BY PRICE THEN BY NAME SKIP 2 TAKE 4: ", result5);

//var result16 = products.GroupBy(p => p.Category); // GroupBy para fazer o agrupamento pelo filtro desejado no caso por categoria usa o esquema de (chave, valor) para fazer a organização do resultado
var result16 =
    from p in products
    group p by p.Category;
foreach (IGrouping<Category, Product> group in result16)
{
    Console.WriteLine();
    Console.WriteLine($"Category {group.Key.Name} :");
    foreach (Product p in group)
    {
        Console.WriteLine(p);
    }
    Console.WriteLine();

}