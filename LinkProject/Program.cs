namespace LinkProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category>
            {
                new Category { CategoryId = 1, CategoryName = "Bilgisayar" },
                new Category { CategoryId = 2, CategoryName = "Telefon" },
            };

            List<Product> products = new List<Product>
            {
                new Product{ProductId = 1, CategoryId = 1, ProductName = "Monster Laptop", QuantityPerUnit = "32 GB Ram", UnitPrice = 27000, UnitsInStock = 15},
                new Product{ProductId = 2, CategoryId = 1, ProductName = "MSI Laptop", QuantityPerUnit = "16 GB Ram", UnitPrice = 29000, UnitsInStock = 10},
                new Product{ProductId = 3, CategoryId = 1, ProductName = "MacAir Laptop", QuantityPerUnit = "32 GB Ram", UnitPrice = 35000, UnitsInStock = 25},
                new Product{ProductId = 4, CategoryId = 2, ProductName = "Apple Laptop", QuantityPerUnit = "64 GB Ram", UnitPrice = 56000, UnitsInStock = 45},
                new Product{ProductId = 5, CategoryId = 2, ProductName = "Samsung Laptop", QuantityPerUnit = "8 GB Ram", UnitPrice = 7000, UnitsInStock = 5},

            };

            Console.WriteLine("Algoritmik--------------");
            foreach (var product in products)
            {
                if (product.UnitPrice > 8000 && product.UnitsInStock > 8)
                {
                    Console.WriteLine(product.ProductName);
                }
            }

            Console.WriteLine("Linq----------------");

            var result = products.Where(p => p.UnitPrice > 8000 && p.UnitsInStock > 8);

            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }


            GetProducts(products);

        }
        //Console.WriteLine("Algoritmik--------------");
        static List<Product> GetProducts(List<Product> products)
        {
            List<Product> filteredProducts = new List<Product>();
            foreach (var product in products)
            {
                if (product.UnitPrice > 8000 && product.UnitsInStock > 8)
                {
                    filteredProducts.Add(product);
                }
            }

            return filteredProducts;
        }

        //Console.WriteLine("Linq----------------");
        static List<Product> GetProductsLinq(List<Product> products)
        {
            return products.Where(p => p.UnitPrice > 8000 && p.UnitsInStock > 8).ToList();
            
        }

    }

    class Product
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public int UnitPrice { get; set; }
        public int UnitsInStock { get; set; }

    }

    class Category
    {
        public int CategoryId { get; set; }

        public string CategoryName { get; set; }

    }
}
