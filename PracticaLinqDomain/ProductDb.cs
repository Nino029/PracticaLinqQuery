using PracticaLinqDomain.BaseClass;

namespace PracticaLinqDomain

{
    public class ProductDb
    {

        private readonly List<Product> _products;

        public ProductDb(List<Product> products)
        {
            _products = products;
        }

        public IEnumerable<ProductResult> GetProductsByCategory(int categoryId)
        {
            var result = from product in _products
                         where product.CategoryId == categoryId
                         select new ProductResult
                         {
                             ProductoId = product.ProductId,
                             CodigoBarra = product.CodigoBarra,
                             Marca = product.Marca,
                             Stock = product.Stock,
                             NombreCategoria = product.Category?.Nombre
                         };

            return result;
        }
    }




}

