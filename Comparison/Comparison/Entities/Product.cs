using System.Globalization;

namespace Comparison.Entities
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Name}, {Price.ToString("F2", CultureInfo.InvariantCulture)}";
        }

        public int CompareTo(Product other)
        {
            return Name.ToUpper().CompareTo((other.Name.ToUpper())); // Realizando a comparação entre dois produtos
            //return Price.CompareTo(other.Price); Realizando a comparação por preço
        }
    }
}
