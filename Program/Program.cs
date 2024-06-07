
using PracticaLinqDomain;
using PracticaLinqDomain.BaseClass;

class Program
{
    static void Main()
    {
    
        var categories = new List<Category>
        {
            new Category { CategoryId = 1, Nombre = "Electrónica" },
            new Category { CategoryId = 2, Nombre = "Ropa" }
        };

     
        var products = new List<Product>
        {
            new Product { ProductId = 1, CodigoBarra = "12345", Marca = "Sony", Stock = 10, CategoryId = 1, Category = categories[0] },
            new Product { ProductId = 2, CodigoBarra = "67890", Marca = "LG", Stock = 5, CategoryId = 1, Category = categories[0] },
            new Product { ProductId = 3, CodigoBarra = "11111", Marca = "Nike", Stock = 20, CategoryId = 2, Category = categories[1] }
        };

   
        var productDb = new ProductDb(products);

       
        var productosElectronica = productDb.GetProductsByCategory(1);
        foreach (var producto in productosElectronica)
        {
            Console.WriteLine($"ProductoId: {producto.ProductoId}, CodigoBarra: {producto.CodigoBarra}, Marca: {producto.Marca}, Stock: {producto.Stock}, NombreCategoria: {producto.NombreCategoria}");
        }
    }
}
