using System.Reflection.Metadata.Ecma335;

namespace ravendb.Models
{
    public class Product
    {
        public Product(string id, string name, double price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        private string Id { get; set; }
        private string Name { get; set; }
        private double Price { get; set; }




        public string getId() => Id;
        public string getName() => Name;
        public double getPrice() => Price;
    }
}
