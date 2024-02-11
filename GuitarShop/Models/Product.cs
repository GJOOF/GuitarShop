namespace GuitarShop.Models
{
    public class Product
    {
        private static int IdCreator = 0; // Id счетчик
        public int Id;
        public string Name; 
        public int Сost; 
        public string Description; 

        public Product(string name, int сost, string description)
        {
            Id = IdCreator++;
            Name = name;
            Сost = сost;
            Description = description;
        }

        public override string ToString()
        {
            return $"ID: {this.Id}\n{this.Name}\n{this.Сost} p.\n{this.Description}";
        }
    }
}