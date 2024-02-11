using GuitarShop.Models;

namespace GuitarShop
{
    public class ProductRepository
    {
        static List<Product> Products = new List<Product>()
        {
            new Product("Fender Stratocaster Black", 179000,
                "Body Style:Stratocaster\r\n\r\nBody Material:Alder\r\n\r\nBody Finish:Gloss Nitrocellulose Lacquer"),
            new Product("Gibson EDS-1275 Doubleneck Cherry Red", 727000,
                "Body Style:SG\r\n\r\nBody Shape:EDS-1275\r\n\r\nBody Material:Solid Mahogany\r\n\r\nBody Finish:Gloss Nitrocellulose Lacquer"),
            new Product("Gibson SG Standard Cherry", 218000,
                "Body Style:SGn\r\n\r\nBody Material:Mahogany\r\n\r\nBinding:Single Ply Cream, Fretboard\r\n\r\nBody Finish:Satin Nitrocellulose Lacquer"),
            new Product("Gibson Les Paul Special TV Yellow", 164000,
                "Body Style:Les Paul\r\nBody Material:Mahogany\r\nBody Finish:Gloss Nitrocellulose Lacquer"),
            new Product("Washburn EA20 White", 26000,
                "Body Style:E20\r\n\r\nBody Material:Spruce\r\n\r\nBody Finish:Gloss Nitrocellulose Lacquer")
        };

        public ProductRepository()
        {

        }

        public List<Product> GetProducts()
        {
            return Products;
        }

        internal object TryGetById(int id)
        {
            return Products.FirstOrDefault(product => product.Id == id);

        }
    }
}

