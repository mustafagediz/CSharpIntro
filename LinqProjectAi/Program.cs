namespace LinkProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kategorileri temsil eden bir liste oluşturuluyor.
            List<Category> categories = new List<Category>
            {
                new Category { CategoryId = 1, CategoryName = "Bilgisayar" },
                new Category { CategoryId = 2, CategoryName = "Telefon" },
            };

            // Ürünleri temsil eden bir liste oluşturuluyor.
            List<Product> products = new List<Product>
            {
                new Product { ProductId = 1, CategoryId = 1, ProductName = "Monster Laptop", QuantityPerUnit = "32 GB Ram", UnitPrice = 27000, UnitsInStock = 15 },
                new Product { ProductId = 2, CategoryId = 1, ProductName = "MSI Laptop", QuantityPerUnit = "16 GB Ram", UnitPrice = 29000, UnitsInStock = 10 },
                new Product { ProductId = 3, CategoryId = 1, ProductName = "MacAir Laptop", QuantityPerUnit = "32 GB Ram", UnitPrice = 35000, UnitsInStock = 25 },
                new Product { ProductId = 4, CategoryId = 2, ProductName = "Apple Laptop", QuantityPerUnit = "64 GB Ram", UnitPrice = 56000, UnitsInStock = 45 },
                new Product { ProductId = 5, CategoryId = 2, ProductName = "Samsung Laptop", QuantityPerUnit = "8 GB Ram", UnitPrice = 7000, UnitsInStock = 5 },
            };

            // Algoritmik yöntemle ürünleri filtrele ve ekrana yazdır.
            Console.WriteLine("Algoritmik--------------");
            foreach (var product in products)
            {
                if (product.UnitPrice > 8000 && product.UnitsInStock > 8)
                {
                    Console.WriteLine(product.ProductName);
                }
            }

            // LINQ kullanarak ürünleri filtrele ve ekrana yazdır.
            Console.WriteLine("Linq----------------");
            var result = products.Where(p => p.UnitPrice > 8000 && p.UnitsInStock > 8);
            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }

            // Algoritmik yöntemle filtrelenmiş ürünleri döndür ve ekrana yazdır.
            GetProducts(products);
        }

        // Algoritmik yöntemle ürünleri filtrele ve döndür.
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

        // LINQ kullanarak ürünleri filtrele ve döndür.
        static List<Product> GetProductsLinq(List<Product> products)
        {
            return products.Where(p => p.UnitPrice > 8000 && p.UnitsInStock > 8).ToList();
        }
    }

    // Ürün sınıfı tanımlanıyor.
    class Product
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public int UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
    }

    // Kategori sınıfı tanımlanıyor.
    class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}

//Bu kodlar, ürün ve kategori sınıflarını kullanarak bir ürün listesi oluşturur ve bu ürün listesinde belirli koşulları sağlayan ürünleri filtreler. Algoritmik bir yaklaşım ve LINQ (Language-Integrated Query) kullanımıyla iki farklı şekilde bu filtreleme işlemini gerçekleştirirler.

//    Algoritmik Yaklaşım:

//GetProducts metodu, bir liste içerisinde belirli koşulları sağlayan ürünleri filtreleyen bir algoritma kullanır.
//foreach döngüsü ile ürün listesini gezerek, her bir ürünün UnitPrice (Birim Fiyat) ve UnitsInStock (Stoktaki Birim Sayısı) özelliklerini kontrol eder.
//    Belirtilen koşulları sağlayan ürünleri yeni bir liste olan filteredProducts listesine ekler ve bu listeyi döndürür.
//    LINQ Kullanımı:

//LINQ, dil içine entegre edilmiş sorgu yetenekleri sunan bir özelliktir.
//    GetProductsLinq metodu, LINQ sorgularını kullanarak belirli koşulları sağlayan ürünleri filtreler.
//    LINQ ifadesi olan products.Where(p => p.UnitPrice > 8000 && p.UnitsInStock > 8).ToList();, belirtilen koşulları sağlayan ürünleri direkt olarak bir LINQ sorgusu ile filtreler ve bu ürünleri bir liste olarak döndürür.
//    İki yöntem de aynı sonucu üretir, ancak LINQ kullanımı daha kısa ve okunabilir bir syntax sunar. LINQ, veri sorgulama ve filtreleme gibi işlemleri daha açık ve deklaratif bir şekilde ifade etmeye olanak tanır, bu da kodun daha anlaşılır olmasını sağlar. Ayrıca, LINQ sorguları genellikle daha performanslıdır çünkü altta optimize edilmiş sorgulara dönüştürülerek çalışırlar. 
